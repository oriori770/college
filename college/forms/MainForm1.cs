using college.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace college.forms
{
    public partial class MainForm1 : Form
    {
        private DbContext _DbContext;
        public MainForm1(DbContext dbContext)
        {
            InitializeComponent();
            _DbContext = dbContext;
        }

        private void buttonAdministrator_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ManagementForm(_DbContext).Show();
        }

        private void buttonStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            new StudentForm(_DbContext).Show();
        }
    }
}
