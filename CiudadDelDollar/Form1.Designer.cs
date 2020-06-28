namespace SingleResponsibility
{
    partial class Form1
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
            this.BtnReporte = new System.Windows.Forms.Button();
            this.NUMEROPLACA = new System.Windows.Forms.TextBox();
            this.LUGARINFRACCION = new System.Windows.Forms.TextBox();
            this.HORA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TIPOPLACA = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnReporte
            // 
            this.BtnReporte.Location = new System.Drawing.Point(308, 325);
            this.BtnReporte.Margin = new System.Windows.Forms.Padding(4);
            this.BtnReporte.Name = "BtnReporte";
            this.BtnReporte.Size = new System.Drawing.Size(249, 28);
            this.BtnReporte.TabIndex = 0;
            this.BtnReporte.Text = "Crear Reporte";
            this.BtnReporte.UseVisualStyleBackColor = true;
            this.BtnReporte.Click += new System.EventHandler(this.BtnReporte_Click);
            // 
            // NUMEROPLACA
            // 
            this.NUMEROPLACA.Location = new System.Drawing.Point(546, 171);
            this.NUMEROPLACA.Name = "NUMEROPLACA";
            this.NUMEROPLACA.Size = new System.Drawing.Size(177, 22);
            this.NUMEROPLACA.TabIndex = 1;
            // 
            // LUGARINFRACCION
            // 
            this.LUGARINFRACCION.Location = new System.Drawing.Point(487, 213);
            this.LUGARINFRACCION.Name = "LUGARINFRACCION";
            this.LUGARINFRACCION.Size = new System.Drawing.Size(236, 22);
            this.LUGARINFRACCION.TabIndex = 2;
            // 
            // HORA
            // 
            this.HORA.Location = new System.Drawing.Point(487, 254);
            this.HORA.Name = "HORA";
            this.HORA.Size = new System.Drawing.Size(90, 22);
            this.HORA.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Numero de Placa:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lugar Infracción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hora de Infracción:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(316, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(466, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Registro de Multas de Transito Emixtra";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // TIPOPLACA
            // 
            this.TIPOPLACA.FormattingEnabled = true;
            this.TIPOPLACA.Items.AddRange(new object[] {
            "P",
            "C",
            "M",
            "U"});
            this.TIPOPLACA.Location = new System.Drawing.Point(487, 171);
            this.TIPOPLACA.Name = "TIPOPLACA";
            this.TIPOPLACA.Size = new System.Drawing.Size(53, 24);
            this.TIPOPLACA.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SingleResponsibility.Properties.Resources.emixtra;
            this.pictureBox1.Location = new System.Drawing.Point(1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 278);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(854, 433);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TIPOPLACA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HORA);
            this.Controls.Add(this.LUGARINFRACCION);
            this.Controls.Add(this.NUMEROPLACA);
            this.Controls.Add(this.BtnReporte);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnReporte;
        private System.Windows.Forms.TextBox NUMEROPLACA;
        private System.Windows.Forms.TextBox LUGARINFRACCION;
        private System.Windows.Forms.TextBox HORA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TIPOPLACA;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

