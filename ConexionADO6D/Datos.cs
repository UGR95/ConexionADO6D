using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConexionADO6D
{
    internal class Datos
    {
        private string conexionBD = "Data Source = DESKTOP-7789AN9\\SQLEXPRESS; Initial Catalog = pubs6d; integrated security = true;";

        public DataTable TablaAutor()
        {

            try
            {
                string Query = "Select * from Authors with(nolock)";
                DataTable dt = new DataTable();


                SqlConnection con = new SqlConnection(conexionBD);
                con.Open();

                SqlCommand comand = new SqlCommand(Query, con);

                SqlDataReader dr = comand.ExecuteReader();

                dt.Load(dr);

                con.Close();

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable FiltroAutor(string Filtro)
        {
            DataTable dt = new DataTable();
            try
            {
                string QueryFiltro = "SELECT * FROM Authors WITH(NOLOCK) WHERE au_Fname like '%" + Filtro + "%'";

                SqlConnection con = new SqlConnection(conexionBD);

                con.Open();

                SqlDataAdapter da = new SqlDataAdapter(QueryFiltro, con);

                da.Fill(dt);

                con.Close();

                return dt;
            }
            catch (Exception)
            {
                return dt;
            }
        }

        public string AgregarAutor(string id, string Nombre, string Apellido, string Telefono, string Direccion, string Ciudad, string Estado, int CodigoPostal, bool contrato)
        {
            int contrto = contrato == true ? 1 : 0;
            try
            {
                string QueryAgregar = "INSERT INTO Authors VALUES " +
                    "('" + id + "'," +
                    "'" + Apellido + "'," +
                    "'" + Nombre + "'," +
                    "'" + Telefono + "'," +
                    "'" + Direccion + "'," +
                    "'" + Ciudad + "'," +
                    "'" + Estado + "'," +
                    "'" + CodigoPostal + "'," +
                    "" + contrto + ")";

                SqlConnection con = new SqlConnection(conexionBD);

                con.Open();

                SqlCommand cmd = new SqlCommand(QueryAgregar, con);

                cmd.ExecuteNonQuery();

                con.Close();

                return null;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public string ModificarAutor(string id, string Nombre, string Apellido, string Telefono, string Direccion, string Ciudad, string Estado, int CodigoPostal, bool contrato)
        {
            int contrto = contrato == true ? 1 : 0;
            try
            {
                string QueryModificar = "UPDATE Authors SET " +
                    "au_lname = '" + Apellido + "'," +
                    "au_fname = '" + Nombre + "'," +
                    "phone = '" + Telefono + "'," +
                    "address = '" + Direccion + "'," +
                    "city = '" + Ciudad + "'," +
                    "state = '" + Estado + "'," +
                    "zip = '" + CodigoPostal + "'," +
                    "contract = " + contrto + 
                    "WHERE au_id = '"+ id + "'";

                SqlConnection con = new SqlConnection(conexionBD);

                con.Open();

                SqlCommand cmd = new SqlCommand(QueryModificar, con);

                cmd.ExecuteNonQuery();

                con.Close();

                return null;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public string EliminarAutor(string Id)
        {
            try
            {
                string QueryEliminar = "DELETE FROM Authors " +
                    "WHERE au_Id = '"+ Id +"'";

                SqlConnection con = new SqlConnection(conexionBD);
                con.Open();
                SqlCommand cmd = new SqlCommand(QueryEliminar, con);

                cmd.ExecuteNonQuery();

                con.Close();

                return null;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
