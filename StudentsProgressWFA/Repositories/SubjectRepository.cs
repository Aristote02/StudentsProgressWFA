using Microsoft.Data.SqlClient;
using StudentsProgressWFA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsProgressWFA.Repositories
{
    public class SubjectRepository
    {
        private string ConnectionString = "Server=DESKTOP-K1G3SS3\\SQLEXPRESS;Database=StudentProgressdb;Trusted_Connection=True;Encrypt=false;";
        private SqlConnection Connection { get; set; }
        public SubjectRepository()
        {
            Connection = new SqlConnection(ConnectionString);
        }
        private void Connect()
        {
            try
            {
                Connection.Open();
            }
            catch
            {
                throw;
            }
        }
        private void Close()
        {
            try
            {
                Connection.Close();
            }
            catch
            {
                throw;
            }
        }
        public List<Subject> GetAllSubject()
        {
            List<Subject> subjects = new List<Subject>();
            Connect();
            string request = "Select * From Subject";
            SqlCommand command = new SqlCommand(request, Connection);
            var res = command.ExecuteReader();
            if (res.HasRows)
            {
                while (res.Read())
                {
                    Subject subject = new Subject();
                    subject.id = Convert.ToInt32(res.GetValue(0).ToString());
                    subject.name = res.GetValue(1).ToString();
                    subjects.Add(subject);
                }
            }

            Close();
            return subjects;
        }
        public void InsertSubject(Subject subject)
        {
            Connect();
            string request = "insert into Subject(name)values(@name)";
            SqlCommand command = new SqlCommand(request, Connection);
            command.Parameters.AddWithValue("@name", subject.name);
            command.ExecuteNonQuery();
            Close();
        }
        public void UpdateSubject(Subject subject)
        {
            Connect();
            string request = "Update Subject set name = @name where id = @id";
            SqlCommand command = new SqlCommand(request, Connection);
            command.Parameters.AddWithValue("@id", subject.id);
            command.Parameters.AddWithValue("@name", subject.name);
            command.ExecuteNonQuery();
            Close();
        }
        public void DeleteSubject(int id)
        {
            Connect();
            string request = " Delete from Subject where id=@id";
            SqlCommand command = new SqlCommand(request, Connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            Close();
        }
    }
}
