using Dapper;
using SimiSoft.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimiSoft.BML
{

    public class productoProveedores
    {
        private DataAccess dataAccess = DataAccess.Instance();
        public int idproductoProveedor { get; set; }
        public int idProveedor { get; set; }
        public int idProducto { get; set; }

        public productoProveedores()
        {
        }
        public int Add()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idProveedor", idProveedor);
            parametros.Add("@idProducto", idProducto);
            return dataAccess.Execute("stp_productosProveedores_add", parametros);
        }
        public int Delete()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idproductoProveedor", idproductoProveedor);
            return dataAccess.Execute("stp_productosProveedores_delete", parametros);
        }
        public List<productoProveedores> GetAll()
        {
            return dataAccess.Query<productoProveedores>("stp_productosProveedores_getall").ToList();
        }
        public productoProveedores GetById()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idproductoProveedor", idproductoProveedor);
            return dataAccess.QuerySingle<productoProveedores>("stp_productosProveedores_getbyid", parametros);
        }
        public int Update()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idMunicipio", idproductoProveedor);
            parametros.Add("@idProveedor", idProveedor);
            parametros.Add("@idProducto", idProducto);
            return dataAccess.Execute("stp_productosProveedores_update", parametros);
        }
    }
}

