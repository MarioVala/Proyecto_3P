using Dapper;
using SimiSoft.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimiSoft.BML
{
    public class Inventario
    {
        private DataAccess dataAccess = DataAccess.Instance();
        public int idInventario { get; set; }
        public int idSucursal { get; set; }
        public int idProducto { get; set; }
        public int existencia { get; set; }

        public Inventario()
        {
        }
        public int Add()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idSucursal", idSucursal);
            parametros.Add("@idProducto", idProducto);
            parametros.Add("@existencia", existencia);
            return dataAccess.Execute("stp_inventarios_add", parametros);
        }

        public int Delete()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idInventario", idInventario);
            return dataAccess.Execute("stp_inventarios_delete", parametros);
        }

        public List<Inventario> GetAll()
        {
            return dataAccess.Query<Inventario>("stp_inventarios_getall").ToList();
        }
        public Inventario GetById()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idInventario", idInventario);
            return dataAccess.QuerySingle<Inventario>("stp_inventarios_getbyid", parametros);
        }

        public int Update()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idInventario", idInventario);
            parametros.Add("@idSucursal", idSucursal);
            parametros.Add("@idProducto", idProducto);
            parametros.Add("@existencia", existencia);
            return dataAccess.Execute("stp_inventarios_update", parametros);
        }
    }
}

