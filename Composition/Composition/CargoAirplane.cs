// =========================
// CLASSE FILHA 2 (HERANÇA)
// =========================
// CargoAirplane também "é um" Airplane.
using Airline;

public class CargoAirplane : Airplane
{
    // Payload máximo que o avião suporta
    public double PayloadMax { get; }

    // Peso carregado atual
    public double LoadedWeight { get; private set; }

    public CargoAirplane(string prefix, double payloadMax)
        : base(prefix)
    {
        if (payloadMax <= 0)
            throw new ArgumentException("Payload must be > 0.");

        PayloadMax = payloadMax;
        LoadedWeight = 0;
    }

    // Carrega um peso específico.
    public void LoadCargo(double weight)
    {
        if (weight <= 0)
            throw new ArgumentException("Weight must be > 0.");

        if (LoadedWeight + weight > PayloadMax)
            throw new InvalidOperationException("Payload limit exceeded.");

        LoadedWeight += weight;
    }

    public override double CalculateCost()
    {
        // custo base + algo proporcional ao peso (exemplo didático)
        return base.CalculateCost() + (LoadedWeight * 0.1);
    }
}
