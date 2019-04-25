using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using SystoqueApplication.Interfaces;
using SystoqueApplication.Models;
using SystoqueApplication.Util;

namespace SystoqueApplication.Repository
{
    public class VendedorRepository: IVendedorRepository
    {
        public void Incluir(VendedorModel vendedor)
        {
            string sql = $"insert into tblvendedor(Nome,DataNasc,Comissao) values ('{vendedor.Nome}','{vendedor.Datanasc.ToString("yyyy/MM/dd")}',{vendedor.Comissao})";
            AcessoBD acesso = new AcessoBD();
            acesso.ComandoSQL(sql);
        }

        public void Alterar(VendedorModel vendedor)
        {
            string sql = $"update tblvendedor set Nome = '{vendedor.Nome}', DataNasc = '{vendedor.Datanasc.ToString("yyyy/MM/dd")}',Comissao = {vendedor.Comissao}" +
                $" where Matricula = {vendedor.Matricula}";
            AcessoBD acesso = new AcessoBD();
            acesso.ComandoSQL(sql);
        }

        public List<VendedorModel> Lista()
        {
            List<VendedorModel> vendedores = new List<VendedorModel>();
            VendedorModel vendedor;

            string sql = "select * from tblvendedor";

            AcessoBD acesso = new AcessoBD();
            DataTable dt = acesso.Consulta(sql);

            for(int i = 0; i < dt.Rows.Count; i++)
            {
                vendedor = new VendedorModel();
                vendedor.Matricula = int.Parse(dt.Rows[i]["Matricula"].ToString());
                vendedor.Nome = dt.Rows[i]["Nome"].ToString();
                vendedor.Datanasc = DateTime.Parse(dt.Rows[i]["DataNasc"].ToString());
                vendedor.Comissao = decimal.Parse(dt.Rows[i]["Comissao"].ToString());
                vendedores.Add(vendedor);
            }

            return vendedores;
        }

        public VendedorModel Selecionar(int? id)
        {
            VendedorModel vendedor;
            string sql = $"select * from tblvendedor where matricula = {id}";
            AcessoBD acesso = new AcessoBD();
            DataTable dt = acesso.Consulta(sql);

            if (dt.Rows.Count > 0)
            {
                vendedor = new VendedorModel();
                vendedor.Matricula = int.Parse(dt.Rows[0]["Matricula"].ToString());
                vendedor.Nome = dt.Rows[0]["Nome"].ToString();
                vendedor.Datanasc = DateTime.Parse(dt.Rows[0]["DataNasc"].ToString());
                vendedor.Comissao = decimal.Parse(dt.Rows[0]["Comissao"].ToString());

            }
            else vendedor = null;

            return vendedor;
        }
    }
}