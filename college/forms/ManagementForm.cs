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
    public partial class ManagementForm : Form
    {
        private DbContext _dbContext;
        public ManagementForm(DbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
        }
    }
}
