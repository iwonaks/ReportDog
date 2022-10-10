namespace ReportApp
{
    public interface IDog
    {
        public static DateTime UtcNow { get; }
        string Chipnumber { get; set; }
        string Cpc { get; set; }
        string Gender { get; set; }
        string Name { get; set; }
        
        int Id { get; set; }

        int Age { get; set; }
        int Behavior { get; set; }
        int Cooperation { get; set; }
        int Stay_a { get; set; }
        int Stay_b { get; set; }
        int Work { get; set; }
               
        abstract int ValueWork();
        abstract int ValueCooperation();
        abstract int ValueStay_a();
        abstract int ValueStay_b();
        abstract int ValueBehavior();

        abstract void AddToList();
    }
}
