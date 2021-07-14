using AutoMapper;
using ProjetoEventoFF.Application.Interface;
using ProjetoEventoFF.Domain.Entities;
using ProjetoEventoFF.MVC.AutoMapper;
using ProjetoEventoFF.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ProjetoEventoFF.MVC.Controllers
{
    public class CalendarioController : Controller
    {
        private readonly ICalendarioAppService _calendarioAppServive;
        private readonly IEquipeAppService _equipeAppServive;
        protected readonly IMapper _mapper;

        public CalendarioController(ICalendarioAppService calendarioAppService, IEquipeAppService equipeAppService)
        {
            _calendarioAppServive = calendarioAppService;
            _equipeAppServive = equipeAppService;
            _mapper = AutoMapperConfig.RegisterMappings();
        }        

        // GET: Calendario
        public ActionResult Index()
        {            
            var calendarioViewModel = _mapper.Map<IEnumerable<Calendario>, IEnumerable<CalendarioViewModel>>(_calendarioAppServive.BuscarTodos());
            return View(calendarioViewModel);
        }

        // GET: Calendario/Details/5
        public ActionResult Details(int id)
        {
            var calendario = _calendarioAppServive.BuscarPorId(id);
            var equipeViewModel = _mapper.Map<Calendario, CalendarioViewModel>(calendario);
            return View(equipeViewModel);
        }

        // GET: Calendario/Create
        public ActionResult Create()
        {
            ViewBag.EquipeId = new SelectList(_equipeAppServive.GetAll(), "EquipeId", "Nome");
            return View();
        }

        // POST: Calendario/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CalendarioViewModel calendarioViewModel)
        {
            if (ModelState.IsValid)
            {
                var calendarioDomain = _mapper.Map<CalendarioViewModel, Calendario>(calendarioViewModel);
                _calendarioAppServive.Add(calendarioDomain);
                return RedirectToAction("Index");
            }

            ViewBag.EquipeId = new SelectList(_equipeAppServive.GetAll(), "EquipeId", "Nome", calendarioViewModel.EquipeId);
            return View(calendarioViewModel);
        }

        // GET: Calendario/Edit/5
        public ActionResult Edit(int id)
        {
            var calendario = _calendarioAppServive.BuscarPorId(id);
            var equipeViewModel = _mapper.Map<Calendario, CalendarioViewModel>(calendario);

            ViewBag.EquipeId = new SelectList(_equipeAppServive.GetAll(), "EquipeId", "Nome", calendario.EquipeId);

            return View(equipeViewModel);
        }

        // POST: Calendario/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CalendarioViewModel calendarioViewModel)
        {
            if (ModelState.IsValid)
            {
                var calendarioDomain = _mapper.Map<CalendarioViewModel, Calendario>(calendarioViewModel);
                _calendarioAppServive.Update(calendarioDomain);
                return RedirectToAction("Index");
            }

            ViewBag.EquipeId = new SelectList(_equipeAppServive.GetAll(), "EquipeId", "Nome", calendarioViewModel.EquipeId);
            return View(calendarioViewModel);
        }

        // GET: Calendario/Delete/5
        public ActionResult Delete(int id)
        {
            var calendario = _calendarioAppServive.BuscarPorId(id);
            var equipeViewModel = _mapper.Map<Calendario, CalendarioViewModel>(calendario);
            return View(equipeViewModel);
        }

        // POST: Calendario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var calendario = _calendarioAppServive.BuscarPorId(id);
            _calendarioAppServive.Remove(calendario);
            return RedirectToAction("Index");
        }
    }
}
