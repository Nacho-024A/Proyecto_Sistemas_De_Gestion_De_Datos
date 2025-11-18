using EAFIT_BaseDeDatos.Core.EAFIT_BROKER;
using EAFIT_BaseDeDatos.Core.EAFIT_ENTITIES;
using EAFIT_BaseDeDatos.Core.EAFIT_MANAGER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EAFIT_BaseDeDatos.Core.EAFIT_FACADE
{
    public class FacadeUsuarios
    {
        public (bool, string) InsertarUsuario(Dictionary<string, string> ValuesUsuario)
        {
            ManagerUsuarios manager = new ManagerUsuarios();
            return manager.InsertarUsuario(ValuesUsuario);
        }
        public bool ActualizarUsuario(Dictionary<string, string> ValuesUsuario)
        {
            EAFIT_MANAGER.ManagerUsuarios InsertUser = new EAFIT_MANAGER.ManagerUsuarios();
            return InsertUser.ActualizarUsuario(ValuesUsuario);

        }
        public bool InactivarUsuario(string ValuesUsuario)
        {
            EAFIT_MANAGER.ManagerUsuarios InsertUser = new EAFIT_MANAGER.ManagerUsuarios();
            return InsertUser.InactivarUsuario(ValuesUsuario);

        }

        public bool ActivarUsuario(string ValuesUsuario)
        {
            EAFIT_MANAGER.ManagerUsuarios InsertUser = new EAFIT_MANAGER.ManagerUsuarios();
            return InsertUser.ActivarUsuario(ValuesUsuario);
        }

        public Dictionary<string, string> ValidarUsuario(string UserSearch)
        {

            ManagerUsuarios ValidateUser = new ManagerUsuarios();
            return ValidateUser.ValidarUsuario(UserSearch);
        }

        public List<KeyValuePair<int, string>> ObtenerFacultades()
        {
            ManagerUsuarios InstManager = new ManagerUsuarios();
            return InstManager.ObtenerFacultades();
        }

        public List<KeyValuePair<int, string>> ObtenerCarreras(int idFacultad)
        {
            ManagerUsuarios InstManager = new ManagerUsuarios();
            return InstManager.ObtenerCarrerasPorFacultad(idFacultad);
        }

        public List<KeyValuePair<int, string>> ObtenerPensums(int idFacultad)
        {
            ManagerUsuarios InstManager = new ManagerUsuarios();
            return InstManager.ObtenerPensumsPorCarrera(idFacultad);
        }

    }
}
