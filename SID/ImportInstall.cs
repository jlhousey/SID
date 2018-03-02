using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SID.sbi_salesdbDataSetTableAdapters;
using System.Data;
using System.Windows.Forms;

namespace SID
{
    
    class ImportInstall
    
     

    {   private XlFileHandler xlFileHandler;
        private DataMapping dm;
        private DataTable importItems;
        private sbi_salesdbDataSet sbi_salesdbDataSet;
        private InstallScheduleTableAdapter installScheduleTableAdapter;
        private string xlCols;
        private string sqlCols;
        private int installSheetNumber;
        private string filename;
        private string destpath;
        private int[] rowArray;
        
        
        
        public ImportInstall()
        {
            sbi_salesdbDataSet = new sbi_salesdbDataSet();
            
            
            
            try
            {
                xlCols = Properties.Settings.Default.InstallMappings;
                sqlCols = Properties.Settings.Default.SqlInstallMappings;
                installSheetNumber = Convert.ToInt32(Properties.Settings.Default.InstallSheetNumber);
                string rows = Properties.Settings.Default.InstallRows;
                filename = Properties.Settings.Default.InstallScheduleLocation;
                destpath = Properties.Settings.Default.TempFileDirectory;
                rowArray = rows.Split(',').Select(s => Int32.Parse(s)).ToArray();
                
            }
            catch
            {
                MessageBox.Show("Install Schedule Import settings in wrong format, see config file.");
            }

            


        }

       public void GetImportTable()
        {
            string destfile = "ImportedInstall" + Session.UserName() + ".xlsx";

            xlFileHandler = new XlFileHandler("", destfile, filename, destpath);
            xlFileHandler.FileCopy(false);
            dm = new DataMapping(xlCols, sqlCols, sbi_salesdbDataSet.InstallSchedule);
            
            
            
            dm.RowSelect(rowArray, true);
            string ofileName = xlFileHandler.OutputFile();
            importItems = dm.OutputTable(ofileName, 1);
            

        }


       public void UpdateSOPList()
        {
            installScheduleTableAdapter = new InstallScheduleTableAdapter();
            installScheduleTableAdapter.Fill(sbi_salesdbDataSet.InstallSchedule);
            List<string> newSOPS = new List<String>();
            foreach (DataRow r in importItems.Rows)
            {
                
                if (ValidateSOPNumber(r))
                {
                    //remove asterisk characters used to mark if a job is a revist.

                    string val = r["SOPID"].ToString().Replace("*", "");
                    string val2 = r["InstallNumber"].ToString();
                    int val3 = Convert.ToInt32(val)*100 + Convert.ToInt32(val2);
                    Convert.ToInt32(val2);
                    DataRow s = sbi_salesdbDataSet.InstallSchedule.FindByInstallID(val3);
                    
                    if (s == null)
                    {
                       
                            DataRow newRow = sbi_salesdbDataSet.InstallSchedule.NewRow();
                            newRow["InstallID"] = val3;
                            for (int i = 0; i < importItems.Columns.Count; i++)
                            {
                                string clm = importItems.Columns[i].ColumnName;
                                if (sbi_salesdbDataSet.InstallSchedule.Columns.Contains(clm)&& clm!="InstallID")
                                {
                                    newRow[clm] = r[i];
                                }
                            }
                            sbi_salesdbDataSet.InstallSchedule.Rows.Add(newRow); 
                        
                    }
                    else
                    {
                        
                            if (s.RowState != DataRowState.Modified)
                            {
                                s["InstallDate"] = r["InstallDate"];
                                if (r["InstallDate"] == DBNull.Value)
                                {
                                    s["InstallDate"] = new DateTime(2100,1,1);
                                }
                                else
                                {
                                    s["InstallDate"] = r["InstallDate"];
                                }
                                
                                
                                if (r["Rag"] == DBNull.Value)
                                {
                                    s["Rag"] = 3;
                                }
                                else
                                {
                                    s["RAG"] = r["RAG"];
                                }
                            } 
                        
                    
                    }
                }
               
            }
            UpdateDatabase();
            
        }

