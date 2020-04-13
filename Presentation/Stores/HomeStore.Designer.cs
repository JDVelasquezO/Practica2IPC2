namespace Presentation.Stores
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
            this.dgvStore = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMuni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbxDepartament = new System.Windows.Forms.ComboBox();
            this.cbxMunicipality = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStore)).BeginInit();
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
            // dgvStore
            // 
            this.dgvStore.AllowUserToAddRows = false;
            this.dgvStore.AllowUserToDeleteRows = false;
            this.dgvStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colPhone,
            this.colAddress,
            this.colMuni,
            this.colDepartament,
            this.colEmployee});
            this.dgvStore.Location = new System.Drawing.Point(29, 187);
            this.dgvStore.Name = "dgvStore";
            this.dgvStore.ReadOnly = true;
            this.dgvStore.Size = new System.Drawing.Size(769, 194);
            this.dgvStore.TabIndex = 35;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colPhone
            // 
            this.colPhone.HeaderText = "Teléfono";
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            // 
            // colAddress
            // 
            this.colAddress.HeaderText = "Dirección";
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            // 
            // colMuni
            // 
            this.colMuni.HeaderText = "Municipio";
            this.colMuni.Name = "colMuni";
            this.colMuni.ReadOnly = true;
            // 
            // colDepartament
            // 
            this.colDepartament.HeaderText = "Departamento";
            this.colDepartament.Name = "colDepartament";
            this.colDepartament.ReadOnly = true;
            // 
            // colEmployee
            // 
            this.colEmployee.HeaderText = "Empleado";
            this.colEmployee.Name = "colEmployee";
            this.colEmployee.ReadOnly = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(538, 109);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 46);
            this.button3.TabIndex = 34;
            this.button3.Text = "Buscar por departamento";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(155, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 46);
            this.button2.TabIndex = 33;
            this.button2.Text = "Buscar por municipio";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbxDepartament
            // 
            this.cbxDepartament.FormattingEnabled = true;
            this.cbxDepartament.Location = new System.Drawing.Point(520, 63);
            this.cbxDepartament.Name = "cbxDepartament";
            this.cbxDepartament.Size = new System.Drawing.Size(188, 21);
            this.cbxDepartament.TabIndex = 31;
            // 
            // cbxMunicipality
            // 
            this.cbxMunicipality.FormattingEnabled = true;
            this.cbxMunicipality.Location = new System.Drawing.Point(115, 63);
            this.cbxMunicipality.Name = "cbxMunicipality";
            this.cbxMunicipality.Size = new System.Drawing.Size(204, 21);
            this.cbxMunicipality.TabIndex = 30;
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
            this.ClientSize = new System.Drawing.Size(810, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dgvStore);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cbxDepartament);
            this.Controls.Add(this.cbxMunicipality);
            this.Controls.Add(this.label2);
            this.Name = "HomeStore";
            this.Text = "HomeStore";
            this.Load += new System.EventHandler(this.HomeStore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgvStore;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbxDepartament;
        private System.Windows.Forms.ComboBox cbxMunicipality;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMuni;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartament;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployee;
    }
}