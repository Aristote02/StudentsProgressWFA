using Microsoft.Data.SqlClient;
using StudentsProgressWFA.Entities;

namespace StudentsProgressWFA.Repositories
{
    public class FacultyRepository
    {
        private string connectionString = "Server=DESKTOP-K1G3SS3\\SQLEXPRESS;Database=StudentProgressdb;Trusted_Connection=True;Encrypt=false;";
        private SqlConnection Connection { get; set; }
        public FacultyRepository()
        {
            Connection = new SqlConnection(connectionString);
        }

        public void Connect()
        {
            try
            {
                Connection.Open();
            }
            catch { throw; }
        }
        public void Close()
        {
            try
            {
                Connection.Close();
            }
            catch { throw; }
        }

        public List<Faculty> GetFaculties()
        {
            List<Faculty> faculties = new List<Faculty>();
            Connect();
            string request = "Select * from Faculty";
            SqlCommand command = new SqlCommand(request, Connection);
            var result = command.ExecuteReader();

            if (result.HasRows)
            {
                while (result.Read())
                {
                    Faculty faculty = new Faculty();
                    faculty.id = int.Parse(result.GetValue(0).ToString());
                    faculty.name = result.GetValue(1).ToString();
                    faculties.Add(faculty);
                }
            }
            Close();
            return faculties;
        }
        public void InsertFac(Faculty faculty)
        {
            Connect();
            string request = "Insert into Faculty(name)values(@name)";
            SqlCommand command = new SqlCommand(request, Connection);
            command.Parameters.AddWithValue("@name", faculty.name);
            command.ExecuteNonQuery();
            Close();
        }
        public void UpdateFac(Faculty faculty)
        {
            Connect();
            string request = "Update Faculty set name = @name where id = @id";
            SqlCommand command = new SqlCommand(request, Connection);
            command.Parameters.AddWithValue("@id", faculty.id);
            command.Parameters.AddWithValue("@name", faculty.name);
            command.ExecuteNonQuery();
            Close();
        }

        public void DeleteFac(int id)
        {
            Connect();
            string request = "Delete from Faculty where id = @id";
            SqlCommand command = new SqlCommand(request, Connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            Close();
        }
    }
}
