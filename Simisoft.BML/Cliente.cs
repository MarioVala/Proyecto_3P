using Dapper;
using SimiSoft.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimiSoft.BML
{
    public class Cliente
    {
        private DataAccess dataAccess = DataAccess.Instance();
        public int idCliente { get; set; }
        public string nombreCliente { get; set; }
        public int idContacto { get; set; }
        public bool activo { get; set; }

        public Cliente()
        {
        }

        public int Add() {
            var parametros = new DynamicParameters();
            parametros.Add("@nombreCliente", nombreCliente);
            parametros.Add("@idContacto", idContacto);
            return dataAccess.Execute("stp_clientes_add", parametros);
        }

        public int Delete() {
            var parametros = new DynamicParameters();
            parametros.Add("@idCliente", idCliente);
            return dataAccess.Execute("stp_clientes_delete", parametros);
        }
        public List<Cliente> GetAll() {
            return dataAccess.Query<Cliente>("stp_clientes_getall").ToList();
        }

        public Cliente GetById() {
            var parametros = new DynamicParameters();
            parametros.Add("@idCliente", idCliente);
            return dataAccess.QuerySingle<Cliente>("stp_clientes_getbyid", parametros);
        }
        public int Update() {
            var parametros = new DynamicParameters();
            parametros.Add("@idCliente", idCliente);
            parametros.Add("@nombreCliente", nombreCliente);
            parametros.Add("@idContacto", idContacto);
            return dataAccess.Execute("stp_clientes_update", parametros);
        }
    }
}
