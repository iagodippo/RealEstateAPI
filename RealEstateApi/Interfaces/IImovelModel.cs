using RealEstateApi.Models;
using System.Collections.Generic;

namespace RealEstateApi.Interfaces
{
    public interface IImovelModel
    {
        List<ImovelModel> GetAll();
        ImovelModel Get(int id);
        ImovelModel Create(ImovelModel imovel);
        ImovelModel Update(ImovelModel imovel);
        ImovelModel Delete(int id);
    }
}
