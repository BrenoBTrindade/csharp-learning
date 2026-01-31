namespace Movies;

public class MovieMain
{
    public static void Main(string[] args)
    {
        Movie movieA = new Movie("Matrix", "Ficção Cientifica");
        Movie movieB = new Movie("Senhor dos Anéis", "Fantasia");

        Console.WriteLine(movieA.Title);
        Console.WriteLine(movieB.Title);
    } 
}