using StudentsProgressWFA.Entities;
using StudentsProgressWFA.Repositories;

namespace StudentsProgressWFA
{
    public partial class PassExamForm : Form
    {
        PassExRepository examrepository = new PassExRepository();
        public PassExamForm()
        {
            InitializeComponent();
        }

        private void PassExamForm_Load(object sender, EventArgs e)
        {
            passExdataGridView.DataSource = examrepository.GetPassExamList();
        }

        private void passEx_buttonInsert_Click(object sender, EventArgs e)
        {
            PassExam passexam = new PassExam();
            passexam.StudentName = textBoxpassexstName.Text;
            passexam.TestType = textBoxpassExTesttype.Text;
            passexam.Point = int.Parse(textBoxpassExPoint.Text);
            examrepository.InsertValue(passexam);

            passExdataGridView.DataSource = examrepository.GetPassExamList();
        }
        /// <summary>
        /// updating passexam class by name of the student
        ///type of test and point, then get the passed exam 
        ///by id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void passEx_buttonUpdate_Click(object sender, EventArgs e)
        {
            PassExam passexam = new PassExam();
            passexam.Id = int.Parse(textBoxIdPassEx.Text);
            passexam.StudentName = textBoxpassexstName.Text;
            passexam.TestType = textBoxpassExTesttype.Text;
            passexam.Point = int.Parse(textBoxpassExPoint.Text);

            examrepository.UpdateResultExam(passexam);

            passExdataGridView.DataSource = examrepository.GetPassExamList();

        }

        private void passEx_buttonDelete_Click(object sender, EventArgs e)
        {
            examrepository.DeleteResultexam(Convert.ToInt32(textBoxIdPassEx.Text));
            passExdataGridView.DataSource = examrepository.GetPassExamList();
        }


        private void textBoxpassexstName_TextChanged(object sender, EventArgs e)
        {
            passExdataGridView.DataSource = examrepository.GetPassedExamByStudentName(textBoxpassexstName.Text);
        }

        private void textBoxpassExTesttype_TextChanged(object sender, EventArgs e)
        {
            passExdataGridView.DataSource = examrepository.FindPassedExamByTestType(textBoxpassExTesttype.Text);
        }
    }
}
