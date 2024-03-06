using Microsoft.Data.SqlClient;
using StudentsProgressWFA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsProgressWFA.Repositories
{
    public class GroupStRepository
    {
        private string connectionString = "Server=DESKTOP-K1G3SS3\\SQLEXPRESS;Database=StudentProgressdb;Trusted_Connection=True;Encrypt=false;";
        private SqlConnection Connection { get; set; }
        public GroupStRepository()
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
        public List<GroupSt> GetGroupSts()
        {
            List<GroupSt> groupSts = new List<GroupSt>();
            Connect();
            string request = "Select * From GroupSt";
            SqlCommand command = new SqlCommand(request, Connection);
            var result = command.ExecuteReader();

            if (result.HasRows)
            {
                while (result.Read())
                {
                    GroupSt groupSt = new GroupSt();
                    groupSt.id = Convert.ToInt32(result.GetValue(0).ToString());
                    groupSt.name = result.GetValue(1).ToString();
                    groupSts.Add(groupSt);
                }
            }
            Close();
            return groupSts;
        }
        public void InsertGroup(GroupSt groupSt)
        {
            Connect();
            string request = "insert into GroupSt(name)values(@name)";
            SqlCommand command = new SqlCommand(request, Connection);
            command.Parameters.AddWithValue("@name", groupSt.name);
            command.ExecuteNonQuery();
            Close();
        }
        public void UpdateGroup(GroupSt groupSt)
        {
            Connect();
            string request = "update GroupSt set name = @name where id =@id";
            SqlCommand command = new SqlCommand(request, Connection);
            command.Parameters.AddWithValue("@id", groupSt.id);
            command.Parameters.AddWithValue("@name", groupSt.name);
            command.ExecuteNonQuery();
            Close();
        }
        public void DeleteGroup(int id)
        {
            Connect();
            string resquest = "Delete from GroupSt where id = @id";
            SqlCommand command = new SqlCommand(resquest, Connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            Close();
        }
    }
}
