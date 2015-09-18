using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace ARXBackup
{
    public partial class frmPreferencias : Form
    {
        public frmPreferencias()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            guardaConfiguracion();
            this.Close();
        }


        private void cargaConfiguracion()
        {
            tServidorSQL.Text = ConfigurationManager.AppSettings["servidor"];
            tUsuarioSQL.Text = ConfigurationManager.AppSettings["usuario"];
            tClaveSQL.Text = ConfigurationManager.AppSettings["clave"];

            string bases = ConfigurationManager.AppSettings["bases"];
            string[] divididos = bases.Split('|');

            foreach (var i in divididos)
            {
                lBasesdeDatos.Items.Add(i);
            }

            tRutaRespaldo.Text = ConfigurationManager.AppSettings["ruta"];
            tHora.Text = ConfigurationManager.AppSettings["hora"];

            tServidorCloud.Text = ConfigurationManager.AppSettings["servidorFTP"];
            tRutaADD.Text = ConfigurationManager.AppSettings["rutaADD"];

            if (ConfigurationManager.AppSettings["nube"] == "1")
            {
                chActivarNube.Checked = true;
            }

            if (ConfigurationManager.AppSettings["apagar"] == "1")
            {
                chApagar.Checked = true;
            }

        }

        private void guardaConfiguracion()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.AppSettings.Settings["servidor"].Value = tServidorSQL.Text;
            config.AppSettings.Settings["usuario"].Value = tUsuarioSQL.Text;
            config.AppSettings.Settings["clave"].Value = tClaveSQL.Text;


            config.AppSettings.Settings["ruta"].Value = tRutaRespaldo.Text;
            config.AppSettings.Settings["hora"].Value = tHora.Value.Hour.ToString("00") + ":" + tHora.Value.Minute.ToString("00");

            string bases = "";

            foreach (var i in lBasesdeDatos.Items)
            {
                bases = bases + i.ToString() + "|";
            }

            bases = bases.Substring(0, bases.Length - 1);

            if (chApagar.Checked == true)
            {
                config.AppSettings.Settings["apagar"].Value = "1";
            }
            else
            {
                config.AppSettings.Settings["apagar"].Value = "0";
            }

            if (chActivarNube.Checked == true)
            {
                config.AppSettings.Settings["nube"].Value = "1";
            }else{
                config.AppSettings.Settings["nube"].Value = "0";
            }

            config.AppSettings.Settings["servidorFTP"].Value = tServidorCloud.Text;
            config.AppSettings.Settings["rutaADD"].Value = tRutaADD.Text;
            
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void frmPreferencias_Load(object sender, EventArgs e)
        {
            cargaConfiguracion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lBasesdeDatos.Items.Add(tBase.Text);
            tBase.Text = "";
        }

        private void lBasesdeDatos_DoubleClick(object sender, EventArgs e)
        {
            lBasesdeDatos.Items.RemoveAt(lBasesdeDatos.SelectedIndex);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            tRutaRespaldo.Text = folderBrowserDialog1.SelectedPath;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            tRutaADD.Text = folderBrowserDialog1.SelectedPath;
        }
    }
}
