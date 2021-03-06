using LinqToExcel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinqToExcel.Extensions;

namespace DriverUI
{
    public partial class DashBoard : Form
    {
        TcpServer server;

        public DashBoard()
        {
            InitializeComponent();
            server = new TcpServer(12000,this);
        }

        #region Form Events
        private void DashBoard_Load(object sender, EventArgs e)
        {
            SQLDataClassesDataContext db = new SQLDataClassesDataContext();
            lookUpEdit.Properties.DataSource = VMSGridControl.DataSource = db.Vms;
            TodosGridControl.DataSource = db.TODOs;
            JobGridControl.DataSource = db.JOBs;
            AccountGridControl.DataSource = db.Accounts;
            Worker.RunWorkerAsync();
        }

        private void DashBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            server.StopListening();
        }
        private void IP_Box_Enter(object sender, EventArgs e)
        {
            if(VMS_Name_Box.Text!="All")
                IP_Box.Text = VMS_Name_Box.Text == "" ? "" : "172.16.0." + VMS_Name_Box.Text;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            SQLDataClassesDataContext db = new SQLDataClassesDataContext();
            var file = new OpenFileDialog() { Title = "import Accounts", Filter = "Excel Files (*.xlsx)|*.xlsx|All files (*.*)|*.*" };
            file.ShowDialog();
            var excelData = new ExcelQueryFactory(file.FileName);
            var data = from x in excelData.Worksheet<Account>("Sheet1")
                       select x;
            try
            {
                AccountGridControl.DataSource = data;
                db.Accounts.InsertAllOnSubmit(data);
                db.SubmitChanges();
                MessageBox.Show("Data imported Successfully..!", "Nice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Something Went Wrong..!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        #endregion

        #region Worker and Timer
        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            server.StartListening();

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            SQLDataClassesDataContext db = new SQLDataClassesDataContext();
            lookUpEdit.Properties.DataSource = VMSGridControl.DataSource = db.Vms.Where(x => true);
            JobGridControl.DataSource = db.JOBs.Where(x => true);
            TodosGridControl.DataSource = db.TODOs.Where(x => true);
            AccountGridControl.DataSource = db.Accounts.Where(x => true);

        }
        #endregion

        #region Metods
        public void addlog(string text)
        {
            logListBox.Items.Add(DateTime.Now + " : " + text);
        }
        #endregion

        #region Buttons Events
        private void AddVmsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SQLDataClassesDataContext db = new SQLDataClassesDataContext();
                var vm = new Vm()
                {
                    Id = Convert.ToInt32(VMS_Name_Box.Text),
                    IP = IP_Box.Text,
                    Status = "DOWN"
                };
                vm.Accounts.AddRange(db.Accounts.Where(x => x.VMS == Convert.ToInt32(VMS_Name_Box.Text)).OrderBy(x => x.Profile));
                db.Vms.InsertOnSubmit(vm);
                db.SubmitChanges();

                VMS_Name_Box.Text = "";
                IP_Box.Text = "";

                lookUpEdit.Properties.DataSource = VMSGridControl.DataSource = db.Vms.Select(x => new { x.Id, x.IP, x.Status });

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Something Went Wrong..!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void StartVMBtn_Click(object sender, EventArgs e)
        {
            if (VMS_Name_Box.Text == "All")
            {
                try
                {
                    SQLDataClassesDataContext db = new SQLDataClassesDataContext();
                    string respond = "";
                    foreach (var vm in db.Vms.Where(v => v.Status == "READY"))
                    {
                        try
                        {
                            respond += Client.SendAsync(vm.IP, 11000, "Start").Result + "\n";
                        }
                        catch (Exception) { respond+="vm \"" + vm.Id + "\" failed to start\n"; }
                    }
                    MessageBox.Show(respond);
                }
                catch (Exception ex){Console.WriteLine(ex.Message);}
                
            }
            else if(VMS_Name_Box.Text!=""&&IP_Box.Text!="")
            {
                try
                {
                    MessageBox.Show(Client.SendAsync(IP_Box.Text, 11000, "Start").Result);
                }
                catch (Exception) { MessageBox.Show("Failed to start"); }
            }
            
        }

        private void StopVMBtn_Click(object sender, EventArgs e)
        {
            if (IP_Box.Text == "") return;
            if (VMS_Name_Box.Text == "All")
            {
                try
                {
                    SQLDataClassesDataContext db = new SQLDataClassesDataContext();
                    string respond="";
                    foreach (var vm in db.Vms.Where(v => v.Status == "READY"))
                    {
                        try
                        {
                            respond +=Client.SendAsync(vm.IP, 11000, "Stop").Result+"\n";
                        }
                        catch (Exception) { respond += "vm \"" + vm.Id + "\" failed to stop\n"; }
                    }
                    MessageBox.Show(respond);
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            }
            else
            {
                try
                {
                    MessageBox.Show(Client.SendAsync(IP_Box.Text, 11000, "Stop").Result);
                }
                catch (Exception){MessageBox.Show("Failed to stop");}
            }
        }
        
        private void AddAccBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SQLDataClassesDataContext db = new SQLDataClassesDataContext();
                var acc = new Account
                {
                    VMS = Convert.ToInt32(lookUpEdit.EditValue),
                    Profile = Convert.ToInt32(Profile_Box.Text),
                    Name = Account_Name.Text,
                    Username = Username_Box.Text,
                    Password = Password_Box.Text,
                    Status = "Fine",
                };
                db.Accounts.InsertOnSubmit(acc);
                db.SubmitChanges();

                AccountGridControl.DataSource = db.Accounts.Where(x => true);

                lookUpEdit.EditValue = "";
                Account_Name.Text = "";
                Username_Box.Text = "";
                Password_Box.Text = "";
                Profile_Box.Text = "";
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Something Went Wrong..!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void AddJobBtn_Click(object sender, EventArgs e)
        {
            try
            {
                 SQLDataClassesDataContext db = new SQLDataClassesDataContext();
                if (VMS_Number_Box.Text == "All")
                {
                    foreach (var vm in db.Vms.Where(v=>v.Status=="READY").Select(x=>x.Id))
                    {
                        var job = new JOB
                        {
                            post_id = Post_Id_Box.Text,
                            action = Action_Box.Text,
                            text = Text_Box.Text == "" ? null : Text_Box.Text
                        };
                        var todo = new TODO
                        {
                            VMS = vm,
                            state = "waiting",
                            JOB = job

                        };
                        db.TODOs.InsertOnSubmit(todo);
                        db.JOBs.InsertOnSubmit(job);
                    }
                }
                else
                {
                    var job = new JOB
                    {
                        post_id = Post_Id_Box.Text,
                        action = Action_Box.Text,
                        text = Text_Box.Text == "" ? null : Text_Box.Text
                    };
                    var todo = new TODO
                    {
                        VMS = Convert.ToInt32(VMS_Number_Box.Text),
                        state = "waiting",
                        JOB = job

                    };
                    db.JOBs.InsertOnSubmit(job);
                    db.TODOs.InsertOnSubmit(todo);

                }
                
                db.SubmitChanges();
                VMS_Number_Box.Text = "";
                Post_Id_Box.Text = "";
                Action_Box.Text = "";
                Text_Box.Text = "";

                TodosGridControl.DataSource = db.TODOs.Where(x => true);
                JobGridControl.DataSource = db.JOBs.Where(x => true);


            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Something Went Wrong..!", MessageBoxButtons.OK, MessageBoxIcon.Error); }



        }
        #endregion

        #region grid Events
        private void gridControl2_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            Post_Id_Box.Text = gridView3.GetFocusedRowCellValue(colpost_id).ToString();
            Action_Box.Text = gridView3.GetFocusedRowCellValue(colaction).ToString();
            try
            {
                Text_Box.Text = gridView3.GetFocusedRowCellValue(coltext).ToString();
            }
            catch (Exception)
            {
                Text_Box.Text = "";
            }
        }

        private void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            SQLDataClassesDataContext db = new SQLDataClassesDataContext();
            db.SubmitChanges();
        }

        private void gridView2_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
        {
            SQLDataClassesDataContext db = new SQLDataClassesDataContext();
            db.TODOs.DeleteOnSubmit((db.TODOs.Single(x => x.Id == (e.Row as TODO).Id)));
            db.JOBs.DeleteOnSubmit((db.JOBs.Single(x => x.Id == (e.Row as TODO).JOB.Id)));
            db.SubmitChanges();


        }
        #endregion

        #region MenuStrip

        private async void startAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SQLDataClassesDataContext db = new SQLDataClassesDataContext();
                string respond = "";
                foreach (var vm in db.Vms.Where(v => v.Status == "READY"))
                {
                    try
                    {
                        respond += await Client.SendAsync(vm.IP, 11000, "Start") + "\n";
                    }
                    catch (Exception) { respond += "vm \"" + vm.Id + "\" failed to start\n"; }
                }
                MessageBox.Show(respond);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        private async void stopAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SQLDataClassesDataContext db = new SQLDataClassesDataContext();
                string respond = "";
                foreach (var vm in db.Vms.Where(v => v.Status == "READY"))
                {
                    try
                    {
                        respond += await Client.SendAsync(vm.IP, 11000, "Stop") + "\n";
                    }
                    catch (Exception) { respond += "vm \"" + vm.Id + "\" failed to stop\n"; }
                }
                MessageBox.Show(respond);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        private async void startThisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(await Client.SendAsync((gridView1.GetRow(gridView1.FocusedRowHandle).Cast<Vm>().IP), 11000, "Start"));
            }
            catch (Exception) { MessageBox.Show("Failed to start"); }
        }

        private async void stopThisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(await Client.SendAsync((gridView1.GetRow(gridView1.FocusedRowHandle).Cast<Vm>().IP), 11000, "Stop"));
            }
            catch (Exception) { MessageBox.Show("Failed to stop"); }
        }
    }
    #endregion
}
