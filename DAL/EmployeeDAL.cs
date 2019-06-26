using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BOL;
namespace DAL
{
    public class EmployeeDAL
    {
        public static List<Employee> getAll()
        {
            List<Employee> e = new List<Employee>();
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Modular Project\cruds\mvc_front\App_Data\employee.mdf;Integrated Security=True";
            IDbConnection con = new SqlConnection(conString);
            string query = "select * from Emp";
            IDbCommand cmd = new SqlCommand(query, con as SqlConnection);
            try
            {
                con.Open();
                IDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int Id = int.Parse(reader["id"].ToString());
                    string name = reader["name"].ToString();
                    int age = int.Parse(reader["age"].ToString());

                    e.Add(new Employee() { Id = Id, Name = name, Age = age });
                }
            }
            catch (Exception f)
            {
                Console.WriteLine(f.StackTrace);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
                return e;
        }

    }
}
