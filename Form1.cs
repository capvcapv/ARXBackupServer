using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Net;
using System.IO;
using System.IO.Compression;
using Ionic.Zip;
using System.Diagnostics;

namespace ARXBackup
{
    public partial class Form1 : Form
    {
        private bool bandera = true;
        private string[] bases;
        private string hora;

        private DateTime tmp;

        private string usuario;
        private string clave;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void iniciaRespaldo()
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            try
            {
                while (bandera)
                {

                    if (backgroundWorker1.CancellationPending)
                    {
                        e.Cancel = true;
                        bandera = false;
                    }
                    else
                    {
                        if (DateTime.Now.Hour == Convert.ToInt32(hora.Substring(0, 2)) && DateTime.Now.Minute == Convert.ToInt32(hora.Substring(3, 2)))
                        {
                            int contador = 0;
                            foreach (var i in bases)
                            {
                                string primero = "osql.exe -S " + ConfigurationManager.AppSettings["servidor"] + " -U " + ConfigurationManager.AppSettings["usuario"] + " -P " + ConfigurationManager.AppSettings["clave"] + " -Q ";
                                string segundo = "\"BACKUP DATABASE " + i + " TO DISK='" + ConfigurationManager.AppSettings["ruta"] + i + ".bak'\"";
                                string tercero = primero + segundo;
                                ExecuteCommand(tercero);

                                if (Convert.ToInt32(ConfigurationManager.AppSettings["nube"]) == 1)
                                {
                                    EnviarRespaldoNube(i + ".bak", ConfigurationManager.AppSettings["ruta"] + i + ".bak");
                                }

                                backgroundWorker1.ReportProgress(contador);
                                contador++;
                            }

                            RespaldaADD();

                            if (File.Exists(ConfigurationManager.AppSettings["ruta"] + "ADD.zip"))
                            {
                                File.Delete(ConfigurationManager.AppSettings["ruta"] + "ADD.zip");
                            }
                            File.Move("ADD.zip", ConfigurationManager.AppSettings["ruta"] + "ADD.zip");

                            if (Convert.ToInt32(ConfigurationManager.AppSettings["nube"]) == 1)
                            {
                                EnviarRespaldoNube("ADD.zip", ConfigurationManager.AppSettings["ruta"] + "ADD.zip");
                                backgroundWorker1.ReportProgress(999);
                            }



                        }
                    }

                    System.Threading.Thread.Sleep(60000);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage==999)
            {
                richTextBox1.Text = richTextBox1.Text + System.Environment.NewLine + "ADD respaldado";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + System.Environment.NewLine + "Empresa respaldada: " + bases[e.ProgressPercentage];
            }
            
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lEstado.Text = "Estado: Servicio Parado";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            string tmpBases = ConfigurationManager.AppSettings["bases"];
            bases= tmpBases.Split('|');

            hora = ConfigurationManager.AppSettings["hora"];

            if (Convert.ToInt32(ConfigurationManager.AppSettings["nube"]) == 1)
            {
                
                frmLogin login = new frmLogin();
                login.ShowDialog();

                if (login.datos_capturados == true)
                {
                    usuario = login.usuario;
                    clave = login.clave;

                    richTextBox1.Text = richTextBox1.Text + Environment.NewLine + "El respaldo en la Nube esta activado";
                    backgroundWorker1.RunWorkerAsync();
                    lEstado.Text = "Estado: Servicio Inicializado";
                    bandera = true;
                }

            }
            else
            {
                backgroundWorker1.RunWorkerAsync();
                lEstado.Text = "Estado: Servicio Inicializado";
                bandera = true;
            }
                   

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
           backgroundWorker1.CancelAsync();          
        }

        private string ExecuteCommand(string _Command)
        {

            System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/c " + _Command);

            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.UseShellExecute = false;

            procStartInfo.CreateNoWindow = true;

            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = procStartInfo;
            proc.Start();
            proc.WaitForExit();

            string result = proc.StandardOutput.ReadToEnd();

            return result;
        }

