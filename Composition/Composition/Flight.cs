// =========================
// CLASSE Flight
// =========================
// Representa um voo.
// Um voo TEM um avião → isso é COMPOSIÇÃO.
using Airline;

public class Flight
{
    // Identificador do voo
    public string FlightId { get; set; }

    // Distância do voo
    public double Distance;

    // 👉 COMPOSIÇÃO ACONTECE AQUI 👇
    // Flight TEM um Airplane
    // Não é herança, é posse (has-a)
    public Airplane Airplane;

    // Construtor do voo
    public Flight(string FlightId, double Distance)
    {
        // Atribui os valores recebidos
        this.FlightId = FlightId;
        this.Distance = Distance;

        // Repare:
        // O Airplane NÃO é criado aqui.
        // Ele será associado depois.
    }

    // Método do voo que calcula o custo
    public double CalculateCost()
    {
        // Delegação:
        // O voo não sabe calcular o custo sozinho,
        // então ele pede para o avião calcular.
        return Airplane.CalculateCost();
    }
}