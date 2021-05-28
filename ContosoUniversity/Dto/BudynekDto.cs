namespace ContosoUniversity.Dto
{
    public class BudynekDto
    {
        public BudynekDto()
        {
        }


        public BudynekDto(int? id, string nazwa, int licznikId)
        {
            Id = id;
            Nazwa = nazwa;
            LicznikId = licznikId;
        }

        public int? Id { get; set; }
        public string Nazwa { get; set; }

        public int LicznikId { get; set; }
    }
}