using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ARXBackup
{
    public partial class frmLogin : Form
    {
        public bool datos_capturados = false;
        public string usuario="";
        public string clave="";

        public frmLogin()
        {
            InitializeComponent();
        }

        private void bAcceder_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(tID.Text)||!String.IsNullOrWhiteSpace(tContraseña.Text)){

                usuario = tID.Text;
                clave = tContraseña.Text;
                datos_capturados = true;

            }else{
                datos_capturados=false;
            }

        }
    }
}
