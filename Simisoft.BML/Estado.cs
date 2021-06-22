using Dapper;
using SimiSoft.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimiSoft.BML
{
    public class Estado
    {
        private DataAccess dataAccess = DataAccess.Instance();

        public int idEstado { get; set; }
        public string nombreEstado { get; set; }

        public Estado()
        {
        }

        public int Add()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@nombreEstado", nombreEstado);
            return dataAccess.Execute("stp_estados_add", parametros);
        }

        public int Delete(string idaborrar)
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idEstado", idaborrar);
            return dataAccess.Execute("stp_estados_delete", parametros);
        }

        public List<Estado> GetAll()
        {
            return dataAccess.Query<Estado>("stp_estados_getall").ToList();
        }
        public Estado GetById()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idEstado", idEstado);
            return dataAccess.QuerySingle<Estado>("stp_estados_getbyid", parametros);
        }

        public int Update()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idEstado", idEstado);
            parametros.Add("@nombreEstado", nombreEstado);
            return dataAccess.Execute("stp_estados_update", parametros);
        }
    }
}
