using Newtonsoft.Json;
using RealEstateApi.Interfaces;
using RealEstateApi.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace RealEstateApi.Repository
{
    public class ImovelRepository : IImovelModel
    {
        private readonly string url = "https://62a27c33cc8c0118ef62ed42.mockapi.io/api/v1/Imoveis";
        public ImovelModel Create(ImovelModel imovel)
        {
            var newImovel = new ImovelModel();
            try
            {
                using (var client = new HttpClient())
                {
                    string jsonObjeto = JsonConvert.SerializeObject(imovel);
                    var content = new StringContent(jsonObjeto, Encoding.UTF8, "application/json");
                    var response = client.PostAsync(url, content);
                    response.Wait();

                    if(response.Result.IsSuccessStatusCode)
                    {
                        var feedback = response.Result.Content.ReadAsStringAsync();
                        newImovel = JsonConvert.DeserializeObject<ImovelModel>(feedback.Result);
                    }
                }
            }
            catch (System.Exception)
            {
                throw new System.Exception("Não foi possível criar o imóvel. Tente novamente.");
            }
            return newImovel;
        }

        public ImovelModel Delete(int id)
        {
            var newImovel = new ImovelModel();
            try
            {
                using (var client = new HttpClient())
                {
                    string jsonObjeto = JsonConvert.SerializeObject(id);
                    var content = new StringContent(jsonObjeto, Encoding.UTF8, "application/json");
                    var response = client.DeleteAsync(url + "/" + id);
                    response.Wait();

                    if (response.Result.IsSuccessStatusCode)
                    {
                        var feedback = response.Result.Content.ReadAsStringAsync();
                        newImovel = JsonConvert.DeserializeObject<ImovelModel>(feedback.Result);
                    }
                }
            }
            catch (System.Exception)
            {
                throw new System.Exception("Não foi possível deletar o imóvel passado. Tente novamente.");
            }
            return newImovel;
        }

        public ImovelModel Get(int id)
        {
            var newImovel = new ImovelModel();
            try
            {
                using (var client = new HttpClient())
                {
                    string jsonObjeto = JsonConvert.SerializeObject(id);
                    var content = new StringContent(jsonObjeto, Encoding.UTF8, "application/json");
                    var response = client.GetAsync(url + "/" + id);
                    response.Wait();

                    if (response.Result.IsSuccessStatusCode)
                    {
                        var feedback = response.Result.Content.ReadAsStringAsync();
                        newImovel = JsonConvert.DeserializeObject<ImovelModel>(feedback.Result);
                    }
                }
            }
            catch (System.Exception)
            {
                throw new System.Exception("Não foi possível trazer o imóvel passado. Tente novamente.");
            }
            return newImovel;
        }

        public List<ImovelModel> GetAll()
        {
            var response = new List<ImovelModel>();
            try
            {
                using (var client = new HttpClient())
                {
                    var request = client.GetStringAsync(url);
                    request.Wait();

                    response = JsonConvert.DeserializeObject<List<ImovelModel>>(request.Result);
                }
            }
            catch (System.Exception)
            {
                throw new System.Exception("Não foi possível trazer todos os imóveis. Tente novamente.");
            }
            return response;
        }

        public ImovelModel Update(ImovelModel imovel)
        {
            var newImovel = new ImovelModel();
            int id = imovel.Id;
            try
            {
                using (var client = new HttpClient())
                {
                    string jsonObjeto = JsonConvert.SerializeObject(imovel);
                    var content = new StringContent(jsonObjeto, Encoding.UTF8, "application/json");
                    var response = client.PutAsync(url + "/" + id, content);
                    response.Wait();

                    if (response.Result.IsSuccessStatusCode)
                    {
                        var feedback = response.Result.Content.ReadAsStringAsync();
                        newImovel = JsonConvert.DeserializeObject<ImovelModel>(feedback.Result);
                    }
                }
            }
            catch (System.Exception)
            {
                throw new System.Exception("Não foi possível atualizar o imóvel. Tente novamente.");
            }
            return newImovel;
        }
    }
}
