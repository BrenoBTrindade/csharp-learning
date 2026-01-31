namespace Airline
{
    // =========================
    // CLASSE BASE (HERANÇA)
    // =========================
    // Airplane é a "classe pai" (base class).
    // Ela contém o que TODO avião tem em comum.
    public class Airplane
    {
        // Propriedade pública (leitura) do prefixo.
        // "get;" permite ler de fora, "private set;" impede alterar fora da classe.
        public string Prefix { get; private set; }

        // Construtor da classe base.                                                                                                                                                                                                                                                                                                                                                                                           
        // Todo Airplane precisa nascer com um Prefix.
        public Airplane(string prefix)
        {
            Prefix = prefix;
        }

        // Método virtual: permite que classes filhas sobrescrevam (override) se quiserem.
        // Aqui está simples porque é apenas um exemplo.
        public virtual double CalculateCost()
        {
            return 1200;
        }
    }