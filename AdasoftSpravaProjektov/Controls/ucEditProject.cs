using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdasoftSpravaProjektov.Controls
{
    public partial class ucEditProject : UserControl
    {
        public ucEditProject()
        {
            InitializeComponent();
        }

        public int ItemId { get { return int.Parse(txtId.Text); } set { txtId.Text = value.ToString(); } }
        public string ItemName { get { return txtName.Text; } set { txtName.Text = value; } }
        public string ItemAbbreviation { get { return txtAbbreviation.Text; } set { txtAbbreviation.Text = value; } }
        public string ItemCustomer { get { return txtCustomer.Text; } set { txtCustomer.Text = value; } }




    }
}
