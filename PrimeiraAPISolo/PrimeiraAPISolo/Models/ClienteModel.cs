namespace PrimeiraAPISolo.Models
{
    public class ClienteModel
    {
        public string Cliente { get; set; }

        public ClienteModel(string nome)
        {
            this.Cliente = nome;
        }
    }
}
