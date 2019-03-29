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

        public Cliente SelecionarPorCodigo(int codigoCliente)
        {
            MySqlConnection msc = new MySqlConnection("server=127.0.0.1; uid=root; pwd=1234567; database=db_aula2103");
            msc.Open();

            MySqlDataAdapter msda = new MySqlDataAdapter("select * from tb_cliente where id_cliente = " + codigoCliente , msc);

            DataSet ds = new DataSet();
            msda.Fill(ds);

            msc.Close();

            List<Cliente> lista = new List<Cliente>();

            Cliente item = new Cliente();

            if (ds.Tables[0].Rows.Count > 0)
            {
                item.cdCliente = int.Parse(ds.Tables[0].Rows[0]["id_cliente"].ToString());
                item.nmCliente = ds.Tables[0].Rows[0]["nome_cliente"].ToString();
                item.dtNascimento = DateTime.Parse(ds.Tables[0].Rows[0]["dtNasc_cliente"].ToString());
                item.peso = decimal.Parse(ds.Tables[0].Rows[0]["peso_cliente"].ToString());
            }

            return item;
        }

        public void InserirCliente(Cliente cliente)
        {
            MySqlConnection msc = new MySqlConnection("server=127.0.0.1; uid=root; pwd=1234567; database=db_aula2103");
            msc.Open();

            MySqlCommand cmd = new MySqlCommand("insert into tb_cliente values (@id_cliente, @nome_cliente, @peso_cliente, @dtNasc_cliente)", msc);
            cmd.Parameters.AddWithValue("@id_cliente", cliente.cdCliente);
            cmd.Parameters.AddWithValue("@nome_cliente", cliente.nmCliente);
            cmd.Parameters.AddWithValue("@peso_cliente", cliente.peso);
            cmd.Parameters.AddWithValue("@dtNasc_cliente", cliente.dtNascimento);

            cmd.ExecuteNonQuery();
            msc.Close();

        }

        public void EditarCliente(int id, Cliente cliente)
        {
            MySqlConnection msc = new MySqlConnection("server=127.0.0.1; uid=root; pwd=1234567; database=db_aula2103");
            msc.Open();

            MySqlCommand cmd = new MySqlCommand("update tb_cliente set nome_cliente = @nome_cliente, peso_cliente = @peso_cliente, dtNasc_cliente = @dtNasc_cliente where id_cliente = "+ id , msc);
            cmd.Parameters.AddWithValue("@nome_cliente", cliente.nmCliente);
            cmd.Parameters.AddWithValue("@peso_cliente", cliente.peso);
            cmd.Parameters.AddWithValue("@dtNasc_cliente", cliente.dtNascimento);

            cmd.ExecuteNonQuery();
            msc.Close();
        }
    }
}