       private bool ValidateSOPNumber(DataRow r)
       {
           if (r["SOPID"] == DBNull.Value || r["InstallNumber"] == DBNull.Value)
           {
               return false;
           }
           else
	        {
                //remove asterisk characters used to mark if a job is a revist.
               // check if the string looks like a number
	            string val = r["SOPID"].ToString().Replace("*", "");
                string val2 = r["SOPID"].ToString();
                try
                {
                    Convert.ToInt32(val);
                    Convert.ToInt32(val2);
                    return true;
                }
                catch
                {
                    string errorRow = (rowArray[0]+ importItems.Rows.IndexOf(r)).ToString();
                    MessageBox.Show("Invalid entry on row " + errorRow + " of Install schedule. \n The SOP number " + val + "or install number" + val2 + " could not be read");
                    return false;
                } 
	        }
       }

        private void UpdateDatabase()
        {
            try
            {
                this.installScheduleTableAdapter.Update(this.sbi_salesdbDataSet);
                MessageBox.Show("Update successful");
            }
            catch (DBConcurrencyException dbcx)
            {
                DialogResult response = MessageBox.Show(CreateMessage((sbi_salesdbDataSet.InstallScheduleRow)
                    (dbcx.Row)), "Concurrency Exception", MessageBoxButtons.YesNo);

                ProcessDialogResult(response);
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("An error was thrown while attempting to update the database." + ex.Message);
            }
        }
        private string CreateMessage(sbi_salesdbDataSet.InstallScheduleRow cr)
        {
            return
                "Someone had made  change while you were updating the Install Schedule \n" +
                "Database: " + GetRowData(GetCurrentRowInDB(cr), DataRowVersion.Default) + "\n" +
                "Original: " + GetRowData(cr, DataRowVersion.Original) + "\n" +
                "Proposed: " + GetRowData(cr, DataRowVersion.Current) + "\n" +
                "Do you still want to update the database with the proposed value?";
        }
        //-------------------------------------------------------------------------- 
        // This method loads a temporary table with current records from the database 
        // and returns the current values from the row that caused the exception. 
        //-------------------------------------------------------------------------- 
        private sbi_salesdbDataSet.InstallScheduleDataTable tempSOPDataTable =
            new sbi_salesdbDataSet.InstallScheduleDataTable();

        private sbi_salesdbDataSet.InstallScheduleRow GetCurrentRowInDB(sbi_salesdbDataSet.InstallScheduleRow RowWithError)
        {
            this.installScheduleTableAdapter.Fill(tempSOPDataTable);

            sbi_salesdbDataSet.InstallScheduleRow currentRowInDb =
                tempSOPDataTable.FindByInstallID(RowWithError.SOPID);

            return currentRowInDb;
        }


        //-------------------------------------------------------------------------- 
        // This method takes a Row and RowVersion  
        // and returns a string of column values to display to the user. 
        //-------------------------------------------------------------------------- 
        private string GetRowData(sbi_salesdbDataSet.InstallScheduleRow depRow, DataRowVersion RowVersion)
        {
            string rowData = "";

            for (int i = 0; i < depRow.ItemArray.Length; i++)
            {
                rowData = rowData + depRow[i, RowVersion].ToString() + " ";
            }
            return rowData;
        }


        // This method takes the DialogResult selected by the user and updates the database  
        // with the new values or cancels the update and resets the Customers table  
        // (in the dataset) with the values currently in the database. 

        private void ProcessDialogResult(DialogResult response)
        {
            switch (response)
            {
                case DialogResult.Yes:
                    sbi_salesdbDataSet.Merge(tempSOPDataTable, true, MissingSchemaAction.Ignore);
                    UpdateDatabase();
                    break;

                case DialogResult.No:
                    sbi_salesdbDataSet.Merge(tempSOPDataTable);
                    MessageBox.Show("Update cancelled");
                    break;
            }
        }
    }
}
