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


        List<Savas_Araclari> kartlar = new List<Savas_Araclari>();

        List<Savas_Araclari> kartlarpc = new List<Savas_Araclari>();

        //tek sayilar oyuncunun ciftler bilgisayarin nin
        Ucak ucak = new Ucak(baslangic);
        Obus obus = new Obus(baslangic);
        Fikrateyn fikrateyn = new Fikrateyn(baslangic);

        Siha siha = new Siha(baslangic);
        KFS kfs = new KFS(baslangic);
        Sida sida = new Sida(baslangic);

        Ucak ucak0 = new Ucak(baslangic);
        Obus obus0 = new Obus(baslangic);
        Fikrateyn fikrateyn0 = new Fikrateyn(baslangic);

        Siha siha0 = new Siha(baslangic);
        KFS kfs0 = new KFS(baslangic);
        Sida sida0 = new Sida(baslangic);

        Ucak ucak1 = new Ucak(baslangic);
        Obus obus1 = new Obus(baslangic);
        Fikrateyn fikrateyn1 = new Fikrateyn(baslangic);

        Siha siha1 = new Siha(baslangic);
        KFS kfs1 = new KFS(baslangic);
        Sida sida1 = new Sida(baslangic);



        Ucak ucak2 = new Ucak(baslangic);
        Obus obus2 = new Obus(baslangic);
        Fikrateyn fikrateyn2 = new Fikrateyn(baslangic);

        Siha siha2 = new Siha(baslangic);
        KFS kfs2 = new KFS(baslangic);
        Sida sida2 = new Sida(baslangic);

        //Ucak ucak2 = new Ucak(baslangic);




        Ucak ucak3 = new Ucak(baslangic);
        Obus obus3 = new Obus(baslangic);
        Fikrateyn fikrateyn3 = new Fikrateyn(baslangic);

        Siha siha3 = new Siha(baslangic);
        KFS kfs3 = new KFS(baslangic);
        Sida sida3 = new Sida(baslangic);


        Ucak ucak4 = new Ucak(baslangic);
        Obus obus4 = new Obus(baslangic);
        Fikrateyn fikrateyn4 = new Fikrateyn(baslangic);

        Siha siha4 = new Siha(baslangic);
        KFS kfs4 = new KFS(baslangic);
        Sida sida4 = new Sida(baslangic);

        Ucak ucak5 = new Ucak(baslangic);
        Obus obus5 = new Obus(baslangic);
        Fikrateyn fikrateyn5 = new Fikrateyn(baslangic);

        Siha siha5 = new Siha(baslangic);
        KFS kfs5 = new KFS(baslangic);
        Sida sida5 = new Sida(baslangic);

        Ucak ucak6 = new Ucak(baslangic);
        Obus obus6 = new Obus(baslangic);
        Fikrateyn fikrateyn6 = new Fikrateyn(baslangic);

        Siha siha6 = new Siha(baslangic);
        KFS kfs6 = new KFS(baslangic);
        Sida sida6 = new Sida(baslangic);

        Ucak ucak7 = new Ucak(baslangic);
        Obus obus7 = new Obus(baslangic);
        Fikrateyn fikrateyn7 = new Fikrateyn(baslangic);

        Siha siha7 = new Siha(baslangic);
        KFS kfs7 = new KFS(baslangic);
        Sida sida7 = new Sida(baslangic);

        Ucak ucak8 = new Ucak(baslangic);
        Obus obus8 = new Obus(baslangic);
        Fikrateyn fikrateyn8 = new Fikrateyn(baslangic);

        Siha siha8 = new Siha(baslangic);
        KFS kfs8 = new KFS(baslangic);
        Sida sida8 = new Sida(baslangic);

        Ucak ucak9 = new Ucak(baslangic);
        Obus obus9 = new Obus(baslangic);
        Fikrateyn fikrateyn9 = new Fikrateyn(baslangic);

        Siha siha9 = new Siha(baslangic);
        KFS kfs9 = new KFS(baslangic);
        Sida sida9 = new Sida(baslangic);

        Ucak ucak10 = new Ucak(baslangic);
        Obus obus10 = new Obus(baslangic);
        Fikrateyn fikrateyn10 = new Fikrateyn(baslangic);

        Siha siha10 = new Siha(baslangic);
        KFS kfs10 = new KFS(baslangic);
        Sida sida10 = new Sida(baslangic);

        Ucak ucak11 = new Ucak(baslangic);
        Obus obus11 = new Obus(baslangic);
        Fikrateyn fikrateyn11 = new Fikrateyn(baslangic);

        Siha siha11 = new Siha(baslangic);
        KFS kfs11 = new KFS(baslangic);
        Sida sida11 = new Sida(baslangic);

        Ucak ucak12 = new Ucak(baslangic);
        Obus obus12 = new Obus(baslangic);
        Fikrateyn fikrateyn12 = new Fikrateyn(baslangic);

        Siha siha12 = new Siha(baslangic);
        KFS kfs12 = new KFS(baslangic);
        Sida sida12 = new Sida(baslangic);

        Ucak ucak13 = new Ucak(baslangic);
        Obus obus13 = new Obus(baslangic);
        Fikrateyn fikrateyn13 = new Fikrateyn(baslangic);

        Siha siha13 = new Siha(baslangic);
        KFS kfs13 = new KFS(baslangic);
        Sida sida13 = new Sida(baslangic);

        Ucak ucak14 = new Ucak(baslangic);
        Obus obus14 = new Obus(baslangic);
        Fikrateyn fikrateyn14 = new Fikrateyn(baslangic);

        Siha siha14 = new Siha(baslangic);
        KFS kfs14 = new KFS(baslangic);
        Sida sida14 = new Sida(baslangic);

        Ucak ucak15 = new Ucak(baslangic);
        Obus obus15 = new Obus(baslangic);
        Fikrateyn fikrateyn15 = new Fikrateyn(baslangic);

        Siha siha15 = new Siha(baslangic);
        KFS kfs15 = new KFS(baslangic);
        Sida sida15 = new Sida(baslangic);

        Ucak ucak16 = new Ucak(baslangic);
        Obus obus16 = new Obus(baslangic);
        Fikrateyn fikrateyn16 = new Fikrateyn(baslangic);

        Siha siha16 = new Siha(baslangic);
        KFS kfs16 = new KFS(baslangic);
        Sida sida16 = new Sida(baslangic);

        Ucak ucak17 = new Ucak(baslangic);
        Obus obus17 = new Obus(baslangic);
        Fikrateyn fikrateyn17 = new Fikrateyn(baslangic);

        Siha siha17 = new Siha(baslangic);
        KFS kfs17 = new KFS(baslangic);
        Sida sida17 = new Sida(baslangic);

        Ucak ucak18 = new Ucak(baslangic);
        Obus obus18 = new Obus(baslangic);
        Fikrateyn fikrateyn18 = new Fikrateyn(baslangic);

        Siha siha18 = new Siha(baslangic);
        KFS kfs18 = new KFS(baslangic);
        Sida sida18 = new Sida(baslangic);










        List<Savas_Araclari>[] rastgeledagitim = new List<Savas_Araclari>[10];

        for (int i = 0; i < rastgeledagitim.Length; i++)
        {
            rastgeledagitim[i] = new List<Savas_Araclari>();
        }

        rastgeledagitim[0].Add(ucak1);
        rastgeledagitim[0].Add(obus1);
        rastgeledagitim[0].Add(fikrateyn1);

        rastgeledagitim[0].Add(siha1);
        rastgeledagitim[0].Add(kfs1);
        rastgeledagitim[0].Add(sida1);

        rastgeledagitim[1].Add(ucak3);
        rastgeledagitim[1].Add(obus3);
        rastgeledagitim[1].Add(fikrateyn3);

        rastgeledagitim[1].Add(siha3);
        rastgeledagitim[1].Add(kfs3);
        rastgeledagitim[1].Add(sida3);

        rastgeledagitim[2].Add(ucak5);
        rastgeledagitim[2].Add(obus5);
        rastgeledagitim[2].Add(fikrateyn5);

        rastgeledagitim[2].Add(siha5);
        rastgeledagitim[2].Add(kfs5);
        rastgeledagitim[2].Add(sida5);

        rastgeledagitim[3].Add(ucak7);
        rastgeledagitim[3].Add(obus7);
        rastgeledagitim[3].Add(fikrateyn7);

        rastgeledagitim[3].Add(siha7);
        rastgeledagitim[3].Add(kfs7);
        rastgeledagitim[3].Add(sida7);

        rastgeledagitim[4].Add(ucak9);
        rastgeledagitim[4].Add(obus9);
        rastgeledagitim[4].Add(fikrateyn9);

        rastgeledagitim[4].Add(siha9);
        rastgeledagitim[4].Add(kfs9);
        rastgeledagitim[4].Add(sida9);

        rastgeledagitim[5].Add(ucak11);
        rastgeledagitim[5].Add(obus11);
        rastgeledagitim[5].Add(fikrateyn11);

        rastgeledagitim[5].Add(siha11);
        rastgeledagitim[5].Add(kfs11);
        rastgeledagitim[5].Add(sida11);

        rastgeledagitim[6].Add(ucak13);
        rastgeledagitim[6].Add(obus13);
        rastgeledagitim[6].Add(fikrateyn13);

        rastgeledagitim[6].Add(siha13);
        rastgeledagitim[6].Add(kfs13);
        rastgeledagitim[6].Add(sida13);

        rastgeledagitim[7].Add(ucak15);
        rastgeledagitim[7].Add(obus15);
        rastgeledagitim[7].Add(fikrateyn15);

        rastgeledagitim[7].Add(siha15);
        rastgeledagitim[7].Add(kfs15);
        rastgeledagitim[7].Add(sida15);

        //pc icin
        List<Savas_Araclari>[] rastgeledagitimpc = new List<Savas_Araclari>[10];

        for (int i = 0; i < rastgeledagitimpc.Length; i++)
        {
            rastgeledagitimpc[i] = new List<Savas_Araclari>();
        }

        rastgeledagitimpc[0].Add(ucak2);
        rastgeledagitimpc[0].Add(obus2);
        rastgeledagitimpc[0].Add(fikrateyn2);

        rastgeledagitimpc[0].Add(siha2);
        rastgeledagitimpc[0].Add(kfs2);
        rastgeledagitimpc[0].Add(sida2);

        rastgeledagitimpc[1].Add(ucak4);
        rastgeledagitimpc[1].Add(obus4);
        rastgeledagitimpc[1].Add(fikrateyn4);

        rastgeledagitimpc[1].Add(siha4);
        rastgeledagitimpc[1].Add(kfs4);
        rastgeledagitimpc[1].Add(sida4);

        rastgeledagitimpc[2].Add(ucak6);
        rastgeledagitimpc[2].Add(obus6);
        rastgeledagitimpc[2].Add(fikrateyn6);

        rastgeledagitimpc[2].Add(siha6);
        rastgeledagitimpc[2].Add(kfs6);
        rastgeledagitimpc[2].Add(sida6);

        rastgeledagitimpc[3].Add(ucak8);
        rastgeledagitimpc[3].Add(obus8);
        rastgeledagitimpc[3].Add(fikrateyn8);

        rastgeledagitimpc[3].Add(siha8);
        rastgeledagitimpc[3].Add(kfs8);
        rastgeledagitimpc[3].Add(sida8);

        rastgeledagitimpc[4].Add(ucak10);
        rastgeledagitimpc[4].Add(obus10);
        rastgeledagitimpc[4].Add(fikrateyn10);

        rastgeledagitimpc[4].Add(siha10);
        rastgeledagitimpc[4].Add(kfs10);
        rastgeledagitimpc[4].Add(sida10);

        rastgeledagitimpc[5].Add(ucak12);
        rastgeledagitimpc[5].Add(obus12);
        rastgeledagitimpc[5].Add(fikrateyn12);

        rastgeledagitimpc[5].Add(siha12);
        rastgeledagitimpc[5].Add(kfs12);
        rastgeledagitimpc[5].Add(sida12);

        rastgeledagitimpc[6].Add(ucak14);
        rastgeledagitimpc[6].Add(obus14);
        rastgeledagitimpc[6].Add(fikrateyn14);

        rastgeledagitimpc[6].Add(siha14);
        rastgeledagitimpc[6].Add(kfs14);
        rastgeledagitimpc[6].Add(sida14);

        rastgeledagitimpc[7].Add(ucak16);
        rastgeledagitimpc[7].Add(obus16);
        rastgeledagitimpc[7].Add(fikrateyn16);

        rastgeledagitimpc[7].Add(siha16);
        rastgeledagitimpc[7].Add(kfs16);
        rastgeledagitimpc[7].Add(sida16);







        kartlar.Add(ucak);
        kartlar.Add(obus);
        kartlar.Add(fikrateyn);
        kartlar.Add(ucak);


        kartlarpc.Add(ucak2);
        kartlarpc.Add(obus2);
        kartlarpc.Add(fikrateyn2);
        kartlarpc.Add(ucak2);


        //Console.WriteLine(kartlar[0].AltSinif);
        //Console.WriteLine(kartlar[0].VurusAvantaji);




        //Console.WriteLine(kartlar[3].AltSinif);




        //ucak.KartPuaniGoster();

        //Savas_Araclari[] deste = { ucak, ucak[0], ucak2, obus };

        Bilgisayar pc = new Bilgisayar(1, 0);
        Kullanici ben = new Kullanici(1, "ahmet", 0);

        ben.KartListesi = new List<Savas_Araclari>();

        pc.KartListesi = new List<Savas_Araclari>();


        //ben.KartListesi = kartlar;

        //Console.WriteLine(ben.KartListesi.Count);

        //pc.KartListesi = kartlarpc;

        ben.KartListesi.Add(ucak);
        ben.KartListesi.Add(obus);
        ben.KartListesi.Add(fikrateyn);

        ben.KartListesi.Add(rastgeledagitim[0][random.Next(0, rastgeledagitim[0].Count)]);
        ben.KartListesi.Add(rastgeledagitim[1][random.Next(0, rastgeledagitim[0].Count)]);
        ben.KartListesi.Add(rastgeledagitim[2][random.Next(0, rastgeledagitim[0].Count)]);


        pc.KartListesi.Add(ucak0);
        pc.KartListesi.Add(obus0);
        pc.KartListesi.Add(fikrateyn0);

        pc.KartListesi.Add(rastgeledagitimpc[0][random.Next(0, rastgeledagitim[0].Count)]);
        pc.KartListesi.Add(rastgeledagitimpc[1][random.Next(0, rastgeledagitim[0].Count)]);
        pc.KartListesi.Add(rastgeledagitimpc[2][random.Next(0, rastgeledagitim[0].Count)]);







        //ben.KartSec();

        //kartlar.Clear();
        //kartlarpc.Clear();

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
                else if (kartlar2[i].Dayaniklilik <= 0)
                {
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

            if (ben.Skor < 20)
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


            if (ben.KartListesi.Count < 1 && pc.KartListesi.Count < 1)
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
            /*rastgele kart ataması olacak eger seviye yuksekse diger kartlar da verilebilecek[done]
                
                eger 1 kart kaldıysa 2 kart verecek [done]

                tüm kartlar kullanıldıysa bi kart tekrar seçilebilecek
            */


            kartlar2.Clear();
            kartlarpc2.Clear();
            File.WriteAllText("similasyon.txt", "başarıyla yazıldı");

            adim++;

        } while (adim < 6);//while(ben.KartListesi.Count > 0 && pc.KartListesi.Count > 0);

        if (ben.Skor < pc.Skor)
        {
            Console.WriteLine("%s Kazandi", ben.OyuncuAdi);
        }
        else if (pc.Skor < ben.Skor)
        {
            Console.WriteLine("%s Kazandi", pc.OyuncuAdi);
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
                Console.WriteLine("%s Kazandi", ben.OyuncuAdi);
            }
            else if (bilgisayar_dayaniklilik_toplam < kullanici_dayaniklilik_toplam)
            {
                Console.WriteLine("%s Kazandi", pc.OyuncuAdi);
            }
            else
            {
                Console.WriteLine("beraberlik");
            }
        }


    }
}
