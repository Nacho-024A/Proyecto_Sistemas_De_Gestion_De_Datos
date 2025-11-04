using EAFIT_BaseDeDatos.Core.EAFIT_MANAGER;
using System.Collections.Generic;

namespace EAFIT_BaseDeDatos.Core.EAFIT_FACADE
{
    public class FacadeHorarios
    {
        public bool InsertarHorario(Dictionary<string, string> ValuesHorario)
        {
            ManagerHorarios InsertHorario = new ManagerHorarios();
            return InsertHorario.InsertarHorario(ValuesHorario);
        }

        public bool ActualizarHorario(Dictionary<string, string> ValuesHorario)
        {
            ManagerHorarios UpdateHorario = new ManagerHorarios();
            return UpdateHorario.ActualizarHorario(ValuesHorario);
        }

        public bool EliminarHorario(int id_horario)
        {
            ManagerHorarios DeleteHorario = new ManagerHorarios();
            return DeleteHorario.EliminarHorario(id_horario);
        }

        public Dictionary<string, string> ConsultarHorario(int id_horario)
        {
            ManagerHorarios GetHorario = new ManagerHorarios();
            return GetHorario.ConsultarHorario(id_horario);
        }
    }
}
