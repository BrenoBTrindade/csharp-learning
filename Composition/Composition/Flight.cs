// =========================
// COMPOSIÇÃO (HAS-A)
// =========================
// Flight "TEM UM" Airplane.
// (relationship: HAS-A)
using Airline;

public class Flight
{
    public string FlightId { get; }
    public double Distance { get; }

    // Aqui está a COMPOSIÇÃO:
    // Um Flight contém uma referência para Airplane.
    // E esse Airplane pode ser PassengerAirplane OU CargoAirplane.
    public Airplane Airplane { get; set; }

    public Flight(string flightId, double distance)
    {
        FlightId = flightId;
        Distance = distance;
    }

    public double CalculateCost()
    {
        // Flight delega o cálculo para o Airplane (polimorfismo).
        // Se Airplane for PassengerAirplane, chama o override dele.
        // Se for CargoAirplane, chama o override dele.
        if (Airplane == null)
            throw new InvalidOperationException("Flight has no airplane assigned.");

        return Airplane.CalculateCost();
    }
}
