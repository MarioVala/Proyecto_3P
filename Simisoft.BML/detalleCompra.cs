using Dapper;
using SimiSoft.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimiSoft.BML
{
    public class detalleCompra
    {
        private DataAccess dataAccess = DataAccess.Instance();
        public int idDetalleCompra { get; set; }
        public int idCompra { get; set; }
        public int idProducto { get; set; }
        public int cantidad { get; set; }
        public decimal costo { get; set; }
        public decimal descuento { get; set; }
        public decimal importeTotal { get; set; }
        public decimal importeNeto { get; set; }

        public detalleCompra()
        {
        }
        public int Add()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idCompra", idCompra);
            parametros.Add("@idProducto", idProducto);
            parametros.Add("@cantidad", cantidad);
            parametros.Add("@costo", costo);
            parametros.Add("@descuento", descuento);
            parametros.Add("@importeTotal", importeTotal);
            parametros.Add("@importeNeto", importeNeto);
            return dataAccess.Execute("stp_detalleCompras_add", parametros);
        }

        public int Delete(string idaborrar)
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idDetalleCompra", idaborrar);
            return dataAccess.Execute("stp_detalleCompras_delete", parametros);
        }
        public List<detalleCompra> GetAll()
        {
            return dataAccess.Query<detalleCompra>("stp_detalleCompras_getall").ToList();
        }
        public detalleCompra GetById()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idDetalleCompra", idDetalleCompra);
            return dataAccess.QuerySingle<detalleCompra>("stp_detalleCompras_getbyid", parametros);
        }
        public int Update()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idDetalleCompra", idDetalleCompra);
            parametros.Add("@idCompra", idCompra);
            parametros.Add("@idProducto", idProducto);
            parametros.Add("@cantidad", cantidad);
            parametros.Add("@costo", costo);
            parametros.Add("@descuento", descuento);
            parametros.Add("@importeTotal", importeTotal);
            parametros.Add("@importeNeto", importeNeto);
            return dataAccess.Execute("stp_detalleCompras_update", parametros);
        }
    }
}
