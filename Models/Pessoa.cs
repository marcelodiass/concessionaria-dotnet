namespace Concessionaria.Models
{
    public class Pessoa : IPessoa
    {
        public long Id;
        internal string Nome { get; set; }
        private string CPF { get; set; }
        internal string Endereco { get; set; } 
        internal string Telefone { get; set; }
        public string Email { get; set; }


        public Pessoa(string nome, string cpf, string endereco, string telefone, string email)
        {
            if (nome == "" || cpf == "" || endereco == "" || telefone == "" || email == "")
            {
                throw new ArgumentNullException("Por favor preencha todos os campos.");
            }

            Nome = nome;
            CPF = cpf;
            Endereco = endereco;
            Telefone = telefone;
            Email = email;
        }

        public string getCPF()
        {
            return CPF;
        }

        public virtual void Cadastrar()
        {
            throw new NotImplementedException();
        }

        public void Editar()
        {
            throw new NotImplementedException();
        }

        public void Excluir()
        {
            throw new NotImplementedException();
        }
    }

}
