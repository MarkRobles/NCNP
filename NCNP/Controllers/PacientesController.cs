using NCNP.Clases;
using NCNP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NCNP.Controllers
{
    [Authorize]
    public class PacientesController : Controller
    {
        clsPacientes _paciente = new clsPacientes();

        // GET: Pacientes
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View(_paciente.GetTs());
        }

        // GET: Pacientes/Details/5
        public ActionResult Details(Guid id)
        {
            if (_paciente == null)
            {
                HttpNotFound();
            }

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
                // TODO: Add insert logic here
                _paciente.CrudT(Paciente, ECrud.Alta);
                return RedirectToAction("Index");
            }
            catch(Exception ex) 
            {
                ViewBag.message = ex.Message;
                return View();
            }
        }

        // GET: Pacientes/Edit/5
        public ActionResult Edit(Guid id)
        {

            if (_paciente == null)
            {
                HttpNotFound();
            }

            return View(_paciente.GetT(new Models.Pacientes { Id = id }));
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
        public ActionResult Delete(Guid id)
        {

            if (_paciente == null)
            {
                HttpNotFound();
            }

            return View(_paciente.GetT(new Pacientes { Id = id }));
        }

        // POST: Pacientes/Delete/5
        [HttpPost]
        public ActionResult Delete(Guid id, Pacientes paciente)
        {
            try
            {
                // TODO: Add delete logic here
                paciente.Id = id;
                _paciente.CrudT(paciente,ECrud.Borrar);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
