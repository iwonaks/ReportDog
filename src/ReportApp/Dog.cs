namespace ReportApp
{
    public class NamedObject
    {
        public static DateTime UtcNow { get; }
        public string Chipnumber { get; set; } = string.Empty;
        public string Cpc { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;


        public int Id { get; set; } = default;
        public int Age { get; set; }= default;
        public int Behavior { get; set; } = default;
        public int VBehavior { get; set; } = default;
        public int Cooperation { get; set; } = default;
        public int VCooperation { get; set; } = default;
        public int Stay_a { get; set; } = default;
        public int VStay_a { get; set; } = default;
        public int Stay_b { get; set; } = default;
        public int VStay_b { get; set; } = default;
        public int Work { get; set; } = default;
        public int VWork { get; set; } = default;

        public List<Dog> dogs = new List<Dog>();
    }

    public abstract class DogBase :NamedObject
    {
        public abstract int ValueWork();
        public abstract int ValueCooperation();
        public abstract int ValueStay_a();
        public abstract int ValueStay_b();
        public abstract int ValueBehavior();   

        public abstract void AddToList();
    }
    
    public class Dog: NamedObject
    {
        public int ValueWork(int i) => 10*i;

        public int ValueCooperation(int i) => 4*i;
    
        public int ValueStay_a(int i) => 5*i;
        
        public int ValueStay_b(int i) => 3*i;
        
        public int ValueBehavior(int i) => 6*i;           

        public void AddToList(List<Dog> dogs)
            {
                dogs.Where(dog => dog.Id == 1 || dog.Id == 2 || dog.Id == 3)
                .Select(dog => { dog.VWork = dog.ValueWork(dog.Work); return dog; }).ToList();

                dogs.Where(dog => dog.Id == 1 || dog.Id == 2 || dog.Id == 3)
                .Select(dog => { dog.VCooperation = dog.ValueCooperation(dog.Cooperation); return dog; }).ToList();

                dogs.Where(dog => dog.Id == 1 || dog.Id == 2 || dog.Id == 3)
                .Select(dog => { dog.VStay_a = dog.ValueStay_a(dog.Stay_a); return dog; }).ToList();

                dogs.Where(dog => dog.Id == 1 || dog.Id == 2 || dog.Id == 3)
                .Select(dog => { dog.VStay_b = dog.ValueStay_b(dog.Stay_b); return dog; }).ToList();

                dogs.Where(dog => dog.Id == 1 || dog.Id == 2 || dog.Id == 3)
                .Select(dog => { dog.VBehavior = dog.ValueBehavior(dog.Behavior); return dog; }).ToList();
            }
    }
}