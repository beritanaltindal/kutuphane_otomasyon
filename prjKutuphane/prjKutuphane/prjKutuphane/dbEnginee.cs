using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb; 
//Access db kullanmak için

namespace prjKutuphane
{
    class dbEnginee
    {
        public string Yol()
        {
            return "Provider=Microsoft.ACE.Oledb.12.0; data source=C:\\Users\\ALTINDAL\\Desktop\\dbKutuphane.accdb";
        }

        public DataTable Girisyap(String KullaniciAd, String Sifre)
        {
            string sql = "select * from tblKullanicilar where KullaniciAd=@KullaniciAd and Sifre=@Sifre ";
            OleDbConnection con = new OleDbConnection(Yol());
            con.Open();

            DataTable dt = new DataTable();
            OleDbDataAdapter adp = new OleDbDataAdapter(sql , con);
            adp.SelectCommand.Parameters.AddWithValue( "@KullaniciAd" , KullaniciAd);
            adp.SelectCommand.Parameters.AddWithValue("@Sifre", Sifre);
            adp.Fill(dt);
            return dt;

        }
        

        public DataTable KategoriYukle()
        {
            string sql = "select * from tblKategoriler order by Kategori ASC ";
            OleDbConnection con = new OleDbConnection(Yol());
            con.Open();
            DataTable dt = new DataTable();
            OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
            adp.Fill(dt);
            return dt;
        }
        public DataTable YetkiYukle()
        {
            string sql = "select * from tblYetki order by YetkiDurum ASC ";
            OleDbConnection con = new OleDbConnection(Yol());
            con.Open();
            DataTable dt = new DataTable();
            OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
            adp.Fill(dt);
            return dt;
        }
        public void KullaniciKayit(string KullaniciAd, string Sifre, string AdSoyad, string YetkiDurum)
        {
            OleDbConnection con = new OleDbConnection(Yol());
            con.Open();
            string sql = "insert into tblKullanicilar(KullaniciAd, Sifre, AdSoyad, YetkiDurum) values(@KullaniciAd, @Sifre, @AdSoyad, @YetkiDurum)";
            OleDbCommand com = new OleDbCommand(sql, con);
            com.Parameters.AddWithValue("@KullaniciAd", KullaniciAd);
            com.Parameters.AddWithValue("@Sifre", Sifre);
            com.Parameters.AddWithValue("@AdSoyad", AdSoyad);
            com.Parameters.AddWithValue("@YetkiDurum", YetkiDurum);
            
            com.ExecuteNonQuery();
            con.Close();

        }

        public void KitapKayit(string KitapKod, string KitapAd, string KategoriAd, string YazarAd, string RafNo, string KitapDurum, string Aciklama)
        {
            OleDbConnection con = new OleDbConnection(Yol());
            con.Open();
            string sql = "insert into tblKitaplar(KitapKod, KitapAd, KategoriAd, YazarAd, RafNo, KitapDurum, Aciklama) values(@KitapKod, @KitapAd, @KategoriAd, @YazarAd, @RafNo, @KitapDurum, @Aciklama)";
            OleDbCommand com = new OleDbCommand(sql,con);
            com.Parameters.AddWithValue("@KitapKod", KitapKod);
            com.Parameters.AddWithValue("@KitapAd", KitapAd);
            com.Parameters.AddWithValue("@KategoriAd", KategoriAd);
            com.Parameters.AddWithValue("@YazarAd", YazarAd);
            com.Parameters.AddWithValue("@RafNo", RafNo);
            com.Parameters.AddWithValue("@KitapDurum", KitapDurum);
            com.Parameters.AddWithValue("@Aciklama", Aciklama);
            com.ExecuteNonQuery();
            con.Close();

        }
        public bool KitapKontrol(string KitapKod)
        {
            OleDbConnection con = new OleDbConnection(Yol());
            con.Open();
            string sql = "select * from tblKitaplar where KitapKod=@KitapKod";
            DataTable dt = new DataTable();
            OleDbDataAdapter adp = new OleDbDataAdapter(sql,con);
            adp.SelectCommand.Parameters.AddWithValue("@KitapKod",KitapKod);
            adp.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                return true;
            }
            else
            {
                return false; 
            }
        }
        public bool KullaniciKontrol(string KullaniciAd)
        {
            OleDbConnection con = new OleDbConnection(Yol());
            con.Open();
            string sql = "select * from tblKullanicilar where KullaniciAd=@KullaniciAd";
            DataTable dt = new DataTable();
            OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
            adp.SelectCommand.Parameters.AddWithValue("@KullaniciAd", KullaniciAd);
            adp.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        } 
        public DataTable KitapBul(string KitapKod)
        {
            OleDbConnection con = new OleDbConnection(Yol());
            con.Open();
            string sql = "select * from tblKitaplar where KitapKod=@KitapKod";
            DataTable dt = new DataTable();
            OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
            adp.SelectCommand.Parameters.AddWithValue("@KitapKod", KitapKod);
            adp.Fill(dt);
            return dt;
        }
        public void KitapGuncelle(string KitapKod, string KitapAd, string KategoriAd, string YazarAd, string RafNo, string KitapDurum, string Aciklama)
        {
            OleDbConnection con = new OleDbConnection(Yol());
            con.Open();
            string sql = "update tblKitaplar set KitapAd=@KitapAd, KategoriAd=@KategoriAd, YazarAd=@YazarAd, RafNo=@RafNo, KitapDurum=@KİtapDurum, Aciklama=@Aciklama where KitapKod=@KitapKod ";
            OleDbCommand com = new OleDbCommand(sql, con);
            
            com.Parameters.AddWithValue("@KitapAd", KitapAd);
            com.Parameters.AddWithValue("@KategoriAd", KategoriAd);
            com.Parameters.AddWithValue("@YazarAd", YazarAd);
            com.Parameters.AddWithValue("@RafNo", RafNo);
            com.Parameters.AddWithValue("@KitapDurum", KitapDurum);
            com.Parameters.AddWithValue("@Aciklama", Aciklama);
            com.Parameters.AddWithValue("@KitapKod", KitapKod);
            com.ExecuteNonQuery();
            con.Close();

        }
        public DataTable TumKitaplar()
        {
            OleDbConnection con = new OleDbConnection(Yol());
            con.Open();
            string sql = "select * from tblKitaplar Order by KitapAd ASC";
            DataTable dt = new DataTable();
            OleDbDataAdapter adp = new OleDbDataAdapter(sql,con);
            adp.Fill(dt);
            return dt;


        }
        public DataTable KitapArama(String Bul)
        {
            OleDbConnection con = new OleDbConnection(Yol());
            con.Open();
            string sql = "select * from tblKitaplar where KitapAd like '%" + Bul + "%' or YazarAd like'%"+ Bul + "%'or KitapKod like '%" +Bul+ "%' ";
            DataTable dt = new DataTable();
            OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
            adp.Fill(dt);
            return dt;


        }
        public void KitapSil(string KitapKod)
        {
            OleDbConnection con = new OleDbConnection(Yol());
            con.Open();
            string sql = "delete from tblKitaplar where KitapKod=@KitapKod";
            OleDbCommand com = new OleDbCommand(sql,con);
            com.Parameters.AddWithValue("@KitapKod",KitapKod);
            com.ExecuteNonQuery();
            con.Close();

        }
       



    }
}
