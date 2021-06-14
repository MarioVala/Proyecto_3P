using Dapper;
using SimiSoft.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimiSoft.BML
{
   public class Compra
    {
        private DataAccess dataAccess = DataAccess.Instance();
        public int idCompra { get; set; }
        public int idProveedor { get; set; }
        public double descuento { get; set; }
        public string fecha { get; set; }
        public double costo { get; set; }
        public char estado { get; set; }
        public double importeTotal { get; set; }
        public double importeNeto { get; set; }
        public int cantidad { get; set; }

        public Compra()
        {
        }

        public int Add() {
            var parametros = new DynamicParameters();
            parametros.Add("@idProveedor", idProveedor);
            parametros.Add("@descuento", descuento);
            parametros.Add("@fecha", fecha);
            parametros.Add("@costo", costo);
            parametros.Add("@estado", estado);
            parametros.Add("@importeTotal", importeTotal);
            parametros.Add("@importeNeto", importeNeto);
            parametros.Add("@cantidad", cantidad);
            return dataAccess.Execute("stp_compras_add", parametros);
        }

        public int Delete()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idCompra", idCompra);
            return dataAccess.Execute("stp_compras_delete", parametros);
        }

        public List<Compra> GetAll()
        {
            return dataAccess.Query<Compra>("stp_compras_getall").ToList();
        }

        public Compra GetById()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idCompra", idCompra);
            return dataAccess.QuerySingle<Compra>("stp_compras_getbyid", parametros);
        }
        public int Update()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idCompra", idCompra);
            parametros.Add("@idProveedor", idProveedor);
            parametros.Add("@descuento", descuento);
            parametros.Add("@fecha", fecha);
            parametros.Add("@costo", costo);
            parametros.Add("@estado", estado);
            parametros.Add("@importeTotal", importeTotal);
            parametros.Add("@importeNeto", importeNeto);
            parametros.Add("@cantidad", cantidad);
            return dataAccess.Execute("stp_compras_update", parametros);
        }
    }
}
