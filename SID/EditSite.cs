using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SID
{
    public partial class EditSite : Form
    {
        public string newFilter = "";
        public EditSite()
        {
            InitializeComponent();
            // TODO: This line of code loads data into the 'sbi_salesdbDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.sbi_salesdbDataSet.Client);
            // TODO: This line of code loads data into the 'sbi_salesdbDataSet.SiteDetails' table. You can move, or remove it, as needed.
            this.siteDetailsTableAdapter.Fill(this.sbi_salesdbDataSet.SiteDetails);
        }

        public EditSite(int siteID)
        {
            InitializeComponent();
            // TODO: This line of code loads data into the 'sbi_salesdbDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.sbi_salesdbDataSet.Client);
            // TODO: This line of code loads data into the 'sbi_salesdbDataSet.SiteDetails' table. You can move, or remove it, as needed.
            this.siteDetailsTableAdapter.FillBySiteID(this.sbi_salesdbDataSet.SiteDetails, siteID);

        }

        private void siteDetailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.siteDetailsBindingSource.EndEdit();
            this.jobBindingSource.EndEdit();
            this.jobTableAdapter.Update(this.sbi_salesdbDataSet.Job);
            this.tableAdapterManager.UpdateAll(this.sbi_salesdbDataSet);
            this.Close();

        }

        private void EditSite_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sbi_salesdbDataSet.Job' table. You can move, or remove it, as needed.
            this.jobTableAdapter.Fill(this.sbi_salesdbDataSet.Job);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.siteDetailsBindingSource.EndEdit();
            this.jobBindingSource.EndEdit();
            this.jobTableAdapter.Update(this.sbi_salesdbDataSet.Job);
            this.tableAdapterManager.UpdateAll(this.sbi_salesdbDataSet);
            DataRowView currentSite = (DataRowView)siteDetailsBindingSource.Current;
            //currentPO["Name"] = tbPOSOP.Text;

            int siteID = Convert.ToInt32(currentSite["SiteID"]);
            int clientID = Convert.ToInt32(comboBox1.SelectedValue);
            using (EditJob ej = new EditJob(clientID, true))
            {
                this.DialogResult = DialogResult.OK;
                var result = ej.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string ejreturn = Convert.ToString(ej.returnJobId);
                    if (String.IsNullOrWhiteSpace(newFilter))
                    {
                        newFilter = "JobId = " + ejreturn;
                    }
                    else
                    {
                        newFilter += " OR JobID = " + ejreturn;
                    }

                }

            }
            this.siteDetailsTableAdapter.FillBySiteID(this.sbi_salesdbDataSet.SiteDetails, siteID);
            this.jobTableAdapter.Fill(this.sbi_salesdbDataSet.Job);
        }

        private void jobDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex == -1 || e.ColumnIndex == -1))
            {




                int jobId = Convert.ToInt32(jobDataGridView.Rows[e.RowIndex].Cells["JobID"].Value);
                this.Validate();
                this.siteDetailsBindingSource.EndEdit();
                this.jobBindingSource.EndEdit();
                this.jobTableAdapter.Update(this.sbi_salesdbDataSet.Job);
                this.tableAdapterManager.UpdateAll(this.sbi_salesdbDataSet);
                DataRowView currentSite = (DataRowView)siteDetailsBindingSource.Current;
                //currentPO["Name"] = tbPOSOP.Text;

                int siteID = Convert.ToInt32(currentSite["SiteID"]);
                int clientID = Convert.ToInt32(comboBox1.SelectedValue);



                EditJob ej = new EditJob(clientID, jobId);
                ej.ShowDialog();
                this.siteDetailsTableAdapter.FillBySiteID(this.sbi_salesdbDataSet.SiteDetails, siteID);
                this.jobTableAdapter.Fill(this.sbi_salesdbDataSet.Job);


            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DataRowView currentSite = (DataRowView)siteDetailsBindingSource.Current;
            int siteID = Convert.ToInt32(currentSite["SiteID"]);
            string name = Convert.ToString(this.sbi_salesdbDataSet.SiteDetails.FindBySiteID(siteID)["Name"]);

            if (this.jobTableAdapter.FindChildren(siteID) > 0)
            {
                MessageBox.Show("Site has active jobs- please remove or move these before deleting the site record");

            }
            else
            {
                if(MessageBox.Show("Are you sure you want to remove " + name + " from the database?","Delete Record?" ,MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    sbi_salesdbDataSet.SiteDetailsRow r = this.sbi_salesdbDataSet.SiteDetails.FindBySiteID(siteID);
                    r.Delete();
                    siteDetailsBindingNavigatorSaveItem.PerformClick();

                }
            }
        }
    }
}
