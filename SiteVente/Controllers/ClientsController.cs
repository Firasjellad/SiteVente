using Microsoft.AspNetCore.Mvc;
using SiteVente.Models;

namespace SiteVente.Controllers
{
    public class ClientsController : Controller
    {
        private readonly Repository _repository;

        public ClientsController(Repository repository)
        {
            _repository = repository;
        }

        // GET: ClientsController
        public ActionResult Index()
        {
            return View(_repository.GetClients());
        }

        // GET: ClientsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClientsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientsController/Create
        [HttpPost]
        public ActionResult Create(Client Client)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repository.AddClient(Client);
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

        // GET: ClientsController/Edit/5
        public ActionResult Edit(string id)
        {
            Client p = _repository.GetClientByName(id);
            return View(p);
        }

        [HttpPost]
        public ActionResult Edit(Client Client)
        {
            _repository.UpdateClient(Client);
            return View(Client);
        }


        // GET: ClientsController/Delete/5
        public ActionResult Delete(string id)
        {
            try
            {
                _repository.DeletClient(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {

                return RedirectToAction(nameof(Index));
            }
        }
    }
}
