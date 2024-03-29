﻿using Microsoft.EntityFrameworkCore;
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
    public partial class Student_UpdateInfo : Form
    {
        private readonly Login frmLogin;
        private readonly Student_Dashboard frmStdDashboard;
        public Student_UpdateInfo(Login _frmLogin, Student_Dashboard _frmStd)
        {
            InitializeComponent();
            this.Resize += (sender, e) => Invalidate();
            frmLogin = _frmLogin;
            frmStdDashboard = _frmStd;
        }

        private void button2_Click(object sender, EventArgs e)
        {     
            this.Close();
        }

        private async void btnInfo_Click(object sender, EventArgs e)
        {

                var result = new OutputParameter<int>();
                await frmLogin.Procedures.updateUserDataAsync(frmLogin.userInfo.usr_id, txtFname.Text, txtLname.Text,
                    txtAddress.Text, txtEmail.Text, txtPassword.Text, result);

            if (result.Value == 1)
            {
                MessageBox.Show($"Your information was updated successfully.", "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                var Name = $"{txtFname.Text} {txtLname.Text}";
                frmStdDashboard.UpdateUserInfo(frmStdDashboard.DeptID, frmLogin.userInfo.usr_id.ToString(), Name, txtEmail.Text, txtAddress.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error, please make sure you entered correct data or Email already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    
    }
}
