using Dapper;
using SimiSoft.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimiSoft.BML
{
    public class Ventas
    {

        private DataAccess dataAccess = DataAccess.Instance();

        public int idUsuario { get; set; }
        public int idSucursal { get; set; }
        public string tipoUsuario { get; set; }
        public string nombre { get; set; }
        public int idContacto { get; set; }
        public string usuario { get; set; }
        public string password { get; set; }

        public Ventas()
        {
        }

        public int Add()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idSucursal", idSucursal);
            parametros.Add("@tipoUsuario", tipoUsuario);
            parametros.Add("@nombre", nombre);
            parametros.Add("@idContacto", idContacto);
            parametros.Add("@usuario", usuario);
            parametros.Add("@password", password);
            return dataAccess.Execute("stp_ventas_add", parametros);
        }

        public int Delete()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idUsuario", idUsuario);
            return dataAccess.Execute("stp_ventas_delete", parametros);
        }

        public List<Ventas> GetAll()
        {
            return dataAccess.Query<Ventas>("stp_ventas_getall").ToList();
        }
        public Ventas GetById()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idUsuario", idUsuario);
            return dataAccess.QuerySingle<Ventas>("stp_ventas_getbyid", parametros);
        }
        public int Update()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idUsuario", idUsuario);
            parametros.Add("@idSucursal", idSucursal);
            parametros.Add("@tipoUsuario", tipoUsuario);
            parametros.Add("@nombre", nombre);
            parametros.Add("@idContacto", idContacto);
            parametros.Add("@usuario", usuario);
            parametros.Add("@password", password);
            return dataAccess.Execute("stp_ventas_update", parametros);
        }


    }
}
