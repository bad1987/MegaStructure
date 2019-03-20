using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaStructure
{
    class traitementHS
    {
        private int mo_type;
        private DatabaseLite lite;

        public traitementHS()
        {
            mo_type = 0;
            lite = new DatabaseLite();
            lite.creatConnection();
        }

        public void setType(int type)
        {
            mo_type = type;
        }

        private String returnPrefixPieceHS()
        {
            //MessageBox.Show(typePiece.ToString());
            DateTime date = DateTime.Now;
            String year = date.Date.ToString("yy"), pref = "";
            if (mo_type == 1)
                pref = year + "EHS";
            else
                pref = year + "SHS";

            return pref;
        }

        public String buildPieceHS(String current)
        {
            String newpiece = "", pieceDate = "", curdate = "";
            if (current.Length > 0)
                pieceDate = current[0] + "" + current[1];
            curdate = DateTime.Now.Date.ToString("yy");
            if (current.Length == 0 || pieceDate.CompareTo(curdate) != 0)
            {
                newpiece = returnPrefixPieceHS() + "0000001";
            }
            else
            {
                String prefix = "", suffix = "";
                int i = 0;
                foreach (char car in current)
                {
                    if (i <= 4)
                    {
                        prefix += car;
                    }
                    else
                    {
                        suffix += car;
                    }
                    i += 1;
                }
                String temp = (int.Parse(suffix) + 1).ToString();

                if (temp.Length < suffix.Length)
                {
                    int len = (suffix.Length - temp.Length) - 1;
                    while (len >= 0)
                    {
                        temp = suffix[len] + temp;
                        len--;
                    }
                }
                newpiece = prefix + temp;
            }

            return newpiece;
        }

        private String returnPrefixPiece()
        {
            //MessageBox.Show(typePiece.ToString());
            DateTime date = DateTime.Now;
            String year = date.Date.ToString("yy"), pref = "";
            if (mo_type == 1)
                pref = year + "ME";
            else if (mo_type == 2)
                pref = year + "MS";
            else
                pref = year + "MR";

            return pref;
        }

        public String buildPiece(String current)
        {
            String newpiece = "", pieceDate = "", curdate = "";
            if (current.Length > 0)
                pieceDate = current[0] + "" + current[1];
            curdate = DateTime.Now.Date.ToString("yy");
            if (current.Length == 0 || pieceDate.CompareTo(curdate) != 0)
            {
                newpiece = returnPrefixPiece() + "0000001";
            }
            else
            {
                String prefix = "", suffix = "";
                int i = 0;
                foreach (char car in current)
                {
                    if (i <= 3)
                    {
                        prefix += car;
                    }
                    else
                    {
                        suffix += car;
                    }
                    i += 1;
                }
                String temp = (int.Parse(suffix) + 1).ToString();

                if (temp.Length < suffix.Length)
                {
                    int len = (suffix.Length - temp.Length) - 1;
                    while (len >= 0)
                    {
                        temp = suffix[len] + temp;
                        len--;
                    }
                }
                newpiece = prefix + temp;
            }

            return newpiece;
        }

        public void ligneMouvInsertion(Double mo_qte, int mo_type, String mo_date, String mo_piece, String mo_motif, int ma_no, int de_no)
        {
            String request = @"
                INSERT INTO F_LIGNEMOUVEMENT (MO_QTE,MO_DATE,MO_TYPE,MO_PIECE,MO_MOTIF,MA_NO,DE_NO)
                VALUES({0},'{1}',{2},'{3}','{4}',{5},{6})
            ";
            request = String.Format(request, mo_qte, mo_date, mo_type, mo_piece, mo_motif, ma_no, de_no);
            using (SQLiteCommand cmd = new SQLiteCommand(request, lite.getConnector()))
            {
                cmd.ExecuteNonQuery();
            }
        }
        
        public void updateStock(int ma_num, Double stock, Double hs, Double minstock)
        {
            String request = @"
               UPDATE F_MATSTOCK SET ST_QTESTOCK={1}, ST_HORSERVICE={2}, ST_QTEMIN={3} WHERE MA_NO = {0}
            ";
            request = string.Format(request, ma_num, stock, hs, minstock);

            using (SQLiteCommand cmd = new SQLiteCommand(request, lite.getConnector()))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public void updateStockHS(int ma_num, Double hs)
        {
            String request = @"
               UPDATE F_MATSTOCK SET ST_HORSERVICE={1} WHERE MA_NO = {0}
            ";
            request = string.Format(request, ma_num, hs);

            using (SQLiteCommand cmd = new SQLiteCommand(request, lite.getConnector()))
            {
                cmd.ExecuteNonQuery();
            }
        }

    }
}
