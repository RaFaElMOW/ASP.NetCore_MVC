using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Etec.Aula2802.MCV.Models.Data
{
    public class ClienteData
    {
        public List<Cliente> SelecionarTodos()
        {
            MySqlConnection msc = new MySqlConnection("server=127.0.0.1; uid=root; pwd=1234567; database=db_aula2103");
            msc.Open();

            MySqlDataAdapter msda = new MySqlDataAdapter("select * from tb_cliente",msc);

            DataSet ds = new DataSet();
            msda.Fill(ds);

            msc.Close();

            List<Cliente> lista = new List<Cliente>();

            foreach(DataRow dr in ds.Tables[0].Rows)
            {
                Cliente item = new Cliente();

                item.cdCliente = int.Parse(dr["id_cliente"].ToString());
                item.nmCliente = dr["nome_cliente"].ToString();
                item.dtNascimento = DateTime.Parse(dr["dtNasc_cliente"].ToString());
                item.peso = decimal.Parse(dr["peso_cliente"].ToString());

                lista.Add(item);
            }

            return lista;
        }
    }
}
