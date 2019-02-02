using Entidades.Interfaces;

namespace Entidades.Entidades.App
{
    public class Fornecedor : IEntity
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Estado { get; set; }
    }
}
