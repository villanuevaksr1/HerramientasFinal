﻿namespace Trabajo_final_herramientas_II
{
    partial class ClienteClases
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
            this.dtg = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancelReserv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(101, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(308, 38);
            this.label5.TabIndex = 17;
            this.label5.Text = "Clases disponibles";
            // 
            // dtg
            // 
            this.dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg.Location = new System.Drawing.Point(19, 94);
            this.dtg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtg.Name = "dtg";
            this.dtg.RowHeadersWidth = 51;
            this.dtg.RowTemplate.Height = 24;
            this.dtg.Size = new System.Drawing.Size(485, 391);
            this.dtg.TabIndex = 18;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(539, 94);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(500, 391);
            this.dataGridView2.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(643, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 38);
            this.label1.TabIndex = 20;
            this.label1.Text = "Clases Reservadas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 506);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 50);
            this.button1.TabIndex = 21;
            this.button1.Text = "RESERVAR CLASE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnCancelReserv
            // 
            this.btnCancelReserv.Location = new System.Drawing.Point(539, 506);
            this.btnCancelReserv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelReserv.Name = "btnCancelReserv";
            this.btnCancelReserv.Size = new System.Drawing.Size(139, 50);
            this.btnCancelReserv.TabIndex = 22;
            this.btnCancelReserv.Text = "CANCELAR RESERVA";
            this.btnCancelReserv.UseVisualStyleBackColor = true;
            // 
            // ClienteClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Trabajo_final_herramientas_II.Properties.Resources._6_430_000__Structure_Pictures;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1061, 594);
            this.Controls.Add(this.btnCancelReserv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dtg);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ClienteClases";
            this.Text = "ClienteClases";
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtg;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCancelReserv;
    }
}