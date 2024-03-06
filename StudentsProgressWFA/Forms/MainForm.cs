using StudentsProgressWFA.Repositories;

namespace StudentsProgressWFA
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (StudentForm studentForm = new StudentForm())
            {
                studentForm.ShowDialog();
            }
        }

        private void facultyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FacultyForm facultyForm = new FacultyForm())
            {
                facultyForm.ShowDialog();
            }
        }

        private void specialtyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SpecialtyForm specialtyForm = new SpecialtyForm())
            {
                specialtyForm.ShowDialog();
            }
        }

        private void groupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (GroupStForm groupStForm = new GroupStForm())
            {
                groupStForm.ShowDialog();
            }
        }

        private void subjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SubjectForm subjectForm = new SubjectForm())
            {
                subjectForm.ShowDialog();
            }
        }

        private void typeOfTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (TypeTestForm typeTestForm = new TypeTestForm())
            {
                typeTestForm.ShowDialog();
            }
        }

        private void passExamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (PassExamForm passExamForm = new PassExamForm())
            {
                passExamForm.ShowDialog();
            }
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (TestForm testForm = new TestForm())
            {
                testForm.ShowDialog();
            }
        }

        private void AveragedataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AverageScore_Click(object sender, EventArgs e)
        {
            AveragedataGridView.DataSource = new PassExRepository().GetAveragePoint();
        }

        private void Minbutton_Click(object sender, EventArgs e)
        {
            DiffanSimpdataGridView.DataSource = new PassExRepository().FindDiffSub();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DiffanSimpdataGridView.DataSource = new PassExRepository().FindSimpSub();
        }

        private void MostSuccSt_Button_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;

            DiffanSimpdataGridView.DataSource = new PassExRepository().GetMostSuccessfulStudent(startDate, endDate);
        }
    }
}
