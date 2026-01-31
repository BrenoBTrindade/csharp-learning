namespace Airline
{
    // =========================
    // CLASSE Airplane
    // =========================
    // Representa um avião.
    // Essa classe é "simples" e independente.
    // Ela NÃO depende de Flight.
    public class Airplane
    {
        // Campo que guarda o prefixo do avião (ex: PR-ABC)
        public string prefix;

        // Construtor do avião
        // Toda vez que criamos um Airplane, ele PRECISA de um prefixo
        public Airplane(string prefix)
        {
            // "this.prefix" refere-se ao campo da classe
            // "prefix" refere-se ao parâmetro do construtor
            this.prefix = prefix;
        }

        // Método que calcula o custo do avião
        // Aqui é apenas um valor fixo para exemplo
        public double CalculateCost()
        {
            return 1200;
        }
    }
}