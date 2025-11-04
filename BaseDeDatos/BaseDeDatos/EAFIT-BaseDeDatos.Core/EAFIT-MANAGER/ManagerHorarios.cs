using EAFIT_BaseDeDatos.Core.EAFIT_BROKER;
using System.Collections.Generic;

namespace EAFIT_BaseDeDatos.Core.EAFIT_MANAGER
{
    public class ManagerHorarios
    {
        public bool InsertarHorario(Dictionary<string, string> ValuesHorario)
        {
            BrokerHorarios InsertHorario = new BrokerHorarios();
            return InsertHorario.InsertarHorario(ValuesHorario);
        }

        public bool ActualizarHorario(Dictionary<string, string> ValuesHorario)
        {
            BrokerHorarios UpdateHorario = new BrokerHorarios();
            return UpdateHorario.ActualizarHorario(ValuesHorario);
        }

        public bool EliminarHorario(int id_horario)
        {
            BrokerHorarios DeleteHorario = new BrokerHorarios();
            return DeleteHorario.EliminarHorario(id_horario);
        }

        public Dictionary<string, string> ConsultarHorario(int id_horario)
        {
            BrokerHorarios GetHorario = new BrokerHorarios();
            return GetHorario.ConsultarHorario(id_horario);
        }
    }
}
