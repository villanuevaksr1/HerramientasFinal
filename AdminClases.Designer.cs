namespace Trabajo_final_herramientas_II
{
    partial class AdminClases
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
            this.dgvClasesDisp = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameClass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipeClass = new System.Windows.Forms.ComboBox();
            this.dtpHorario = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.nudCupoMax = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSalonAsig = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbInstAsig = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasesDisp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCupoMax)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClasesDisp
            // 
            this.dgvClasesDisp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClasesDisp.Location = new System.Drawing.Point(344, 88);
            this.dgvClasesDisp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvClasesDisp.Name = "dgvClasesDisp";
            this.dgvClasesDisp.RowHeadersWidth = 51;
            this.dgvClasesDisp.RowTemplate.Height = 24;
            this.dgvClasesDisp.Size = new System.Drawing.Size(460, 370);
            this.dgvClasesDisp.TabIndex = 14;
            this.dgvClasesDisp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(440, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 31);
            this.label5.TabIndex = 16;
            this.label5.Text = "Clases disponibles";
            // 
            // btnAddClass
            // 
            this.btnAddClass.Location = new System.Drawing.Point(14, 363);
            this.btnAddClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(118, 50);
            this.btnAddClass.TabIndex = 18;
            this.btnAddClass.Text = "GENERAR CLASE";
            this.btnAddClass.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(9, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nombre de la clase";
            // 
            // txtNameClass
            // 
            this.txtNameClass.Location = new System.Drawing.Point(201, 106);
            this.txtNameClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNameClass.Name = "txtNameClass";
            this.txtNameClass.Size = new System.Drawing.Size(116, 20);
            this.txtNameClass.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(9, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tipo de clase";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(9, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "Fecha y hora";
            // 
            // cmbTipeClass
            // 
            this.cmbTipeClass.FormattingEnabled = true;
            this.cmbTipeClass.Location = new System.Drawing.Point(201, 145);
            this.cmbTipeClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbTipeClass.Name = "cmbTipeClass";
            this.cmbTipeClass.Size = new System.Drawing.Size(116, 21);
            this.cmbTipeClass.TabIndex = 23;
            // 
            // dtpHorario
            // 
            this.dtpHorario.Location = new System.Drawing.Point(146, 187);
            this.dtpHorario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpHorario.Name = "dtpHorario";
            this.dtpHorario.Size = new System.Drawing.Size(194, 20);
            this.dtpHorario.TabIndex = 24;
            this.dtpHorario.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(9, 225);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "Cupo Maximo";
            // 
            // nudCupoMax
            // 
            this.nudCupoMax.Location = new System.Drawing.Point(201, 232);
            this.nudCupoMax.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudCupoMax.Name = "nudCupoMax";
            this.nudCupoMax.Size = new System.Drawing.Size(116, 20);
            this.nudCupoMax.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(9, 271);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 24);
            this.label6.TabIndex = 27;
            this.label6.Text = "Salon Asignado";
            // 
            // txtSalonAsig
            // 
            this.txtSalonAsig.Location = new System.Drawing.Point(201, 277);
            this.txtSalonAsig.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSalonAsig.Name = "txtSalonAsig";
            this.txtSalonAsig.Size = new System.Drawing.Size(116, 20);
            this.txtSalonAsig.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(10, 316);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 24);
            this.label7.TabIndex = 29;
            this.label7.Text = "Instructor asignado";
            // 
            // cmbInstAsig
            // 
            this.cmbInstAsig.FormattingEnabled = true;
            this.cmbInstAsig.Location = new System.Drawing.Point(201, 320);
            this.cmbInstAsig.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbInstAsig.Name = "cmbInstAsig";
            this.cmbInstAsig.Size = new System.Drawing.Size(116, 21);
            this.cmbInstAsig.TabIndex = 30;
            // 
            // AdminClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Trabajo_final_herramientas_II.Properties.Resources._6_430_000__Structure_Pictures;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(807, 479);
            this.Controls.Add(this.cmbInstAsig);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSalonAsig);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudCupoMax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpHorario);
            this.Controls.Add(this.cmbTipeClass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNameClass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddClass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvClasesDisp);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminClases";
            this.Text = "ClasesYReservas";
            this.Load += new System.EventHandler(this.ClasesYReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasesDisp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCupoMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvClasesDisp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipeClass;
        private System.Windows.Forms.DateTimePicker dtpHorario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudCupoMax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSalonAsig;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbInstAsig;
    }
}