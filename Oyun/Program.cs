using Main;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
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



        Ucak ucak2 = new Ucak(baslangic);
        Obus obus2 = new Obus(baslangic);
        Fikrateyn fikrateyn2 = new Fikrateyn(baslangic);

        Siha siha2 = new Siha(baslangic);
        KFS kfs2 = new KFS(baslangic);
        Sida sida2 = new Sida(baslangic);

        //Ucak ucak2 = new Ucak(baslangic);







        kartlar.Add(ucak);
        kartlar.Add(obus);
        kartlar.Add(fikrateyn);
        kartlar.Add(ucak);


        kartlarpc.Add(ucak2);
        kartlarpc.Add(obus2);
        kartlarpc.Add(fikrateyn2);
        kartlarpc.Add(ucak2);


        Console.WriteLine(kartlar[0].AltSinif);
        Console.WriteLine(kartlar[0].VurusAvantaji);




        //Console.WriteLine(kartlar[3].AltSinif);




        //ucak.KartPuaniGoster();

        //Savas_Araclari[] deste = { ucak, ucak[0], ucak2, obus };

        Bilgisayar pc = new Bilgisayar(1, 0);
        Kullanici ben = new Kullanici(1, "ahmet", 0);

        ben.KartListesi = new List<Savas_Araclari>();

        pc.KartListesi = new List<Savas_Araclari>();


        ben.KartListesi = kartlar;

        Console.WriteLine(ben.KartListesi.Count);

        pc.KartListesi = kartlarpc;


        //ben.KartSec();

        //kartlar.Clear();
        //kartlarpc.Clear();

        List<Savas_Araclari> kartlar2 = new List<Savas_Araclari>();
        List<Savas_Araclari> kartlarpc2 = new List<Savas_Araclari>();



        do
        {
            kartlarpc2.Add(pc.KartSec());
            Console.WriteLine();

            kartlarpc2.Add(pc.KartSec());
            Console.WriteLine();

            kartlarpc2.Add(pc.KartSec());
            Console.WriteLine();




            kartlar2.Add(ben.KartSec());
            Console.WriteLine();
            kartlar2.Add(ben.KartSec());
            Console.WriteLine();
            kartlar2.Add(ben.KartSec());
            Console.WriteLine("\n");

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

            /*rastgele kart ataması olacak eger seviye yuksekse diger kartlar da verilebilecek
                
                eger 1 kart kaldıysa 2 kart verecek

                tüm kartlar kullanıldıysa bi kart tekrar seçilebilecek
            */



            File.WriteAllText("similasyon.txt", "başarıyla yazıldı");
        } while (false);//while(ben.KartListesi.Count > 0 && pc.KartListesi.Count > 0);




    }
}
