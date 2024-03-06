using Microsoft.Data.SqlClient;
using StudentsProgressWFA.Entities;

namespace StudentsProgressWFA.Repositories;

public class StudentRepository
{
    /// <summary>
    /// private connection string to get access in the 
    /// database
    /// </summary>
    private string connectionString = "Server=DESKTOP-K1G3SS3\\SQLEXPRESS;Database=StudentProgressdb;Trusted_Connection=True;Encrypt=false;";

    private SqlConnection connection { get; set; }

    /// <summary>
    /// in the constructor, i initialize a new instance of the
    /// SqlConnection class when given a connectionString that 
    /// contains the connection 
    /// </summary>
    public StudentRepository()
    {
        connection = new SqlConnection(connectionString);
    }

    private void Connect()
    {
        try
        {
            connection.Open();
        }
        catch
        {
            throw;
        }
    }

    private void close()
    {
        try
        {
            connection.Close();
        }
        catch
        {
            throw;
        }
    }

    /// <summary>
    /// Read the data from the database
    /// </summary>
    /// <returns></returns>
    public List<Student> GetAll()
    {
        List<Student> students = new List<Student>();
        Connect();

        string request = "select St.Id as Id, St.name as St_name, F.Name as Fac_Name,Sp.Name as Spe_Name, GSt.Name as Group_name From Student st join Faculty F on St.id_faculty = F.Id join Specialty Sp on St.id_specialty = Sp.Id join GroupSt gst on St.id_group = GSt.Id";

        SqlCommand command = new SqlCommand(request, connection);

        var result = command.ExecuteReader();

        if (result.HasRows)
        {
            while (result.Read())
            {
                Student student = new Student();
                student.Id = Convert.ToInt32(result.GetValue(0).ToString());
                student.Name = result.GetValue(1).ToString();
                student.Faculty = result.GetValue(2).ToString();
                student.Specialty = result.GetValue(3).ToString();
                student.GroupName = result.GetValue(4).ToString();
                students.Add(student);
            }

        }

        close();

        return students;
    }

    /// <summary>
    /// Insert record to the table
    /// </summary>
    /// <param name="student"></param>
    /// 
    public void InsertValues(Student student)
    {
        Connect();
        string request = "INSERT INTO Student (name,id_faculty,id_specialty,id_group) values(@Name,(select id from Faculty where name = @faculty_name),(select id from Specialty where Name = @specialty_name) ,(select id from GroupSt where Name = @group_name))";
        SqlCommand command = new SqlCommand(request, connection);
        command.Parameters.AddWithValue("@Name", student.Name);
        command.Parameters.AddWithValue("@faculty_name", student.Faculty);
        command.Parameters.AddWithValue("@specialty_name", student.Specialty);
        command.Parameters.AddWithValue("@group_name", student.GroupName);
        command.ExecuteNonQuery();
        close();
    }
    /// <summary>
    /// Updating the student record
    /// </summary>
    /// <param name="student"></param>
    public void Update(Student student)
    {
        Connect();
        string request = "UPDATE Student SET Name = @Name, id_faculty = (select id from Faculty where name = @faculty_name), id_specialty = (select id from Specialty where name = @specialty_name), id_group = (select id from GroupSt where name = @group_name) where id = @Id";
        SqlCommand command = new SqlCommand(request, connection);
        command.Parameters.AddWithValue("@Id ", student.Id);
        command.Parameters.AddWithValue("@Name", student.Name);
        command.Parameters.AddWithValue("@faculty_name", student.Faculty);
        command.Parameters.AddWithValue("@specialty_name", student.Specialty);
        command.Parameters.AddWithValue("@group_name", student.GroupName);
        command.ExecuteNonQuery();
        close();

    }

    /// <summary>
    /// Method for deleting  records
    /// </summary>
    /// <param name="student"><s/param>
    public void Delete(int id)
    {
        Connect();
        string request = "DELETE From Student where Id = @Id";
        SqlCommand command = new SqlCommand(request, connection);
        command.Parameters.AddWithValue("@Id", id);
        command.ExecuteNonQuery();
        close();
    }
    /// <summary>
    /// This method will help us to search the student by the starting letter of his name
    /// up to the last and find the student's name
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public List<Student> GetallByName(string name)
    {
        List<Student> list = new List<Student>();

        foreach (var student in GetAll())
        {
            if (student.Name.Contains(name))
            {
                list.Add(student);
            }
        }

        return list;
    }
    /// <summary>
    /// this simply help the user find the student by his faculty in case he forget the name
    /// of the student or his specilaty or group so he can type the name of the faculty 
    /// and find the student 
    /// </summary>
    /// <param name="faculty"></param>
    /// <returns></returns>
    public List<Student> GetStudentByFaculty(string faculty)
    {
        List<Student> list = new List<Student>();

        foreach (var student in GetAll())
        {
            if (student.Faculty.Contains(faculty))
            {
                list.Add(student);
            }
        }
        return list;
    }

    public List<Student> FindStudentBySpecialty(string specialty)
    {
        List<Student> list = new List<Student>();

        foreach (var student in GetAll())
        {
            if (student.Specialty.Contains(specialty))
            {
                list.Add(student);
            }
        }
        return list;
    }
    public List<Student> FindStudentByGroup(string group)
    {
        List<Student> list = new List<Student>();

        foreach (var student in GetAll())
        {
            if (student.GroupName.Contains(group))
            {
                list.Add(student);
            }
        }

        return list;
    }

    public List<Student> FindStudentById(int id)
    {
        List<Student> list = new List<Student>();

        foreach (var student in GetAll())
        {
            if (student.Id.ToString().Contains(id.ToString()))
            {
                list.Add(student);
            }
        }
        return list;
    }
}
