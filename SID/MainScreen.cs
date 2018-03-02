using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;



namespace SID

{
    public partial class MainScreen : Form
    {

        private ClientList2 clientList;
        private NavButtons navButtons;
        private Form backgroundForm;
        public MainScreen()
        {

           
                InitializeComponent();
                
                Login login = new Login();
                login.ShowDialog();

            if (Session.loaded)
            {
                ;
                if (clientList == null)
                {
                    slUser.Text = Session.UserName();
                    
                    bool disable = Control.ModifierKeys == Keys.Shift;
                    if (Properties.Settings.Default.AutoImportInstall && !disable)
                    {
                        ImportInstall import = new ImportInstall();
                        import.GetImportTable();
                        import.UpdateSOPList();
                    }
                    //MessageBox.Show("Loaded");
                    clientList = new ClientList2();
                }
                this.WindowState = FormWindowState.Maximized;


                navButtons = new NavButtons();
                this.Controls.Add(navButtons);
                navButtons.Dock = DockStyle.Top;
                navButtons.Dock = DockStyle.Left;
                navButtons.Enabled = true;
                navButtons.Visible = true;
                navButtons.BringToFront();

                this.LoadBackgroundForm(clientList);
               
                
            }
            else
            {
                MessageBox.Show("Login failed");
                this.Load += new EventHandler(CloseOnStart);

            }

        }
                
        private void CloseOnStart(object sender, EventArgs e)
        {
            this.Close();
        }


            
        
        public void LoadBackgroundForm(Form background)
        {
            if (backgroundForm != null)
            {
                backgroundForm.Close();
            }
            backgroundForm = background;
            
            backgroundForm.MdiParent = this;

            backgroundForm.Show();
            //backgroundForm.Dock = DockStyle.Fill;
            backgroundForm.WindowState = FormWindowState.Maximized;

            

            
        }

        
        
        
    }
}
