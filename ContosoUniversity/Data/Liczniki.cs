namespace ContosoUniversity.Data
{
    public class Liczniki
    {
        public Liczniki()
        {
        }

        public Liczniki(string nazwa, string typ)
        {
            Nazwa = nazwa;
            Typ = typ;
        }

        public int Id { get; set; }

        public string Nazwa { get; set; }

        public string Typ { get; set; }
    }
}