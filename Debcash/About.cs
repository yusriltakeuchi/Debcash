using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Debcash
{
    public partial class About : MetroFramework.Forms.MetroForm
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {

        }

        private void btnVisit_Click(object sender, EventArgs e)
        {
           
        }

        private void btnVisitme_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://yurani.me");
        }
    }
}
