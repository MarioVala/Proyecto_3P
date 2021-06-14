using Dapper;
using SimiSoft.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimiSoft.BML
{
    public class Categoria
    {
        private DataAccess dataAccess = DataAccess.Instance();
        public int idCategoria { get; set; }
        public string nombreCategoria { get; set; }
        public bool activo { get; set; }

        public Categoria()
        {
        }
        public int Add()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@nombreCategoria", nombreCategoria);
            return dataAccess.Execute("stp_categorias_add", parametros);
        }

        public int Delete() 
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idCategoria", idCategoria);
            return dataAccess.Execute("stp_categorias_delete", parametros);
        }

        public List<Categoria> GetAll()
        {
            return dataAccess.Query<Categoria>("stp_categorias_getall").ToList();
        }
        public Categoria GetById()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idCategoria", idCategoria);
            return dataAccess.QuerySingle<Categoria>("stp_categorias_getbyid", parametros);
        }

        public int Update()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idCategoria", idCategoria);
            parametros.Add("@nombreCategoria", nombreCategoria);
            return dataAccess.Execute("stp_categorias_update", parametros);
        }
    }
}
