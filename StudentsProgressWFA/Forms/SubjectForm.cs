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
    public partial class SubjectForm : Form
    {
        SubjectRepository repository= new SubjectRepository();
        public SubjectForm()
        {
            InitializeComponent();
        }

        private void SubjectForm_Load(object sender, EventArgs e)
        {
            SubjectdataGridView.DataSource = repository.GetAllSubject();
        }

        private void Insertbutton_Click(object sender, EventArgs e)
        {
            Subject subject = new Subject();
            subject.name = nametextBox.Text;
            repository.InsertSubject(subject);
            SubjectdataGridView.DataSource = repository.GetAllSubject();
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            Subject subject= new Subject();
            subject.id = int.Parse(IdtextBox.Text);
            subject.name = nametextBox.Text;
            repository.UpdateSubject(subject);
            SubjectdataGridView.DataSource = repository.GetAllSubject();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            repository.DeleteSubject(int.Parse(IdtextBox.Text));
            SubjectdataGridView.DataSource = repository.GetAllSubject();
        }
    }
}
