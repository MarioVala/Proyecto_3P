using Dapper;
using SimiSoft.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimiSoft.BML
{
    public class Movimientos
    {
        private DataAccess dataAccess = DataAccess.Instance();

        public int idMovimiento { get; set; }
        public string tipoMovimiento { get; set; }
        public string fecha { get; set; }

        public Movimientos()
        {
        }

        public int Add()
        {
            var parametros = new DynamicParameters();

            parametros.Add("@tipoMovimiento", tipoMovimiento);
            parametros.Add("@fecha", fecha);
            return dataAccess.Execute("stp_movimientos_add", parametros);
        }

        public List<Movimientos> GetAll()
        {
            return dataAccess.Query<Movimientos>("stp_movimientos_getall").ToList();
        }
        public Movimientos GetById()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idMovimiento", idMovimiento);
            return dataAccess.QuerySingle<Movimientos>("stp_movimientos_getbyid", parametros);
        }

        public int Update()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idMovimiento", idMovimiento);
            parametros.Add("@tipoMovimiento", tipoMovimiento);
            parametros.Add("@fecha", fecha);
            return dataAccess.Execute("stp_movimientos_update", parametros);
        }

        public int Delete()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idMovimiento", idMovimiento);
            return dataAccess.Execute("stp_movimientos_delete", parametros);
        }
    }
}
