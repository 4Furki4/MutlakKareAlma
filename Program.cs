using System;

namespace MutlakDeger
{
    class Program
    {
        static void Main(string[] args)
        {
            Konsol_Islemleri konsol= new Konsol_Islemleri();
            Algoritma_Islemleri algoritma = new Algoritma_Islemleri();
            konsol.IlkMesaj();
            algoritma.SonuclariYazdir(algoritma.AlgoritmaKur(konsol.SayılarıAlma()));
        }
    }
}
