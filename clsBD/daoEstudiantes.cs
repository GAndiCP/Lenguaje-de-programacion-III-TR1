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
    class daoEstudiantes
    {
        public static bool guardar(estudiantes  es)
        {
            try
            {
                clsBD clsbd=new clsBD();
                string sql= "insert Estudiantes values ('"+es.Pnombre1+"','" + es.Snombre1+"','" + es.Papellido1+"','" + es.Sapellido1+"','" + es.Telefono1+"','" + es.Celular1+"','" + es.Direccion1+"','" + es.Email1+"','" + es.Fnacimiento1+"')";
                SqlCommand cmd = new SqlCommand(sql,clsbd.conectar());
                int cantidad=cmd.ExecuteNonQuery();
                if(cantidad==1)
                {
                    return true;
                }
                else
                    return false;

                clsbd.desconectar();
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static DataTable listar()
        {
            try
            {
                clsBD clsbd = new clsBD();
                string sql = "select*from Estudiantes";
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
        public static estudiantes buscar(string nombre)
        {
            try
            {
                clsBD clsbd = new clsBD();
                string sql = "select*from Estudiantes where Pnombre='"+nombre+"';";
                SqlCommand cmd = new SqlCommand(sql, clsbd.conectar());
                SqlDataReader dtr = cmd.ExecuteReader();
                estudiantes est=new estudiantes();
                if(dtr.Read())
                {
                    est.Id = int.Parse(dtr["id"].ToString());
                    est.Pnombre1 = dtr["Pnombre"].ToString();
                    est.Snombre1=dtr["Snombre"].ToString() ;
                    est.Papellido1 = dtr["Papellido"].ToString();
                    est.Sapellido1 = dtr["Sapellido"].ToString();
                    est.Telefono1 = dtr["Telefono"].ToString();
                    est.Celular1 = dtr["Celular"].ToString();
                    est.Direccion1 = dtr["Direccion"].ToString();
                    est.Email1 = dtr["Email"].ToString();
                    est.Fnacimiento1 = dtr["Fnacimiento"].ToString();

                    clsbd.desconectar();
                    return est;
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
        public static bool Actualizar(estudiantes es)
        {
            try
            {
                clsBD clsbd = new clsBD();
                string sql = "update Estudiantes SET Pnombre='" + es.Pnombre1 + "',Snombre='" + es.Snombre1 + "',Papellido='" + es.Papellido1 + "',Sapellido='" + es.Sapellido1 + "',Telefono='" + es.Telefono1 + "',Celular='" + es.Celular1 + "',Direccion='" + es.Direccion1 + "',Email='" + es.Email1 + "',Fnacimiento='" + es.Fnacimiento1 + "' where id="+es.Id+"";
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
        public static bool Eliminar(int id)
        {
            try
            {
                clsBD clsbd = new clsBD();
                string sql = "delete from Estudiantes where id='"+id+"'";
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
