namespace Trabajo_final_herramientas_II
{
    partial class CambioRol
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
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.rbInst = new System.Windows.Forms.RadioButton();
            this.rbClient = new System.Windows.Forms.RadioButton();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(272, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(291, 38);
            this.label5.TabIndex = 13;
            this.label5.Text = "CAMBIO DE ROL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(44, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 38);
            this.label1.TabIndex = 14;
            this.label1.Text = "¿Con qué rol deseas continuar? ";
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.BackColor = System.Drawing.Color.Transparent;
            this.rbAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAdmin.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rbAdmin.Location = new System.Drawing.Point(51, 182);
            this.rbAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(246, 33);
            this.rbAdmin.TabIndex = 15;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Text = "ADMINISTRADOR";
            this.rbAdmin.UseVisualStyleBackColor = false;
            this.rbAdmin.CheckedChanged += new System.EventHandler(this.rbAdmin_CheckedChanged);
            // 
            // rbInst
            // 
            this.rbInst.AutoSize = true;
            this.rbInst.BackColor = System.Drawing.Color.Transparent;
            this.rbInst.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInst.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbInst.Location = new System.Drawing.Point(51, 224);
            this.rbInst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbInst.Name = "rbInst";
            this.rbInst.Size = new System.Drawing.Size(203, 33);
            this.rbInst.TabIndex = 16;
            this.rbInst.TabStop = true;
            this.rbInst.Text = "INSTRUCTOR";
            this.rbInst.UseVisualStyleBackColor = false;
            // 
            // rbClient
            // 
            this.rbClient.AutoSize = true;
            this.rbClient.BackColor = System.Drawing.Color.Transparent;
            this.rbClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbClient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbClient.Location = new System.Drawing.Point(51, 263);
            this.rbClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbClient.Name = "rbClient";
            this.rbClient.Size = new System.Drawing.Size(143, 33);
            this.rbClient.TabIndex = 17;
            this.rbClient.TabStop = true;
            this.rbClient.Text = "CLIENTE";
            this.rbClient.UseVisualStyleBackColor = false;
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(51, 324);
            this.btnContinue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(165, 54);
            this.btnContinue.TabIndex = 18;
            this.btnContinue.Text = "CONTINUAR";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(243, 324);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(165, 54);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // CambioRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Trabajo_final_herramientas_II.Properties.Resources._6_430_000__Structure_Pictures;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(899, 580);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.rbClient);
            this.Controls.Add(this.rbInst);
            this.Controls.Add(this.rbAdmin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CambioRol";
            this.Text = "CambioRol";
            this.Load += new System.EventHandler(this.CambioRol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.RadioButton rbInst;
        private System.Windows.Forms.RadioButton rbClient;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnCancelar;
    }
}