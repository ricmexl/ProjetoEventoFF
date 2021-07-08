using AutoMapper;
using ProjetoEventoFF.Application.Interface;
using ProjetoEventoFF.Domain.Entities;
using ProjetoEventoFF.MVC.AutoMapper;
using ProjetoEventoFF.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ProjetoEventoFF.MVC.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly IUsuarioAppService _usuarioAppService;
        private readonly IEquipeAppService _equipeAppServive;
        protected readonly IMapper _mapper;

        public UsuariosController(IUsuarioAppService usuarioAppService, IEquipeAppService equipeAppService)
        {
            _usuarioAppService = usuarioAppService;
            _equipeAppServive = equipeAppService;
            _mapper = AutoMapperConfig.RegisterMappings();
        }       

        // GET: Usuarios
        public ActionResult Index()        {
            
            var usuarioViewModel = _mapper.Map<IEnumerable<Usuario>, IEnumerable<UsuarioViewModel>>(_usuarioAppService.GetAll());
            return View(usuarioViewModel);
        }

        // GET: Usuarios/Details/5
        public ActionResult Details(int id)
        {
            var usuario = _usuarioAppService.GetById(id);
            var usuarioViewModel = _mapper.Map<Usuario, UsuarioViewModel>(usuario);
            return View(usuarioViewModel);
        }

        // GET: Usuarios/Create      
        
        public ActionResult Create(FormCollection collection)
        {
            ViewBag.EquipeId = new SelectList(_equipeAppServive.GetAll(), "EquipeId", "Nome");
            return View();
        }

        // POST: Usuarios/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UsuarioViewModel usuario)
        {
            if (ModelState.IsValid)
            {
                var usuarioDomain = _mapper.Map<UsuarioViewModel, Usuario>(usuario);
                _usuarioAppService.Add(usuarioDomain);
                return RedirectToAction("Index");
            }

            ViewBag.EquipeId = new SelectList(_equipeAppServive.GetAll(), "EquipeId", "Nome");
            return View(usuario);
        }

        // GET: Usuarios/Edit/5
        public ActionResult Edit(int id)
        {
            var usuario = _usuarioAppService.GetById(id);
            var usuarioViewModel = _mapper.Map<Usuario, UsuarioViewModel>(usuario);

            ViewBag.EquipeId = new SelectList(_equipeAppServive.GetAll(), "EquipeId", "Nome");

            return View(usuarioViewModel);
        }

        // POST: Usuarios/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UsuarioViewModel usuario)
        {
            if(ModelState.IsValid)
            {
                var usuarioDomain = _mapper.Map<UsuarioViewModel, Usuario>(usuario);
                _usuarioAppService.Update(usuarioDomain);

                return RedirectToAction("Index");
            }

            ViewBag.EquipeId = new SelectList(_equipeAppServive.GetAll(), "EquipeId", "Nome");
            return View(usuario);
        }

        // GET: Usuarios/Delete/5
        public ActionResult Delete(int id)
        {
            var usuario = _usuarioAppService.GetById(id);
            var usuarioViewModel = _mapper.Map<Usuario, UsuarioViewModel>(usuario);

            return View(usuarioViewModel);
        }

        // POST: Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var usuario = _usuarioAppService.GetById(id);
            _usuarioAppService.Remove(usuario);

            return RedirectToAction("Index");
        }
    }
}
