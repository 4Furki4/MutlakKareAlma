using System;
using System.Collections.Generic;
namespace MutlakDeger
{
    public class Konsol_Islemleri
    {
        public void IlkMesaj()
        {
            System.Console.WriteLine("Aralarında boşluk olacak şekilde gireceğiniz n tane sayının"+
            "67'den küçük olup olmadığına bakılacak. 67'den küçük olan sayıların, 67'yle olan farklarının toplamı, 67'den büyük olanların"+
            "67'yle olan mutlak değerlerinin toplamının kareleri ekrana yazılacak. \n Lütfen sayıları giriniz:");
        }
        public List<int> SayılarıAlma() // Integer listeye konsoldan alınan string sayıları aradaki boşluklara göre ayırıp int olacak şekilde ekleyen metot.
        {
            List<int> sayilar = new List<int>();
            string input = Console.ReadLine();
            
            foreach (var sayı in input.Split(" "))
            {
                sayilar.Add(int.Parse(sayı));
            }
            return sayilar;
        }
    }
}