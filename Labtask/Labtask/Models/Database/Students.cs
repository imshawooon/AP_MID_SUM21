using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace Labtask.Models.Database
{
    public class Students
    {
        SqlConnection conn;

        public Students(SqlConnection conn)
        {
            this.conn = conn;
        }

        public void Insert(Student s)
        {
            string query = String.Format("Insert into student values ('{0}','{1}','{2}',{3},'{4}',{5})", s.Name, s.Id,s.DOB,s.Credit,s.CGPA,s.deptId);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public List<Student> GetAll()
        {
            List<Student> students = new List<Student>();
            string query = "select * from student";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                Student s = new Student()
                {
                    Name= reader.GetString(reader.GetOrdinal("Name")),
                    Id = reader.GetString(reader.GetOrdinal("Id")),
                    DOB = reader.GetString(reader.GetOrdinal("DOB")),
                    Credit = reader.GetInt32(reader.GetOrdinal("Credit")),
                    CGPA = reader.GetString(reader.GetOrdinal("CGPA")),
                    deptId = reader.GetInt32(reader.GetOrdinal("deptId")),

                };
                students.Add(s);


            }
            conn.Close();
            return students;

        }

       public Student Get(string Id)
        {
            Student s = null;
            string query = $"select * from student where id= '{Id}'";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                s = new Student()
                {
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Id = reader.GetString(reader.GetOrdinal("Id")),
                    DOB = reader.GetString(reader.GetOrdinal("DOB")),
                    Credit = reader.GetInt32(reader.GetOrdinal("Credit")),
                    CGPA = reader.GetString(reader.GetOrdinal("CGPA")),
                    deptId = reader.GetInt32(reader.GetOrdinal("deptId")),

                };
               
                


            }
            conn.Close();
            return s;


        }

        public void Update(Student s)
        {
            string query = $"Update student Set Name='{s.Name}', DOB='{s.DOB}' , Credit={s.Credit}, CGPA='{s.CGPA}', DeptId='{s.deptId}' Where Id = '{s.Id}'";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Delete(string s)
        {
            string query = $"Delete from student Where Id = '{s}'";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public Student LogIn(string s)
        {

            Student a = null;
            string query = $"select * from Admin where UserName= '{s}'";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                a = new Student()
                {
                    UserName = reader.GetString(reader.GetOrdinal("UserName")),
                    password = reader.GetString(reader.GetOrdinal("password")),
                    

                };




            }
            conn.Close();
            return a;


        }
    }
}