using System;
using System.Collections.Generic;
namespace MutlakDeger
{
    public class Algoritma_Islemleri
    {
        public List<double> AlgoritmaKur(List<int> list)
        {
            double kucukSayiFarklari=0, buyukSayiFarklari=0;
            List<Double> Sonuc= new List<double>();
            foreach (var item in list)
            {
                if(item<67){kucukSayiFarklari+=67-item;}else{buyukSayiFarklari+=Math.Pow((Math.Abs(67-item)),2);}
            }
            Sonuc.Add(kucukSayiFarklari); // elde edilen toplam sayılarını listeye ekledim.
            Sonuc.Add(buyukSayiFarklari);
            return Sonuc; //Listeyi SonuclariYazdir metodunda kullanmak üzere döndürdüm.
        }
        public void SonuclariYazdir(List<double> list) //elde edilen değerleri parametre olarak aldım ve bunları foreach döngüsüyle ekrana yazdırdım.
        {
            foreach (var item in list)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}