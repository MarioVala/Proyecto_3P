using Dapper;
using SimiSoft.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimiSoft.BML
{
    public class detalleMovimientos
    {
        private DataAccess dataAccess = DataAccess.Instance();
        public int idDetalleMovimiento { get; set; }
        public int idProducto { get; set; }
        public int cantidad { get; set; }

        public detalleMovimientos()
        {
        }
        public int Add()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idProducto", idProducto);
            parametros.Add("@cantidad", cantidad);
            return dataAccess.Execute("stp_detalleMovimientos_add", parametros);
        }

        public int Delete(string idaborrar)
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idDetalleMovimiento", idaborrar);
            return dataAccess.Execute("stp_detalleMovimientos_delete", parametros);
        }

        public List<detalleMovimientos> GetAll()
        {
            return dataAccess.Query<detalleMovimientos>("stp_detalleMovimientos_getall").ToList();
        }
        public detalleMovimientos GetById()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idDetalleMovimiento", idDetalleMovimiento);
            return dataAccess.QuerySingle<detalleMovimientos>("stp_detalleMovimientos_getbyid", parametros);
        }

        public int Update()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idDetalleMovimiento", idDetalleMovimiento);
            parametros.Add("@idProducto", idProducto);
            parametros.Add("@cantidad", cantidad);
            return dataAccess.Execute("stp_detallleMovimientos_update", parametros);
        }
    }
}
