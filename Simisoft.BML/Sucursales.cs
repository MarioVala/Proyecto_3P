using Dapper;
using SimiSoft.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimiSoft.BML
{
    public class Sucursales
    {
        private DataAccess dataAccess = DataAccess.Instance();
        public int idSucursal { get; set; }
        public string nombreSucursal { get; set; }
        public int idContacto { get; set; }
        public bool activo { get; set; }

        public Sucursales()
        {
        }

        public int Add()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idContacto", idContacto);
            parametros.Add("@nombreSucursal", nombreSucursal);
            return dataAccess.Execute("stp_Sucursales_add", parametros);
        }
        public int Delete()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idSucursal", idSucursal);
            return dataAccess.Execute("stp_Sucursales_delete", parametros);
        }
        public List<Sucursales> GetAll()
        {
            return dataAccess.Query<Sucursales>("stp_Sucursales_getall").ToList();
        }
        public Sucursales GetById()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idSucursal", idSucursal);
            return dataAccess.QuerySingle<Sucursales>("stp_Sucursales_getbyid", parametros);
        }
        public int Update()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idSucursal", idSucursal);
            parametros.Add("@nombreSucursal", nombreSucursal);
            parametros.Add("@idContacto", idContacto);
            return dataAccess.Execute("stp_Sucursales_update", parametros);
        }

    }
}