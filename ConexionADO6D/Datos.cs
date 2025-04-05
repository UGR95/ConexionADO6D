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
        private string Connexionstring = "Data Source = DESKTOP-7789AN9\\SQLEXPRESS; Initial Catalog = pubs6d; integrated security = true;";

        public DataTable Refrescar(string Estado)
        {
            //string Query = "Select * from vwAutores with(nolock)";
            DataTable dt = new DataTable();

            SqlConnection con = new SqlConnection(Connexionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("sprConsultarAutores", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Estado", Estado);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                dt.Load(reader);
            }

            con.Close();
            return dt;

        }

        public DataTable CargarEstados()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = new SqlConnection(Connexionstring);
                con.Open();
                SqlCommand cmd = new SqlCommand("sprObtenerEstados", con);
                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }

                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable Filtro(string Filtro)
        {
            DataTable dt = new DataTable();
            try
            {
                ////string QueryFiltro = "SELECT * FROM Authors WITH(NOLOCK) WHERE au_Fname like '%" + Filtro + "%'";

                SqlConnection con = new SqlConnection(Connexionstring);
                con.Open();

                SqlCommand cmd = new SqlCommand("sprConsultarAutoresFiltro", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", Filtro);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                }    

                con.Close();
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public string AgregarAutor(string id, string Nombre, string Apellido, string Telefono, string Direccion, string Ciudad, string Estado, int CodigoPostal, bool Contrato)
        {
            try
            {
                int cont = Contrato == true ? 1 : 0;
                /*string QueryAgregar = "INSERT INTO Authors VALUES (" +
                    "'" + id + "'," +
                    "'" + Apellido + "'," +
                    "'" + Nombre + "'," +
                    "'" + Telefono + "'," +
                    "'" + Direccion + "'," +
                    "'" + Ciudad + "'," +
                    "'" + Estado + "'," +
                    "" + CodigoPostal + "," +
                    "" + cont + ")";
                */


                SqlConnection con = new SqlConnection(Connexionstring);
                con.Open();
                SqlCommand cmd = new SqlCommand("spi_AgregarAutor", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@Apellido",Apellido);
                cmd.Parameters.AddWithValue("@Telefono",Telefono);
                cmd.Parameters.AddWithValue("@Direccion",Direccion);
                cmd.Parameters.AddWithValue("@Ciudad",Ciudad);
                cmd.Parameters.AddWithValue("@Estado",Estado);
                cmd.Parameters.AddWithValue("@CodigoPostal",CodigoPostal);
                cmd.Parameters.AddWithValue("@Contrato",cont);

                cmd.ExecuteNonQuery();

                con.Close();

                return null;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public string EliminarAutor(string id)
        {
            try
            {
                #region Query
                string QueryAgregar = "DELETE FROM Authors WHERE au_id = '" + id + "'";
                #endregion

                SqlConnection con = new SqlConnection(Connexionstring);
                con.Open();
                SqlCommand cmd = new SqlCommand("spdEliminarAutor", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);

                // Declarar parámetro de salida si ocurre algún error
                SqlParameter paramError = new SqlParameter("@Error", SqlDbType.VarChar, 100);
                paramError.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(paramError);

                cmd.ExecuteNonQuery();

                con.Close();

                return paramError.Value.ToString();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string ModificarAutor(string id, string Nombre, string Apellido, string Telefono, string Direccion, string Ciudad, string Estado, int CodigoPostal, bool Contrato)
        {
            try
            {
                #region Query
                //int cont = Contrato == true ? 1 : 0;
                //string QueryAgregar = "UPDATE Authors" +
                //    " SET au_lname = '" + Apellido + "'," +
                //    "au_fname = '" + Nombre + "'," +
                //    "phone = '" + Telefono + "'," +
                //    "address ='" + Direccion + "'," +
                //    "city = '" + Ciudad + "'," +
                //    "state = '" + Estado + "'," +
                //    "zip = " + CodigoPostal + "," +
                //    "contract = " + cont +
                //    "WHERE au_id = '" + id + "'";
                #endregion

                string Error = null;

                SqlConnection con = new SqlConnection(Connexionstring);
                con.Open();
                SqlCommand cmd = new SqlCommand("spuActualizarAutor", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@Apellido", Apellido);
                cmd.Parameters.AddWithValue("@Telefono", Telefono);
                cmd.Parameters.AddWithValue("@Direccion", Direccion);
                cmd.Parameters.AddWithValue("@Ciudad", Direccion);
                cmd.Parameters.AddWithValue("@Estado", Estado);
                cmd.Parameters.AddWithValue("@CodigoPostal", CodigoPostal);
                cmd.Parameters.AddWithValue("@Contrato", Contrato);

                // Declarar parámetro de salida si ocurre algún error
                SqlParameter paramError = new SqlParameter("@Error", SqlDbType.VarChar, 100);
                paramError.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(paramError);

                cmd.ExecuteNonQuery();

                con.Close();

                return Error = paramError.Value.ToString();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
