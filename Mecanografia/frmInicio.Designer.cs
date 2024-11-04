namespace Mecanografia
{
    partial class frmInicio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.panelUp = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.Iconos = new System.Windows.Forms.ImageList(this.components);
            this.panelContendor = new System.Windows.Forms.Panel();
            this.lblTempo = new System.Windows.Forms.Label();
            this.txtPalabra = new System.Windows.Forms.TextBox();
            this.lblPalabra = new System.Windows.Forms.Label();
            this.tiempo = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.lblTexto = new System.Windows.Forms.Label();
            this.lblMejor = new System.Windows.Forms.Label();
            this.panelUp.SuspendLayout();
            this.panelContendor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUp
            // 
            this.panelUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(68)))), ((int)(((byte)(73)))));
            this.panelUp.Controls.Add(this.btnSalir);
            this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp.Location = new System.Drawing.Point(0, 0);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(843, 45);
            this.panelUp.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ImageKey = "Cerrar.png";
            this.btnSalir.ImageList = this.Iconos;
            this.btnSalir.Location = new System.Drawing.Point(801, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(42, 45);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Iconos
            // 
            this.Iconos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Iconos.ImageStream")));
            this.Iconos.TransparentColor = System.Drawing.Color.Transparent;
            this.Iconos.Images.SetKeyName(0, "Cerrar.png");
            // 
            // panelContendor
            // 
            this.panelContendor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(144)))), ((int)(((byte)(161)))));
            this.panelContendor.Controls.Add(this.lblMejor);
            this.panelContendor.Controls.Add(this.lblTexto);
            this.panelContendor.Controls.Add(this.lblScore);
            this.panelContendor.Controls.Add(this.lblTempo);
            this.panelContendor.Controls.Add(this.txtPalabra);
            this.panelContendor.Controls.Add(this.lblPalabra);
            this.panelContendor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContendor.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelContendor.Location = new System.Drawing.Point(0, 45);
            this.panelContendor.Name = "panelContendor";
            this.panelContendor.Size = new System.Drawing.Size(843, 444);
            this.panelContendor.TabIndex = 1;
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.ForeColor = System.Drawing.Color.White;
            this.lblTempo.Location = new System.Drawing.Point(373, 19);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(64, 19);
            this.lblTempo.TabIndex = 2;
            this.lblTempo.Text = "tiempo";
            // 
            // txtPalabra
            // 
            this.txtPalabra.Font = new System.Drawing.Font("Century Gothic", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalabra.Location = new System.Drawing.Point(221, 221);
            this.txtPalabra.Name = "txtPalabra";
            this.txtPalabra.Size = new System.Drawing.Size(394, 72);
            this.txtPalabra.TabIndex = 1;
            this.txtPalabra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPalabra.TextChanged += new System.EventHandler(this.txtPalabra_TextChanged);
            // 
            // lblPalabra
            // 
            this.lblPalabra.AutoSize = true;
            this.lblPalabra.Font = new System.Drawing.Font("Century Gothic", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalabra.ForeColor = System.Drawing.Color.White;
            this.lblPalabra.Location = new System.Drawing.Point(286, 137);
            this.lblPalabra.Name = "lblPalabra";
            this.lblPalabra.Size = new System.Drawing.Size(255, 63);
            this.lblPalabra.TabIndex = 0;
            this.lblPalabra.Text = "PALABRA";
            // 
            // tiempo
            // 
            this.tiempo.Interval = 1000;
            this.tiempo.Tick += new System.EventHandler(this.tiempo_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(668, 19);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(68, 24);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "Score";
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.ForeColor = System.Drawing.Color.White;
            this.lblTexto.Location = new System.Drawing.Point(12, 19);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(120, 19);
            this.lblTexto.TabIndex = 4;
            this.lblTexto.Text = "Mejor puntaje:";
            // 
            // lblMejor
            // 
            this.lblMejor.AutoSize = true;
            this.lblMejor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMejor.ForeColor = System.Drawing.Color.White;
            this.lblMejor.Location = new System.Drawing.Point(138, 19);
            this.lblMejor.Name = "lblMejor";
            this.lblMejor.Size = new System.Drawing.Size(0, 19);
            this.lblMejor.TabIndex = 5;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(843, 489);
            this.Controls.Add(this.panelContendor);
            this.Controls.Add(this.panelUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.panelUp.ResumeLayout(false);
            this.panelContendor.ResumeLayout(false);
            this.panelContendor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panelContendor;
        private System.Windows.Forms.ImageList Iconos;
        private System.Windows.Forms.TextBox txtPalabra;
        private System.Windows.Forms.Label lblPalabra;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Timer tiempo;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblMejor;
        private System.Windows.Forms.Label lblTexto;
    }
}

