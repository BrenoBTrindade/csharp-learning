// =========================
// CLASSE MainClass
// =========================
// Ponto de entrada da aplicação
using Airline;

public class MainClass
{
    // Método principal (entry point)
    public static void Main(string[] args)
    {
        // Criamos um avião (objeto independente)
        Airplane embraer = new Airplane("PR-ABC");

        // Criamos um voo
        Flight flightA = new Flight("001", 500);

        // 👉 A COMPOSIÇÃO ACONTECE AQUI 👇
        // Estamos dizendo que o voo TEM esse avião
        flightA.Airplane = embraer;

        // Usamos o objeto composto:
        // - acessamos o prefixo do avião do voo
        // - chamamos o cálculo de custo do voo
        Console.WriteLine(
            flightA.Airplane.prefix + " - " +
            flightA.CalculateCost().ToString()
        );
    }
}
