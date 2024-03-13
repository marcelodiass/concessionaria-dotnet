using System;

namespace Concessionaria.Models
{
    public class Funcionario : Pessoa
    {
        public Funcionario(string Cargo, string nome, string cpf, string endereco, string telefone, string email, long id = 0, decimal Salario = 0) : base(nome, cpf, endereco, telefone, email)
        {
            if (id == 0)
            {
                Id = DateTime.Now.Ticks;
            }
            else
            {
                Id = id;
            }

            if (Cargo == "" || Salario == 0)
            {
                throw new ArgumentNullException("Por favor preencha todos os campos.");
            }
        }

        public string Cargo { get; set; }
        private decimal Salario {  get; set; }
        
        public string getSalario()
        {
            return $"O salário do funcionário é {Salario}";
        }

        public override void Cadastrar()
        {
            // Algum tipo de verificação
            base.Cadastrar();
        }


    }
}
