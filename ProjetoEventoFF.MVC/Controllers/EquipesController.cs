using AutoMapper;
using ProjetoEventoFF.Application.Interface;
using ProjetoEventoFF.Domain.Entities;
using ProjetoEventoFF.MVC.AutoMapper;
using ProjetoEventoFF.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ProjetoEventoFF.MVC.Controllers
{
    public class EquipesController : Controller
    {
        private readonly IEquipeAppService _equipeAppServive;
        protected readonly IMapper _mapper;

        public EquipesController(IEquipeAppService equipeAppService)
        {
            _equipeAppServive = equipeAppService;
            _mapper = AutoMapperConfig.RegisterMappings();
        }

        // GET: Equipes
        public ActionResult Index()
        {
            var equipeViewModel = _mapper.Map<IEnumerable<Equipe>, IEnumerable<EquipeViewModel>>(_equipeAppServive.GetAll());
            return View(equipeViewModel);
        }

        // GET: Equipes/Details/5
        public ActionResult Details(int id)
        {
            var equipe = _equipeAppServive.GetById(id);
            var equipeViewModel = _mapper.Map<Equipe, EquipeViewModel>(equipe);
            return View(equipeViewModel);
        }

        // GET: Equipes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Equipes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EquipeViewModel equipe)
        {
            if (ModelState.IsValid)
            {
                var equipeDomain = _mapper.Map<EquipeViewModel, Equipe>(equipe);
                _equipeAppServive.Add(equipeDomain);
                return RedirectToAction("Index");
            }
            
            return View(equipe);
        }

        // GET: Equipes/Edit/5
        public ActionResult Edit(int id)
        {
            var equipe = _equipeAppServive.GetById(id);
            var equipeViewModel = _mapper.Map<Equipe, EquipeViewModel>(equipe);
            return View(equipeViewModel);
        }

        // POST: Equipes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EquipeViewModel equipeViewModel)
        {
            if (ModelState.IsValid)
            {
                var equipeDomain = _mapper.Map<EquipeViewModel, Equipe>(equipeViewModel);
                _equipeAppServive.Update(equipeDomain);

                return RedirectToAction("Index");
            }
            
            return View(equipeViewModel);
        }

        // GET: Equipes/Delete/5
        public ActionResult Delete(int id)
        {
            var equipe = _equipeAppServive.GetById(id);
            var equipeViewModel = _mapper.Map<Equipe, EquipeViewModel>(equipe);
            return View(equipeViewModel);
        }

        // POST: Equipes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var equipe = _equipeAppServive.GetById(id);            
            _equipeAppServive.Remove(equipe);
            return RedirectToAction("Index");
        }
    }
}
