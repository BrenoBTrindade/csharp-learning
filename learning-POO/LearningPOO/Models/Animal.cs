namespace LearningPOO.Models
{
    public abstract class Animal
    {
        public string? Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name; Age = age; 
        }
        public Animal() { }
        public virtual string Comer()
        {
            return $"O Animal comeu";
        }
    }
}
