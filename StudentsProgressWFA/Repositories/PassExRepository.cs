using Microsoft.Data.SqlClient;
using StudentsProgressWFA.Entities;
using StudentsProgressWFA.Helpers;

namespace StudentsProgressWFA.Repositories
{
    public class PassExRepository
    {
        private string connectionString = "Server=DESKTOP-K1G3SS3\\SQLEXPRESS;Database=StudentProgressdb;Trusted_Connection=True;Encrypt=false;";
        private SqlConnection Connection { get; set; }

        public PassExRepository()
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
        public List<PassExam> GetPassExamList()
        {
            List<PassExam> passexams = new List<PassExam>();
            Connect();
            string request = "Select Pass_Exam.id as id, Student.name as St_name, Type_test.name as type_test, point From Pass_Exam  join Student on Pass_Exam.id_student = Student.id join Test on Pass_Exam.id_test = Test.id join Type_test on Test.id_Type = Type_test.id";
            SqlCommand command = new SqlCommand(request, Connection);
            var res = command.ExecuteReader();

            if (res.HasRows)
            {
                while (res.Read())
                {
                    PassExam passexam = new PassExam();
                    passexam.Id = Convert.ToInt32(res.GetValue(0).ToString());
                    passexam.StudentName = res.GetValue(1).ToString();
                    passexam.TestType = res.GetValue(2).ToString();
                    passexam.Point = Convert.ToInt32(res.GetValue(3).ToString());
                    passexams.Add(passexam);
                }

            }

            Close();
            return passexams;
        }

        public void InsertValue(PassExam passexam)
        {
            Connect();
            string request = "INSERT INTO Pass_Exam(id_student,id_test,point)values((select id from Student where name = @student_name),(select Test.id from Test inner join Type_test on Test.id_type = Type_test.id where Type_test.name = @type_test), @point) ";
            SqlCommand command = new SqlCommand(request, Connection);
            command.Parameters.AddWithValue("@student_name", passexam.StudentName);
            command.Parameters.AddWithValue("@type_test", passexam.TestType);
            command.Parameters.AddWithValue("@point", passexam.Point);
            command.ExecuteNonQuery();
            Close();
        }
        public void UpdateResultExam(PassExam passexam)
        {
            Connect();
            string request = "UPDATE Pass_Exam SET id_student = (select id from Student where name = @student_name),id_test = (select Test.id from Test join Type_test on Test.id_type = Type_test.id where Type_test.name = @type_test), point = @point WHERE id = @id ";
            SqlCommand command = new SqlCommand(request, Connection);
            command.Parameters.AddWithValue("@Id", passexam.Id);
            command.Parameters.AddWithValue("@student_name", passexam.StudentName);
            command.Parameters.AddWithValue("@type_test", passexam.TestType);
            command.Parameters.AddWithValue("@point", passexam.Point);
            command.ExecuteNonQuery();
            Close();

        }

        public void DeleteResultexam(int Id)
        {
            Connect();
            string request = "DELETE From Pass_Exam where Id = @Id";
            SqlCommand command = new SqlCommand(request, Connection);
            command.Parameters.AddWithValue("@Id", Id);
            command.ExecuteNonQuery();
            Close();
        }
        /// <summary>
        /// this method find the average score of each student, grouped
        /// by faculties and specialties
        /// </summary>
        /// <returns></returns>
        public List<AverageSt> GetAveragePoint()
        {
            List<AverageSt> averageSts = new List<AverageSt>();
            Connect();
            string request = "select Student.name as Student_name,Specialty.Name as Spec_name,Faculty.Name as Fac_name, AVG(point) as Average_Point from Pass_Exam join Student on Pass_Exam.id_student = Student.id join Specialty on Student.id_specialty = Specialty.Id join Faculty on Student.id_faculty = Faculty.Id group by Faculty.Name, Specialty.Name,Student.name";
            SqlCommand command = new SqlCommand(request, Connection);
            var res = command.ExecuteReader();

            if (res.HasRows)
            {
                while (res.Read())
                {
                    AverageSt average = new AverageSt();
                    average.StudentName = res.GetValue(0).ToString();
                    average.Faculty = res.GetValue(1).ToString();
                    average.Specialty = res.GetValue(2).ToString();
                    average.Average = int.Parse(res.GetValue(3).ToString());
                    averageSts.Add(average);
                }
            }
            Close();
            return averageSts;
        }
        /// <summary>
        /// this method will help us find the most diffuclt 
        /// subject for each specialty
        /// </summary>
        /// <returns></returns>
        public List<DiffAndSimSub> FindDiffSub()
        {
            List<DiffAndSimSub> diffSubjects = new List<DiffAndSimSub>();
            Connect();
            string resquest = "with  averageQuery as (select Specialty.Name as spec_name, Subject.Name as sub , avg(Pass_Exam.point) as Average_Point from Pass_Exam join Student on Pass_Exam.id_student = Student.id join Specialty on Student.id_specialty = Specialty.Id join Test on Pass_Exam.id_test = Test.id join Subject on Test.id_subject = Subject.Id group by Specialty.Name,Subject.Name) select spec_name, sub,  min(Average_Point) as diffSub from averageQuery group by spec_name,  sub";
            SqlCommand command = new SqlCommand(resquest, Connection);
            var res = command.ExecuteReader();
            if (res.HasRows)
            {
                while (res.Read())
                {
                    DiffAndSimSub diffSub = new DiffAndSimSub();
                    diffSub.Specialty = res.GetValue(0).ToString();
                    diffSub.Subject = res.GetValue(1).ToString();
                    diffSubjects.Add(diffSub);
                }
            }
            Close();
            return diffSubjects;
        }

