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
    public partial class SpecialtyForm : Form
    {
        SpecialtyRepository repository = new SpecialtyRepository();
        public SpecialtyForm()
        {
            InitializeComponent();
        }

        private void SpecialtyForm_Load(object sender, EventArgs e)
        {
            SpecialtydataGridView.DataSource = repository.GetSpecialties();
        }

        private void insertbutton_Click(object sender, EventArgs e)
        {
            Specialty specialty = new Specialty();
            specialty.name = nametextBox.Text;
            repository.InsertSpec(specialty);
            SpecialtydataGridView.DataSource = repository.GetSpecialties();
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            Specialty specialty = new Specialty();
            specialty.id = int.Parse(idtextBox.Text);
            specialty.name = nametextBox.Text;
            repository.UpdateSpec(specialty);
            SpecialtydataGridView.DataSource = repository.GetSpecialties();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            repository.DeleteSpec(int.Parse(idtextBox.Text));
            SpecialtydataGridView.DataSource = repository.GetSpecialties();
        }
    }
}
