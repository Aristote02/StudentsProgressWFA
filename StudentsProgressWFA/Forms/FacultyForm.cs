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
    public partial class FacultyForm : Form
    {
        FacultyRepository repository = new FacultyRepository();
        public FacultyForm()
        {
            InitializeComponent();
        }

        private void FacultyForm_Load(object sender, EventArgs e)
        {
            FacdataGridView.DataSource = repository.GetFaculties();
        }

        private void Insertbutton_Click(object sender, EventArgs e)
        {
            Faculty faculty = new Faculty();
            faculty.name = namefactextBox.Text;
            repository.InsertFac(faculty);
            FacdataGridView.DataSource = repository.GetFaculties();
        }

        private void Updatefacbutton_Click(object sender, EventArgs e)
        {
            Faculty faculty = new Faculty();
            faculty.id = int.Parse(IdtextBox.Text);
            faculty.name = namefactextBox.Text;
            repository.UpdateFac(faculty);
            FacdataGridView.DataSource = repository.GetFaculties();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            repository.DeleteFac(int.Parse(IdtextBox.Text));
            FacdataGridView.DataSource = repository.GetFaculties();
        }
    }
}
