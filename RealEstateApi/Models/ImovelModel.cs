namespace RealEstateApi.Models
{
    public class ImovelModel
    {
        public int Id { get; set; }
        public string TipoDoImovel { get; set; }
        public double ValorDeVenda { get; set; }
        public double ValorDeLocacao { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
    }
}
