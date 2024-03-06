using StudentsProgressWFA.Entities;
using StudentsProgressWFA.Repositories;

namespace StudentsProgressWFA
{
    public partial class StudentForm : Form
    {
        /// <summary>
        /// repository object allows us to acces all the 
        /// method in the StudentRepository class
        /// </summary>
        StudentRepository repository = new StudentRepository();
        public StudentForm()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// using the studentGriview to get the data source
        /// that the datagridview is displaying data for.
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            studentGridView.DataSource  = repository.GetAll();
        }

        private void Insertbutton_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Name = stNametextBox.Text;
            student.Faculty = FacIDtextBox.Text;
            student.Specialty = SpecIDtextBox.Text;
            student.GroupName = GrIDtextBox.Text;

            repository.InsertValues(student);

            studentGridView.DataSource = repository.GetAll();
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Id = Convert.ToInt32(stIDtextBox.Text);
            student.Name = stNametextBox.Text;
            student.Faculty = FacIDtextBox.Text;
            student.Specialty = SpecIDtextBox.Text;
            student.GroupName = GrIDtextBox.Text;

            repository.Update(student);

            studentGridView.DataSource = repository.GetAll();
        }
        /// <summary>
        /// delete button, i called the repository object
        /// which allow me to get then delete method from
        /// the studentRepository, and convert the user input 
        /// into integer value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Deletebutton_Click(object sender, EventArgs e)
        {
            repository.Delete(Convert.ToInt32(stIDtextBox.Text));

            studentGridView.DataSource = repository.GetAll();
        }

        /// <summary>
        /// To find the student by his name starting from the first lettter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stNametextBox_TextChanged(object sender, EventArgs e)
        {
            studentGridView.DataSource = repository.GetallByName(stNametextBox.Text);
        }

        private void FacIDtextBox_TextChanged(object sender, EventArgs e)
        {
            studentGridView.DataSource = repository.GetStudentByFaculty(FacIDtextBox.Text);
        }
        /// <summary>
        /// using the student from property textchanged, it allows
        /// me to find the student's specialty just by entering the
        /// first letter of his specialty in the Specialty textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SpecIDtextBox_TextChanged(object sender, EventArgs e)
        {
            studentGridView.DataSource = repository.FindStudentBySpecialty(SpecIDtextBox.Text);
        }

        private void GrIDtextBox_TextChanged(object sender, EventArgs e)
        {
            studentGridView.DataSource = repository.FindStudentByGroup(GrIDtextBox.Text);
        }

        private void stIDtextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(stIDtextBox.Text))
            {
                MessageBox.Show("You didn't provide the id");
            }
            else
            {
                studentGridView.DataSource = repository.FindStudentById(Convert.ToInt32(stIDtextBox.Text));
            }

            
        }
    }
}