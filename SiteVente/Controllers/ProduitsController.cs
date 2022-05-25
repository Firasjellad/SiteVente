using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SiteVente.Models;

namespace SiteVente.Controllers
{
    public class ProduitsController : Controller
    {
        private readonly Repository _repository;

        public ProduitsController(Repository repository)
        {
            _repository = repository;
        }

        // GET: ProduitsController
        public ActionResult Index()
        {
            return View(_repository.GetProduits());
        }

        // GET: ProduitsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProduitsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProduitsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Produit produit)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repository.AddProduit(produit);
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: ProduitsController/Edit/5
        public ActionResult Edit(string id)
        {
            Produit p = _repository.GetProduitByName(id);
            return View(p);
        }

        [HttpPost]
        public ActionResult Edit(Produit produit)
        {
            _repository.UpdateProduit(produit);
            return View(produit);
        }


        // GET: ProduitsController/Delete/5
        public ActionResult Delete(string id)
        {
            try
            {
                _repository.DeletProduit(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {

                return RedirectToAction(nameof(Index));
            }
        }

       
    }
}
