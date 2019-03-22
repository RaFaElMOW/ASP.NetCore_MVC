using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Etec.Aula2802.MCV.Models.Data
{
    public class FornecedorData
    {
        public List<Fornecedor> SelecionarTodos()
        {
            MySqlConnection msc = new MySqlConnection("server 127.0.0.1; uid=root; pwd=1234567; database=db_aula2103");
            msc.Open();

            MySqlDataAdapter msda = new MySqlDataAdapter("select * from tb_fornecedor",msc);

            DataSet ds = new DataSet();
            msda.Fill(ds);

            msc.Close();


            List<Fornecedor> lista = new List<Fornecedor>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Fornecedor item = new Fornecedor();
                item.cdFornecedor = int.Parse(dr["id_fornecedor"].ToString());
                item.nmFornecedor = dr["nome_fornecedor"].ToString();
                item.CPNJ = dr["cnpj_fornecedor"].ToString();
                item.endereco = dr["endereco_fornecedor"].ToString();
                item.telefone = dr["fone_fornecedor"].ToString();

                lista.Add(item);
            }
            return (lista);

        }
    }
}
