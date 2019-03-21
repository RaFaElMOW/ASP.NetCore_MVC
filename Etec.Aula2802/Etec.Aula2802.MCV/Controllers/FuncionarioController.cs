using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Etec.Aula2802.MCV.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        public ActionResult Index()
        {
            return View();
        }

        // GET: Funcionario/Details/5
        public ActionResult Detalhes(int id)
        {
            return View();
        }

        // GET: Funcionario/Create
        public ActionResult Cadastrar()
        {
            return View();
        }

        public ActionResult Lista()
        {
            Models.Funcionario funcionario0 = new Models.Funcionario();
            funcionario0.cdFuncionario = 1;
            funcionario0.nmFuncionario = "Ronaldo";
            funcionario0.endereco = "Rua um";
            funcionario0.rg = "451457896";
            funcionario0.cpf = "43454587896";
            funcionario0.telefone = "1145478547";
            funcionario0.cargo = "Analista de Sistemas";

            Models.Funcionario funcionario1 = new Models.Funcionario();
            funcionario1.cdFuncionario = 2;
            funcionario1.nmFuncionario = "Rafael";
            funcionario1.endereco = "Rua dois";
            funcionario1.rg = "457878965";
            funcionario1.cpf = "43461579852";
            funcionario1.telefone = "1145789632";
            funcionario1.cargo = "Desenvolvedor";

            Models.Funcionario funcionario2 = new Models.Funcionario();
            funcionario2.cdFuncionario = 3;
            funcionario2.nmFuncionario = "Maria";
            funcionario2.endereco = "Rua três";
            funcionario2.rg = "456987412";
            funcionario2.cpf = "32145678545";
            funcionario2.telefone = "1145478547";
            funcionario2.cargo = "Artista Plástica";

            Models.Funcionario funcionario3 = new Models.Funcionario();
            funcionario3.cdFuncionario = 4;
            funcionario3.nmFuncionario = "Jeniffer";
            funcionario3.endereco = "Rua quatro";
            funcionario3.rg = "458786213";
            funcionario3.cpf = "43436987545";
            funcionario3.telefone = "1145789632";
            funcionario3.cargo = "Marketing";

            Models.Funcionario funcionario4 = new Models.Funcionario();
            funcionario4.cdFuncionario = 5;
            funcionario4.nmFuncionario = "Antônio";
            funcionario4.endereco = "Rua cinco";
            funcionario4.rg = "453214578";
            funcionario4.cpf = "13649875347";
            funcionario4.telefone = "1145789654";
            funcionario4.cargo = "DBA";

            Models.Funcionario funcionario5 = new Models.Funcionario();
            funcionario5.cdFuncionario = 6;
            funcionario5.nmFuncionario = "Julieta";
            funcionario5.endereco = "Rua Limão";
            funcionario5.rg = "412478965";
            funcionario5.cpf = "45457896547";
            funcionario5.telefone = "1145789654";
            funcionario5.cargo = "Escritora";

            List<Models.Funcionario> lista = new List<Models.Funcionario>();

            lista.Add(funcionario0);
            lista.Add(funcionario1);
            lista.Add(funcionario2);
            lista.Add(funcionario3);
            lista.Add(funcionario4);
            lista.Add(funcionario5);

            return View(lista);
        }

        // POST: Funcionario/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(Models.Funcionario collection)
        {
            try
            {
                using (TextWriter tw = new StreamWriter(@"C:\Inputs\LogFuncionario.txt", true))
                {
                    tw.WriteLine("Inserção de dados");
                    tw.WriteLine("Cod. Funcionario: " + collection.cdFuncionario);
                    tw.WriteLine("Nome Funcionario: " + collection.nmFuncionario);
                    tw.WriteLine("Endereço: " + collection.endereco);
                    tw.WriteLine("Telefone: " + collection.telefone);
                    tw.WriteLine("RG: " + collection.rg);
                    tw.WriteLine("CPF: " + collection.cpf);
                    tw.WriteLine("Cargo: " + collection.cargo + "\n\n");
                }

                return RedirectToAction(nameof(Cadastrar));
            }
            catch
            {
                return View();
            }
        }

        // GET: Funcionario/Edit/5
        public ActionResult Editar(int id)
        {
            return View();
        }

        // POST: Funcionario/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(int id, Models.Funcionario collection)
        {
            try
            {
                using (TextWriter tw = new StreamWriter(@"C:\Inputs\LogFuncionario.txt", true))
                {
                    tw.WriteLine("Edição de dados");
                    tw.WriteLine("Cod. Funcionario: " + collection.cdFuncionario);
                    tw.WriteLine("Nome Funcionario: " + collection.nmFuncionario);
                    tw.WriteLine("Endereço: " + collection.endereco);
                    tw.WriteLine("Telefone: " + collection.telefone);
                    tw.WriteLine("RG: " + collection.rg);
                    tw.WriteLine("CPF: " + collection.cpf);
                    tw.WriteLine("Cargo: " + collection.cargo + "\n\n");
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Funcionario/Delete/5
        public ActionResult Deletar(int id)
        {
            return View();
        }

        // POST: Funcionario/Delete/5
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