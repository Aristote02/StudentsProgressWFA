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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentsProgressWFA
{
    public partial class TypeTestForm : Form
    {
        TypeTestRepository repository = new TypeTestRepository();
        public TypeTestForm()
        {
            InitializeComponent();
        }

        private void TypeTestForm_Load(object sender, EventArgs e)
        {
            TypetestdataGridView.DataSource = repository.GetAllTypeOfTest();
        }

        private void Insertbutton_Click(object sender, EventArgs e)
        {
            TypeTest typetest = new TypeTest();
            typetest.Name = NameTexbox.Text;

            repository.InserValue(typetest);
            TypetestdataGridView.DataSource = repository.GetAllTypeOfTest();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            repository.DeleteTest(int.Parse(IdtextBox.Text));
            TypetestdataGridView.DataSource = repository.GetAllTypeOfTest();
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            TypeTest typeTest = new TypeTest();
            typeTest.Id = int.Parse(IdtextBox.Text);
            typeTest.Name = NameTexbox.Text;

            repository.Update(typeTest);
            TypetestdataGridView.DataSource = repository.GetAllTypeOfTest();
        }
    }
}
