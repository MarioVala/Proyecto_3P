using Dapper;
using SimiSoft.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimiSoft.BML
{
    public class Proveedores
    {
        private DataAccess dataAccess = DataAccess.Instance();
        public int idProveedor { get; set; }
        public string nombreProveedor { get; set; }
        public int idContacto { get; set; }
        public bool activo { get; set; }

        public Proveedores()
        {
        }

        public int Add()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@nombreProveedor", nombreProveedor);
            parametros.Add("@idContacto", idContacto);
            return dataAccess.Execute("stp_proveedores_add", parametros);
        }

        public int Delete()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idProveedor", idProveedor);
            return dataAccess.Execute("stp_proveedores_delete", parametros);
        }

        public List<Proveedores> GetAll()
        {
            return dataAccess.Query<Proveedores>("stp_proveedores_getall").ToList();
        }
        public Proveedores GetById()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idProveedor", idProveedor);
            return dataAccess.QuerySingle<Proveedores>("stp_proveedores_getbyid", parametros);
        }

        public int Update()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idProveedor", idProveedor);
            parametros.Add("@nombreProveedor", nombreProveedor);
            parametros.Add("@idContacto", idContacto);
            return dataAccess.Execute("stp_proveedores_update", parametros);
        }
    }
}
