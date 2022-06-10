using System.ComponentModel;

namespace RealEstateApi.Models
{
    public class ImovelModel
    {
        public int Id { get; set; }
        [DisplayName("Tipo")]
        public string TipoDoImovel { get; set; }
        [DisplayName("Valor de Venda")]
        public double ValorDeVenda { get; set; }
        [DisplayName("Valor de Locação")]
        public double ValorDeLocacao { get; set; }
        [DisplayName("Endereço")]
        public string Endereco { get; set; }
        [DisplayName("Nº")]
        public int Numero { get; set; }
        [DisplayName("Complemento")]
        public string Complemento { get; set; }
        [DisplayName("Bairro")]
        public string Bairro { get; set; }
        [DisplayName("Cidade")]
        public string Cidade { get; set; }
        [DisplayName("Estado")]
        public string Estado { get; set; }
        [DisplayName("CEP")]
        public string Cep { get; set; }
    }
}
