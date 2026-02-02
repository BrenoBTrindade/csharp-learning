namespace LearningPOO.Models
{
    public class Dog
    {
        public string? Name { get; set; }
        public int Age { get; set; }

        public string Comer()
        {
            return $"O cachorro {Name} comeu";
        }
    }
}
