using Main;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        Console.Write("Baslangic seviyesi girin: ");
        int baslangic = Convert.ToInt32(Console.ReadLine());

        List<Savas_Araclari>[] rastgeledagitim = new List<Savas_Araclari>[10];

        for (int i = 0; i < rastgeledagitim.Length; i++)
        {
            rastgeledagitim[i] = new List<Savas_Araclari>();
            rastgeledagitim[i].Add(new Ucak(baslangic));
            rastgeledagitim[i].Add(new Obus(baslangic));
            rastgeledagitim[i].Add(new Fikrateyn(baslangic));

            rastgeledagitim[i].Add(new Siha(baslangic));
            rastgeledagitim[i].Add(new KFS(baslangic));
            rastgeledagitim[i].Add(new Sida(baslangic));

        }
        //pc icin
        List<Savas_Araclari>[] rastgeledagitimpc = new List<Savas_Araclari>[10];

        for (int i = 0; i < rastgeledagitimpc.Length; i++)
        {
            rastgeledagitimpc[i] = new List<Savas_Araclari>();
            rastgeledagitimpc[i].Add(new Ucak(baslangic));
            rastgeledagitimpc[i].Add(new Obus(baslangic));
            rastgeledagitimpc[i].Add(new Fikrateyn(baslangic));
                           
            rastgeledagitimpc[i].Add(new Siha(baslangic));
            rastgeledagitimpc[i].Add(new KFS(baslangic));
            rastgeledagitimpc[i].Add(new Sida(baslangic));
        }
        

        Bilgisayar pc = new Bilgisayar(1, 0);
        Kullanici ben = new Kullanici(1, "ahmet", 0);

        ben.KartListesi = new List<Savas_Araclari>();

        pc.KartListesi = new List<Savas_Araclari>();


        ben.KartListesi.Add(new Ucak(baslangic));
        ben.KartListesi.Add(new Obus(baslangic));
        ben.KartListesi.Add(new Fikrateyn(baslangic));

        ben.KartListesi.Add(rastgeledagitim[0][random.Next(0, rastgeledagitim[0].Count)]);
        ben.KartListesi.Add(rastgeledagitim[1][random.Next(0, rastgeledagitim[0].Count)]);
        ben.KartListesi.Add(rastgeledagitim[2][random.Next(0, rastgeledagitim[0].Count)]);


        pc.KartListesi.Add(new Ucak(baslangic));
        pc.KartListesi.Add(new Obus(baslangic));
        pc.KartListesi.Add(new Fikrateyn(baslangic));

        pc.KartListesi.Add(rastgeledagitimpc[0][random.Next(0, rastgeledagitim[0].Count)]);
        pc.KartListesi.Add(rastgeledagitimpc[1][random.Next(0, rastgeledagitim[0].Count)]);
        pc.KartListesi.Add(rastgeledagitimpc[2][random.Next(0, rastgeledagitim[0].Count)]);


        List<Savas_Araclari> kartlar2 = new List<Savas_Araclari>();
        List<Savas_Araclari> kartlarpc2 = new List<Savas_Araclari>();

            int adim = 1;
        do
        {     
            kartlar2.Add(ben.KartSec());
            Console.WriteLine();
            kartlar2.Add(ben.KartSec());
            Console.WriteLine();
            kartlar2.Add(ben.KartSec());
            Console.WriteLine("\n");


            kartlarpc2.Add(pc.KartSec());
            Console.WriteLine();
            kartlarpc2.Add(pc.KartSec());
            Console.WriteLine();
            kartlarpc2.Add(pc.KartSec());
            Console.WriteLine();

            for (int i = 0; i < kartlarpc2.Count; i++)
            {
                if (kartlarpc2[i].Avantaj == kartlar2[i].Sinif) 
                { 
                    kartlar2[i].DurumGuncelle(kartlarpc2[i].Vurus + kartlarpc2[i].VurusAvantaji);
                    Console.WriteLine();
                }
                else
                {
                    kartlar2[i].DurumGuncelle(kartlarpc2[i].Vurus);
                    Console.WriteLine();

                }

                if (kartlar2[i].Avantaj == kartlarpc2[i].Sinif)
                {
                    kartlarpc2[i].DurumGuncelle(kartlar2[i].Vurus + kartlar2[i].VurusAvantaji);
                    Console.WriteLine();

                }
                else
                {
                    kartlarpc2[i].DurumGuncelle(kartlar2[i].Vurus);
                    Console.WriteLine();

                }

                if (kartlar2[i].Dayaniklilik > 0)
                {
                    ben.KartListesi.Add(kartlar2[i]);
                }
                else if(kartlar2[i].Dayaniklilik <= 0)
                {
                    Console.WriteLine(kartlar2[i].AltSinif + " karti yenildi.");
                    if (kartlar2[i].SeviyePuani <= 10)
                    {
                        pc.SkorGoster(10);
                        Console.WriteLine();

                    }
                    else
                    {
                        pc.SkorGoster(kartlar2[i].SeviyePuani);
                        Console.WriteLine();

                    }
                }
                if (kartlarpc2[i].Dayaniklilik > 0)
                {
                    pc.KartListesi.Add(kartlarpc2[i]);
                }
                else if (kartlarpc2[i].Dayaniklilik <= 0)
                {
                    Console.WriteLine(kartlarpc2[i].AltSinif + " karti yenildi.");

                    if (kartlarpc2[i].SeviyePuani <= 10)
                    {
                        ben.SkorGoster(10);
                        Console.WriteLine();

                    }
                    else
                    {
                        ben.SkorGoster(kartlarpc2[i].SeviyePuani);
                        Console.WriteLine();
                    }
                }
            }

            if(ben.Skor < 20)
            {
                ben.KartListesi.Add(rastgeledagitim[adim + 2][random.Next(0, 3)]);
                if (ben.KartListesi.Count == 2)
                {
                    ben.KartListesi.Add(rastgeledagitim[adim + 3][random.Next(0, 3)]);

                }
            }
            else
            {
                ben.KartListesi.Add(rastgeledagitim[adim + 2][random.Next(0, 6)]);
                if (ben.KartListesi.Count == 2)
                {
                    ben.KartListesi.Add(rastgeledagitim[adim + 3][random.Next(0, 6)]);

                }
            }

            
            if(ben.KartListesi.Count < 1 && pc.KartListesi.Count < 1)
            {
                Console.WriteLine("kart bitti.\n");
                break;
            }

            if (pc.Skor < 20)
            {
                pc.KartListesi.Add(rastgeledagitimpc[adim + 2][random.Next(0, 3)]);
                if (pc.KartListesi.Count == 2)
                {
                    pc.KartListesi.Add(rastgeledagitimpc[adim + 3][random.Next(0, 3)]);
                }
            }
            else
            {
                pc.KartListesi.Add(rastgeledagitimpc[adim + 2][random.Next(0, 6)]);
                if (pc.KartListesi.Count == 2)
                {
                    pc.KartListesi.Add(rastgeledagitimpc[adim + 3][random.Next(0, 6)]);
                }
            }

            kartlar2.Clear();
            kartlarpc2.Clear();
            File.WriteAllText("similasyon.txt", "başarıyla yazıldı");

            adim++;
           
        } while (adim < 6);//while(ben.KartListesi.Count > 0 && pc.KartListesi.Count > 0);

        if(ben.Skor > pc.Skor)
        {
            Console.WriteLine(ben.OyuncuAdi + " Kazandi, SKOR: " + ben.Skor + "\nBilgisayar skoru: " + pc.Skor);
        }
        else if (pc.Skor > ben.Skor)
        {
            Console.WriteLine(pc.OyuncuAdi + " Kazandi, SKOR: " + pc.Skor + "\n" + ben.OyuncuAdi + " skoru: " + ben.Skor);
        }
        else
        {
            int kullanici_dayaniklilik_toplam = 0;
            foreach (var kart in ben.KartListesi)
            {
                kullanici_dayaniklilik_toplam += kart.Dayaniklilik;
            }

            int bilgisayar_dayaniklilik_toplam = 0;
            foreach (var kart in pc.KartListesi)
            {
                bilgisayar_dayaniklilik_toplam += kart.Dayaniklilik;
            }

            if (kullanici_dayaniklilik_toplam < bilgisayar_dayaniklilik_toplam)
            {
                Console.WriteLine(ben.OyuncuAdi + " Kazandi, SKOR: " + ben.Skor + "\nBilgisayar skoru: " + pc.Skor);
            }
            else if (bilgisayar_dayaniklilik_toplam < kullanici_dayaniklilik_toplam)
            {
                Console.WriteLine(pc.OyuncuAdi + " Kazandi, SKOR: " + pc.Skor + "\n" + ben.OyuncuAdi + " skoru: " + ben.Skor);
            }
            else
            {
                Console.WriteLine("beraberlik");
            }
        }


    }
}
