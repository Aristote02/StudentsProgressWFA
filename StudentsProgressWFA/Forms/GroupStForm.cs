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
    public partial class GroupStForm : Form
    {
        GroupStRepository repositoryGr = new GroupStRepository();
        public GroupStForm()
        {
            InitializeComponent();
        }

        private void GroupStForm_Load(object sender, EventArgs e)
        {
            GrdataGridView.DataSource = repositoryGr.GetGroupSts();
        }

        private void Insertbutton_Click(object sender, EventArgs e)
        {
            GroupSt groupSt = new GroupSt();
            groupSt.name = grNametextBox.Text;
            repositoryGr.InsertGroup(groupSt);
            GrdataGridView.DataSource = repositoryGr.GetGroupSts();
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            GroupSt groupSt = new GroupSt();
            groupSt.id = int.Parse(IdtextBox.Text);
            groupSt.name = grNametextBox.Text;
            repositoryGr.UpdateGroup(groupSt);
            GrdataGridView.DataSource = repositoryGr.GetGroupSts();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            repositoryGr.DeleteGroup(int.Parse(IdtextBox.Text));
            GrdataGridView.DataSource = repositoryGr.GetGroupSts();
        }
    }
}
