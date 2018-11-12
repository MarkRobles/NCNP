using NCNP.Clases;
using NCNP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NCNP.Controllers
{
    public class PacientesController : Controller
    {
        clsPacientes _paciente = new clsPacientes();

        // GET: Pacientes
        public ActionResult Index()
        {
            return View(_paciente.GetTs());
        }

        // GET: Pacientes/Details/5
        public ActionResult Details(Guid id)
        {
            return View(_paciente.GetT(new Models.Pacientes { Id = id }));
        }

        // GET: Pacientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pacientes/Create
        [HttpPost]
        public ActionResult Create(Pacientes Paciente)
        {
            try
            {
                _paciente.CrudT(Paciente, ECrud.Alta);
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pacientes/Edit/5
        public ActionResult Edit(Guid id)
        {
            return View(_paciente.GetT(new Pacientes { Id = id }));
        }

        // POST: Pacientes/Edit/5
        [HttpPost]
        public ActionResult Edit(Guid id, Pacientes paciente)
        {
            try
            {
                // TODO: Add update logic here
                paciente.Id = id;
                _paciente.CrudT(paciente, ECrud.Actualizar);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pacientes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Pacientes/Delete/5
        [HttpPost]
        public ActionResult Delete(Guid id, Pacientes paciente)
        {
            try
            {
                // TODO: Add delete logic here
                paciente.Id = id;
                _paciente.CrudT(paciente, ECrud.Borrar);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
