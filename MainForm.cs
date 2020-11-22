using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleApp
{
    public partial class MainForm : Form
    {
        Document document = new Document();
        List<Form> openedForms = new List<Form>();
        bool aplicationClosing = false;

        public MainForm()
        {
            InitializeComponent();
            IsMdiContainer = true;
            CreateChild();
        }

        private void addListViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateChild();
        }

        private void MainForm_MdiChildActivate(object sender, EventArgs e)
        {
            ToolStripManager.RevertMerge(toolStrip);

            VehiclesForm frmChild = (VehiclesForm)ActiveMdiChild;
            if (frmChild != null)
            {
                ToolStripManager.Merge(frmChild.toolStrip1, toolStrip);
            }
        }

        private void CreateChild()
        {
            VehiclesForm vehiclesForm = new VehiclesForm(document);
            vehiclesForm.MdiParent = this;
            vehiclesForm.Show();
            openedForms.Add(vehiclesForm);
        }

        public bool TryRemoveForm(Form form)
        {
            if (openedForms.Count == 1 && !aplicationClosing)
                return false;
            openedForms.Remove(form);
            return true;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            aplicationClosing = true;
            e.Cancel = false;
        }
    }
}
