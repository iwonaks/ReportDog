namespace ReportApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>();

            DateTime saveUtcNow = DateTime.UtcNow;

            dogs.Add(new Dog()
            {
                Id = 1,
                Name = "Malwa",
                Chipnumber = "125df",
                Gender = "M",
                Age = 3,
                Cpc = "T",
                Work = 3,
                Cooperation = 2,
                Stay_a = 3,
                Stay_b = 4,
                Behavior = 3
            });

            dogs.Add(new Dog()
            {
                Id = 2,
                Name = "Jack",
                Chipnumber = "145893",
                Gender = "F",
                Age = 6,
                Cpc = "N",
                Work = 4,
                Cooperation = 4,
                Stay_a = 0,
                Stay_b = 1,
                Behavior = 4
            });

            dogs.Add(new Dog()
            {
                Id = 3,
                Name = "Dron",
                Chipnumber = "M95856",
                Gender = "M",
                Age = 4,
                Cpc = "N",
                Work = 4,
                Cooperation = 4,
                Stay_a = 0,
                Stay_b = 2,
                Behavior = 4
            });

            foreach( Dog dog in dogs)
            {
                dog.AddToList(dogs);
            }

            using (var writer = File.AppendText("report.txt"))
            {   
                writer.WriteLine($"Raport. Data sporządzenia: {saveUtcNow}");

                foreach (Dog i in dogs)
                {
                    writer.WriteLine($"Nr psa: {i.Id}  Imię: {i.Name}  Nr chip: {i.Chipnumber} Płeć psa: {i.Gender}  Wiek psa w latach: {i.Age}");
                    writer.WriteLine($"Czy pies posiada tytuł Champion of Work: {i.Cpc}");
                    writer.WriteLine($"Punkty uzyskane w danej kategorii:");
                    writer.WriteLine($"Praca na otoku, ocena: {i.Work} co daje: {i.VWork}p.");
                    writer.WriteLine($"Współpraca z przewodnikiem, ocena: {i.Cooperation} co daje: {i.VCooperation}p.");
                    writer.WriteLine($"Odłożenie psa luzem, ocena: {i.Stay_a} co daje: {i.VStay_a}p.");
                    writer.WriteLine($"Odłożenie psa na uwięzi, ocena: {i.Stay_b} co daje: {i.VStay_b}p.");
                    writer.WriteLine($"Zachowanie przy zwierzynie, ocena: {i.Behavior} co daje: {i.VBehavior}");
                    writer.WriteLine("SUMA PUNKTÓW {result}");
                    writer.WriteLine();
                }
                writer.WriteLine("-------------------------------------------------------------------------");
            }
            Console.WriteLine("Statystyki dotyczące psów zostały zapisane w pliku report.txt");
        }
    }
}