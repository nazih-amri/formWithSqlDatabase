using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace formWithSqlDatabase
{
    public class Connectdb
    {
        //string connection to the db
        static string chaine = @"Data Source=DESKTOP-3S9AFM5;Initial Catalog=app;Integrated Security=True";
        //starting connection
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        public static SqlDataReader reader;
        static SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
        /// <summary>
        /// class constructor
        /// </summary>
        public Connectdb()
        {
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        }
        /// <summary>
        /// method for adding a new student 
        /// </summary>
        /// <param name="b">combobox where the id will be added</param>
        /// <param name="name">name of the student</param>
        /// <param name="cin">identity the the student</param>
        /// <param name="age">student age</param>
        public static void add(ComboBox b, string name, string cin, int age)
        {
            
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "insert into Etudiant(name, cin, age) values('" + name + "','" + cin + "','" + age + "') ";
            cmd.ExecuteNonQuery();
            cnx.Close();


            //add the new id to the current ddl
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "select max(id) as id from etudiant order by id desc";
            cmd.ExecuteNonQuery();
            int last = (int)cmd.ExecuteScalar();
            b.Items.Add(last.ToString());
            b.Text = last.ToString();
            cnx.Close();

        }

        /// <summary>
        /// method that get the last id from the database and put it on the combobox last item
        /// </summary>
        /// <param name="b"></param>
        public static void lastId(ComboBox b)
        {
                       
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "select max(id) as id from etudiant order by id desc";
                cmd.ExecuteNonQuery();
                int last = (int)cmd.ExecuteScalar();
                b.Items.Add(last.ToString());
                b.Text = last.ToString();
                cnx.Close();

        }
        /// <summary>
        /// method for get the ids and insert them in the combo box
        /// </summary>
        /// <param name="b1">the combobox where the ids will be inserted</param>
        public static void ids(ComboBox b1)
        {

            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "select * from etudiant";
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                b1.Items.Add(reader["id"]);
            }
            cnx.Close();
        }
        /// <summary>
        /// method charger for getting all the data from the database and show them on the form's fileds
        /// </summary>
        /// <param name="b">combobox where the id is</param>
        /// <param name="p">the name of the student</param>
        /// <param name="n">the cin of the student</param>
        /// <param name="a">the age of the student</param>
        public static void charger(ComboBox b, TextBox p, TextBox n, TextBox a)
        {
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "select * from etudiant";

            //test methods

            DataTable dtids = new DataTable();

            adapter.Fill(dtids);

            foreach (DataRow row in dtids.Rows)
            {
                if (b.Text == row["id"].ToString())
                {
                    p.Text = row["name"].ToString();
                    n.Text = row["cin"].ToString();
                    a.Text = row["age"].ToString();

                }

            }
            cnx.Close();
        }
        /// <summary>
        /// method for modify all the infos of a student,after the modify the method will update the database with the new infos
        /// </summary>
        /// <param name="b">combobox where the id is</param>
        /// <param name="p">the new name</param>
        /// <param name="n">the new cin</param>
        /// <param name="a">the new age</param>
        public static void modify(ComboBox b, TextBox p, TextBox n, TextBox a)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "select * from etudiant";

            adapter = new SqlDataAdapter(cmd);
            DataTable dtids = new DataTable();

            adapter.Fill(dtids);
            foreach (DataRow row in dtids.Rows)
            {
                if (b.Text == row["id"].ToString())
                {
                    cmd.CommandText = "update etudiant set name='" + p.Text + "',cin='" + n.Text + "', age='" + int.Parse(a.Text) + "'where id='" + int.Parse(b.Text) + "' ";

                }

            }
            cmd.ExecuteNonQuery();
            adapter.Update(dtids);
            cnx.Close();
        }
        /// <summary>
        /// method for deleting a record or a row from database 
        /// </summary>
        /// <param name="b">combobox where we will choose the id that will be deleted</param>
        public static void supprimer(ComboBox b)
        {
            int id = int.Parse(b.Text);
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "delete from etudiant where id='" + id + "' ";
            cmd.ExecuteNonQuery();
            b.Items.Remove(b.SelectedItem);
            cnx.Close();
        }
    }
}
