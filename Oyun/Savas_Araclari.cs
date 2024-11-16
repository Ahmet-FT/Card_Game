using System;

namespace Main
{
    // Abstract Savaş Araçları Sınıfı
    abstract class Savas_Araclari
    {
        public int SeviyePuani { get; set; }
        public abstract int Dayaniklilik { get; set; }
        public abstract int Vurus { get; set; }
        public abstract string Sinif { get; }

        // Kart puanı göstermek için metod
        public void KartPuaniGoster()
        {
            Console.WriteLine($"Dayaniklilik: {Dayaniklilik}, Seviye Puani: {SeviyePuani}, Sınıf: {Sinif}");
        }

        // Abstract metod: Durum güncelleme
        public abstract void DurumGuncelle(int vurduguHasar);
    }

    // Abstract Hava Araçları Sınıfı
    abstract class Hava_Araclari : Savas_Araclari
    {
        public abstract string AltSinif { get; }
        public abstract int KaraVurusAvantaji { get; }

        // Constructor
        protected Hava_Araclari(int seviyePuani)
        {
            SeviyePuani = seviyePuani;
        }
        public override void DurumGuncelle(int vurduguHasar)
        {
            Dayaniklilik -= vurduguHasar;
            SeviyePuani += vurduguHasar;
            Console.WriteLine($"{AltSinif} Durumu Güncellendi: Dayaniklilik = {Dayaniklilik}, SeviyePuani = {SeviyePuani}");
        }
    }

    // Uçak Sınıfı
    class Ucak : Hava_Araclari
    {
        public override int Dayaniklilik { get; set; } = 20;
        public override int Vurus { get; set; } = 10;
        public override string Sinif => "Hava";
        public override string AltSinif => "Uçak";
        public override int KaraVurusAvantaji => 10;

        // Constructor
        public Ucak(int seviyePuani) : base(seviyePuani) { }

        // Durum güncelleme
        
    }

    // SİHA Sınıfı
    class Siha : Hava_Araclari
    {
        public override int Dayaniklilik { get; set; } = 15;
        public override int Vurus { get; set; } = 10;
        public override string Sinif => "Hava";
        public override string AltSinif => "Siha";
        public override int KaraVurusAvantaji => 10;

        // Constructor
        public Siha(int seviyePuani) : base(seviyePuani) { }

        // Durum güncelleme
        
    }

    // Abstract Kara Araçları Sınıfı
    abstract class Kara_Araclari : Savas_Araclari
    {
        public abstract string AltSinif { get; }
        public abstract int DenizVurusAvantaji { get; }

        protected Kara_Araclari(int seviyePuani)
        {
            SeviyePuani = seviyePuani;
        }
        public override void DurumGuncelle(int vurduguHasar)
        {
            Dayaniklilik -= vurduguHasar;
            SeviyePuani += vurduguHasar;
            Console.WriteLine($"{AltSinif} Durumu Güncellendi: Dayaniklilik = {Dayaniklilik}, SeviyePuani = {SeviyePuani}");
        }
    }

    // Obüs Sınıfı
    class Obus : Kara_Araclari
    {
        public override int Dayaniklilik { get; set; } = 20;
        public override int Vurus { get; set; } = 10;
        public override string Sinif => "Kara";
        public override string AltSinif => "Obüs";
        public override int DenizVurusAvantaji => 5;

        public Obus(int seviyePuani) : base(seviyePuani) { }

        // Durum güncelleme
        
    }

    // KFS Sınıfı
    class KFS : Kara_Araclari
    {
        public override int Dayaniklilik { get; set; } = 10;
        public override int Vurus { get; set; } = 10;
        public override string Sinif => "Kara";
        public override string AltSinif => "KFS";
        public override int DenizVurusAvantaji => 10;

        public KFS(int seviyePuani) : base(seviyePuani) { }


        // Durum güncelleme
        
    }

    // Abstract Deniz Araçları Sınıfı
    abstract class Deniz_Araclari : Savas_Araclari
    {
        public abstract string AltSinif { get; }
        public abstract int HavaVurusAvantaji { get; }

        protected Deniz_Araclari(int seviyePuani)
        {
            SeviyePuani = seviyePuani;
        }
        public override void DurumGuncelle(int vurduguHasar)
        {
            Dayaniklilik -= vurduguHasar;
            SeviyePuani += vurduguHasar;
            Console.WriteLine($"{AltSinif} Durumu Güncellendi: Dayaniklilik = {Dayaniklilik}, SeviyePuani = {SeviyePuani}");
        }
    }

    // Firkateyn Sınıfı
    class Fikrateyn : Deniz_Araclari
    {
        public override int Dayaniklilik { get; set; } = 25;
        public override int Vurus { get; set; } = 10;
        public override string Sinif => "Deniz";
        public override string AltSinif => "Firkateyn";
        public override int HavaVurusAvantaji => 5;

        public Fikrateyn(int seviyePuani) : base(seviyePuani) { }


        // Durum güncelleme
        
    }

    // SİDA Sınıfı
    class Sida : Deniz_Araclari
    {
        public override int Dayaniklilik { get; set; } = 15;
        public override int Vurus { get; set; } = 10;
        public override string Sinif => "Deniz";
        public override string AltSinif => "Sida";
        public override int HavaVurusAvantaji => 10;

        public Sida(int seviyePuani) : base(seviyePuani) { }


        // Durum güncelleme
        
    }
}
