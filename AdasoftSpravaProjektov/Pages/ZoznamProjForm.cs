using AdasoftBussines.Data;
using AdasoftBussines.DataProvider;
using AdasoftData;
using AdasoftData.model;
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
        ZoznamProjektov<ProjectItem> _zoznam = null;
        public ZoznamProjForm()
        {
            InitializeComponent();
            _dataProvider = new DataProvider<XmlProjectDocumentReader>(new XmlProjectDocumentReader() );
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

            AdDocument adDocument= _dataProvider.GetDocument();

            _zoznam = (ZoznamProjektov<ProjectItem>)adDocument;

            foreach (ProjectItem item in _zoznam.Items)
            {
            
               TreeNode tn= treeView1.Nodes.Add(item.Id.ToString() );
                tn.Tag = item.Id-1;

            }
        }

        private void InitData()
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode!=null)
            {
                List<ProjectItem> listProjects = _zoznam.Items.ToList<ProjectItem>();
                int index= (int)treeView1.SelectedNode.Tag;
                ucEditProject1.ItemId= listProjects[index].Id;
                ucEditProject1.ItemAbbreviation = listProjects[index].Abreviation;
                ucEditProject1.ItemCustomer = listProjects[index].Customer;
                ucEditProject1.ItemName = listProjects[index].Name;

            }
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
