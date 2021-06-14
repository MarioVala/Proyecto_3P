using Dapper;
using SimiSoft.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimiSoft.BML
{
    public class Localidad
    {
        private DataAccess dataAccess = DataAccess.Instance();

        public int idLocalidad { get; set; }
        public int idMunicipio { get; set; }
        public string nombreLocalidad { get; set; }

        public Localidad()
        {
        }


        public int Add()
        {
            var parametros = new DynamicParameters();

            parametros.Add("@idMunicipio", idMunicipio);
            parametros.Add("@nombreLocalidad", nombreLocalidad);
            return dataAccess.Execute("stp_localidades_add", parametros);
        }

        public List<Localidad> GetAll()
        {
            return dataAccess.Query<Localidad>("stp_localidades_getall").ToList();
        }
        public Localidad GetById()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idLocalidad", idLocalidad);
            return dataAccess.QuerySingle<Localidad>("stp_localidades_getbyid", parametros);
        }

        public int Update()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idLocalidad", idLocalidad);
            parametros.Add("@idMunicipio", idMunicipio);
            parametros.Add("@nombreLocalidad", nombreLocalidad);
            return dataAccess.Execute("stp_localidades_update", parametros);
        }

        public int Delete()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idLocalidad", idLocalidad);
            return dataAccess.Execute("stp_localidades_delete", parametros);
        }

    }
}
