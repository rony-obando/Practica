
namespace Practica
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.LBNombres = new System.Windows.Forms.Label();
            this.LBApellidos = new System.Windows.Forms.Label();
            this.LBDNI = new System.Windows.Forms.Label();
            this.LBSalario = new System.Windows.Forms.Label();
            this.TxBNombres = new System.Windows.Forms.TextBox();
            this.TxBApellidos = new System.Windows.Forms.TextBox();
            this.TxBDNI = new System.Windows.Forms.TextBox();
            this.TxBSalario = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSmaximo = new System.Windows.Forms.Button();
            this.btnSminimo = new System.Windows.Forms.Button();
            this.OrdAsc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LBNombres
            // 
            this.LBNombres.AutoSize = true;
            this.LBNombres.Location = new System.Drawing.Point(16, 31);
            this.LBNombres.Name = "LBNombres";
            this.LBNombres.Size = new System.Drawing.Size(49, 13);
            this.LBNombres.TabIndex = 1;
            this.LBNombres.Text = "Nombres";
            // 
            // LBApellidos
            // 
            this.LBApellidos.AutoSize = true;
            this.LBApellidos.Location = new System.Drawing.Point(16, 66);
            this.LBApellidos.Name = "LBApellidos";
            this.LBApellidos.Size = new System.Drawing.Size(49, 13);
            this.LBApellidos.TabIndex = 2;
            this.LBApellidos.Text = "Apellidos";
            // 
            // LBDNI
            // 
            this.LBDNI.AutoSize = true;
            this.LBDNI.Location = new System.Drawing.Point(16, 108);
            this.LBDNI.Name = "LBDNI";
            this.LBDNI.Size = new System.Drawing.Size(26, 13);
            this.LBDNI.TabIndex = 3;
            this.LBDNI.Text = "DNI";
            // 
            // LBSalario
            // 
            this.LBSalario.AutoSize = true;
            this.LBSalario.Location = new System.Drawing.Point(19, 143);
            this.LBSalario.Name = "LBSalario";
            this.LBSalario.Size = new System.Drawing.Size(39, 13);
            this.LBSalario.TabIndex = 4;
            this.LBSalario.Text = "Salario";
            // 
            // TxBNombres
            // 
            this.TxBNombres.Location = new System.Drawing.Point(29, 19);
            this.TxBNombres.Name = "TxBNombres";
            this.TxBNombres.Size = new System.Drawing.Size(100, 20);
            this.TxBNombres.TabIndex = 5;
            // 
            // TxBApellidos
            // 
            this.TxBApellidos.Location = new System.Drawing.Point(29, 55);
            this.TxBApellidos.Name = "TxBApellidos";
            this.TxBApellidos.Size = new System.Drawing.Size(100, 20);
            this.TxBApellidos.TabIndex = 6;
            // 
            // TxBDNI
            // 
            this.TxBDNI.Location = new System.Drawing.Point(29, 93);
            this.TxBDNI.Name = "TxBDNI";
            this.TxBDNI.Size = new System.Drawing.Size(100, 20);
            this.TxBDNI.TabIndex = 7;
            // 
            // TxBSalario
            // 
            this.TxBSalario.Location = new System.Drawing.Point(29, 131);
            this.TxBSalario.Name = "TxBSalario";
            this.TxBSalario.Size = new System.Drawing.Size(100, 20);
            this.TxBSalario.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OrdAsc);
            this.groupBox1.Controls.Add(this.btnSminimo);
            this.groupBox1.Controls.Add(this.btnSmaximo);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 58);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Botones";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxBNombres);
            this.groupBox2.Controls.Add(this.TxBApellidos);
            this.groupBox2.Controls.Add(this.TxBSalario);
            this.groupBox2.Controls.Add(this.TxBDNI);
            this.groupBox2.Location = new System.Drawing.Point(64, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 161);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Empleado";
            // 
            // btnSmaximo
            // 
            this.btnSmaximo.Location = new System.Drawing.Point(217, 19);
            this.btnSmaximo.Name = "btnSmaximo";
            this.btnSmaximo.Size = new System.Drawing.Size(93, 23);
            this.btnSmaximo.TabIndex = 1;
            this.btnSmaximo.Text = "Salario Maximo";
            this.btnSmaximo.UseVisualStyleBackColor = true;
            this.btnSmaximo.Click += new System.EventHandler(this.btnSmaximo_Click);
            // 
            // btnSminimo
            // 
            this.btnSminimo.Location = new System.Drawing.Point(128, 19);
            this.btnSminimo.Name = "btnSminimo";
            this.btnSminimo.Size = new System.Drawing.Size(83, 23);
            this.btnSminimo.TabIndex = 2;
            this.btnSminimo.Text = "Salario Minimo";
            this.btnSminimo.UseVisualStyleBackColor = true;
            this.btnSminimo.Click += new System.EventHandler(this.btnSminimo_Click);
            // 
            // OrdAsc
            // 
            this.OrdAsc.Location = new System.Drawing.Point(48, 19);
            this.OrdAsc.Name = "OrdAsc";
            this.OrdAsc.Size = new System.Drawing.Size(74, 23);
            this.OrdAsc.TabIndex = 3;
            this.OrdAsc.Text = "Ordenar +";
            this.OrdAsc.UseVisualStyleBackColor = true;
            this.OrdAsc.Click += new System.EventHandler(this.OrdAsc_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(421, 261);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LBSalario);
            this.Controls.Add(this.LBDNI);
            this.Controls.Add(this.LBApellidos);
            this.Controls.Add(this.LBNombres);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LBNombres;
        private System.Windows.Forms.Label LBApellidos;
        private System.Windows.Forms.Label LBDNI;
        private System.Windows.Forms.Label LBSalario;
        private System.Windows.Forms.TextBox TxBNombres;
        private System.Windows.Forms.TextBox TxBApellidos;
        private System.Windows.Forms.TextBox TxBDNI;
        private System.Windows.Forms.TextBox TxBSalario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSmaximo;
        private System.Windows.Forms.Button btnSminimo;
        private System.Windows.Forms.Button OrdAsc;
    }
}

