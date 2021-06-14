using Dapper;
using SimiSoft.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimiSoft.BML
{
    public class detalleVentas
    {
        private DataAccess dataAccess = DataAccess.Instance();
        public int idDetalleVenta { get; set; }
        public int idVenta { get; set; }
        public int idProducto { get; set; }
        public int cantidad { get; set; }
        public double precio { get; set; }
        public double descuento { get; set; }
        public double importeTotal { get; set; }
        public double importeNeto { get; set; }

        public detalleVentas()
        {
        }
        public int Add()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idVenta", idVenta);
            parametros.Add("@idProducto", idProducto);
            parametros.Add("@cantidad", cantidad);
            parametros.Add("@precio", precio);
            parametros.Add("@descuento", descuento);
            parametros.Add("@importeTotal", importeTotal);
            parametros.Add("@importeNeto", importeNeto);
            return dataAccess.Execute("stp_detalleVentas_add", parametros);
        }

        public int Delete()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idDetalleVenta", idDetalleVenta);
            return dataAccess.Execute("stp_detalleVentas_delete", parametros);
        }

        public List<detalleVentas> GetAll()
        {
            return dataAccess.Query<detalleVentas>("stp_detalleVentas_getall").ToList();
        }
        public detalleVentas GetById()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idDetalleVenta", idDetalleVenta);
            return dataAccess.QuerySingle<detalleVentas>("stp_detalleVentas_getbyid", parametros);
        }

        public int Update()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idDetalleVenta", idDetalleVenta);
            parametros.Add("@idVenta", idVenta);
            parametros.Add("@idProducto", idProducto);
            parametros.Add("@cantidad", cantidad);
            parametros.Add("@precio", precio);
            parametros.Add("@descuento", descuento);
            parametros.Add("@importeTotal", importeTotal);
            parametros.Add("@importeNeto", importeNeto);
            return dataAccess.Execute("stp_detalleVentas_update", parametros);
        }
    }
}
