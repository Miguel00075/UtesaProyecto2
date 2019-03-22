namespace Sist_Facturacion.Administracion
{
    partial class Usuario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lbusuarioTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxConfiguracion = new System.Windows.Forms.CheckBox();
            this.checkBoxCliente = new System.Windows.Forms.CheckBox();
            this.checkBoxInventario = new System.Windows.Forms.CheckBox();
            this.checkModuloFacturacion = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGusuario = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGusuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbusuarioTotal);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtNum);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DataGusuario);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(516, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "NIVEL:";
            // 
            // lbusuarioTotal
            // 
            this.lbusuarioTotal.AutoSize = true;
            this.lbusuarioTotal.Location = new System.Drawing.Point(563, 165);
            this.lbusuarioTotal.Name = "lbusuarioTotal";
            this.lbusuarioTotal.Size = new System.Drawing.Size(16, 13);
            this.lbusuarioTotal.TabIndex = 13;
            this.lbusuarioTotal.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "ROL";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox1.Location = new System.Drawing.Point(358, 162);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DimGray;
            this.groupBox1.Controls.Add(this.checkBoxConfiguracion);
            this.groupBox1.Controls.Add(this.checkBoxCliente);
            this.groupBox1.Controls.Add(this.checkBoxInventario);
            this.groupBox1.Controls.Add(this.checkModuloFacturacion);
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(326, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 143);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MODULOS";
            // 
            // checkBoxConfiguracion
            // 
            this.checkBoxConfiguracion.AutoSize = true;
            this.checkBoxConfiguracion.Location = new System.Drawing.Point(7, 89);
            this.checkBoxConfiguracion.Name = "checkBoxConfiguracion";
            this.checkBoxConfiguracion.Size = new System.Drawing.Size(115, 17);
            this.checkBoxConfiguracion.TabIndex = 3;
            this.checkBoxConfiguracion.Text = "CONFIGURACION";
            this.checkBoxConfiguracion.UseVisualStyleBackColor = true;
            this.checkBoxConfiguracion.CheckedChanged += new System.EventHandler(this.checkBoxConfiguracion_CheckedChanged);
            // 
            // checkBoxCliente
            // 
            this.checkBoxCliente.AutoSize = true;
            this.checkBoxCliente.Location = new System.Drawing.Point(7, 66);
            this.checkBoxCliente.Name = "checkBoxCliente";
            this.checkBoxCliente.Size = new System.Drawing.Size(78, 17);
            this.checkBoxCliente.TabIndex = 2;
            this.checkBoxCliente.Text = "CLIENTES";
            this.checkBoxCliente.UseVisualStyleBackColor = true;
            this.checkBoxCliente.CheckedChanged += new System.EventHandler(this.checkBoxCliente_CheckedChanged);
            // 
            // checkBoxInventario
            // 
            this.checkBoxInventario.AutoSize = true;
            this.checkBoxInventario.Location = new System.Drawing.Point(7, 43);
            this.checkBoxInventario.Name = "checkBoxInventario";
            this.checkBoxInventario.Size = new System.Drawing.Size(92, 17);
            this.checkBoxInventario.TabIndex = 1;
            this.checkBoxInventario.Text = "INVENTARIO";
            this.checkBoxInventario.UseVisualStyleBackColor = true;
            this.checkBoxInventario.CheckedChanged += new System.EventHandler(this.CheckBoxInventario_CheckedChanged);
            // 
            // checkModuloFacturacion
            // 
            this.checkModuloFacturacion.AutoSize = true;
            this.checkModuloFacturacion.Location = new System.Drawing.Point(7, 20);
            this.checkModuloFacturacion.Name = "checkModuloFacturacion";
            this.checkModuloFacturacion.Size = new System.Drawing.Size(102, 17);
            this.checkModuloFacturacion.TabIndex = 0;
            this.checkModuloFacturacion.Text = "FACTURACION";
            this.checkModuloFacturacion.UseVisualStyleBackColor = true;
            this.checkModuloFacturacion.CheckedChanged += new System.EventHandler(this.CheckModuloFacturacion_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(342, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(360, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "FICHA DE USUARIOS DEL SISTEMA";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(331, 357);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(104, 39);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(610, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 39);
            this.button2.TabIndex = 7;
            this.button2.Text = "CANCELAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(468, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "MODIFICAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(659, 42);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(114, 20);
            this.txtNum.TabIndex = 5;
            this.txtNum.Text = "0";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(415, 116);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(164, 20);
            this.txtPass.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CONTRASEÑA";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(415, 81);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(164, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NOMBRE";
            // 
            // DataGusuario
            // 
            this.DataGusuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGusuario.Location = new System.Drawing.Point(3, 3);
            this.DataGusuario.Name = "DataGusuario";
            this.DataGusuario.Size = new System.Drawing.Size(314, 420);
            this.DataGusuario.TabIndex = 0;
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGusuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxInventario;
        private System.Windows.Forms.CheckBox checkModuloFacturacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGusuario;
        private System.Windows.Forms.Label lbusuarioTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxConfiguracion;
        private System.Windows.Forms.CheckBox checkBoxCliente;
    }
}