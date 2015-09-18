namespace ARXBackup
{
    partial class frmPreferencias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPreferencias));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tBase = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lBasesdeDatos = new System.Windows.Forms.ListBox();
            this.tClaveSQL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tUsuarioSQL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tServidorSQL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chApagar = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tRutaRespaldo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tHora = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chActivarNube = new System.Windows.Forms.CheckBox();
            this.tServidorCloud = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tRutaADD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tBase);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lBasesdeDatos);
            this.groupBox1.Controls.Add(this.tClaveSQL);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tUsuarioSQL);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tServidorSQL);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 236);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de servidor";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tBase
            // 
            this.tBase.Location = new System.Drawing.Point(12, 201);
            this.tBase.Name = "tBase";
            this.tBase.Size = new System.Drawing.Size(182, 20);
            this.tBase.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Base de datos";
            // 
            // lBasesdeDatos
            // 
            this.lBasesdeDatos.FormattingEnabled = true;
            this.lBasesdeDatos.Location = new System.Drawing.Point(250, 90);
            this.lBasesdeDatos.Name = "lBasesdeDatos";
            this.lBasesdeDatos.Size = new System.Drawing.Size(239, 134);
            this.lBasesdeDatos.TabIndex = 6;
            this.lBasesdeDatos.DoubleClick += new System.EventHandler(this.lBasesdeDatos_DoubleClick);
            // 
            // tClaveSQL
            // 
            this.tClaveSQL.Location = new System.Drawing.Point(12, 144);
            this.tClaveSQL.Name = "tClaveSQL";
            this.tClaveSQL.PasswordChar = '*';
            this.tClaveSQL.Size = new System.Drawing.Size(213, 20);
            this.tClaveSQL.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Clave";
            // 
            // tUsuarioSQL
            // 
            this.tUsuarioSQL.Location = new System.Drawing.Point(12, 95);
            this.tUsuarioSQL.Name = "tUsuarioSQL";
            this.tUsuarioSQL.Size = new System.Drawing.Size(213, 20);
            this.tUsuarioSQL.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario";
            // 
            // tServidorSQL
            // 
            this.tServidorSQL.Location = new System.Drawing.Point(9, 52);
            this.tServidorSQL.Name = "tServidorSQL";
            this.tServidorSQL.Size = new System.Drawing.Size(343, 20);
            this.tServidorSQL.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servidor";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chApagar);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.tRutaRespaldo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tHora);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 140);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos para generar respaldo ";
            // 
            // chApagar
            // 
            this.chApagar.AutoSize = true;
            this.chApagar.Location = new System.Drawing.Point(250, 49);
            this.chApagar.Name = "chApagar";
            this.chApagar.Size = new System.Drawing.Size(189, 17);
            this.chApagar.TabIndex = 5;
            this.chApagar.Text = "Apagar equipo al terminar respaldo";
            this.chApagar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(425, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tRutaRespaldo
            // 
            this.tRutaRespaldo.Location = new System.Drawing.Point(15, 100);
            this.tRutaRespaldo.Name = "tRutaRespaldo";
            this.tRutaRespaldo.Size = new System.Drawing.Size(403, 20);
            this.tRutaRespaldo.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ruta de respaldo";
            // 
            // tHora
            // 
            this.tHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.tHora.Location = new System.Drawing.Point(12, 46);
            this.tHora.Name = "tHora";
            this.tHora.ShowUpDown = true;
            this.tHora.Size = new System.Drawing.Size(200, 20);
            this.tHora.TabIndex = 1;
            this.tHora.Value = new System.DateTime(2015, 7, 23, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Hora de generacion de respaldo";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chActivarNube);
            this.groupBox3.Controls.Add(this.tServidorCloud);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(527, 102);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(262, 140);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ARX Cloud";
            // 
            // chActivarNube
            // 
            this.chActivarNube.AutoSize = true;
            this.chActivarNube.Location = new System.Drawing.Point(9, 33);
            this.chActivarNube.Name = "chActivarNube";
            this.chActivarNube.Size = new System.Drawing.Size(59, 17);
            this.chActivarNube.TabIndex = 2;
            this.chActivarNube.Text = "Activar";
            this.chActivarNube.UseVisualStyleBackColor = true;
            this.chActivarNube.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tServidorCloud
            // 
            this.tServidorCloud.Location = new System.Drawing.Point(9, 88);
            this.tServidorCloud.Name = "tServidorCloud";
            this.tServidorCloud.Size = new System.Drawing.Size(246, 20);
            this.tServidorCloud.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Servidor Cloud";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.tRutaADD);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(527, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(262, 72);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Contpaq I";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(228, 35);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tRutaADD
            // 
            this.tRutaADD.Location = new System.Drawing.Point(12, 37);
            this.tRutaADD.Name = "tRutaADD";
            this.tRutaADD.Size = new System.Drawing.Size(211, 20);
            this.tRutaADD.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ruta ADD";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(679, 357);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 37);
            this.button4.TabIndex = 4;
            this.button4.Text = "Guardar Cambios";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // frmPreferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 410);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPreferencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preferencias";
            this.Load += new System.EventHandler(this.frmPreferencias_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tServidorSQL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tUsuarioSQL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tClaveSQL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tBase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lBasesdeDatos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tRutaRespaldo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker tHora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chActivarNube;
        private System.Windows.Forms.TextBox tServidorCloud;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chApagar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tRutaADD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}