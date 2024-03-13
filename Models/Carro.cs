
namespace Concessionaria.Models
{
    public class Carro
    {
        private int Id { get; set; }
        internal string Modelo { get; set; }
        internal string Placa { get; set; }
        public decimal Valor { get; set; }

        public Carro(int id, string modelo, string placa, decimal valor)
        {
            Id = id;
            Modelo = modelo ?? throw new ArgumentNullException("Insira o modelo.");
            Placa = placa ?? throw new ArgumentNullException("Insira a placa.");
            Valor = valor;
        }

        public string getId()
        {
            return $"O id do carro é {Id}";
        }
    }
}
