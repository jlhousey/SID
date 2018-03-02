using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SID
{
    public partial class EditJob : Form
    {
        int cID = 0;
        public int returnJobId = 0;
        private DataTable modified;
        public EditJob()
        {
            InitializeComponent();
            this.lineTableAdapter.Fill(this.sbi_salesdbDataSet.Line);
            // TODO: This line of code loads data into the 'sbi_salesdbDataSet.Job' table. You can move, or remove it, as needed.
            this.jobTableAdapter.Fill(this.sbi_salesdbDataSet.Job);
            this.siteDetailsTableAdapter.Fill(this.sbi_salesdbDataSet.SiteDetails);
            // TODO: This line of code loads data into the 'sbi_salesdbDataSet.Line' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.sbi_salesdbDataSet.Client);
            // TODO: This line of code loads data into the 'sbi_salesdbDataSet.SiteDetails' table. You can move, or remove it, as needed.
            siteDetailsBindingSource.Sort = "Name";
        }

        public EditJob(int clientID, bool newItem)
        {
            cID = clientID;
            // TODO: This line of code loads data into the 'sbi_salesdbDataSet.Line' table. You can move, or remove it, as needed.
            InitializeComponent();
            this.lineTableAdapter.Fill(this.sbi_salesdbDataSet.Line);
            // TODO: This line of code loads data into the 'sbi_salesdbDataSet.Job' table. You can move, or remove it, as needed.
            this.jobTableAdapter.Fill(this.sbi_salesdbDataSet.Job);
            this.siteDetailsTableAdapter.FillByClient(this.sbi_salesdbDataSet.SiteDetails,clientID);
            // TODO: This line of code loads data into the 'sbi_salesdbDataSet.Line' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.sbi_salesdbDataSet.Client);
            // TODO: This line of code loads data into the 'sbi_salesdbDataSet.SiteDetails' table. You can move, or remove it, as needed.
            siteDetailsBindingSource.Sort = "Name";
            if (newItem)
            {
                DataRow dr = sbi_salesdbDataSet.Job.NewRow();

                sbi_salesdbDataSet.Job.Rows.Add(dr);
                this.jobBindingSource.Position = sbi_salesdbDataSet.Job.Rows.IndexOf(dr);

            }
        }
        public EditJob(int clientID, int siteID, bool newItem)
        {
            cID = clientID;
            // TODO: This line of code loads data into the 'sbi_salesdbDataSet.Line' table. You can move, or remove it, as needed.
            InitializeComponent();
            this.lineTableAdapter.Fill(this.sbi_salesdbDataSet.Line);
            // TODO: This line of code loads data into the 'sbi_salesdbDataSet.Job' table. You can move, or remove it, as needed.
            this.jobTableAdapter.Fill(this.sbi_salesdbDataSet.Job);
            this.siteDetailsTableAdapter.FillByClient(this.sbi_salesdbDataSet.SiteDetails, clientID);
            // TODO: This line of code loads data into the 'sbi_salesdbDataSet.Line' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.sbi_salesdbDataSet.Client);
            // TODO: This line of code loads data into the 'sbi_salesdbDataSet.SiteDetails' table. You can move, or remove it, as needed.
            siteDetailsBindingSource.Sort = "Name";
            if (newItem)
            {
                DataRow dr = sbi_salesdbDataSet.Job.NewRow();
                dr["SiteID"] = siteID;

                sbi_salesdbDataSet.Job.Rows.Add(dr);
                this.jobBindingSource.Position = sbi_salesdbDataSet.Job.Rows.IndexOf(dr);
                //comboBox1.SelectedValue = siteID;
            }

        }
        public EditJob(int clientID, int jobID)
        {
            // TODO: This line of code loads data into the 'sbi_salesdbDataSet.Line' table. You can move, or remove it, as needed.
            InitializeComponent();
            this.lineTableAdapter.Fill(this.sbi_salesdbDataSet.Line);
            // TODO: This line of code loads data into the 'sbi_salesdbDataSet.Job' table. You can move, or remove it, as needed.
            this.jobTableAdapter.FillByJobID(this.sbi_salesdbDataSet.Job,jobID);
            this.siteDetailsTableAdapter.FillByClient(this.sbi_salesdbDataSet.SiteDetails, clientID);
            //this.siteDetailsTableAdapter.Fill(this.sbi_salesdbDataSet.SiteDetails);
            // TODO: This line of code loads data into the 'sbi_salesdbDataSet.Line' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.sbi_salesdbDataSet.Client);
            // TODO: This line of code loads data into the 'sbi_salesdbDataSet.SiteDetails' table. You can move, or remove it, as needed.
            cID = clientID;
            siteDetailsBindingSource.Sort = "Name";

        }

        private void jobBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                DataRowView drv1 = (DataRowView)jobBindingSource.Current;
                this.Validate();

                this.lineBindingSource.EndEdit();

                //getmodified();

                this.jobBindingSource.EndEdit();
                this.lineBindingSource.EndEdit();
                if (drv1["SiteID"] != null && drv1["SiteID"] != DBNull.Value && comboBox1.SelectedIndex != -1)
                {
                    bool proceed = true;
                    if (drv1["SOPID"] != null && drv1["SOPID"] != DBNull.Value)
                    {
                        if (this.jobTableAdapter.CountSOP(Convert.ToInt32(drv1["SOPID"])) > 0)
                        {
                            DataTable sopJobs = this.jobTableAdapter.GetDataBySOPID(Convert.ToInt32(drv1["SOPID"]));
                            DataRow drv2 = sopJobs.Rows[0];
                            if (Convert.ToInt32(drv1["JobID"]) != Convert.ToInt32(drv2["JobID"]))
                            {
                                int dupeSiteID = Convert.ToInt32(drv2["SiteID"]);
                                sbi_salesdbDataSet.SiteDetailsDataTable dupeSite = this.siteDetailsTableAdapter.GetDataBySiteID(dupeSiteID);
                                string dupeSiteName = Convert.ToString(dupeSite.FindBySiteID(dupeSiteID)["Name"]);
                                int dupeClientID = Convert.ToInt32(dupeSite.FindBySiteID(dupeSiteID)["ClientID"]);
                                sbi_salesdbDataSet.ClientDataTable dupeClient = this.clientTableAdapter.GetDataByClient(dupeClientID);
                                string dupeClientName = Convert.ToString(dupeClient.FindByClientID(dupeClientID)["Name"]);

                                MessageBox.Show("SOP " + Convert.ToInt32(drv1["SOPID"]) + " already exists in the database within " + dupeClientName + " " + dupeSiteName + ". Please check and adjust your data as necessary.");


                                proceed = false;
                            }
                        }
                    }

                    if (proceed)
                    {

                        this.lineTableAdapter.Update(this.sbi_salesdbDataSet.Line);
                        this.tableAdapterManager.UpdateAll(this.sbi_salesdbDataSet);
                        //if (modified != null)
                        //{
                        //    this.sbi_salesdbDataSet.Line.Merge(modified);
                        //    this.lineTableAdapter.Update(sbi_salesdbDataSet.Line);
                        //    this.tableAdapterManager.UpdateAll(this.sbi_salesdbDataSet);
                        //    modified.Clear();

                        //}
                        DataRowView drv = (DataRowView)jobBindingSource.Current;
                        int currentJob = Convert.ToInt32(drv["JobID"]);
                        returnJobId = currentJob;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                } 
            }

        }
        private void getmodified()
        {
            DataTable changes = this.sbi_salesdbDataSet.Line.GetChanges();
            if (changes != null && changes.Rows.Count > 0)
            {

                modified = this.sbi_salesdbDataSet.Line.Clone();
                modified.PrimaryKey = null;
                modified.Columns["LineID"].Unique = false;
                foreach (DataRow r in changes.Rows)
                {
                    updateAllocation(r);
                    DataRow original = modified.NewRow();
                    for (int i = 0; i < changes.Columns.Count; i++)
                    {

                        original[i] = r[i, DataRowVersion.Original];
                    }

                    string connectionString = Properties.Settings.Default.sbi_salesdbConnectionString;

                    int jID = Convert.ToInt32(original["JobID"]);
                    int newLine = -1;


                    original["Deleted"] = 1;
                    original["ModifiedBy"] = Session.UserID;
                    original["DateModified"] = DateTime.Today;
                    original["LineID"] = newLine;

                    modified.Rows.Add(original);
                }

            }

        }

        private void updateAllocation(DataRow r)
        {
            string oi = Convert.ToString(r["OIDate"]);
            if (!String.IsNullOrWhiteSpace(oi))
                
            {
                {
                    int lineID = Convert.ToInt32(r["LineId"].ToString());
                    DateTime sDate = Convert.ToDateTime(r["OIDate"].ToString());


                    DateTime firstDayOfTheMonth = new DateTime(sDate.Year, sDate.Month, 1);
                    DateTime eomonth = firstDayOfTheMonth.AddMonths(1).AddDays(-1);

                    this.sbi_salesdbDataSet.Line.FindByLineID(lineID).OIAllocatedMonth = eomonth;
                }
            }

            string install = Convert.ToString(r["InstallDate"]);

            if (!String.IsNullOrWhiteSpace(install))
            {
                {
                    int lineID = Convert.ToInt32(r["LineId"].ToString());
                    DateTime sDate = Convert.ToDateTime(r["InstallDate"].ToString());

                    DateTime wedOfWeek = sDate.AddDays(3 - Convert.ToInt32(sDate.DayOfWeek));
                    DateTime firstDayOfTheMonth = new DateTime(wedOfWeek.Year, wedOfWeek.Month, 1);
                    DateTime eomonth = firstDayOfTheMonth.AddMonths(1).AddDays(-1);

                    this.sbi_salesdbDataSet.Line.FindByLineID(lineID).SalesAllocatedMonth = eomonth;
                }
            }
        }

        private void EditJob_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sbi_salesdbDataSet1.SAM' table. You can move, or remove it, as needed.
            this.sAMTableAdapter.Fill(this.sbi_salesdbDataSet1.SAM);
            // TODO: This line of code loads data into the 'sbi_salesdbDataSet1.ProductType' table. You can move, or remove it, as needed.
            this.productTypeTableAdapter.Fill(this.sbi_salesdbDataSet1.ProductType);
            // TODO: This line of code loads data into the 'sbi_salesdbDataSet1.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.sbi_salesdbDataSet1.Category);
            // TODO: This line of code loads data into the 'sbi_salesdbDataSet1.Status' table. You can move, or remove it, as needed.
            this.statusTableAdapter.Fill(this.sbi_salesdbDataSet1.Status);
            // TODO: This line of code loads data into the 'sbi_salesdbDataSet1.Line' table. You can move, or remove it, as needed.
            this.lineTableAdapter.Fill(this.sbi_salesdbDataSet1.Line);
            // TODO: This line of code loads data into the 'sbi_salesdbDataSet1.DAM' table. You can move, or remove it, as needed.
            this.dAMTableAdapter.Fill(this.sbi_salesdbDataSet1.DAM);
            // TODO: This line of code loads data into the 'sbi_salesdbDataSet.Client' table. You can move, or remove it, as needed.


            //this.lineTableAdapter.Fill(this.sbi_salesdbDataSet.Line);
            // TODO: This line of code loads data into the 'sbi_salesdbDataSet.Job' table. You can move, or remove it, as needed.
            //this.jobTableAdapter.Fill(this.sbi_salesdbDataSet.Job);
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                this.Validate();
                this.jobBindingSource.EndEdit();
                this.lineBindingSource.EndEdit();
                this.lineTableAdapter.Update(this.sbi_salesdbDataSet.Line);
                this.tableAdapterManager.UpdateAll(this.sbi_salesdbDataSet);
                DataRowView drv = (DataRowView)jobBindingSource.Current;
                int currentJob = Convert.ToInt32(drv["JobID"]);

                if (currentJob != -1)
                {
                    string connectionString = Properties.Settings.Default.sbi_salesdbConnectionString;
                    string commandText = "CreateLine";
                    int jID = currentJob;
                    int newLine;
                    int samID = 1;
                    int damID = 1;
                    if (cID != 0)
                    {
                        damID = Convert.ToInt32(sbi_salesdbDataSet.Client.FindByClientID(cID)["DAMID"]);
                        samID = Convert.ToInt32(sbi_salesdbDataSet1.DAM.FindByDAMID(damID)["SAMID"]);

                    }

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand(commandText, conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add(new SqlParameter("@JobID", jID));
                            cmd.Parameters.Add(new SqlParameter("@DamID", damID));
                            cmd.Parameters.Add(new SqlParameter("@SAMID", samID));


                            SqlParameter LineID = new SqlParameter("@LineID", SqlDbType.Int);
                            LineID.Direction = ParameterDirection.Output;
                            cmd.Parameters.Add(LineID);

                            conn.Open();
                            cmd.ExecuteNonQuery();

                            //MessageBox.Show("LineID" + LineID.Value);
                            newLine = Convert.ToInt32(LineID.Value);
                        }
                    }

                    EditLine el = new EditLine(newLine, samID, damID);
                    el.ShowDialog();
                    this.lineTableAdapter.Fill(this.sbi_salesdbDataSet.Line);
                }


            }
            
            
        }

        private void lineDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {
            //MessageBox.Show("Error happened " + anError.Context.ToString() + anError.ColumnIndex);

            if (anError.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show("Commit error");
            }
            if (anError.Context == DataGridViewDataErrorContexts.CurrentCellChange)
            {
                MessageBox.Show("Cell change");
            }
            if (anError.Context == DataGridViewDataErrorContexts.Parsing)
            {
                MessageBox.Show("parsing error");
            }
            if (anError.Context == DataGridViewDataErrorContexts.LeaveControl)
            {
                MessageBox.Show("leave control error");
            }

            if ((anError.Exception) is ConstraintException)
            {
                DataGridView view = (DataGridView)sender;
                view.Rows[anError.RowIndex].ErrorText = "an error";
                view.Rows[anError.RowIndex].Cells[anError.ColumnIndex].ErrorText = "an error";

                anError.ThrowException = false;
            }

        }

        private void lineDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            /*DataRowView drv = (DataRowView)jobBindingSource.Current;
            int currentJob = Convert.ToInt32(drv["JobID"]);
            e.Row.Cells["DAMID"].Value = this.sbi_salesdbDataSet.Client.FindByClientID(Convert.ToInt32(comboBox2.SelectedValue)).DAMID;
            e.Row.Cells["JobID"].Value = currentJob;*/
        }

        private void lineDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex == -1 || e.ColumnIndex == -1))
            {
                int lineId = Convert.ToInt32(lineDataGridView.Rows[e.RowIndex].Cells["LineID"].Value);
                EditLine el = new EditLine(lineId);
                el.ShowDialog();
                this.lineTableAdapter.Fill(this.sbi_salesdbDataSet.Line);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)clientBindingSource.Current;
            //currentPO["Name"] = tbPO

            
            int currentClient = Convert.ToInt32(drv["ClientID"]);

            if (currentClient != -1)
            {
                string connectionString = Properties.Settings.Default.sbi_salesdbConnectionString;
                string commandText = "CreateSite";
                int cID = currentClient;
                int newSite;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(commandText, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add(new SqlParameter("@ClientID", cID));
                        SqlParameter SiteID = new SqlParameter("@SiteID", SqlDbType.Int);
                        SiteID.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(SiteID);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                       // MessageBox.Show("SiteID" + SiteID.Value);
                        newSite = Convert.ToInt32(SiteID.Value);
                    }
                }

                EditSite es = new EditSite(newSite);
                es.button1.Visible = false;
                es.ShowDialog();
                this.siteDetailsTableAdapter.FillBySiteID(this.sbi_salesdbDataSet.SiteDetails, newSite);
            }
            
            
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DataRowView currentJob = (DataRowView)jobBindingSource.Current;
            int jobID = Convert.ToInt32(currentJob["jobID"]);
            string name = Convert.ToString(this.sbi_salesdbDataSet.Job.FindByJobID(jobID)["SOPID"]);

            if (this.lineTableAdapter.FindChildren(jobID) > 0)
            {
                MessageBox.Show("Job has active lines- please remove or move these before deleting the job record");

            }
            else
            {
                if (MessageBox.Show("Are you sure you want to remove " + name + " from the database?", "Delete Record?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    sbi_salesdbDataSet.JobRow r = this.sbi_salesdbDataSet.Job.FindByJobID(jobID);
                    r.Delete();
                    this.jobBindingSource.EndEdit();
                    
                    this.jobTableAdapter.Update(this.sbi_salesdbDataSet.Job);
                    this.tableAdapterManager.UpdateAll(this.sbi_salesdbDataSet);
                    this.Close();

                }
            }
        }
    }
}
