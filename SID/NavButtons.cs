using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SID
{
    public partial class NavButtons : UserControl
    {
        public NavButtons()
        {
            InitializeComponent();
        }

        private void btnPurchaseOrders_Click(object sender, EventArgs e)
        {
            MainScreen mf = this.FindForm() as MainScreen;
            SOPReg sr = mf.ActiveMdiChild as SOPReg;
            ClientList2 cl = mf.ActiveMdiChild as ClientList2;
            if (sr != null)
            {
                sr.saveChanges();
            }
            else
            {
                if (cl != null)
                {
                    cl.saveChanges();
                }
            }

            ImportInstall import = new ImportInstall();
            import.GetImportTable();
            import.UpdateSOPList();



            SOPReg sr2 = new SOPReg();
            mf.LoadBackgroundForm(sr2);
            sr2.RefreshInstall();



        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            MainScreen mf = this.FindForm() as MainScreen;
            SOPReg sr = mf.ActiveMdiChild as SOPReg;
            ClientList2 cl = mf.ActiveMdiChild as ClientList2;
            if (sr != null)
            {
                sr.saveChanges();
            }
            else
            {
                if (cl != null)
                {
                    cl.saveChanges();
                }
            }

            SelectDeveloper sd = new SelectDeveloper(true);
            sd.ShowDialog();
            if (sr != null)
            {
                sr.RefreshAfterAdd();
                //mf.LoadBackgroundForm(sr);
            }
            else
            {
               
                if (cl != null)
                {
                    cl.RefreshAfterAdd();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainScreen mf = this.FindForm() as MainScreen;
            SOPReg sr = mf.ActiveMdiChild as SOPReg;
            ClientList2 cl = mf.ActiveMdiChild as ClientList2;
            if (sr != null)
            {
                sr.saveChanges();
            }
            else
            {
                if (cl != null)
                {
                    cl.saveChanges();
                }
            }

            EditDeveloper ed = new EditDeveloper(true);
            ed.ShowDialog();
            if (sr != null)
            {
                sr.RefreshAfterAdd();
                //mf.LoadBackgroundForm(sr);
            }
            else
            {
                
                if (cl != null)
                {
                    cl.RefreshAfterAdd();
                }
            }
        }

        private void btnSOPList_Click(object sender, EventArgs e)
        {
            MainScreen mf = this.FindForm() as MainScreen;
            SOPReg sr = mf.ActiveMdiChild as SOPReg;
            ClientList2 cl = mf.ActiveMdiChild as ClientList2;
            if (sr != null)
            {
                sr.saveChanges();
            }
            else
            {
                if (cl != null)
                {
                    cl.saveChanges();
                }
            }
            SelectClient sc = new SelectClient();
            sc.ShowDialog();
            if (sr != null)
            {
                sr.RefreshAfterAdd();
                //mf.LoadBackgroundForm(sr);
            }
            else
            {
                
                if (cl != null)
                {
                    cl.RefreshAfterAdd();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int jobID = 0;
            MainScreen mf = this.FindForm() as MainScreen;
            SOPReg sr = mf.ActiveMdiChild as SOPReg;
            ClientList2 cl = mf.ActiveMdiChild as ClientList2;
            if (sr!=null)
            {
                sr.saveChanges(); 
            }
            else if (cl != null)
            {
                cl.saveChanges();
            }
            ;
            
            using (SelectClient sc = new SelectClient(true))
            {

                var result = sc.ShowDialog();
                if (result == DialogResult.OK)
                {
                    jobID = sc.returnNewJob;

                }

            }

            if (sr!= null)
            {
                sr.RefreshAfterAdd(jobID);
                //mf.LoadBackgroundForm(sr);
            }
            else
            {
               
                if (cl != null)
                {
                    cl.RefreshAfterAdd(jobID);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MainScreen mf = this.FindForm() as MainScreen;
            SOPReg sr = mf.ActiveMdiChild as SOPReg;
            ClientList2 cl = mf.ActiveMdiChild as ClientList2;

            if (sr != null)
            {
                sr.saveChanges();
            }
            else
            {
                if (cl != null)
                {
                    cl.saveChanges();
                }
            }


            mf.LoadBackgroundForm(new ClientList2());
        }

        private void btnDepOverview_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAllocate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLeadScreen_Click(object sender, EventArgs e)
        {
            MainScreen mf = this.FindForm() as MainScreen;
            SOPReg sr = mf.ActiveMdiChild as SOPReg;
            ClientList2 cl = mf.ActiveMdiChild as ClientList2;

            if (sr != null)
            {
                sr.saveChanges();
            }
            else
            {
                if (cl != null)
                {
                    cl.saveChanges();
                }
            }



            mf.LoadBackgroundForm(new SOPReg());
            
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            MainScreen mf = this.FindForm() as MainScreen;
            SOPReg sr = mf.ActiveMdiChild as SOPReg;
            ClientList2 cl = mf.ActiveMdiChild as ClientList2;

            if (sr != null)
            {
                sr.saveChanges();
            }
            else
            {
                if (cl != null)
                {
                    cl.saveChanges();
                }
            }

            SelectSite ss = new SelectSite();
            ss.ShowDialog();
            if (sr != null)
            {
                sr.RefreshAfterAdd();
                //mf.LoadBackgroundForm(sr);
            }
            else
            {
                
                if (cl != null)
                {
                    cl.RefreshAfterAdd();
                }
            }


        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            
        }

        private void btPOList_Click(object sender, EventArgs e)
        {
            MainScreen mf = this.FindForm() as MainScreen;
            SOPReg sr = mf.ActiveMdiChild as SOPReg;
            ClientList2 cl = mf.ActiveMdiChild as ClientList2;

            if (sr != null)
            {
                sr.saveChanges();
            }
            else
            {
                if (cl != null)
                {
                    cl.saveChanges();
                }
            }

            SelectJob sj = new SelectJob();
            sj.ShowDialog();
            if (sr != null)
            {
                sr.RefreshAfterAdd();
                //mf.LoadBackgroundForm(sr);
            }
            else
            {
               
                if (cl != null)
                {
                    cl.RefreshAfterAdd();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainScreen mf = this.FindForm() as MainScreen;
            SOPReg sr = mf.ActiveMdiChild as SOPReg;
            ClientList2 cl = mf.ActiveMdiChild as ClientList2;
            if (sr != null)
            {
                sr.saveChanges();
            }
            else
            {
                if (cl != null)
                {
                    cl.saveChanges();
                }
            }

            EditDAM ed = new EditDAM(true);
            ed.ShowDialog();
            if (sr != null)
            {
                sr.RefreshAfterAdd();
                //mf.LoadBackgroundForm(sr);
            }
            else
            {
                
                if (cl != null)
                {
                    cl.RefreshAfterAdd();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainScreen mf = this.FindForm() as MainScreen;
            SOPReg sr = mf.ActiveMdiChild as SOPReg;
            ClientList2 cl = mf.ActiveMdiChild as ClientList2;
            if (sr != null)
            {
                sr.saveChanges();
            }
            else
            {
                if (cl != null)
                {
                    cl.saveChanges();
                }
            }

            SelectDAM sd = new SelectDAM();
            sd.ShowDialog();
            if (sr != null)
            {
                sr.RefreshAfterAdd();
                //mf.LoadBackgroundForm(sr);
            }
            else
            {
                
                if (cl != null)
                {
                    cl.RefreshAfterAdd();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int jobID = 0;
            string filter = "";
            MainScreen mf = this.FindForm() as MainScreen;
            SOPReg sr = mf.ActiveMdiChild as SOPReg;
            ClientList2 cl = mf.ActiveMdiChild as ClientList2;
            if (sr != null)
            {
                sr.saveChanges();
            }
            else
            {
                if (cl != null)
                {
                    cl.saveChanges();
                }
            }


            using (SelectClient sc = new SelectClient(false))
            {

                var result = sc.ShowDialog();
                if (result == DialogResult.OK)
                {
                    jobID = sc.returnNewJob;
                    filter = sc.returnNewFilter;

                }

            }

            if (sr != null)
            {
                sr.RefreshAfterAdd(filter);
                //mf.LoadBackgroundForm(sr);
            }
            else
            {
                
                if (cl != null)
                {
                    cl.RefreshAfterAdd(filter);
                }
            }
            

        }
    }
}
