using appEstudiantes.bean;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appEstudiantes.clsBD
{
    class daoCursos
    {
        public static DataTable listar()
        {
            try
            {
                clsBD clsbd = new clsBD();
                string sql = "EXECUTE SP_FUSION";
                SqlCommand cmd = new SqlCommand(sql, clsbd.conectar());
                SqlDataReader dtr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable dt = new DataTable();
                dt.Load(dtr);

                clsbd.desconectar();

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static cursos buscar(int id)
        {
            try
            {
                clsBD clsbd = new clsBD();
                string sql = "select*from Estudiantes_cursos where idEstudiantes=" + id + ";";
                SqlCommand cmd = new SqlCommand(sql, clsbd.conectar());
                SqlDataReader dtr = cmd.ExecuteReader();
                cursos cur = new cursos();
                if (dtr.Read())
                {
                    cur.IdEstudiante = int.Parse(dtr["idEstudiantes"].ToString());
                    cur.Matematicas1 = int.Parse(dtr["Matematicas"].ToString());
                    cur.Comunicacion1 = int.Parse(dtr["Comunicacion"].ToString());
                    cur.Religion1 = int.Parse(dtr["Religion"].ToString());
                    cur.Historia1 = int.Parse(dtr["Historia"].ToString());
                    cur.Ciencias1 = int.Parse(dtr["Ciencias"].ToString());
                    cur.Civica1 = int.Parse(dtr["Civica"].ToString());
                    cur.Psicologia1 = int.Parse(dtr["Psicologia"].ToString());
                    cur.Total1 = int.Parse(dtr["totalPorcentaje"].ToString());
                    cur.Observaciones1 = dtr["Observaciones"].ToString();

                    clsbd.desconectar();
                    return cur;
                }
                else
                {
                    clsbd.desconectar();
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static bool Actualizar(cursos cur)
        {
            try
            {
                clsBD clsbd = new clsBD();
                string sql = "update Estudiantes_cursos SET Matematicas=" + cur.Matematicas1 + ",Comunicacion=" + cur.Comunicacion1 + ",Religion=" + cur.Religion1 + ",Historia=" + cur.Historia1 + ",Ciencias=" + cur.Ciencias1 + ",Civica=" + cur.Civica1 + ",Psicologia=" + cur.Psicologia1 + ",totalPorcentaje=" + cur.Total1 + ",Observaciones='" + cur.Observaciones1 + "' where idEstudiantes=" + cur.IdEstudiante + "";
                SqlCommand cmd = new SqlCommand(sql, clsbd.conectar());
                int cantidad = cmd.ExecuteNonQuery();
                if (cantidad == 1)
                {
                    clsbd.desconectar();
                    return true;
                }
                else
                {
                    clsbd.desconectar();
                    return false;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
