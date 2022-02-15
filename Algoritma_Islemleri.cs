using System;
using System.Collections.Generic;
namespace MutlakDeger
{
    public class Algoritma_Islemleri
    {
        public List<double> AlgoritmaKur(List<int> list)
        {
            double kucukSayiFarklari=0;
            double buyukSayiFarklari=0;
            List<int> Kucukler= new List<int>();
            List<int> Buyukler= new List<int>();
            List<Double> Sonuc= new List<double>();
            foreach (var sayi in list)
            {
                if (sayi<67)
                {
                    Kucukler.Add(sayi);
                }else
                {
                    Buyukler.Add(sayi);
                }
            }
            foreach (var item in Kucukler)
            {
                kucukSayiFarklari+=67-item;
            }
            foreach (var item in Buyukler)
            {
                buyukSayiFarklari=Math.Pow((Math.Abs(67-item)),2);
            }
            Sonuc.Add(kucukSayiFarklari);
            Sonuc.Add(buyukSayiFarklari);
            return Sonuc;
        }
        public void SonuclariYazdir(List<double> list)
        {
            foreach (var item in list)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}