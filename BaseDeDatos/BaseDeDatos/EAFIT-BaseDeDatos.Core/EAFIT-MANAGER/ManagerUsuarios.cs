using EAFIT_BaseDeDatos.Core.EAFIT_BROKER;
using EAFIT_BaseDeDatos.Core.EAFIT_ENTITIES;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAFIT_BaseDeDatos.Core.EAFIT_MANAGER
{
    class ManagerUsuarios
    {
        internal (bool, string) InsertarUsuario(Dictionary<string, string> ValuesUsuario)
        {
            BrokerUsuarios broker = new BrokerUsuarios();
            return broker.InsertarUsuario(ValuesUsuario);
        }
        internal bool ActualizarUsuario(Dictionary<string, string> ValuesUsuario)
        {
            BrokerUsuarios UpdateUser = new BrokerUsuarios();
            return UpdateUser.ActualizarUsuario(ValuesUsuario);

        }
        internal bool InactivarUsuario(string ValuesUsuario)
        {
            BrokerUsuarios InactivateUser = new BrokerUsuarios(); 
            return InactivateUser.InactivarUsuario(ValuesUsuario);

        }

        internal bool ActivarUsuario(string ValuesUsuario)
        {
            BrokerUsuarios ActivateUser = new BrokerUsuarios();
            return ActivateUser.ActivarUsuario(ValuesUsuario);
        }
        internal Dictionary<string, string> ValidarUsuario(string UserSearch)
        {

            BrokerUsuarios ValidateUser = new BrokerUsuarios();
            return ValidateUser.ValidarUsuario(UserSearch);
        }

        internal List<KeyValuePair<int, string>> ObtenerFacultades()
        {
            BrokerUsuarios broker = new BrokerUsuarios();
            return broker.ObtenerFacultades();
        }

        internal List<KeyValuePair<int, string>> ObtenerCarrerasPorFacultad(int id_Facultad)
        {
            BrokerUsuarios broker = new BrokerUsuarios();
            return broker.ObtenerCarrerasPorFacultad(id_Facultad);
        }

        internal List<KeyValuePair<int, string>> ObtenerPensumsPorCarrera(int id_Facultad)
        {
            BrokerUsuarios broker = new BrokerUsuarios();
            return broker.ObtenerPensumsPorCarrera(id_Facultad);
        }

    }
}
