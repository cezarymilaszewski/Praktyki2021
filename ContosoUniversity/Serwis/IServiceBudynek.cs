using ContosoUniversity.Dto;

namespace ContosoUniversity.Serwis
{
    internal interface IServiceBudynek
    {
        int Add(BudynekDto budynekDto);
        BudynekDto Get(int id);
        void Update(int id, BudynekDto dto);
        void Delete(int id);
    }
}