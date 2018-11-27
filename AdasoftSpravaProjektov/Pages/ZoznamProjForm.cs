using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdasoftSpravaProjektov.Pages
{
    public partial class ZoznamProjForm : Form
    {
        public ZoznamProjForm()
        {
            InitializeComponent();
        }

        private void ZoznamProjForm_Load(object sender, EventArgs e)
        {
            LogForm logForm = new LogForm();
            logForm.ShowDialog(this);
            if (!logForm._logged)
            {
                logForm.Close();
                this.Close();
            }
            else
            {
                logForm.Close();
            }
        }
    }
}
