using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using L3Manager.Repository.Models;

namespace L3Manager.Web.Controllers
{
    public class ClientesController : Controller
    {
        private EntityDataModels db = new EntityDataModels();

        // GET: Clientes
        public ActionResult Index()
        {
            var clientes = db.Clientes.Include(c => c.Usuario);
            return View(clientes.ToList());
        }

        // GET: Clientes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cliente cliente = db.Clientes.Find(id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            ViewBag.Id_Vendedor = new SelectList(db.Usuarios, "Id", "Nome");
            var cliente = new Cliente();
            return View(cliente);
        }

        // POST: Clientes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Tipo,Nome,Documento,Vencimento_Licenca,Id_Vendedor")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                cliente.Data_Hora_Cadastro = DateTime.Today;
                cliente.Vencimento_Licenca = Convert.ToDateTime(cliente.Vencimento_Licenca);

                db.Clientes.Add(cliente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Id_Vendedor = new SelectList(db.Usuarios, "Id", "Nome", cliente.Id_Vendedor);
            return View(cliente);
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cliente cliente = db.Clientes.Find(id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            ViewBag.Id_Vendedor = new SelectList(db.Usuarios, "Id", "Nome", cliente.Id_Vendedor);
            return View(cliente);
        }

        // POST: Clientes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Tipo,Nome,Documento,Vencimento_Licenca")] Cliente cliente)
        {
            Cliente x = db.Clientes.Find(cliente.Id);

            if (ModelState.IsValid)
            {
                x.Tipo = cliente.Tipo;
                x.Nome = cliente.Nome;
                x.Documento = cliente.Documento;
                x.Vencimento_Licenca = cliente.Vencimento_Licenca;

                db.Entry(x).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Id_Vendedor = new SelectList(db.Usuarios, "Id", "Nome", cliente.Id_Vendedor);
            return View(x);
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cliente cliente = db.Clientes.Find(id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cliente cliente = db.Clientes.Find(id);
            db.Clientes.Remove(cliente);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
