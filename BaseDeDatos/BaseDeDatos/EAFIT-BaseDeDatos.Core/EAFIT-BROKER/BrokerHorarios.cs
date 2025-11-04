using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace EAFIT_BaseDeDatos.Core.EAFIT_BROKER
{
    class BrokerHorarios
    {
        MySqlConnection Connection;
        BrokerConnection InsConnection = new BrokerConnection();

        /// <summary>
        /// Inserta un horario en la base de datos.
        /// </summary>
        internal bool InsertarHorario(Dictionary<string, string> ValuesHorario)
        {
            Connection = InsConnection.OpenConnection();

            string horaInicioStr = ValuesHorario.GetValueOrDefault("hora_inicio");
            string horaInicioMySQL = TimeOnly.TryParse(horaInicioStr, out var horaInicio1)
                ? horaInicio1.ToString("HH:mm:ss")
                : "00:00:00";

            string horaFinalStr = ValuesHorario.GetValueOrDefault("hora_final");
            string horaFinalMySQL = TimeOnly.TryParse(horaInicioStr, out var horaFinal1)
                ? horaFinal1.ToString("HH:mm:ss")
                : "00:00:00";

            
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = string.Format(
                "CALL InsertarHorario({0}, {1}, '{2}', '{3}', '{4}');",
                ValuesHorario.GetValueOrDefault("curso_id_curso"),
                ValuesHorario.GetValueOrDefault("salon_id_salon"),
                ValuesHorario.GetValueOrDefault("dia_semana"),
                horaInicioMySQL,
                horaFinalMySQL
            );
            cmd.Connection = Connection;
            int Result = cmd.ExecuteNonQuery();
            InsConnection.CloseConnection(Connection);
            return Result > 0;

        }

        /// <summary>
        /// Actualiza un horario existente.
        /// </summary>
        internal bool ActualizarHorario(Dictionary<string, string> ValuesHorario)
        {
            Connection = InsConnection.OpenConnection();
            string horaInicioStr = ValuesHorario.GetValueOrDefault("hora_inicio");
            string horaInicioMySQL = TimeOnly.TryParse(horaInicioStr, out var horaInicio1)
                ? horaInicio1.ToString("HH:mm:ss")
                : "00:00:00";

            string horaFinalStr = ValuesHorario.GetValueOrDefault("hora_final");
            string horaFinalMySQL = TimeOnly.TryParse(horaInicioStr, out var horaFinal1)
                ? horaFinal1.ToString("HH:mm:ss")
                : "00:00:00";

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = string.Format(
                "CALL ActualizarHorario({0}, {1}, {2}, '{3}', '{4}', '{5}');",
                ValuesHorario.GetValueOrDefault("id_horario"),
                ValuesHorario.GetValueOrDefault("curso_id_curso"),
                ValuesHorario.GetValueOrDefault("salon_id_salon"),
                ValuesHorario.GetValueOrDefault("dia_semana"),
               horaInicioMySQL,
                horaFinalMySQL
            );
            cmd.Connection = Connection;
            int Result = cmd.ExecuteNonQuery();
            InsConnection.CloseConnection(Connection);
            return Result > 0;
        }

        /// <summary>
        /// Elimina un horario por ID.
        /// </summary>
        internal bool EliminarHorario(int id_horario)
        {
            Connection = InsConnection.OpenConnection();
            MySqlCommand cmd = new MySqlCommand($"CALL EliminarHorario({id_horario});", Connection);
            int Result = cmd.ExecuteNonQuery();
            InsConnection.CloseConnection(Connection);
            return Result > 0;
        }

        /// <summary>
        /// Consulta un horario por ID.
        /// </summary>
        internal Dictionary<string, string> ConsultarHorario(int id_horario)
        {
            Connection = InsConnection.OpenConnection();
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM Horarios WHERE id_horario = {id_horario};", Connection);

            Dictionary<string, string> ReturnHorario = new Dictionary<string, string>();
            MySqlDataReader Result = cmd.ExecuteReader();

            if (Result.Read())
            {
                ReturnHorario.Add("id_horario", Result["id_horario"].ToString());
                ReturnHorario.Add("curso_id_curso", Result["curso_id_curso"].ToString());
                ReturnHorario.Add("salon_id_salon", Result["salon_id_salon"].ToString());
                ReturnHorario.Add("dia_semana", Result["dia_semana"].ToString());
                ReturnHorario.Add("hora_inicio", Result["hora_inicio"].ToString());
                ReturnHorario.Add("hora_fin", Result["hora_fin"].ToString());
            }

            InsConnection.CloseConnection(Connection);
            return ReturnHorario;
        }
    }
}
