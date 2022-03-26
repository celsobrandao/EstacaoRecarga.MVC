using EstacaoRecarga.Aplicacao.Interfaces;
using Microsoft.AspNetCore.Mvc;
using EstacaoRecargaModel = EstacaoRecarga.Dominio.Entidades.EstacaoRecarga;

namespace PowerUp.MVC.Controllers
{
    public class EstacaoRecargaController : Controller
    {
        private readonly IEstacaoRecargaAplicacao _estacaoRecargaApp;

        public EstacaoRecargaController(IEstacaoRecargaAplicacao estacaoRecargaApp)
        {
            _estacaoRecargaApp = estacaoRecargaApp;
        }

        public ActionResult Index()
        {
            return View(_estacaoRecargaApp.ListarTodos().OrderBy(estacao => estacao.Nome));
        }

        public ActionResult Details(Guid id)
        {
            return View(_estacaoRecargaApp.RecuperarPorId(id));
        }

        public ActionResult Create()
        {
            return View(new EstacaoRecargaModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EstacaoRecargaModel estacaoRecarga)
        {
            try
            {
                estacaoRecarga.Id = Guid.NewGuid();
                estacaoRecarga.DataCriacao = DateTime.Now;
                _estacaoRecargaApp.Adicionar(estacaoRecarga);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(Guid id)
        {
            return View(_estacaoRecargaApp.RecuperarPorId(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EstacaoRecargaModel estacaoRecarga)
        {
            try
            {
                _estacaoRecargaApp.Atualizar(estacaoRecarga);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(Guid id)
        {
            return View(_estacaoRecargaApp.RecuperarPorId(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(EstacaoRecargaModel estacaoRecarga)
        {
            try
            {
                _estacaoRecargaApp.Excluir(estacaoRecarga);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