        /// <summary>
        /// this method will help us find the simplest
        /// subject for each specialty
        /// </summary>
        /// <returns></returns>
        public List<DiffAndSimSub> FindSimpSub()
        {
            List<DiffAndSimSub> simpSubjects = new List<DiffAndSimSub>();
            Connect();
            string resquest = "with  averageQuery as (select Specialty.Name as spec_name, Subject.Name as sub , avg(Pass_Exam.point) as Average_Point from Pass_Exam join Student on Pass_Exam.id_student = Student.id join Specialty on Student.id_specialty = Specialty.Id join Test on Pass_Exam.id_test = Test.id join Subject on Test.id_subject = Subject.Id group by Specialty.Name,Subject.Name) select spec_name, sub,  max(Average_Point) as SimpSub from averageQuery group by spec_name,  sub;";
            SqlCommand command = new SqlCommand(resquest, Connection);
            var result = command.ExecuteReader();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    DiffAndSimSub simpSub = new DiffAndSimSub();
                    simpSub.Specialty = result.GetValue(0).ToString();
                    simpSub.Subject = result.GetValue(1).ToString();
                    simpSubjects.Add(simpSub);
                }
            }
            Close();
            return simpSubjects;
        }
        /// <summary>
        /// This method find the most successful student in each session
        /// by entering a start date of a session and the end date within that period it will find 
        /// the most successful student otherwise it will shows no values in the form
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public List<MostSuccessFulStudent> GetMostSuccessfulStudent(DateTime startDate, DateTime endDate)
        {
            List<MostSuccessFulStudent> list = new List<MostSuccessFulStudent>();

            Connect();

            SqlCommand command = new SqlCommand();
            command.Connection = Connection;
            command.CommandText = "with st as(select Student.name as St_name, Specialty.Name as Sp_name , avg(point)  as point from Pass_Exam join Student on Pass_Exam.id_student = Student.id\r\njoin Faculty on Student.id_faculty = Faculty.Id\r\njoin Specialty on Student.id_specialty = Specialty.Id join Test on Pass_Exam.id_test = Test.id where Test.test_date >= convert(datetime, @start) and Test.test_date <= convert(datetime, @end) group by Student.name, Specialty.Name )select Sp_name, max(St_name) as student_name,max(point) as HighestPoint from st group by Sp_name";
            command.Parameters.AddWithValue("@start", startDate);
            command.Parameters.AddWithValue("@end", endDate);

            var reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    MostSuccessFulStudent student = new();
                    student.Speciality = reader.GetValue(0).ToString();
                    student.StudentName = reader.GetValue(1).ToString();
                    student.Point = Convert.ToInt32(reader.GetValue(2).ToString());

                    list.Add(student);
                }
            }

            return list;

        }
        public List<PassExam> GetPassedExamByStudentName(string studentName)
        {
            List<PassExam> list = new List<PassExam>();

            foreach (var passExam in GetPassExamList())
            {
                if (passExam.StudentName.Contains(studentName))
                {
                    list.Add(passExam);
                }
            }
            return list;
        }
        public List<PassExam> FindPassedExamByTestType(string testType)
        {
            List<PassExam> list = new List<PassExam>();

            foreach (var passExam in GetPassExamList())
            {
                if (passExam.TestType.Contains(testType))
                {
                    list.Add(passExam);
                }
            }
            return list;
        }
    }
}
