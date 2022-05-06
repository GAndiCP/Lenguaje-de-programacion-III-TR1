using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appEstudiantes.clsBD
{
    class clsBD
    {
        SqlConnection con;
        public clsBD()
        {
            con = new SqlConnection("Server=LAPTOP-AV1A8FJV;Database=IE_Carlos_Morales_Chimbote;integrated security=true");
        }
        public SqlConnection conectar()
        {
           try
            {
                con.Open();
                return con;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public bool desconectar()
        {
            try
            {
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
