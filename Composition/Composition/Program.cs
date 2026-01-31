// =========================
// =========================
// PROGRAMA (USO)
// =========================
public class MainClass
{
    public static void Main(string[] args)
    {
        // Criamos um avião de passageiros (classe filha).
        PassengerAirplane embraer = new PassengerAirplane("PR-ABC", 110);

        // Criamos um voo (objeto independente).
        Flight flightA = new Flight("001", 500);

        // COMPOSIÇÃO: o voo "tem" um avião.
        // E funciona porque PassengerAirplane É um Airplane.
        flightA.Airplane = embraer;

        // Carrega 1 passageiro no avião.
        embraer.LoadPassenger();

        // Mostra prefixo e custo.
        Console.WriteLine($"{flightA.Airplane.Prefix} - {flightA.CalculateCost()}");
    }
}
