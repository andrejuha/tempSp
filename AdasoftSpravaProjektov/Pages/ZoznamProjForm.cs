using AdasoftBussines.Data;
using AdasoftBussines.DataProvider;
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
        IDataProvider _dataProvider = null;
        public ZoznamProjForm()
        {
            InitializeComponent();
            _dataProvider = new DataProvider<XmlProjectDocumentReader>();
        }

        public ZoznamProjForm(IDataProvider dataProvider)
        {
            InitializeComponent();
            _dataProvider = dataProvider;
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

        private void InitData()
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
