using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentsProgressWFA.Entities;
using StudentsProgressWFA.Repositories;

namespace StudentsProgressWFA
{

    public partial class TestForm : Form
    {
        TestRepository testRepository = new TestRepository();
        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            TestdataGridView.DataSource = testRepository.GetAllPassedTest();
        }

        private void Insertbutton_Click(object sender, EventArgs e)
        {
            Test test = new Test();
            test.Subject = SubjecttextBox.Text;
            test.Type = TypetextBox.Text;
            test.TestDate = Convert.ToDateTime(DatetextBox.Text);
            testRepository.InsertTest(test);

            TestdataGridView.DataSource = testRepository.GetAllPassedTest();
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            Test test = new Test();
            test.Subject = SubjecttextBox.Text;
            test.Type = TypetextBox.Text;
            test.TestDate = Convert.ToDateTime(DatetextBox.Text);
            testRepository.UpdateTest(test);

            TestdataGridView.DataSource = testRepository.GetAllPassedTest();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            testRepository.DeleteTest(Convert.ToInt32(IDtextBox.Text));
            TestdataGridView.DataSource = testRepository.GetAllPassedTest();
        }
    }
}
