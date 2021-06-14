using Dapper;
using SimiSoft.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimiSoft.BML
{
    public class Productos
    {
        private DataAccess dataAccess = DataAccess.Instance();

        public int idProducto { get; set; }
        public int idCategoria { get; set; }
        public string nombre { get; set; }
        public int precio { get; set; }
        public string caducidad { get; set; }
        public int descuento { get; set; }
        public bool activo { get; set; }

        public Productos()
        {
        }

        #region CRUD

        public int Add()
        {
            var parametros = new DynamicParameters();

            parametros.Add("@idCategoria", idCategoria);
            parametros.Add("@nombre", nombre);
            parametros.Add("@precio", precio);
            parametros.Add("@caducidad", caducidad);
            parametros.Add("@descuento", descuento);
       

            return dataAccess.Execute("stp_productos_add", parametros);
        }

        public int Delete()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idProducto", idProducto);
            return dataAccess.Execute("stp_productos_delete", parametros);
        }

        public List<Productos> GetAll()
        {
            return dataAccess.Query<Productos>("stp_productos_getall").ToList();
        }

        public Productos GetById()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idProducto", idProducto);
            return dataAccess.QuerySingle<Productos>("stp_productos_getall", parametros);
        }

        public int Update()
        {
            var parametros = new DynamicParameters();

            parametros.Add("@idProducto", idProducto);
            parametros.Add("@idCategoria", idCategoria);
            parametros.Add("@nombre", nombre);
            parametros.Add("@precio", precio);
            parametros.Add("@caducidad", caducidad);
            parametros.Add("@descuento", descuento);
            return dataAccess.Execute("stp_productos_getall", parametros);
        }



        #endregion




    }
}
