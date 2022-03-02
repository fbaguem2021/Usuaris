using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuaris.Models
{
    public static class SeguretatBd
    {
        public static DataTable select()
        {
            SqlCommand sentencia = new SqlCommand();
            SqlDataReader dades;
            DataTable llista = new DataTable();

            sentencia.Connection = Bd.connection;
            sentencia.CommandText = "select (id) from usuaris where id=8";

            Bd.connection.Open();

            dades = sentencia.ExecuteReader();
            llista.Load(dades);

            Bd.connection.Close();

            
            return llista;
        }

        public static Usuari[] select_users()
        {
            SqlCommand sentencia = new SqlCommand();
            SqlDataReader dades;
            DataTable llista = new DataTable();

            sentencia.Connection = Bd.connection;
            sentencia.CommandText = "select usuaris.*, rols.nom from usuaris join rols on rols.id = usuaris.rols_id";

            Bd.connection.Open();

            dades = sentencia.ExecuteReader();
            llista.Load(dades);

            Bd.connection.Close();

            Usuari[] usersList = new Usuari[llista.Rows.Count];
            for (int i = 0; i < usersList.Length; i++)
            {
                Object[] contenido = Array.ConvertAll(llista.Rows[i].ItemArray, x => x);
                usersList[i] = new Usuari();
                usersList[i].id = (int) contenido[0];
                usersList[i].correu = contenido[1].ToString();
                usersList[i].nom = contenido[2].ToString();
                usersList[i].cognoms = contenido[3].ToString();
                usersList[i].contrasenya = contenido[4].ToString();
                usersList[i].actiu = (bool) contenido[5];
                usersList[i].rols_id = (int) contenido[6];
                usersList[i].rol = contenido[7].ToString();
            }

            return usersList;
        }


        public static Rol[] select_rols()
        {
            SqlCommand sentencia = new SqlCommand();
            SqlDataReader dades;
            DataTable llista = new DataTable();

            sentencia.Connection = Bd.connection;
            sentencia.CommandText = "select *from rols";

            Bd.connection.Open();

            dades = sentencia.ExecuteReader();
            llista.Load(dades);

            Bd.connection.Close();

            Rol[] rolsList = new Rol[llista.Rows.Count];
            for (int i = 0; i < rolsList.Length; i++)
            {
                Object[] contenido = Array.ConvertAll(llista.Rows[i].ItemArray, x => x);
                rolsList[i] = new Rol();
                rolsList[i].id = (int)contenido[0];
                rolsList[i].nom = contenido[1].ToString();
                rolsList[i].actiu = (bool)contenido[2];
            }

            return rolsList;
        }

        public static void insertat_usuari(Usuari user)
        {
            SqlCommand sentencia = new SqlCommand();
            String
                correu = user.correu,
                nom = user.nom,
                cognoms = user.cognoms,
                contrasenya = user.contrasenya;
            bool actiu = user.actiu;
            int rols_id = user.rols_id;

            sentencia.Connection = Bd.connection;
            sentencia.CommandText =
                "insert into usuaris (correu, nom, cognoms, contrasenya, actiu, rols_id) values (@correu, @nom, @cognoms, @contrasenya, @actiu, @rols_id)";
            sentencia.Parameters.Clear();
            sentencia.Parameters.AddWithValue("correu", correu);
            sentencia.Parameters.AddWithValue("nom", nom);
            sentencia.Parameters.AddWithValue("cognoms", cognoms);
            sentencia.Parameters.AddWithValue("contrasenya", contrasenya);
            sentencia.Parameters.AddWithValue("actiu", actiu);
            sentencia.Parameters.AddWithValue("rols_id", rols_id);

            Bd.connection.Open();

            sentencia.ExecuteNonQuery();

            Bd.connection.Close();
        }

        public static void delete_user(int id)
        {
            SqlCommand sentencia = new SqlCommand();
            int ID = id;

            sentencia.Connection = Bd.connection;
            sentencia.CommandText =
                "delete from usuaris where id = @ID";
            sentencia.Parameters.Clear();
            sentencia.Parameters.AddWithValue("ID", ID);

            Bd.connection.Open();

            sentencia.ExecuteNonQuery();

            Bd.connection.Close();
        }

        public static void cargarListaUsuarios(Usuari[] usuarios)
        {
            FormInici.listaUsuarios = usuarios.ToList<Usuari>();
        }
    }
}
