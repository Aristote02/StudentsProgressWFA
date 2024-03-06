using Microsoft.Data.SqlClient;
using StudentsProgressWFA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsProgressWFA.Repositories
{
    public class SpecialtyRepository
    {
        private string connectionString = "Server=DESKTOP-K1G3SS3\\SQLEXPRESS;Database=StudentProgressdb;Trusted_Connection=True;Encrypt=False; ";
        private SqlConnection Connection { get; set; }
        public SpecialtyRepository()
        {
            Connection = new SqlConnection(connectionString);
        }
        private void Connect()
        {
            try
            {
                Connection.Open();
            }
            catch { throw; }
        }
        private void Close()
        {
            try
            {
                Connection.Close();
            }
            catch { throw; }
        }

        public List<Specialty> GetSpecialties()
        {
            List<Specialty> specialties = new List<Specialty>();
            Connect();
            string request = "Select *from Specialty";
            SqlCommand command = new SqlCommand(request, Connection);
            var result = command.ExecuteReader();

            if (result.HasRows)
            {
                while (result.Read())
                {
                    Specialty specialty = new Specialty();
                    specialty.id = int.Parse(result.GetValue(0).ToString());
                    specialty.name = result.GetValue(1).ToString();
                    specialties.Add(specialty);
                }
            }
            Close();
            return specialties;
        }
        public void InsertSpec(Specialty specialty)
        {
            Connect();
            string request = "insert into Specialty(name)values(@name)";
            SqlCommand command = new SqlCommand(request, Connection);
            command.Parameters.AddWithValue("@name", specialty.name);
            command.ExecuteNonQuery();
            Close();
        }
        public void UpdateSpec(Specialty specialty)
        {
            Connect();
            string request = "update Specialty set name = @name where id=@id ";
            SqlCommand command = new SqlCommand(request, Connection);
            command.Parameters.AddWithValue("@id", specialty.id);
            command.Parameters.AddWithValue("@name", specialty.name);
            command.ExecuteNonQuery();
            Close();
        }
        public void DeleteSpec(int id)
        {
            Connect();
            string request = "Delete from Specialty where id=@id";
            SqlCommand command = new SqlCommand(request, Connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            Close();
        }
    }
}
