using System;
using System.Linq;
using ContosoUniversity.Data;
using ContosoUniversity.Dto;

namespace ContosoUniversity.Serwis

{
    public class ServiceLicznikiDane : IServiceLicznikDane
    {
        private readonly LicznikiContext _licznikiContext;
        private IServiceLicznikDane _serviceLicznikDaneImplementation;


        public ServiceLicznikiDane(LicznikiContext context)
        {
            _licznikiContext = context;
        }


        public LicznikiDaneDto Get(int id)
        {
            var licznikDane = _licznikiContext.LicznikDane.Where(z => z.Id == id).Select(z => z).Single();

            //var licznik2 = (from liczniki in _licznikiContext.Liczniki
            //    where licznik.Id == id
            //    select licznik).Single();

            var licznikDaneDto = new LicznikiDaneDto(licznikDane.Id, licznikDane.LicznikId, licznikDane.Stan,
                licznikDane.Zuzycie, licznikDane.IloscDni, licznikDane.AvgZuzycie, licznikDane.DataWpisu);
            return licznikDaneDto;
        }

        public void Update(int id, LicznikiDaneDto dane)
        {
            var licznikDane = _licznikiContext.LicznikDane.Where(z => z.Id == id).Select(z => z).Single();
            licznikDane.LicznikId = dane.LicznikId;
            licznikDane.Stan = dane.Stan;
            licznikDane.AvgZuzycie = dane.AvgZuzycie;
            licznikDane.DataWpisu = dane.DataWpisu;
            licznikDane.IloscDni = dane.IloscDni;
            licznikDane.Zuzycie = dane.Zuzycie;
            
            _licznikiContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var licznik = _licznikiContext.Liczniki.Where(z => z.Id == id).Select(z => z).Single();
            _licznikiContext.Liczniki.Remove(licznik);
            _licznikiContext.SaveChanges();
        }

        public int Add(LicznikiDaneDto dto)
        {
            var nowyLicznikDane = new LicznikDane(dto.LicznikId, dto.Stan, dto.Zuzycie, dto.IloscDni, dto.AvgZuzycie,
                dto.DataWpisu);
            _licznikiContext.LicznikDane.Add(nowyLicznikDane);
            _licznikiContext.SaveChanges();
            return nowyLicznikDane.Id;
        }
    }
}