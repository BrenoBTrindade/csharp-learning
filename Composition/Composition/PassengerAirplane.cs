// =========================
// CLASSE FILHA 1 (HERANÇA)
// =========================
// PassengerAirplane "é um" Airplane.
// (relationship: IS-A)
using Airline;

public class PassengerAirplane : Airplane
{
    // Capacidade máxima de passageiros
    public int PassengerCapacity { get; }

    // Quantidade atual de passageiros (estado interno)
    public int PassengerCount { get; private set; }

    // Construtor da classe filha.
    // ": base(prefix)" chama o construtor da classe Airplane (pai).
    public PassengerAirplane(string prefix, int passengerCapacity)
        : base(prefix)
    {
        if (passengerCapacity <= 0)
            throw new ArgumentException("Passenger capacity must be > 0.");

        PassengerCapacity = passengerCapacity;
        PassengerCount = 0;
    }

    // Carrega 1 passageiro.
    // Se atingir a capacidade, lança exceção.
    public void LoadPassenger()
    {
        if (PassengerCount >= PassengerCapacity)
            throw new InvalidOperationException("No seats left.");

        PassengerCount++;
    }

    // Exemplo opcional: se quiser custo variar por passageiro, você pode sobrescrever.
    // (não é obrigatório para o conceito)
    public override double CalculateCost()
    {
        // custo base + algo por passageiro (exemplo didático)
        return base.CalculateCost() + (PassengerCount * 2);
    }
}