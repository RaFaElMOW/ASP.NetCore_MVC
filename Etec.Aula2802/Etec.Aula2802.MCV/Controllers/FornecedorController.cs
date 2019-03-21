using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Etec.Aula2802.MCV.Controllers
{
    public class FornecedorController : Controller
    {
        // GET: Fornecedor
        public ActionResult Index()
        {
            return View();
        }

        // GET: Fornecedor/Details/5
        public ActionResult Detalhes(int id)
        {
            return View();
        }

        public ActionResult Lista()
        {
            Models.Fornecedor fornecedor0 = new Models.Fornecedor ();
            fornecedor0.cdFornecedor = 1;
            fornecedor0.CPNJ = "501359618565";
            fornecedor0.endereco = "Rua 1, 24";
            fornecedor0.nmFornecedor = "Fornecedor 1";
            fornecedor0.telefone = "1198535458566";

            Models.Fornecedor fornecedor1 = new Models.Fornecedor();
            fornecedor1.cdFornecedor = 2;
            fornecedor1.CPNJ = "50114669565";
            fornecedor1.endereco = "Rua 2, 48";
            fornecedor1.nmFornecedor = "Fornecedor 2";
            fornecedor1.telefone = "1198522558566";

            Models.Fornecedor fornecedor2 = new Models.Fornecedor();
            fornecedor2.cdFornecedor = 3;
            fornecedor2.CPNJ = "22596818565";
            fornecedor2.endereco = "Rua 3, 4424";
            fornecedor2.nmFornecedor = "Fornecedor 3";
            fornecedor2.telefone = "119878465166";

            Models.Fornecedor fornecedor3 = new Models.Fornecedor();
            fornecedor3.cdFornecedor = 4;
            fornecedor3.CPNJ = "59999984445";
            fornecedor3.endereco = "Rua 4, 77";
            fornecedor3.nmFornecedor = "Fornecedor 4";
            fornecedor3.telefone = "1148447156";

            Models.Fornecedor fornecedor4 = new Models.Fornecedor();
            fornecedor4.cdFornecedor = 5;
            fornecedor4.CPNJ = "9996687";
            fornecedor4.endereco = "Rua 5, 1924";
            fornecedor4.nmFornecedor = "Fornecedor 5";
            fornecedor4.telefone = "119789418566";

            Models.Fornecedor fornecedor5 = new Models.Fornecedor();
            fornecedor5.cdFornecedor = 6;
            fornecedor5.CPNJ = "448819918565";
            fornecedor5.endereco = "Rua 7, 24";
            fornecedor5.nmFornecedor = "Fornecedor 7";
            fornecedor5.telefone = "1198577851441";

            List<Models.Fornecedor> lista = new List<Models.Fornecedor>();
            lista.Add(fornecedor0);
            lista.Add(fornecedor1);
            lista.Add(fornecedor2);
            lista.Add(fornecedor3);
            lista.Add(fornecedor4);
            lista.Add(fornecedor5);

            return View(lista);

        }
        // GET: Fornecedor/Create
        public ActionResult Cadastrar()
        {
            return View();
        }

        // POST: Fornecedor/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(Models.Fornecedor collection)
        {
            try
            {
                using (TextWriter tw = new StreamWriter(@"C:\Inputs\LogFornecedor.txt", true))
                {
                    tw.WriteLine("Inserção de dados");
                    tw.WriteLine("Cod. Fornecedor: " + collection.cdFornecedor);
                    tw.WriteLine("Nome Fornecedor: " + collection.nmFornecedor);
                    tw.WriteLine("CNPJ Fornecedor: " + collection.CPNJ);
                    tw.WriteLine("Endereço: " + collection.endereco);
                    tw.WriteLine("Telefone: " + collection.telefone + "\n\n");
                }

                return RedirectToAction(nameof(Cadastrar));
            }
            catch
            {
                return View();
            }
        }

        // GET: Fornecedor/Edit/5
        public ActionResult Editar(int id)
        {
            return View();
        }

        // POST: Fornecedor/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(int id, Models.Fornecedor collection)
        {
            try
            {
                using (TextWriter tw = new StreamWriter(@"C:\Inputs\LogFornecedor.txt", true))
                {
                    tw.WriteLine("Edição de dados");
                    tw.WriteLine("Cod. Fornecedor: " + collection.cdFornecedor);
                    tw.WriteLine("Nome Fornecedor: " + collection.nmFornecedor);
                    tw.WriteLine("CNPJ Fornecedor: " + collection.CPNJ);
                    tw.WriteLine("Endereço: " + collection.endereco);
                    tw.WriteLine("Telefone: " + collection.telefone + "\n\n");
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Fornecedor/Delete/5
        public ActionResult Deletar(int id)
        {
            return View();
        }

        // POST: Fornecedor/Delete/5
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