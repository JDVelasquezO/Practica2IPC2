﻿namespace Presentation.Stores
{
    partial class HomeStore
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
            this.button4 = new System.Windows.Forms.Button();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInitDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinishDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbxDepartament = new System.Windows.Forms.ComboBox();
            this.cbxMunicipality = new System.Windows.Forms.ComboBox();
            this.cbxStore = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(98, 397);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 41);
            this.button4.TabIndex = 36;
            this.button4.Text = "Cargar Archivo de Tiendas";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName,
            this.colLast,
            this.colPhone,
            this.colJob,
            this.colInitDate,
            this.colFinishDate});
            this.dgvEmployees.Location = new System.Drawing.Point(29, 187);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.Size = new System.Drawing.Size(743, 194);
            this.dgvEmployees.TabIndex = 35;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.HeaderText = "Nombre";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colLast
            // 
            this.colLast.HeaderText = "Apellido";
            this.colLast.Name = "colLast";
            this.colLast.ReadOnly = true;
            // 
            // colPhone
            // 
            this.colPhone.HeaderText = "Teléfono";
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            // 
            // colJob
            // 
            this.colJob.HeaderText = "Puesto";
            this.colJob.Name = "colJob";
            this.colJob.ReadOnly = true;
            // 
            // colInitDate
            // 
            this.colInitDate.HeaderText = "Fecha de Inicio";
            this.colInitDate.Name = "colInitDate";
            this.colInitDate.ReadOnly = true;
            // 
            // colFinishDate
            // 
            this.colFinishDate.HeaderText = "Fecha Final";
            this.colFinishDate.Name = "colFinishDate";
            this.colFinishDate.ReadOnly = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(606, 111);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 46);
            this.button3.TabIndex = 34;
            this.button3.Text = "Buscar por departamento";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(347, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 46);
            this.button2.TabIndex = 33;
            this.button2.Text = "Buscar por municipio";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 46);
            this.button1.TabIndex = 32;
            this.button1.Text = "Buscar por tienda";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cbxDepartament
            // 
            this.cbxDepartament.FormattingEnabled = true;
            this.cbxDepartament.Location = new System.Drawing.Point(584, 65);
            this.cbxDepartament.Name = "cbxDepartament";
            this.cbxDepartament.Size = new System.Drawing.Size(188, 21);
            this.cbxDepartament.TabIndex = 31;
            // 
            // cbxMunicipality
            // 
            this.cbxMunicipality.FormattingEnabled = true;
            this.cbxMunicipality.Location = new System.Drawing.Point(307, 65);
            this.cbxMunicipality.Name = "cbxMunicipality";
            this.cbxMunicipality.Size = new System.Drawing.Size(204, 21);
            this.cbxMunicipality.TabIndex = 30;
            // 
            // cbxStore
            // 
            this.cbxStore.FormattingEnabled = true;
            this.cbxStore.Location = new System.Drawing.Point(53, 65);
            this.cbxStore.Name = "cbxStore";
            this.cbxStore.Size = new System.Drawing.Size(193, 21);
            this.cbxStore.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 28);
            this.label2.TabIndex = 28;
            this.label2.Text = "Tiendas";
            // 
            // HomeStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbxDepartament);
            this.Controls.Add(this.cbxMunicipality);
            this.Controls.Add(this.cbxStore);
            this.Controls.Add(this.label2);
            this.Name = "HomeStore";
            this.Text = "HomeStore";
            this.Load += new System.EventHandler(this.HomeStore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJob;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInitDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinishDate;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbxDepartament;
        private System.Windows.Forms.ComboBox cbxMunicipality;
        private System.Windows.Forms.ComboBox cbxStore;
        private System.Windows.Forms.Label label2;
    }
}