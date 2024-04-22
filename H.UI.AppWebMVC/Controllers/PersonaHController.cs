using H.AccesoDatosDAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using H.EntidadesNegocioEN;
using H.LogicaDatosBL;

namespace H.UI.AppWebMVC.Controllers
{
    public class PersonaHController : Controller
    {
        // GET: PersonaHController
        public async Task<ActionResult>  Index()
        {
            var persona = await PersonaHDAL.GetAll();
            return View(persona);
        }

        // GET: PersonaHController/Details/5
        public async Task<ActionResult>  Details(int id)
        {
            var persona = await PersonaHBL.GetById(id);

            return View(persona);
        }

        // GET: PersonaHController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonaHController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult>  Create(PersonaH pPersona)
        {
            try
            {
                var result = await PersonaHBL.Create(pPersona);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonaHController/Edit/5
        public async Task<ActionResult>  Edit(int id)
        {
            var persona = await PersonaHBL.GetById(id);

            return View(persona);
        }

        // POST: PersonaHController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(PersonaH pPersona)
        {
            try
            {
                var result = await PersonaHBL.Update(pPersona);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonaHController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PersonaHController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult>Delete(PersonaH pPersona)
        {
            try
            {
                var result = await PersonaHBL.Delete(pPersona);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
