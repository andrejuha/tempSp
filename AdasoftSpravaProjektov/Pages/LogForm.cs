using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace AdasoftSpravaProjektov.Pages
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
        }
        public bool _logged = false;

  

        private void LogForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string user = ConfigurationManager.AppSettings["user"];
            string password= ConfigurationManager.AppSettings["password"];

            if (txtPassword.Text.GetHashCode().ToString() == password && txtUser.Text == user)
                _logged = true;
            
                this.Visible=false;
        }
    }
}
