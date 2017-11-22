using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
//Access db kullanmak using System.Text.RegularExpressions;
using System.Text.RegularExpressions;
// email formati için kullandik.



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
        public DataTable GorevYukle()
        {
            string sql = "select * from tblGorev order by Gorev ASC ";
            OleDbConnection con = new OleDbConnection(Yol());
            con.Open();
            DataTable dt = new DataTable();
            OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
            adp.Fill(dt);
            return dt;
        }
        public DataTable HasarYukle()
        {
            string sql = "select * from tblHasar order by HasarDurumu ASC ";
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
        public void KullaniciKayit(string KullaniciAd, string Sifre, string AdSoyad, string YetkiDurum,string Eposta)
        {
            OleDbConnection con = new OleDbConnection(Yol());
            con.Open();
            string sql = "insert into tblKullanicilar(KullaniciAd, Sifre, AdSoyad, YetkiDurum,Eposta) values(@KullaniciAd, @Sifre, @AdSoyad, @YetkiDurum, @Eposta)";
            OleDbCommand com = new OleDbCommand(sql, con);
            com.Parameters.AddWithValue("@KullaniciAd", KullaniciAd);
            com.Parameters.AddWithValue("@Sifre", Sifre);
            com.Parameters.AddWithValue("@AdSoyad", AdSoyad);
            com.Parameters.AddWithValue("@YetkiDurum", YetkiDurum);
            com.Parameters.AddWithValue("@Eposta",Eposta);
            
            com.ExecuteNonQuery();
            con.Close();

        }
        public void OkuyucuKayit(string TcKimlik, string AdiSoyadi, string OgrenciNo, DateTime DogumTarihi, string DogumYeri, string Telefon, string Eposta, string Cinsiyet)
        {
            OleDbConnection con = new OleDbConnection(Yol());
            con.Open();
            string sql = "insert into tblOkuyucu(TcKimlik, AdiSoyadi, OgrenciNo, DogumTarihi, DogumYeri, Telefon, Eposta, Cinsiyet) values(@TcKimlik, @AdiSoyadi, @OgrenciNo, @DogumTarihi, @DogumYeri, @Telefon, @Eposta, @Cinsiyet)";
            OleDbCommand com = new OleDbCommand(sql, con);
            com.Parameters.AddWithValue("@TcKimlik", TcKimlik);
            com.Parameters.AddWithValue("@AdiSoyadi", AdiSoyadi);
            com.Parameters.AddWithValue("@OgrenciNo", OgrenciNo);
            com.Parameters.AddWithValue("@DogumTarihi", DogumTarihi);
            com.Parameters.AddWithValue("@DogumYeri", DogumYeri);
            com.Parameters.AddWithValue("@Telefon", Telefon);
            com.Parameters.AddWithValue("@Eposta", Eposta);
            com.Parameters.AddWithValue("@Cinsiyet", Cinsiyet);

            com.ExecuteNonQuery();
            con.Close();

        }
        public void EmanetKayit(string TcKimlik, string AdSoyad, string OgrenciNumarasi, string İletisim, string KitapKod, string KitapAdi, string KitapYazari, DateTime BaslangıcTarihi, string EmanetDurumu)
        {
            OleDbConnection con = new OleDbConnection(Yol());
            con.Open();
            string sql = "insert into tblEmanetKitaplar(TcKimlik, AdSoyad, OgrenciNumarasi, İletişim, KitapKod, KitapAdi, KitapYazari, BaslangıcTarihi, EmanetDurumu) values(@TcKimlik, @AdSoyad, @OgrenciNumarasi, @İletisim, @KitapKod, @KitapAdi, @KitapYazari, @BaslangıcTarihi, @EmanetDurumu)";
            OleDbCommand com = new OleDbCommand(sql, con);
            com.Parameters.AddWithValue("@TcKimlik", TcKimlik);
            com.Parameters.AddWithValue("@AdSoyad", AdSoyad);
            com.Parameters.AddWithValue("@OgrenciNumarasi", OgrenciNumarasi);
            com.Parameters.AddWithValue("@İletisim", İletisim);
            com.Parameters.AddWithValue("@KitapKod", KitapKod);
            com.Parameters.AddWithValue("@KitapAdi", KitapAdi);
            com.Parameters.AddWithValue("@KitapYazari", KitapYazari);
            com.Parameters.AddWithValue("@BaslangıcTarihi", BaslangıcTarihi);
            com.Parameters.AddWithValue("@EmanetDurumu", EmanetDurumu);

            com.ExecuteNonQuery();
            con.Close();

        }
        public void KullaniciBilgileri(string KullaniciAdi, string Gorevi, string AdSoyad, DateTime DogumTarihi, DateTime GirisTarihi)
        {
            OleDbConnection con = new OleDbConnection(Yol());
            con.Open();
            string sql = "insert into tblKullaniciBilgileri(KullaniciAdi, Gorevi, AdSoyad, DogumTarihi, GirisTarihi) values(@KullaniciAdi, @Gorevi, @AdSoyad, @DogumTarihi, @GirisTarihi)";
            OleDbCommand com = new OleDbCommand(sql, con);
            com.Parameters.AddWithValue("KullaniciAdi", KullaniciAdi);
            com.Parameters.AddWithValue("@Gorevi", Gorevi);
            com.Parameters.AddWithValue("@AdSoyad", AdSoyad);
            com.Parameters.AddWithValue("@DogumTarihi", DogumTarihi);
            com.Parameters.AddWithValue("@GirisTarihi", GirisTarihi);
       
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
        public void FotografKaydet(string KullaniciAdi, string FotografYolu)
        {
            OleDbConnection con = new OleDbConnection(Yol());
            con.Open();
            string sql = "insert into tblFotograf(KullaniciAdi, FotografYolu) values(@KullaniciAdi, @FotografYolu)";
            OleDbCommand com = new OleDbCommand(sql, con);
            com.Parameters.AddWithValue("@KullaniciAdi", KullaniciAdi);
            com.Parameters.AddWithValue("@FotografYolu", FotografYolu);
            com.ExecuteNonQuery();
            con.Close();

        }
        public void KapakFotografKaydet(string KitapAdı, string FotografYolu)
        {
            OleDbConnection con = new OleDbConnection(Yol());
            con.Open();
            string sql = "insert into tblKitapBilgileri(KitapAdı, FotografYolu) values(@KitapAdı, @FotografYolu)";
            OleDbCommand com = new OleDbCommand(sql, con);
            com.Parameters.AddWithValue("@KitapAdı", KitapAdı);
            com.Parameters.AddWithValue("@FotografYolu", FotografYolu);
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

        public bool TcKontrol(string TcKimlik)
        {
            OleDbConnection con = new OleDbConnection(Yol());
            con.Open();
            string sql = "select * from tblOgrenciler where TcKimlik=@TcKimlik";
            DataTable dt = new DataTable();
            OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
            adp.SelectCommand.Parameters.AddWithValue("@TcKimlik", TcKimlik);
            adp.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        

        }
        public bool OkuyucuTcKontrol(string TcKimlik)
        {
            OleDbConnection con = new OleDbConnection(Yol());
            con.Open();
            string sql = "select * from tblOkuyucu where TcKimlik=@TcKimlik";
            DataTable dt = new DataTable();
            OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
            adp.SelectCommand.Parameters.AddWithValue("@TcKimlik", TcKimlik);
            adp.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
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

        public DataTable KitapGoruntuleme(string KitapKod)
        {
            OleDbConnection con = new OleDbConnection(Yol());
            con.Open();
            string sql = "select KitapAd,KategoriAd, YazarAd ,Aciklama from tblKitaplar where KitapKod=@KitapKod";
            DataTable dt = new DataTable();
            OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
            adp.SelectCommand.Parameters.AddWithValue("@KitapKod", KitapKod);
            adp.Fill(dt);
            return dt;
        }


        public DataTable SifreBul(string KullaniciAd ,string Eposta)
        {
            OleDbConnection con = new OleDbConnection(Yol());
            con.Open();
            string sql = "select sifre from tblKullanicilar where KullaniciAd=@KullaniciAd and Eposta=@Eposta" ;
            DataTable dt = new DataTable();
            OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
           
            adp.SelectCommand.Parameters.AddWithValue("@KullaniciAd", KullaniciAd);
            adp.SelectCommand.Parameters.AddWithValue("@Eposta", Eposta);

            adp.Fill(dt);
            return dt;
        }

        public DataTable KullaniciBilgileriBul(string KullaniciAdi)
        {
            OleDbConnection con = new OleDbConnection(Yol());
            con.Open();
            string sql = "select * from tblKullaniciBilgileri where KullaniciAdi=@KullaniciAdi";
            DataTable dt = new DataTable();
            OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
            adp.SelectCommand.Parameters.AddWithValue("@KullaniciAdi", KullaniciAdi);
            adp.Fill(dt);
            return dt;
        }
        public DataTable FotografBul(string KullaniciAdi)
        {
            OleDbConnection con = new OleDbConnection(Yol());
            con.Open();
            string sql = "select * from tblFotograf where KullaniciAdi=@KullaniciAdi";
            DataTable dt = new DataTable(); 
            OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
            adp.SelectCommand.Parameters.AddWithValue("@KullaniciAdi", KullaniciAdi);
            adp.Fill(dt);
            return dt;
        }
        public DataTable KapakFotografıBul(string KitapAdı)
        {
            OleDbConnection con = new OleDbConnection(Yol());
            con.Open();
            string sql = "select * from tblKitapBilgileri where KitapAdı=@KitapAdı";
            DataTable dt = new DataTable();
            OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
            adp.SelectCommand.Parameters.AddWithValue("@KitapAdı", KitapAdı);
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
        public void KullaniciBilgileriGuncelle1(string KullaniciAdi, string Gorevi, string AdSoyad, DateTime DogumTarihi, DateTime GirisTarihi)
        {
            OleDbConnection con = new OleDbConnection(Yol());
            con.Open();
            string sql = "update tblKullaniciBilgileri set Gorevi=@Gorevi, AdSoyad=@AdSoyad, Dogumtarihi=@DogumTarihi, GirisTarihi=@GirisTarihi where KullaniciAdi=@KullaniciAdi ";
            OleDbCommand com = new OleDbCommand(sql, con);
            com.Parameters.AddWithValue("@Gorevi", Gorevi);
            com.Parameters.AddWithValue("@AdSoyad", AdSoyad);
            com.Parameters.AddWithValue("@DogumTarihi", DogumTarihi);
            com.Parameters.AddWithValue("@GirisTarihi", GirisTarihi);
            com.Parameters.AddWithValue("@KullaniciAdi", KullaniciAdi);
            com.ExecuteNonQuery();
            con.Close();

        }
        public void KullaniciBilgileriGuncelle2(string KullaniciAd,string AdSoyad)
        {
            OleDbConnection con = new OleDbConnection(Yol());
            con.Open();
            string sql = "update tblKullanicilar set AdSoyad=@AdSoyad where KullaniciAd=@KullaniciAd ";
            OleDbCommand com = new OleDbCommand(sql, con);
            com.Parameters.AddWithValue("@AdSoyad", AdSoyad);
            com.Parameters.AddWithValue("@KullaniciAd", KullaniciAd);
            com.ExecuteNonQuery();
            con.Close();

        }
        public void KullaniciKayitGuncelle(string KullaniciAd, string AdSoyad, string YetkiDurum, string Eposta)
        {
            OleDbConnection con = new OleDbConnection(Yol());
            con.Open();
            string sql = "update tblKullanicilar set AdSoyad=@AdSoyad, YetkiDurum=@YetkiDurum, Eposta=@Eposta where KullaniciAd=@KullaniciAd ";
            OleDbCommand com = new OleDbCommand(sql, con);
            com.Parameters.AddWithValue("@Adsoyad", AdSoyad);
            com.Parameters.AddWithValue("@YetkiDurum", YetkiDurum);
            com.Parameters.AddWithValue("@Eposta", Eposta);
            com.Parameters.AddWithValue("@KullaniciAd", KullaniciAd);
            com.ExecuteNonQuery();
            con.Close();

        }
        public void KullaniciKayitGuncelle2(string KullaniciAd, string AdSoyad)
        {
            OleDbConnection con = new OleDbConnection(Yol());
            con.Open();
            string sql = "update tblKullaniciBilgileri set AdSoyad=@AdSoyad where KullaniciAd=@KullaniciAd ";
            OleDbCommand com = new OleDbCommand(sql, con);
            com.Parameters.AddWithValue("@AdSoyad", AdSoyad);
            com.Parameters.AddWithValue("@KullaniciAd", KullaniciAd);
            com.ExecuteNonQuery();
            con.Close();

        }
        public void sifreguncelle(string KullaniciAd, string Sifre)
        {
            OleDbConnection con = new OleDbConnection(Yol());
            con.Open();
            string sql = "update tblKullanicilar set Sifre=@Sifre where KullaniciAd=@KullaniciAd ";
            OleDbCommand com = new OleDbCommand(sql, con);
            
            com.Parameters.AddWithValue("@Sifre", Sifre);
            com.Parameters.AddWithValue("@KullaniciAd", KullaniciAd);
            com.ExecuteNonQuery();
            con.Close();

        }
        public void FotografGuncelle(string KullaniciAdi, string FotografYolu)
        {
            OleDbConnection con = new OleDbConnection(Yol());
            con.Open();
            string sql = "update tblFotograf set FotografYolu=@FotografYolu where KullaniciAdi=@KullaniciAdi ";
            OleDbCommand com = new OleDbCommand(sql, con);
            com.Parameters.AddWithValue("@FotografYolu", FotografYolu);
            com.Parameters.AddWithValue("@KullaniciAdi", KullaniciAdi);
            com.ExecuteNonQuery();
            con.Close();

        }
        public void KapakFotografGuncelle(string KitapAdı, string FotografYolu)
        {
            OleDbConnection con = new OleDbConnection(Yol());
            con.Open();
            string sql = "update tblKitapBilgileri set FotografYolu=@FotografYolu where KitapAdı=@KitapAdı ";
            OleDbCommand com = new OleDbCommand(sql, con);
            com.Parameters.AddWithValue("@FotografYolu", FotografYolu);
            com.Parameters.AddWithValue("@KitapAdı", KitapAdı);
            com.ExecuteNonQuery();
            con.Close();

        }
        public void EmanetKitapGuncelle(string HasarDurumu, string TcKimlik, string KitapKod)
        {
            OleDbConnection con = new OleDbConnection(Yol());
            con.Open();
            string sql = "update tblEmanetKitaplar set HasarDurumu=@HasarDurumu where TcKimlik=@TcKimlik and KitapKod=@KitapKod ";
            OleDbCommand com = new OleDbCommand(sql, con);
            com.Parameters.AddWithValue("@HasarDurumu", HasarDurumu);
            
            com.Parameters.AddWithValue("@TcKimlik", TcKimlik);
            com.Parameters.AddWithValue("@KitapKod", KitapKod);
            com.ExecuteNonQuery();
            con.Close();

        }
        public void EmanetKitapGuncelle2(string EmanetDurumu, string TcKimlik, string KitapKod)
        {
            OleDbConnection con = new OleDbConnection(Yol());
            con.Open();
            string sql = "update tblEmanetKitaplar set EmanetDurumu=@EmanetDurumu where TcKimlik=@TcKimlik and KitapKod=@KitapKod ";
            OleDbCommand com = new OleDbCommand(sql, con);
            com.Parameters.AddWithValue("@EmanetDurumu", EmanetDurumu);

            com.Parameters.AddWithValue("@TcKimlik", TcKimlik);
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
        public DataTable EmanetKitaplar()
        {
            OleDbConnection con = new OleDbConnection(Yol());
            con.Open();
            string sql = "select * from tblEmanetKitaplar Order by TcKimlik ASC";
            DataTable dt = new DataTable();
            OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
            adp.Fill(dt);
            return dt;


        }


        public DataTable TumOkuyucular()
        {
            OleDbConnection con = new OleDbConnection(Yol());
            con.Open();
            string sql = "select * from tblOkuyucu Order by TcKimlik ASC";
            DataTable dt = new DataTable();
            OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
            adp.Fill(dt);
            return dt;


        }
        public DataTable TumOkuyucularradio2()//ogrenci no sıralama
        {
            OleDbConnection con = new OleDbConnection(Yol());
            con.Open();
            string sql = "select * from tblOkuyucu Order by OgrenciNo ASC";
            DataTable dt = new DataTable();
            OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
            adp.Fill(dt);
            return dt;


        }
        public DataTable TumOkuyucularradio3()//ogrenci no sıralama
        {
            OleDbConnection con = new OleDbConnection(Yol());
            con.Open();
            string sql = "select * from tblOkuyucu Order by AdiSoyadi ASC";
            DataTable dt = new DataTable();
            OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
            adp.Fill(dt);
            return dt;


        }
        public DataTable TumKullanıcılar()
        {
            OleDbConnection con = new OleDbConnection(Yol());
            con.Open();
            string sql = "select KullaniciAd, AdSoyad,YetkiDurum, Eposta,FotografYolu ,KullaniciAdi from tblKullanicilar,tblFotograf where KullaniciAd=KullaniciAdi";
            DataTable dt = new DataTable();
            OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
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
        public DataTable OkuyucuAramaTc(String Bul)
        {
            OleDbConnection con = new OleDbConnection(Yol());
            con.Open();
            string sql = "select * from tblOkuyucu where TcKimlik like '%" + Bul + "%'";
            DataTable dt = new DataTable();
            OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
            adp.Fill(dt);
            return dt;


        }
        public DataTable OkuyucuAramaAdSoyad(String Bul)
        {
            OleDbConnection con = new OleDbConnection(Yol());
            con.Open();
            string sql = "select * from tblOkuyucu where AdiSoyadi like '%" + Bul + "%'";
            DataTable dt = new DataTable();
            OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
            adp.Fill(dt);
            return dt;


        }
        public DataTable OkuyucuAramaOkulNumarasi(String Bul)
        {
            OleDbConnection con = new OleDbConnection(Yol());
            con.Open();
            string sql = "select * from tblOkuyucu where OgrenciNo like '%" + Bul + "%'";
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
        public void KullanıcıSil(string KullaniciAd)
        {
            OleDbConnection con = new OleDbConnection(Yol());
            con.Open();
            string sql = "delete from tblKullanicilar where KullaniciAd=@KullaniciAd";
            OleDbCommand com = new OleDbCommand(sql, con);
            com.Parameters.AddWithValue("@KullaniciAd", KullaniciAd);
            com.ExecuteNonQuery();
            con.Close();

        }
        public void KullanıcıSil2(string KullaniciAd)
        {
            OleDbConnection con = new OleDbConnection(Yol());
            con.Open();
            string sql = "delete from tblKullaniciBilgileri where KullaniciAdi=@KullaniciAdi";
            OleDbCommand com = new OleDbCommand(sql, con);
            com.Parameters.AddWithValue("@KullaniciAd", KullaniciAd);
            com.ExecuteNonQuery();
            con.Close();

        }
        public void KullanıcıSil3(string KullaniciAd)
        {
            OleDbConnection con = new OleDbConnection(Yol());
            con.Open();
            string sql = "delete from tblFotograf where KullaniciAdi=@KullaniciAdi";
            OleDbCommand com = new OleDbCommand(sql, con);
            com.Parameters.AddWithValue("@KullaniciAd", KullaniciAd);
            com.ExecuteNonQuery();
            con.Close();

        }
        public bool emailkontrol(string emailadress)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" + // email tip
            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(emailadress)) // eğer gelen veri email tpinde ise
            {
                return true;
            }
            else
            {
                return false;
            }
        }




    }
}
