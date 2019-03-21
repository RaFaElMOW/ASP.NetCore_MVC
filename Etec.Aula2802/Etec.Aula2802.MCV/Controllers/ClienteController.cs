﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Etec.Aula2802.MCV.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }

        // GET: Cliente/Details/5
        public ActionResult Detalhes(int id)
        {
            return View();
        }

        public ActionResult Lista()
        {
            Models.Cliente cliente0 = new Models.Cliente();
            cliente0.cdCliente = 1;
            cliente0.nmCliente = "Rafael";
            cliente0.peso = decimal.Parse("57,25");
            cliente0.dtNascimento = DateTime.Parse("10/07/1995");

            Models.Cliente cliente1 = new Models.Cliente();
            cliente1.cdCliente = 2;
            cliente1.nmCliente = "João";
            cliente1.peso = decimal.Parse("52,17");
            cliente1.dtNascimento = DateTime.Parse("10/10/1995");

            Models.Cliente cliente2 = new Models.Cliente();
            cliente2.cdCliente = 3;
            cliente2.nmCliente = "Frodo";
            cliente2.peso = decimal.Parse("53,25");
            cliente2.dtNascimento = DateTime.Parse("01/05/1993");

            Models.Cliente cliente3 = new Models.Cliente();
            cliente3.cdCliente = 4;
            cliente3.nmCliente = "Florentino";
            cliente3.peso = decimal.Parse("80,50");
            cliente3.dtNascimento = DateTime.Parse("08/12/1991");

            Models.Cliente cliente4 = new Models.Cliente();
            cliente4.cdCliente = 5;
            cliente4.nmCliente = "Cleiton";
            cliente4.peso = decimal.Parse("53,17");
            cliente4.dtNascimento = DateTime.Parse("15/07/1995");

            Models.Cliente cliente5 = new Models.Cliente();
            cliente5.cdCliente = 6;
            cliente5.nmCliente = "Eustácio";
            cliente5.peso = decimal.Parse("42,07");
            cliente5.dtNascimento = DateTime.Parse("22/07/2010");


            List<Models.Cliente> lista = new List<Models.Cliente>();
            lista.Add(cliente0);
            lista.Add(cliente1);
            lista.Add(cliente2);
            lista.Add(cliente3);
            lista.Add(cliente4);
            lista.Add(cliente5);

            return View(lista);
        }

        // GET: Cliente/Create
        public ActionResult Cadastrar()
        {
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(Models.Cliente collection)
        {
            try
            {
                using (TextWriter tw = new StreamWriter(@"C:\Inputs\LogCliente.txt", true))
                {
                    tw.WriteLine("Inserção de dados");
                    tw.WriteLine("Cod. Cliente: " + collection.cdCliente);
                    tw.WriteLine("Nome Cliente: " + collection.nmCliente);
                    tw.WriteLine("Data de Nascimento: " + collection.dtNascimento);
                    tw.WriteLine("Peso: " + collection.peso + "\n\n");
                }

                return RedirectToAction(nameof(Cadastrar));
            }
            catch
            {
                return View();
            }
        }

        // GET: Cliente/Edit/5
        public ActionResult Editar(int id)
        {
            Models.Cliente cliente = new Models.Cliente();
            if (id == 1)
            {
                cliente.cdCliente = 1;
                cliente.nmCliente = "Rafael";
                cliente.peso = decimal.Parse("57,25");
                cliente.dtNascimento = DateTime.Parse("10/07/1995");
            }

            else if (id == 2)
            {
                cliente.cdCliente = 2;
                cliente.nmCliente = "João";
                cliente.peso = decimal.Parse("52,17");
                cliente.dtNascimento = DateTime.Parse("10/10/1995");
            }

            else if (id == 3)
            {
                cliente.cdCliente = 3;
                cliente.nmCliente = "Frodo";
                cliente.peso = decimal.Parse("53,25");
                cliente.dtNascimento = DateTime.Parse("01/05/1993");
            }

            else if (id == 4)
            {
                cliente.cdCliente = 4;
                cliente.nmCliente = "Florentino";
                cliente.peso = decimal.Parse("80,50");
                cliente.dtNascimento = DateTime.Parse("08/12/1991");
            }

            else if (id == 5)
            {
                cliente.cdCliente = 5;
                cliente.nmCliente = "Cleiton";
                cliente.peso = decimal.Parse("53,17");
                cliente.dtNascimento = DateTime.Parse("15/07/1995");
            }

            else if (id == 6)
            {
                cliente.cdCliente = 6;
                cliente.nmCliente = "Eustácio";
                cliente.peso = decimal.Parse("42,07");
                cliente.dtNascimento = DateTime.Parse("22/07/2010");
            }

            else
            {
                cliente.cdCliente = 0;
                cliente.nmCliente = "Cliente não encontrado";
            }

            return View(cliente);
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(int id, Models.Cliente collection)
        {
            try
            {
                using (TextWriter tw = new StreamWriter(@"C:\Inputs\LogCliente.txt", true))
                {
                    tw.WriteLine("Edição de dados");
                    tw.WriteLine("Cod. Cliente: " + collection.cdCliente);
                    tw.WriteLine("Nome Cliente: " + collection.nmCliente);
                    tw.WriteLine("Data de Nascimento: " + collection.dtNascimento);
                    tw.WriteLine("Peso: " + collection.peso + "\n\n");
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Cliente/Delete/5
        public ActionResult Deletar(int id)
        {
            return View();
        }

        // POST: Cliente/Delete/5
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