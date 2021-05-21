using System;

namespace ContosoUniversity.Data
{
    public class LicznikDane
    {
        public LicznikDane()
        {
        }


        public LicznikDane(int licznikId, decimal stan, decimal zuzycie, int iloscDni, decimal avgZuzycie,
            DateTime dataWpisu)
        {
            LicznikId = licznikId;
            Stan = stan;
            Zuzycie = zuzycie;
            IloscDni = iloscDni;
            AvgZuzycie = avgZuzycie;
            DataWpisu = dataWpisu;
        }

        public int Id { get; set; }
        public int LicznikId { get; set; }
        public decimal Stan { get; set; }
        public decimal Zuzycie { get; set; }
        public int IloscDni { get; set; }
        public decimal AvgZuzycie { get; set; }
        public DateTime DataWpisu { get; set; }
    }
}