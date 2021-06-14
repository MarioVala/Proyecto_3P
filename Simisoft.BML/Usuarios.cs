using Dapper;
using SimiSoft.DAL;
using System.Collections.Generic;
using System.Linq;

namespace SimiSoft.DAL
{
    public class Usuarios
    {
        private DataAccess dataAccess = DataAccess.Instance();

        public int idUsuario { get; set; }
        public int idSucursal { get; set; }
        public string tipoUsuario { get; set; }
        public string nombre { get; set; }
        public int idContacto { get; set; }
        public string usuario { get; set; }
        public string password { get; set; }

        public Usuarios()
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

            return dataAccess.Execute("stp_usuarios_add", parametros);
        }

        public int Delete()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idUsuario", idUsuario);
            return dataAccess.Execute("stp_usuarios_delete", parametros);
        }

        public List<Usuarios> GetAll()
        {
            return dataAccess.Query<Usuarios>("stp_usuarios_getall").ToList();
        }
        public Usuarios GetById()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idUsuario", idUsuario);
            return dataAccess.QuerySingle<Usuarios>("stp_usuarios_getbyid", parametros);
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
            return dataAccess.Execute("stp_usuarios_update", parametros);
        }




    }
}
