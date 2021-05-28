namespace ContosoUniversity.Data
{
    public class Budynek
    {
        public Budynek()
        {
        }

        public Budynek(string nazwa, int licznikId)
        {
            Nazwa = nazwa;
            LicznikId = licznikId;
        }

        public int Id { get; set; }
        public string Nazwa { get; set; }
        public int LicznikId { get; set; }

    }
}