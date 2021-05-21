using System.IO.Compression;
using System.Linq;
using ContosoUniversity.Data;
using ContosoUniversity.Dto;

namespace ContosoUniversity.Serwis
{
    public class ServiceLiczniki :IServiceLicznik
    {
        private readonly LicznikiContext _licznikiContext;

        public ServiceLiczniki(LicznikiContext context)
        {
            _licznikiContext = context;
        }

        public int Add(string nazwa, string typ)
        {
            var nowyLiczniki = new Liczniki(nazwa, typ);
            _licznikiContext.Liczniki.Add(nowyLiczniki);
            _licznikiContext.SaveChanges();
            return nowyLiczniki.Id;
        }

        public LicznikiDto Get(int id)
        {
            var licznik = _licznikiContext.Liczniki.Where(z => z.Id == id).Select(z => z).Single();

            var licznik2 = (from liczniki in _licznikiContext.Liczniki
                where licznik.Id == id
                select licznik).Single();

            var licznikDto = new LicznikiDto(licznik.Id, licznik.Nazwa, licznik.Typ);
            return licznikDto;
        }

        public void Update(int id,LicznikiDto dto)
        {
            var licznik = _licznikiContext.Liczniki.Where(z => z.Id == id).Select(z => z).Single();
            licznik.Nazwa = dto.Nazwa;
            licznik.Typ = dto.Typ;
            _licznikiContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var licznik = _licznikiContext.Liczniki.Where(z => z.Id == id).Select(z => z).Single();
            _licznikiContext.Liczniki.Remove(licznik);
            _licznikiContext.SaveChanges();

        }
    }
}