using System;

namespace ContosoUniversity.Dto
{
    public class LicznikiDaneDto
    {
        public LicznikiDaneDto()
        {
        }

        public LicznikiDaneDto(int? id, int licznikId, decimal stan, decimal zuzycie, int iloscDni, decimal avgZuzycie,
            DateTime dataWpisu)
        {
            Id = id;
            LicznikId = licznikId;
            Stan = stan;
            Zuzycie = zuzycie;
            AvgZuzycie = avgZuzycie;
            DataWpisu = dataWpisu;
            IloscDni = iloscDni;
        }
        public int? Id { get; set; }
        public int LicznikId { get; set; }
        public decimal Stan { get; set; }
        public decimal Zuzycie { get; set; }
        public int IloscDni { get; set; }
        public decimal AvgZuzycie { get; set; }
        public DateTime DataWpisu { get; set; }
    }


}