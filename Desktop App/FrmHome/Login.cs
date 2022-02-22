using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmHome
{
    public partial class Login : Form
    {
        public ExaminationContext Ctx;
        public ExaminationContextProcedures Procedures;
        public Entities.GetUserResult userInfo;
        public Login()
        {
            Ctx = new ExaminationContext();
            Procedures = new ExaminationContextProcedures(Ctx);
            InitializeComponent();
            this.Resize += (sender, e) => Trace.WriteLine(this.Size);
            this.FormClosed += (sender, e) => Ctx?.Dispose();
        }
        protected override void OnLoad(EventArgs e)
        {
            
            base.OnLoad(e);
        }
    
        protected override void OnPaint(PaintEventArgs e)
        {
           
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            const string message =
            "Are you sure that you would like to close the application?";
            const string caption = "Confirmation";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.No)
                e.Cancel = true;         
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            
            var users = await Procedures.GetUserAsync(txtEmail.Text, txtPassword.Text, new OutputParameter<int>());
            
            if (users.Count == 0)
                MessageBox.Show("Incorrect E-mail or password, please try again", "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            else
            {
                userInfo = users[0];
                MessageBox.Show($"Welcome {userInfo.f_name}", "Success",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                if (userInfo.user_type.ToLower() == "s")
                {
                    Student_Dashboard stdDash = new Student_Dashboard(this);
                    this.Hide();
                    stdDash.Show();
                }
                else
                {
                    Admin_Dashboard adminDash = new Admin_Dashboard(this);
                    this.Hide();
                    adminDash.Show();                
                }
                                    
            }
                
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register frmRegister = new Register(this);
            frmRegister.ShowDialog();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
