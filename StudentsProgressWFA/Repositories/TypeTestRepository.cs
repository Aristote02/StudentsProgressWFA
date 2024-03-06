using Microsoft.Data.SqlClient;
using StudentsProgressWFA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsProgressWFA.Repositories
{
    public class TypeTestRepository
    {
        private string ConnectionString = "Server=DESKTOP-K1G3SS3\\SQLEXPRESS;Database=StudentProgressdb;Trusted_Connection=True;Encrypt=false;";
        private SqlConnection Connection { get; set; }
        public TypeTestRepository()
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
        public List<TypeTest> GetAllTypeOfTest()
        {
            List<TypeTest> typeTests = new List<TypeTest>();
            Connect();
            string request = "select *from Type_test";
            SqlCommand command = new SqlCommand(request, Connection);
            var result = command.ExecuteReader();

            if (result.HasRows)
            {
                while (result.Read())
                {
                    TypeTest typetest = new TypeTest();
                    typetest.Id = Convert.ToInt32(result.GetValue(0).ToString());
                    typetest.Name = result.GetValue(1).ToString();
                    typeTests.Add(typetest);
                }
            }
            Close();
            return typeTests;
        }
        public void InserValue(TypeTest typeTest)
        {
            Connect();
            string request = "insert into Type_test(Name)values(@name)";
            SqlCommand command = new SqlCommand(request, Connection);
            command.Parameters.AddWithValue("@name", typeTest.Name);
            command.ExecuteNonQuery();
            Close();

        }
        public void Update(TypeTest typeTest)
        {
            Connect();
            string request = "update Type_test set name =@name where id = @id";
            SqlCommand command = new SqlCommand(request, Connection);
            command.Parameters.AddWithValue("@id", typeTest.Id);
            command.Parameters.AddWithValue("@name", typeTest.Name);
            command.ExecuteNonQuery();
            Close();
        }
        public void DeleteTest(int id)
        {
            Connect();
            string request = "Delete from Type_test where id = @id";
            SqlCommand command = new SqlCommand(request, Connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            Close();
        }
    }
}
