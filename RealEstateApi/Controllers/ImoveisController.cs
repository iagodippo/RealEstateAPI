using Microsoft.AspNetCore.Mvc;
using RealEstateApi.Interfaces;
using RealEstateApi.Models;

namespace RealEstateApi.Controllers
{
    public class ImoveisController : Controller
    {
        private readonly IImovelModel _iImovelModel;
        public ImoveisController(IImovelModel iImovelModel)
        {
            _iImovelModel = iImovelModel;
        }

        // GET: ImovelController
        public ActionResult Index()
        {
            return View(_iImovelModel.GetAll());
        }

        // GET: ImovelController/Details/5
        public ActionResult Details(int id)
        {
            return View(_iImovelModel.Get(id));
        }

        // GET: ImovelController/Create
        public ActionResult Create()
        {
            return View();
        }
        
        // POST: ImovelController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ImovelModel collection)
        {
            try
            {
                _iImovelModel.Create(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ImovelController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_iImovelModel.Get(id));
        }

        // POST: ImovelController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ImovelModel collection)
        {
            try
            {
                _iImovelModel.Update(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ImovelController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_iImovelModel.Get(id));
        }

        // POST: ImovelController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ImovelModel collection)
        {
            try
            {
                _iImovelModel.Delete(id);                
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
