using EAFIT_BaseDeDatos.Core.EAFIT_ENTITIES;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace EAFIT_BaseDeDatos.Core.EAFIT_BROKER
{
    class BrokerUsuarios
    {

        MySqlConnection Connection;
        BrokerConnection InsConnection = new BrokerConnection();
        /// <summary>
        /// Metodo que inserta un usuario en la base de datos 
        /// </summary> 
        /// <returns></returns>
        internal (bool, string) InsertarUsuario(Dictionary<string, string> ValuesInsert)
        {
            try
            {
                Connection = InsConnection.OpenConnection();

                MySqlCommand cmd = new MySqlCommand("InsertarPersona", Connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("p_Tipo_Documento", ValuesInsert["Tipo_Documento"]);
                cmd.Parameters.AddWithValue("p_Numero_Documento", ValuesInsert["Numero_Documento"]);
                cmd.Parameters.AddWithValue("p_Nombres", ValuesInsert["Nombres"]);
                cmd.Parameters.AddWithValue("p_Apellidos", ValuesInsert["Apellidos"]);
                cmd.Parameters.AddWithValue("p_Email", ValuesInsert["Email"]);
                cmd.Parameters.AddWithValue("p_Telefono", ValuesInsert["Telefono"]);
                cmd.Parameters.AddWithValue("p_Direccion", ValuesInsert["Direccion"]);
                cmd.Parameters.AddWithValue("p_Fecha_Nacimiento", ValuesInsert["Fecha_Nacimiento"]);
                cmd.Parameters.AddWithValue("p_Genero", ValuesInsert["Genero"]);
                cmd.Parameters.AddWithValue("p_Fecha_Vinculacion", ValuesInsert["Fecha_Vinculacion"]);
                cmd.Parameters.AddWithValue("p_Cargo", ValuesInsert["Cargo"]);
                cmd.Parameters.AddWithValue("p_Salario", ValuesInsert["Salario"]);
                cmd.Parameters.AddWithValue("p_Semestre", ValuesInsert["Semestre"]);
                cmd.Parameters.AddWithValue("p_Carrera_Id", ValuesInsert["Carrera_Id"]);
                cmd.Parameters.AddWithValue("p_Pensum_Id", ValuesInsert["Pensum_Id"]);
                cmd.Parameters.AddWithValue("p_Estado", ValuesInsert["Estado"]);

                // Parámetro OUT
                MySqlParameter newIdParam = new MySqlParameter("p_NuevoId", MySqlDbType.Int32);
                newIdParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(newIdParam);

                cmd.ExecuteNonQuery();

                int nuevoId = Convert.ToInt32(newIdParam.Value);

                return (true, nuevoId.ToString());
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
            finally
            {
                InsConnection.CloseConnection(Connection);
            }
        }


        /// <summary>
        /// metodo para consultar la información con el nombre de usuario
        /// </summary>
        /// <param name="UserSearch"></param>
        /// <returns></returns>
        internal Dictionary<string, string> ValidarUsuario(string UserSearch)
        {
            Connection = InsConnection.OpenConnection();
            try
            {
                using var transacLogeo = Connection.CreateCommand();
                String Comando = "Select P.id_persona, P.tipo_documento, P.numero_documento, P.nombres, P.apellidos, P.email, P.telefono, P.direccion, P.fecha_nacimiento" +
                                ", P.genero, P.fecha_vinculacion, P.salario, P.semestre, C.nombre_carrera, Pm.nombre_pensum, Es.nombre_estado, F.nombre_facultad, P.cargo" +
                                 " From Personas P " +
                                 " Inner Join carreras C on P.carrera_id_carrera=C.id_carrera " +
                                 " Inner Join pensums Pm on P.pensum_id_pensum=Pm.id_pensum " +
                                 " Inner Join estados Es on P.estados_id_estado=Es.id_estado " +
                                 " Inner Join facultades F on C.facultad_id_facultad=F.id_facultad " +
                                 " Where P.id_persona=@id;";
                transacLogeo.CommandText = String.Format(Comando);
                transacLogeo.Parameters.AddWithValue("@id", UserSearch);
                using var ResultLogin = transacLogeo.ExecuteReader();
                if (!ResultLogin.HasRows)
                {
                    return null; // NO encontrado -> devolvemos null
                }

                var ReturnLogin = new Dictionary<string, string>();
                if (ResultLogin.Read())
                {
                    ReturnLogin.Add("Id", ResultLogin[0].ToString());
                    ReturnLogin.Add("Tipo_Documento", ResultLogin[1].ToString());
                    ReturnLogin.Add("Numero_Documento", ResultLogin[2].ToString());
                    ReturnLogin.Add("Nombres", ResultLogin[3].ToString());
                    ReturnLogin.Add("Apellidos", ResultLogin[4].ToString());
                    ReturnLogin.Add("Email", ResultLogin[5].ToString());
                    ReturnLogin.Add("Telefono", ResultLogin[6].ToString());
                    ReturnLogin.Add("Direccion", ResultLogin[7].ToString());
                    ReturnLogin.Add("Fecha_Nacimiento", Convert.ToDateTime(ResultLogin[8]).ToString("yyyy-MM-dd"));
                    ReturnLogin.Add("Genero", ResultLogin[9].ToString());
                    ReturnLogin.Add("Fecha_Vinculacion", Convert.ToDateTime(ResultLogin[10]).ToString("yyyy-MM-dd"));
                    ReturnLogin.Add("Salario", ResultLogin[11].ToString().Replace(",","."));
                    ReturnLogin.Add("Semestre", ResultLogin[12].ToString());
                    ReturnLogin.Add("Nombre_Carrera", ResultLogin[13].ToString());
                    ReturnLogin.Add("Nombre_Pensum", ResultLogin[14].ToString());
                    ReturnLogin.Add("Nombre_Estado", ResultLogin[15].ToString());
                    ReturnLogin.Add("Nombre_Facultad", ResultLogin[16].ToString());
                    ReturnLogin.Add("Cargo", ResultLogin[17].ToString());
                }
                return ReturnLogin;
            }
            finally
            {
                InsConnection.CloseConnection(Connection);
            }
        }


        /// <summary>
        /// Metodo que actualiza un usuario en la base de datos 
        /// </summary> 
        /// <returns></returns>
        internal bool ActualizarUsuario(Dictionary<string, string> ValuesUsuario)
        {
            Connection = InsConnection.OpenConnection();

            using (MySqlCommand cmd = new MySqlCommand("ActualizarUsuario", Connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("p_id_persona", ValuesUsuario["Id"]);
                cmd.Parameters.AddWithValue("p_tipo_documento", ValuesUsuario["Tipo_Documento"]);
                cmd.Parameters.AddWithValue("p_numero_documento", ValuesUsuario["Numero_Documento"]);
                cmd.Parameters.AddWithValue("p_nombres", ValuesUsuario["Nombres"]);
                cmd.Parameters.AddWithValue("p_apellidos", ValuesUsuario["Apellidos"]);
                cmd.Parameters.AddWithValue("p_email", ValuesUsuario["Email"]);
                cmd.Parameters.AddWithValue("p_telefono", ValuesUsuario["Telefono"]);
                cmd.Parameters.AddWithValue("p_direccion", ValuesUsuario["Direccion"]);
                cmd.Parameters.AddWithValue("p_fecha_nacimiento", ValuesUsuario["Fecha_Nacimiento"]);
                cmd.Parameters.AddWithValue("p_genero", ValuesUsuario["Genero"]);
                cmd.Parameters.AddWithValue("p_fecha_vinculacion", ValuesUsuario["Fecha_Vinculacion"]);
                cmd.Parameters.AddWithValue("p_cargo", ValuesUsuario["Cargo"]);
                cmd.Parameters.AddWithValue("p_salario", ValuesUsuario["Salario"]);
                cmd.Parameters.AddWithValue("p_semestre", ValuesUsuario["Semestre"]);
                cmd.Parameters.AddWithValue("p_carrera_id", ValuesUsuario["Carrera_Id"]);
                cmd.Parameters.AddWithValue("p_pensum_id", ValuesUsuario["Pensum_Id"]);
                cmd.Parameters.AddWithValue("p_estado", ValuesUsuario["Estado"]);

                object result = cmd.ExecuteScalar();

                // Procedure regresa 0 o 1 (filas afectadas)
                int rows = (result != null) ? Convert.ToInt32(result) : 0;

                return rows >= 0;
            }
        }


        /// <summary>
        /// Metodo que inactiva un usuario en la base de datos 
        /// </summary> 
        /// <returns></returns>
        internal bool InactivarUsuario(string UserInactivate)
        {
            Connection = InsConnection.OpenConnection();
            MySqlCommand transacInactivate = new MySqlCommand();
            transacInactivate.CommandText = string.Format("update personas set estados_id_estado=2  where id_persona={0};", UserInactivate);
            transacInactivate.Connection = Connection;
            int ResultInactivate = transacInactivate.ExecuteNonQuery();
            InsConnection.CloseConnection(Connection);
            if (ResultInactivate > 0)
                return true;
            else
                return false;
        }

        internal bool ActivarUsuario(string UserActivate)
        {
            Connection = InsConnection.OpenConnection();
            MySqlCommand transacActivate = new MySqlCommand();
            transacActivate.CommandText = string.Format("update personas set estados_id_estado=1  where id_persona={0};", UserActivate);
            transacActivate.Connection = Connection;
            int ResultActivate = transacActivate.ExecuteNonQuery();
            InsConnection.CloseConnection(Connection);
            if (ResultActivate > 0)
                return true;
            else
                return false;
        }

        internal List<KeyValuePair<int, string>> ObtenerFacultades()
        {
            Connection = InsConnection.OpenConnection();
            var facultades = new List<KeyValuePair<int, string>>();
            try
            {
                using var command = Connection.CreateCommand();
                command.CommandText = "SELECT id_facultad, nombre_facultad FROM facultades ORDER BY nombre_facultad;";
                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    facultades.Add(new KeyValuePair<int, string>(
                        Convert.ToInt32(reader["id_facultad"]),
                        reader["nombre_facultad"].ToString()
                        ));
                }
            }
            finally
            {
                InsConnection.CloseConnection(Connection);
            }
            return facultades;
        }

        internal List<KeyValuePair<int, string>> ObtenerCarrerasPorFacultad(int idFacultad)
        {
            Connection = InsConnection.OpenConnection();
            var carreras = new List<KeyValuePair<int, string>>();
            try
            {
                using var command = Connection.CreateCommand();
                command.CommandText = "SELECT id_carrera, nombre_carrera FROM carreras WHERE facultad_id_facultad = @idFacultad ORDER BY nombre_carrera;";
                command.Parameters.AddWithValue("@idFacultad", idFacultad);
                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    carreras.Add(new KeyValuePair<int, string>(
                        Convert.ToInt32(reader["id_carrera"]),
                        reader["nombre_carrera"].ToString()
                        ));
                }
            }
            finally
            {
                InsConnection.CloseConnection(Connection);
            }
            return carreras;

        }

        internal List<KeyValuePair<int, string>> ObtenerPensumsPorCarrera(int idCarrera)
        {
            Connection = InsConnection.OpenConnection();
            var pensums = new List<KeyValuePair<int, string>>();
            try
            {
                using var command = Connection.CreateCommand();
                command.CommandText = @"SELECT id_pensum, nombre_pensum 
                               FROM pensums 
                               WHERE carrera_id_carrera = @idCarrera 
                               ORDER BY nombre_pensum;";
                command.Parameters.AddWithValue("@idCarrera", idCarrera);

                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    pensums.Add(new KeyValuePair<int, string>(
                        Convert.ToInt32(reader["id_pensum"]),
                        reader["nombre_pensum"].ToString()
                    ));
                }
            }
            finally
            {
                InsConnection.CloseConnection(Connection);
            }
            return pensums;
        }
    }
}
