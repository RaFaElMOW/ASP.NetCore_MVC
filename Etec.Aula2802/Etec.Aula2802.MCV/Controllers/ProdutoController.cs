using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Etec.Aula2802.MCV.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Index()
        {
            return View();
        }

        // GET: Produto/Details/5
        public ActionResult Detalhes(int id)
        {
            return View();
        }

        public ActionResult Lista()
        {
            Models.Produto produto0 = new Models.Produto();
            produto0.cdProduto = 1;
            produto0.descricao = "Duplo";
            produto0.nmProduto = "Papel";
            produto0.quantidade = 24;
            produto0.valor = decimal.Parse("26,58");

            Models.Produto produto1 = new Models.Produto();
            produto1.cdProduto = 2;
            produto1.descricao = "Lote";
            produto1.nmProduto = "Sulfite";
            produto1.quantidade = 60;
            produto1.valor = decimal.Parse("500,00");

            Models.Produto produto2 = new Models.Produto();
            produto2.cdProduto = 3;
            produto2.descricao = "Pacote";
            produto2.nmProduto = "Caneta Bic";
            produto2.quantidade = 4;
            produto2.valor = decimal.Parse("14,99");

            Models.Produto produto3 = new Models.Produto();
            produto3.cdProduto = 4;
            produto3.descricao = "Peça";
            produto3.nmProduto = "Blusa";
            produto3.quantidade = 1;
            produto3.valor = decimal.Parse("10,99");

            Models.Produto produto4 = new Models.Produto();
            produto4.cdProduto = 5;
            produto4.descricao = "Peça";
            produto4.nmProduto = "Boné";
            produto4.quantidade = 199;
            produto4.valor = decimal.Parse("59,99");


            return null;
        }

        // GET: Produto/Create
        public ActionResult Cadastrar()
        {
            return View();
        }

        // POST: Produto/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(Models.Produto collection)
        {
            try
            {
                using (TextWriter tw = new StreamWriter(@"C:\Inputs\LogProduto.txt", true))
                {
                    tw.WriteLine("Inserção de dados");
                    tw.WriteLine("Cod. Produto: " + collection.cdProduto);
                    tw.WriteLine("Nome Produto: " + collection.nmProduto);
                    tw.WriteLine("Valor: " + collection.valor);
                    tw.WriteLine("Descrição: " + collection.descricao);
                    tw.WriteLine("Quantidade: " + collection.quantidade + "\n\n");
                }

                    return RedirectToAction(nameof(Cadastrar));
            }
            catch
            {
                return View();
            }
        }

        // GET: Produto/Edit/5
        public ActionResult Editar(int id)
        {
            return View();
        }

        // POST: Produto/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(int id, Models.Produto collection)
        {
            try
            {
                using (TextWriter tw = new StreamWriter(@"C:\Inputs\LogProduto.txt", true))
                {
                    tw.WriteLine("Edição de dados");
                    tw.WriteLine("Cod. Produto: " + collection.cdProduto);
                    tw.WriteLine("Nome Produto: " + collection.nmProduto);
                    tw.WriteLine("Valor: " + collection.valor);
                    tw.WriteLine("Descrição: " + collection.descricao);
                    tw.WriteLine("Quantidade: " + collection.quantidade + "\n\n");
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Produto/Delete/5
        public ActionResult Deletar(int id)
        {
            return View();
        }

        // POST: Produto/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Deletar(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}