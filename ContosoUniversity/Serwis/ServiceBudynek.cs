using System.Linq;
using ContosoUniversity.Data;
using ContosoUniversity.Dto;

namespace ContosoUniversity.Serwis
{
    public class ServiceBudynek : IServiceBudynek
    {
        private readonly LicznikiContext _budynekContext;

        public ServiceBudynek(LicznikiContext context)
        {
            _budynekContext = context;
        }

        public int Add(BudynekDto budynekDto)
        {
            var nowyBudynek = new Budynek(budynekDto.Nazwa, budynekDto.LicznikId);
            _budynekContext.Budynek.Add(nowyBudynek);
            _budynekContext.SaveChanges();
            return nowyBudynek.Id;
        }

        public BudynekDto Get(int id)
        {
            var budynek = _budynekContext.Budynek.Where(z => z.Id == id).Select(z => z).Single();

            var budynekDto = new BudynekDto(budynek.Id, budynek.Nazwa, budynek.LicznikId);
            return budynekDto;
        }

        public void Update(int id, BudynekDto dto)
        {
            var budynek = _budynekContext.Budynek.Where(z => z.Id == id).Select(z => z).Single();
            budynek.Nazwa = dto.Nazwa;
            budynek.LicznikId = dto.LicznikId;
            _budynekContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var budynek = _budynekContext.Budynek.Where(z => z.Id == id).Select(z => z).Single();
            _budynekContext.Budynek.Remove(budynek);
            _budynekContext.SaveChanges();
        }
    }
}