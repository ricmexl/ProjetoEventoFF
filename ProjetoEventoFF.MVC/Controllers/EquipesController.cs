using AutoMapper;
using ProjetoEventoFF.Application.Interface;
using ProjetoEventoFF.MVC.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
            return View();
        }

        // GET: Equipes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Equipes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Equipes/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Equipes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Equipes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Equipes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Equipes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
