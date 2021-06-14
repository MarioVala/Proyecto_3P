using Dapper;
using SimiSoft.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimiSoft.BML
{
    public class Municipios
    {
        private DataAccess dataAccess = DataAccess.Instance();
        public int idMunicipio { get; set; }
        public int idEstado { get; set; }
        public string nombreMunicipio { get; set; }

        public Municipios()
        {
        }

        public int Add()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@nombreMunicipio", nombreMunicipio);
            return dataAccess.Execute("stp_municipios_add", parametros);
        }
        public int Delete()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idMunicipio", idMunicipio);
            return dataAccess.Execute("stp_municipios_delete", parametros);
        }
        public List<Municipios> GetAll()
        {
            return dataAccess.Query<Municipios>("stp_municipios_getall").ToList();
        }
        public Municipios GetById()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idMunicipio", idMunicipio);
            return dataAccess.QuerySingle<Municipios>("stp_municipios_getbyid", parametros);
        }
        public int Update()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idMunicipio", idMunicipio);
            parametros.Add("@nombreCategoria", nombreMunicipio);
            return dataAccess.Execute("stp_municipios_update", parametros);
        }
    }
}

