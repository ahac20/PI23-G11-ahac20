﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluationManagerG11 {
    public partial class frmLogin : Form {
        public frmLogin() {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void frmLogin_Load(object sender, EventArgs e) {

        }

        private void btLogin_Click(object sender, EventArgs e) {
            if(txtUsername.Text == "") {
                MessageBox.Show("Korisničko ime nije unešeno!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
