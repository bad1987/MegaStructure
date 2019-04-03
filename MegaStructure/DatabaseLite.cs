using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaStructure
{
    class DatabaseLite
    {
        private SQLiteConnection conn;
        private Boolean dbCreated ;
        private String databaseName;
        private String backupName ;
        private String filePath ;
        private String cancelRestore;

        public DatabaseLite()
        {
            //filePath = Environment.CurrentDirectory;
            filePath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            filePath = Path.Combine(filePath, "MegaStructure");
            
            filePath = Path.Combine(filePath, "database");
            if (!Directory.Exists(filePath))
            {
                //MessageBox.Show(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData));
                Directory.CreateDirectory(filePath);
            }
            databaseName = Path.Combine(filePath, "megaStructure.sqlite");
            backupName = Path.Combine(filePath, "megaStructure.backup");
            cancelRestore = Path.Combine(filePath, "beforeRestore.backup");
        }

        public string stripString(string enter)
        {
            return enter.Replace("'", "''");
        }

        public void initDatabase()
        {
            //MessageBox.Show(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Check database", MessageBoxButtons.OK);
            try
            {
                if (File.Exists(databaseName))
                {
                    //MessageBox.Show("Database already Exist", "Check database", MessageBoxButtons.OK);
                    this.dbCreated = true;
                }
                else
                {
                    //SQLiteConnection.CreateFile("database/megaStructure.sqlite");
                    creatConnection();
                    //creation des tables
                    createAll();

                    // creation de l'utilisateur
                    createUser();

                    //creation des familles
                    initFamilles();

                    //creation des materiaux
                    initMateriaux();

                    //creation du depot
                    createDepot();

                    this.dbCreated = true;
                }
            }
            catch (System.IO.IOException)
            {
                //String massage = "A connection to this database already exist";
                //MessageBox.Show(massage, "Database connection", MessageBoxButtons.OK);
            }
            ajoutColonne();
        }

        public void creatConnection()
        {
            String conScript = String.Format("Data Source={0};Version=3;", databaseName);
            conn = new SQLiteConnection(conScript);
          conn.Open();
        }

        public void closeConnection()
        {
            try
            {
                conn.Close();
            }
            catch
            {

            }
        }

        public Boolean isCreated()
        {
            return this.dbCreated;
        }

        public SQLiteConnection getConnector()
        {
            return conn;
        }

        public void createAll()
        {
            //MessageBox.Show("creation des tables", "database", MessageBoxButtons.OK);
            createTableUtilisateurs();
            createTableFamille();
            createTableMateriel();
            createTableDepot();
            createTableMatStock();
            createTableLigneMouvement();
            //MessageBox.Show("toute les tables ont ete crees", "Check database", MessageBoxButtons.OK);
        }

        public void createTableUtilisateurs()
        {
            String request = @"
                    CREATE TABLE IF NOT EXISTS F_UTILISATEUR
                    (UT_NO INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                        UT_NOM VARCHAR(50) NOT NULL,UT_PRENOM VARCHAR(50) NOT NULL,
                        UT_FONCTION VARCHAR(50),UT_CONNECT TINYINT(1) DEFAULT 0,
                        UT_USERNAME VARCHAR(45) NOT NULL,UT_PASSWORD TEXT NOT NULL)
                ";
            SQLiteCommand cmd = new SQLiteCommand(request, this.conn);
            int res = cmd.ExecuteNonQuery();
            //MessageBox.Show(res.ToString(), "Check database", MessageBoxButtons.OK);
        }

        public void createTableFamille()
        {
            String request = @"
                    CREATE TABLE IF NOT EXISTS F_FAMILLE
                    (FA_NO INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                        FA_INTITULE VARCHAR(150) NOT NULL,FA_CODE VARCHAR(100) NOT NULL UNIQUE)
                ";
            SQLiteCommand cmd = new SQLiteCommand(request, this.conn);
            cmd.ExecuteNonQuery();
        }

        public void deleteFromFamille(String code)
        {
            String request = "DELETE FROM F_FAMILLE WHERE FA_CODE = '{0}'";
            String request2 = "UPDATE F_MATERIEL SET FA_CODE = 'MATDIV' WHERE FA_CODE = '{0}'";
            request2 = string.Format(request2, code);
            request = string.Format(request, code);

            //mise a jour de la table materiel
            SQLiteCommand cmd = new SQLiteCommand(request2, this.conn);
            cmd.ExecuteNonQuery();

            cmd = new SQLiteCommand(request, this.conn);
            cmd.ExecuteNonQuery();
        }

        public Boolean isUsed(String code)
        {
            Boolean result = false;
            String request = "SELECT * FROM F_MATERIEL,F_FAMILLE WHERE F_FAMILLE.FA_CODE=F_MATERIEL.FA_CODE AND F_FAMILLE.FA_CODE = '{0}' LIMIT 1";
            request = string.Format(request, code);
            using(SQLiteCommand cmd = new SQLiteCommand(request, conn))
            {
                using(SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        result = true;
                    }
                }
            }

            return result;
        }

        public void createTableMateriel()
        {
            String request = @"
                    CREATE TABLE IF NOT EXISTS F_MATERIEL
                    (MA_NO INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                        MA_DESIGN VARCHAR(200) NOT NULL,MA_DATE TEXT,
                        FA_CODE VARCHAR(100),
                        MA_SUIVISTOCK INTEGER NOT NULL DEFAULT 1,
                        FOREIGN KEY(FA_CODE) REFERENCES F_FAMILLE(FA_CODE))
                ";
            SQLiteCommand cmd = new SQLiteCommand(request, this.conn);
            cmd.ExecuteNonQuery();
        }

        public void ajoutColonne()
        {
            creatConnection();
            String request = @"
                    ALTER TABLE F_MATERIEL ADD COLUMN MA_SUIVISTOCK INTEGER DEFAULT 1   
            ";
            request = String.Format(request, databaseName);

            String request2 = @"PRAGMA table_info(F_MATERIEL)";
            String request3 = @"SELECT MA_SUIVISTOCK FROM F_MATERIEL";

            SQLiteCommand cmd = new SQLiteCommand(request2, this.conn);
            //cmd.ExecuteNonQuery();

            Boolean exists = false;
            using (SQLiteDataReader dr = cmd.ExecuteReader())
            {
                int nameIndex = dr.GetOrdinal("NAME");
                while(dr.Read())
                {
                    if (dr.GetString(nameIndex).Equals("MA_SUIVISTOCK"))
                    {
                        exists = true;
                        break;
                    }
                    //MessageBox.Show(dr.GetString(nameIndex));
                }
                                
            }
            cmd.Dispose();
            if (!exists)
            {
                using(cmd = new SQLiteCommand(request, this.conn))
                {
                    cmd.ExecuteNonQuery();
                }
                //MessageBox.Show("La colonne n'existe pas encore");
            }
        }

        public int getMaterielTypeSuivi(int art_ref)
        {
            string request = "SELECT MA_SUIVISTOCK FROM F_MATERIEL WHERE MA_NO = {0}";
            request = string.Format(request, art_ref);
            creatConnection();
            int suivi = 0;
            using(SQLiteCommand cmd = new SQLiteCommand(request, this.conn))
            {
                using(SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        suivi = dr.GetInt32(0);
                    }
                }
            }
            return suivi;
        }

        public void createTableDepot()
        {
            String request = @"
                    CREATE TABLE IF NOT EXISTS F_DEPOT
                    (DE_NO INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                        DE_DESIGN VARCHAR(100) NOT NULL,DE_ADR VARCHAR(100),
                        UT_NO INTEGER,
                        FOREIGN KEY(UT_NO) REFERENCES F_UTILISATEUR(UT_NO))
                ";
            SQLiteCommand cmd = new SQLiteCommand(request, this.conn);
            cmd.ExecuteNonQuery();
        }

        public void createTableMatStock()
        {
            String request = @"
                    CREATE TABLE IF NOT EXISTS F_MATSTOCK
                    (ST_NO INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                        ST_QTEMIN DOUBLE,ST_QTESTOCK DOUBLE,
                        ST_HORSERVICE DOUBLE,
                        MA_NO INTEGER,
                        DE_NO INTEGER,
                        FOREIGN KEY(MA_NO) REFERENCES F_MATERIEL(MA_NO),
                        FOREIGN KEY(DE_NO) REFERENCES F_DEPOT(DE_NO))
                ";
            SQLiteCommand cmd = new SQLiteCommand(request, this.conn);
            cmd.ExecuteNonQuery();
        }

        public void createTableLigneMouvement()
        {
            String request = @"
                    CREATE TABLE IF NOT EXISTS F_LIGNEMOUVEMENT
                    (MO_NO INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                        MO_QTE DOUBLE,MO_DATE TEXT,
                        MO_TYPE INTEGER,
                        MO_PIECE VARCHAR(45),
                        MO_MOTIF VARCHAR(80),
                        MA_NO INTEGER,
                        DE_NO INTEGER,
                        FOREIGN KEY(MA_NO) REFERENCES F_MATERIEL(MA_NO),
                        FOREIGN KEY(DE_NO) REFERENCES F_DEPOT(DE_NO))
                ";
            SQLiteCommand cmd = new SQLiteCommand(request, this.conn);
            cmd.ExecuteNonQuery();
        }
        

        public void createUser()
        {
            String nom = "BAYANGA", prenom = "ANTOINE DIDIER", fonction = "SOFTWARE ENGENEER", username = "bad1987", password = "antoine1987";
            String request = @"INSERT INTO F_UTILISATEUR (UT_NOM,UT_PRENOM,UT_FONCTION,UT_USERNAME,UT_PASSWORD) 
                            VALUES('{0}','{1}','{2}','{3}','{4}')
                        ";
            request = String.Format(request, nom,prenom,fonction,username,password);
            SQLiteCommand cmd = new SQLiteCommand(request, this.conn);
            cmd.ExecuteNonQuery();
        }

        public Boolean userConnection(String userName,String password)
        {
            creatConnection();
            String request = @"SELECT * FROM F_UTILISATEUR WHERE UT_USERNAME = '{0}' AND UT_PASSWORD = '{1}'";
            request = String.Format(request, userName, password);
            Boolean credentials = false;
            using(SQLiteCommand cmd = new SQLiteCommand(request, this.conn))
            {
                using(SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        credentials = true;
                    }
                }
            }

            return credentials;
        }

        public void createFamille(String fa_ref,String fa_design)
        {
            fa_design = fa_design.Replace("'", "''");
            String request = @"INSERT INTO F_FAMILLE (FA_INTITULE,FA_CODE) 
                            VALUES('{1}','{0}')
                        ";
            request = String.Format(request, fa_ref,fa_design);
            
            SQLiteCommand cmd = new SQLiteCommand(request, this.conn);
            cmd.ExecuteNonQuery();
            /*try
            {
                //cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {

            }*/
        }

        public void createMateriaux(String design,String fa_code)
        {
            design = design.Replace("'", "''");
            String date = DateTime.Now.Date.ToString("yyyy-MM-dd");
            String request = @"INSERT INTO F_MATERIEL (MA_DESIGN,MA_DATE,FA_CODE) 
                        VALUES('{0}','{1}','{2}')
                    ";
            request = String.Format(request, design, date,fa_code);


            SQLiteCommand cmd = new SQLiteCommand(request, this.conn);
            cmd.ExecuteNonQuery();
        }

        public void createDepot()
        {
            String request = @"INSERT INTO F_DEPOT (DE_DESIGN,DE_ADR,UT_NO) 
                        VALUES('{0}','{1}',{2})
                    ";
            request = String.Format(request, "WAZA", "WAZA, MAROUA", 1);


            SQLiteCommand cmd = new SQLiteCommand(request, this.conn);
            cmd.ExecuteNonQuery();
        }

        public Boolean familleExists(String fa_ref)
        {
            Boolean exists = false;
            String request = @"SELECT * FROM F_FAMILLE WHERE FA_CODE = '{0}'";
            request = String.Format(request,fa_ref);
            //Boolean credentials = false;
            using (SQLiteCommand cmd = new SQLiteCommand(request, this.conn))
            {
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        exists = true;
                    }
                }
            }

            return exists;
        }

        public Dictionary<String, String> getAllFamilles()
        {
            Dictionary<String, String> famlist = new Dictionary<string, string>();
            String request = @"SELECT FA_CODE,FA_INTITULE FROM F_FAMILLE";
            using (SQLiteCommand cmd = new SQLiteCommand(request, this.conn))
            {
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        famlist[dr.GetString(0)] = dr.GetString(1);
                    }
                }
            }
            return famlist;
        }


        public void initFamilles()
        {
            StreamReader sd = new StreamReader("familles.txt");
            String line = sd.ReadLine();
            String[] rows = line.Split(';'),items;
            foreach(String row in rows)
            {
               if(row.Length > 0)
                {
                    items = row.Split('@');
                    createFamille(items[0], items[1]);
                }

            }
        }

        public void initMateriaux()
        {
            StreamReader sd = new StreamReader("materiaux.txt");
            String line = sd.ReadLine();
            String[] rows = line.Split(';'), items;
            foreach (String row in rows)
            {
                if (row.Length > 0)
                {
                    items = row.Split('@');
                    createMateriaux(items[0], items[1]);
                }
            }
        }

        public void sauvegarde()
        {
            if (File.Exists(backupName))
            {
                File.Delete(backupName);
            }
            if (File.Exists(cancelRestore))
            {
                File.Delete(cancelRestore);
            }

            File.Copy(databaseName, backupName);
        }

        public void restorer()
        {
            if (File.Exists(backupName))
            {
                closeConnection();
                if (File.Exists(databaseName))
                {
                    File.Copy(databaseName, cancelRestore);
                    File.Delete(databaseName);
                }
                File.Copy(backupName, databaseName);
            }
            else
            {
                MessageBox.Show("Pas de sauvegarde disponible. Vous n'avez pas encore fait une sauvegarde de votre base de donnees", "Restoration de la bd", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        public void exporter()
        {
            FolderBrowserDialog folderobject = new FolderBrowserDialog();
            folderobject.Description = "Selectionnez le repertoire de destination";
            folderobject.ShowNewFolderButton = false;
            folderobject.RootFolder = Environment.SpecialFolder.MyComputer;
            DialogResult result = folderobject.ShowDialog();
            if(result == DialogResult.Cancel)
            {
                MessageBox.Show("Operation aborted", "choix du repertoire", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String filename = Path.GetFileName(backupName),exported;
                exported = Path.Combine(folderobject.SelectedPath, filename);
                try
                {
                    File.Copy(backupName, exported, true);
                }
                catch
                {
                    File.Delete(exported);
                    File.Copy(backupName, exported, true);
                }
                MessageBox.Show("exportation de la base de donnees terminee","exportation de la bd", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void importer()
        {
            OpenFileDialog filedialogobject = new OpenFileDialog();
            filedialogobject.Multiselect = false;
            filedialogobject.Filter = "Files (*.BACKUP;*.SQLITE)|*.BACKUP;*.SQLITE";
            DialogResult result = filedialogobject.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Operation aborted", "choix du repertoire", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String filename = filedialogobject.FileName;
                if (File.Exists(databaseName))
                {
                    closeConnection();
                    File.Copy(databaseName, cancelRestore,true);
                    File.Delete(databaseName);
                }

                File.Copy(filename, databaseName);
                MessageBox.Show("importation de la base de donnees terminee.", "exportation de la bd", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public String getLastLigneMvtPiece(int mo_type)
        {
            String request = @"SELECT MO_PIECE FROM F_LIGNEMOUVEMENT WHERE MO_TYPE={0} AND MO_PIECE LIKE '__M%' ORDER BY MO_NO DESC LIMIT 1";
            String piece = "";
            request = String.Format(request, mo_type);
            using(SQLiteCommand cmd = new SQLiteCommand(request, conn))
            {
                using(SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        piece = dr.GetString(0);
                    }
                }
            }
            return piece;
        }

        public String getLastLigneMvtPieceHS(int mo_type)
        {
            String request = @"SELECT MO_PIECE FROM F_LIGNEMOUVEMENT WHERE MO_TYPE={0} AND MO_PIECE LIKE '%HS%' ORDER BY MO_NO DESC LIMIT 1";
            String piece = "";
            request = String.Format(request, mo_type);
            using (SQLiteCommand cmd = new SQLiteCommand(request, conn))
            {
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        piece = dr.GetString(0);
                    }
                }
            }
            return piece;
        }


    }
}
