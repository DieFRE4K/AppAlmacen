namespace LibFormularios
{
    partial class FrmPadre
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
            this.BtnSalir = new System.Windows.Forms.Button();
            this.PanBotones = new System.Windows.Forms.Panel();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.PanTitulo = new System.Windows.Forms.Panel();
            this.PanDatos = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PanBotones.SuspendLayout();
            this.PanTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(34, 9);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 0;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // PanBotones
            // 
            this.PanBotones.Controls.Add(this.BtnGuardar);
            this.PanBotones.Controls.Add(this.BtnNuevo);
            this.PanBotones.Controls.Add(this.BtnSalir);
            this.PanBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanBotones.Location = new System.Drawing.Point(0, 450);
            this.PanBotones.Name = "PanBotones";
            this.PanBotones.Size = new System.Drawing.Size(774, 44);
            this.PanBotones.TabIndex = 5;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(620, 9);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 2;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(539, 9);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(75, 23);
            this.BtnNuevo.TabIndex = 1;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // PanTitulo
            // 
            this.PanTitulo.Controls.Add(this.label1);
            this.PanTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanTitulo.Location = new System.Drawing.Point(0, 0);
            this.PanTitulo.Name = "PanTitulo";
            this.PanTitulo.Size = new System.Drawing.Size(774, 51);
            this.PanTitulo.TabIndex = 6;
            // 
            // PanDatos
            // 
            this.PanDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanDatos.Location = new System.Drawing.Point(0, 51);
            this.PanDatos.Name = "PanDatos";
            this.PanDatos.Size = new System.Drawing.Size(774, 399);
            this.PanDatos.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(774, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "TITULO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmPadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 494);
            this.Controls.Add(this.PanDatos);
            this.Controls.Add(this.PanTitulo);
            this.Controls.Add(this.PanBotones);
            this.Name = "FrmPadre";
            this.Text = "FrmPadre";
            this.PanBotones.ResumeLayout(false);
            this.PanTitulo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Panel PanTitulo;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Panel PanDatos;
        protected System.Windows.Forms.Panel PanBotones;

    }
}