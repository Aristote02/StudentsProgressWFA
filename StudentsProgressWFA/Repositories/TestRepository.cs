using Microsoft.Data.SqlClient;
using StudentsProgressWFA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsProgressWFA.Repositories
{
    public class TestRepository
    {
        private string connectionString = "Server=DESKTOP-K1G3SS3\\SQLEXPRESS;Database=StudentProgressdb;Trusted_Connection=True;Encrypt=false;";
        private SqlConnection Connection { get; set; }
        public TestRepository()
        {
            Connection = new SqlConnection(connectionString);
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

        public List<Test> GetAllPassedTest()
        {
            List<Test> tests = new List<Test>();
            Connect();
            string request = "select Test.id, Subject.Name, Type_test.name, test_date from Test join Subject on Test.id_subject = Subject.Id join Type_test on Test.id_Type = Type_test.id";
            SqlCommand command = new SqlCommand(request, Connection);
            var res = command.ExecuteReader();

            if (res.HasRows)
            {
                while (res.Read())
                {
                    Test test = new Test();
                    test.Id = Convert.ToInt32(res.GetValue(0).ToString());
                    test.Subject = res.GetValue(1).ToString();
                    test.Type = res.GetValue(2).ToString();
                    test.TestDate = Convert.ToDateTime(res.GetValue(3).ToString());
                    tests.Add(test);
                }
            }
            Close();
            return tests;
        }
        public void InsertTest(Test test)
        {
            Connect();
            string request = "Insert into Test(id_subject,id_Type,test_date)values((select id from Subject where Name = @subject_name),(select id from Type_test where name = @type_test), @pass_date)";
            SqlCommand command = new SqlCommand(request, Connection);
            command.Parameters.AddWithValue("@subject_name", test.Subject);
            command.Parameters.AddWithValue("@type_test", test.Type);
            command.Parameters.AddWithValue("@pass_date", test.TestDate);
            command.ExecuteNonQuery();
            Close();
        }
        public void UpdateTest(Test test)
        {
            Connect();
            string request = "update Test set id_subject = (select id from Subject where Name = @subject_name ),id_Type = (select id from Type_test where name = @type_test), test_date =  @pass_date where id = @Id";
            SqlCommand command = new SqlCommand(request, Connection);
            command.Parameters.AddWithValue("@Id", test.Id);
            command.Parameters.AddWithValue("@subject_name", test.Subject);
            command.Parameters.AddWithValue("@type_test", test.Type);
            command.Parameters.AddWithValue("@pass_date", test.TestDate);
            command.ExecuteNonQuery();
            Close();
        }
        public void DeleteTest(int id)
        {
            Connect();
            string request = "delete from Test where id = @id";
            SqlCommand command = new SqlCommand(request, Connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            Close();

        }
    }
}