        private void EnviarRespaldoNube(string archivo,string ruta)
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create("ftp://" + ConfigurationManager.AppSettings["servidorFTP"] + "//" + archivo);
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential(usuario, clave);
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = true;
                request.Timeout = -1;

                //byte[] buffer = System.IO.File.ReadAllBytes(ruta);
                Stream destino = request.GetRequestStream();
                Stream archivo_origen = new FileStream(ruta, FileMode.Open, FileAccess.Read);
                
                byte[] buffer=new byte[2048];
                int bytes_leidos = 0;

                while ((bytes_leidos = archivo_origen.Read(buffer, 0, buffer.Length)) > 0)
                {
                    destino.Write(buffer, 0, bytes_leidos);
                }
                               
                destino.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            
        }

        private void RespaldaADD()
        {
            try
            {
                ZipFile zip = new ZipFile();

                zip.AddDirectory(ConfigurationManager.AppSettings["rutaADD"]);
                zip.Save("ADD.zip");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                string tmpBases = ConfigurationManager.AppSettings["bases"];
                bases = tmpBases.Split('|');

                hora = ConfigurationManager.AppSettings["hora"];

                if (Convert.ToInt32(ConfigurationManager.AppSettings["nube"]) == 1)
                {
                    richTextBox1.Text = richTextBox1.Text + Environment.NewLine + "El respaldo en la Nube esta activado";
                }

                lEstado.Text = "Estado: Servicio Inicializado";
                bandera = true;

                while (bandera)
                {

                        if (DateTime.Now.Hour == Convert.ToInt32(hora.Substring(0, 2)) && DateTime.Now.Minute == Convert.ToInt32(hora.Substring(3, 2)))
                        {
                            int contador = 0;
                            foreach (var i in bases)
                            {
                                string primero = "osql.exe -S " + ConfigurationManager.AppSettings["servidor"] + " -U " + ConfigurationManager.AppSettings["usuario"] + " -P " + ConfigurationManager.AppSettings["clave"] + " -Q ";
                                string segundo = "\"BACKUP DATABASE " + i + " TO DISK='" + ConfigurationManager.AppSettings["ruta"] + i + ".bak'\"";
                                string tercero = primero + segundo;
                                ExecuteCommand(tercero);

                                if (Convert.ToInt32(ConfigurationManager.AppSettings["nube"]) == 1)
                                {
                                    EnviarRespaldoNube(i + ".bak", ConfigurationManager.AppSettings["ruta"] + i + ".bak");
                                }

                                richTextBox1.Text = richTextBox1.Text + System.Environment.NewLine + "Empresa respaldada: " + bases[contador];
                                contador++;
                            }

                            RespaldaADD();
                            if (File.Exists(ConfigurationManager.AppSettings["ruta"] + "ADD.zip"))
                            {
                                File.Delete(ConfigurationManager.AppSettings["ruta"] + "ADD.zip");
                            }
                            File.Move("ADD.zip", ConfigurationManager.AppSettings["ruta"] + "ADD.zip");

                            if (Convert.ToInt32(ConfigurationManager.AppSettings["nube"]) == 1)
                            {
                                EnviarRespaldoNube("ADD.zip", ConfigurationManager.AppSettings["ruta"] + "ADD.zip");
                            }



                        
                    }
                        if (ConfigurationManager.AppSettings["apagar"] == "1")
                        {
                            apagar();
                        }

                    System.Threading.Thread.Sleep(60000);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.Text = "Servicio oculto";
                notifyIcon1.ShowBalloonTip(500);
                this.Hide();
            }
            else if(FormWindowState.Normal==this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {
            frmPreferencias pref = new frmPreferencias();
            pref.ShowDialog();
        }

        public void apagar()
        {
            try
            {
                while (true)
                {
                    if (tmp.ToLongTimeString() == DateTime.Now.ToLongTimeString())
                    {
                        Process proceso = new Process();
                        proceso.StartInfo.UseShellExecute = false;
                        proceso.StartInfo.RedirectStandardOutput = true;
                        proceso.StartInfo.FileName = "shutdown.exe";
                        proceso.StartInfo.Arguments = null;
                        proceso.Start();
                        break;
                    }
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
