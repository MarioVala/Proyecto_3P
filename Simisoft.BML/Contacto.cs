using Dapper;
using SimiSoft.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimiSoft.BML
{
    public class Contacto
    {
        private DataAccess dataAccess = DataAccess.Instance();
        public int idContacto { get; set; }
        public string entidad { get; set; }
        public string comuna { get; set; }
        public string calle { get; set; }
        public int codigoPostal { get; set; }
        public string telefono { get; set; }

        public Contacto()
        {
        }
        public int Add()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@entidad", entidad);
            parametros.Add("@comuna", comuna);
            parametros.Add("@calle", calle);
            parametros.Add("@codigoPostal", codigoPostal);
            parametros.Add("@telefono", telefono);
            return dataAccess.Execute("stp_categorias_add", parametros);
        }

        public int Delete()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idContacto", idContacto);
            return dataAccess.Execute("stp_contactos_delete", parametros);
        }

        public List<Contacto> GetAll()
        {
            return dataAccess.Query<Contacto>("stp_contactos_getall").ToList();
        }

        public Contacto GetById()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idContacto", idContacto);
            return dataAccess.QuerySingle<Contacto>("stp_contactos_getbyid", parametros);
        }

        public int Update()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idContacto", idContacto);
            parametros.Add("@entidad", entidad);
            parametros.Add("@comuna", comuna);
            parametros.Add("@calle", calle);
            parametros.Add("@codigoPostal", codigoPostal);
            parametros.Add("@telefono", telefono);
            return dataAccess.Execute("stp_contactos_update", parametros);
        }


    }
}
