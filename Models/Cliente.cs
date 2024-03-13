namespace Concessionaria.Models
{
    public class Cliente : Pessoa
    {
        public Cliente(string nome, string cpf, string endereco, string telefone, string email, long id = 0) : base(nome, cpf, endereco, telefone, email)
        {
            if (id == 0)
            {
                Id = DateTime.Now.Ticks;
            }
            else
            {
                Id = id;
            }
        }
    }
}
