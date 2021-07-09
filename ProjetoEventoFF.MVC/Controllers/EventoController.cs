using AutoMapper;
using ProjetoEventoFF.Application.Interface;
using ProjetoEventoFF.Domain.Entities;
using ProjetoEventoFF.MVC.AutoMapper;
using ProjetoEventoFF.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ProjetoEventoFF.MVC.Controllers
{
    public class EventoController : Controller
    {
        private readonly IEventoAppService _eventoAppService;
        private readonly ICalendarioAppService _calendarioAppServive;
        protected readonly IMapper _mapper;

        public EventoController(IEventoAppService eventoAppService, ICalendarioAppService calendarioAppService)
        {
            _eventoAppService = eventoAppService;
            _calendarioAppServive = calendarioAppService;
            _mapper = AutoMapperConfig.RegisterMappings();
        }

        // GET: Evento
        public ActionResult Index()
        {
            var eventoViewModel = _mapper.Map<IEnumerable<Evento>, IEnumerable<EventoViewModel>>(_eventoAppService.BuscarTodos());
            return View(eventoViewModel);
        }

        public ActionResult IndexCalendario(string calendarioId)
        {
            var eventoViewModel = _mapper.Map<IEnumerable<Evento>, IEnumerable<EventoViewModel>>(_eventoAppService.BuscarEventosPorCalendario(1));
            return View(eventoViewModel);
        }

        // GET: Evento/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Evento/Create
        public ActionResult Create()
        {
            ViewBag.CalendarioId = new SelectList(_calendarioAppServive.GetAll(), "CalendarioId", "Nome");
            return View();
        }

        // POST: Evento/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EventoViewModel evento)
        {
            if (ModelState.IsValid)
            {
                var eventoDomain = _mapper.Map<EventoViewModel, Evento>(evento);
                _eventoAppService.Add(eventoDomain);
                return RedirectToAction("Index");
            }

            return View(evento);
        }

        // GET: Evento/Edit/5
        public ActionResult Edit(int id)
        {
            var evento = _eventoAppService.BuscarPorId(id);
            var equipeViewModel = _mapper.Map<Evento, EventoViewModel>(evento);

            ViewBag.CalendarioId = new SelectList(_calendarioAppServive.GetAll(), "CalendarioId", "Nome", evento.CalendarioId);

            return View(equipeViewModel);
        }

        // POST: Evento/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EventoViewModel eventoViewModel)
        {
            if (ModelState.IsValid)
            {
                var eventoDomain = _mapper.Map<EventoViewModel, Evento>(eventoViewModel);
                _eventoAppService.Update(eventoDomain);
                return RedirectToAction("Index");
            }

            ViewBag.CalendarioId = new SelectList(_calendarioAppServive.GetAll(), "CalendarioId", "Nome", eventoViewModel.CalendarioId);
            return View(eventoViewModel);
        }

        // GET: Evento/Delete/5
        public ActionResult Delete(int id)
        {
            var evento = _eventoAppService.BuscarPorId(id);
            var eventoViewModel = _mapper.Map<Evento, EventoViewModel>(evento);
            return View(eventoViewModel);
        }

        // POST: Evento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var evento = _eventoAppService.BuscarPorId(id);
            _eventoAppService.Remove(evento);
            return RedirectToAction("Index");
        }
    }
}
