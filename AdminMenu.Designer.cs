namespace Trabajo_final_herramientas_II
{
    partial class AdminMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.llbGCliente = new System.Windows.Forms.LinkLabel();
            this.llbGInstructores = new System.Windows.Forms.LinkLabel();
            this.llbClases = new System.Windows.Forms.LinkLabel();
            this.llbRepEstadis = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.llbCambRol = new System.Windows.Forms.LinkLabel();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Trabajo_final_herramientas_II.Properties.Resources._6_430_000__Structure_Pictures;
            this.pictureBox1.Location = new System.Drawing.Point(-11, -60);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 672);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
           
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(505, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "CLASES DE FITNESS 🏋️‍♀️ ";
            // 
            // llbGCliente
            // 
            this.llbGCliente.AutoSize = true;
            this.llbGCliente.BackColor = System.Drawing.Color.Transparent;
            this.llbGCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbGCliente.LinkColor = System.Drawing.Color.Gainsboro;
            this.llbGCliente.Location = new System.Drawing.Point(9, 140);
            this.llbGCliente.Name = "llbGCliente";
            this.llbGCliente.Size = new System.Drawing.Size(251, 29);
            this.llbGCliente.TabIndex = 2;
            this.llbGCliente.TabStop = true;
            this.llbGCliente.Text = "👥 Gestion de clientes";
            this.llbGCliente.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbGCliente_LinkClicked);
            // 
            // llbGInstructores
            // 
            this.llbGInstructores.AutoSize = true;
            this.llbGInstructores.BackColor = System.Drawing.Color.Transparent;
            this.llbGInstructores.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbGInstructores.LinkColor = System.Drawing.Color.White;
            this.llbGInstructores.Location = new System.Drawing.Point(9, 208);
            this.llbGInstructores.Name = "llbGInstructores";
            this.llbGInstructores.Size = new System.Drawing.Size(292, 29);
            this.llbGInstructores.TabIndex = 3;
            this.llbGInstructores.TabStop = true;
            this.llbGInstructores.Text = "👥 Gestion de instructores";
            this.llbGInstructores.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbGInstructores_LinkClicked);
            // 
            // llbClases
            // 
            this.llbClases.AutoSize = true;
            this.llbClases.BackColor = System.Drawing.Color.Transparent;
            this.llbClases.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbClases.LinkColor = System.Drawing.Color.White;
            this.llbClases.Location = new System.Drawing.Point(12, 284);
            this.llbClases.Name = "llbClases";
            this.llbClases.Size = new System.Drawing.Size(125, 29);
            this.llbClases.TabIndex = 4;
            this.llbClases.TabStop = true;
            this.llbClases.Text = "🗓️ Clases ";
            this.llbClases.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // llbRepEstadis
            // 
            this.llbRepEstadis.AutoSize = true;
            this.llbRepEstadis.BackColor = System.Drawing.Color.Transparent;
            this.llbRepEstadis.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbRepEstadis.LinkColor = System.Drawing.Color.White;
            this.llbRepEstadis.Location = new System.Drawing.Point(9, 357);
            this.llbRepEstadis.Name = "llbRepEstadis";
            this.llbRepEstadis.Size = new System.Drawing.Size(265, 26);
            this.llbRepEstadis.TabIndex = 5;
            this.llbRepEstadis.TabStop = true;
            this.llbRepEstadis.Text = "📊Reportes y Estadisticas";
            this.llbRepEstadis.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbRepEstadis_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "INICIO / ADMIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(339, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "¡Saludos!";
          
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(339, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(733, 201);
            this.label4.TabIndex = 8;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // llbCambRol
            // 
            this.llbCambRol.AutoSize = true;
            this.llbCambRol.BackColor = System.Drawing.Color.Transparent;
            this.llbCambRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbCambRol.LinkColor = System.Drawing.Color.White;
            this.llbCambRol.Location = new System.Drawing.Point(9, 427);
            this.llbCambRol.Name = "llbCambRol";
            this.llbCambRol.Size = new System.Drawing.Size(174, 29);
            this.llbCambRol.TabIndex = 9;
            this.llbCambRol.TabStop = true;
            this.llbCambRol.Text = "Cambio de Rol";
            this.llbCambRol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbCambRol_LinkClicked);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.Location = new System.Drawing.Point(13, 478);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(221, 62);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "CERRAR SESION";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Trabajo_final_herramientas_II.Properties.Resources.Free_Vector___Background_luxury_minimalist_gradient_style_design;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1112, 566);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.llbCambRol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.llbRepEstadis);
            this.Controls.Add(this.llbClases);
            this.Controls.Add(this.llbGInstructores);
            this.Controls.Add(this.llbGCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminMenu";
            this.Text = "Form2";
          
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel llbGCliente;
        private System.Windows.Forms.LinkLabel llbGInstructores;
        private System.Windows.Forms.LinkLabel llbClases;
        private System.Windows.Forms.LinkLabel llbRepEstadis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel llbCambRol;
        private System.Windows.Forms.Button btnSalir;
    }
}