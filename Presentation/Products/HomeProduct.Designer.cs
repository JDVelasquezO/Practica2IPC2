namespace Presentation.Products
{
    partial class HomeProduct
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
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbxDepartament = new System.Windows.Forms.ComboBox();
            this.cbxMunicipality = new System.Windows.Forms.ComboBox();
            this.cbxStore = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colCategory,
            this.colQuantity,
            this.colMark,
            this.colPrice,
            this.colDueDate,
            this.colSize});
            this.dgvProducts.Location = new System.Drawing.Point(29, 192);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.Size = new System.Drawing.Size(743, 194);
            this.dgvProducts.TabIndex = 17;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colCategory
            // 
            this.colCategory.HeaderText = "Categoría";
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;
            // 
            // colQuantity
            // 
            this.colQuantity.HeaderText = "Cantidad";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            // 
            // colMark
            // 
            this.colMark.HeaderText = "Marca";
            this.colMark.Name = "colMark";
            this.colMark.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Precio";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colDueDate
            // 
            this.colDueDate.HeaderText = "Fecha de vencimiento";
            this.colDueDate.Name = "colDueDate";
            this.colDueDate.ReadOnly = true;
            // 
            // colSize
            // 
            this.colSize.HeaderText = "Tamaño";
            this.colSize.Name = "colSize";
            this.colSize.ReadOnly = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(606, 121);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 46);
            this.button3.TabIndex = 16;
            this.button3.Text = "Buscar por departamento";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(347, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 46);
            this.button2.TabIndex = 15;
            this.button2.Text = "Buscar por municipio";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 46);
            this.button1.TabIndex = 14;
            this.button1.Text = "Buscar por tienda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxDepartament
            // 
            this.cbxDepartament.FormattingEnabled = true;
            this.cbxDepartament.Location = new System.Drawing.Point(584, 75);
            this.cbxDepartament.Name = "cbxDepartament";
            this.cbxDepartament.Size = new System.Drawing.Size(188, 21);
            this.cbxDepartament.TabIndex = 13;
            // 
            // cbxMunicipality
            // 
            this.cbxMunicipality.FormattingEnabled = true;
            this.cbxMunicipality.Location = new System.Drawing.Point(307, 75);
            this.cbxMunicipality.Name = "cbxMunicipality";
            this.cbxMunicipality.Size = new System.Drawing.Size(204, 21);
            this.cbxMunicipality.TabIndex = 12;
            // 
            // cbxStore
            // 
            this.cbxStore.FormattingEnabled = true;
            this.cbxStore.Location = new System.Drawing.Point(53, 75);
            this.cbxStore.Name = "cbxStore";
            this.cbxStore.Size = new System.Drawing.Size(193, 21);
            this.cbxStore.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "Productos";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(98, 415);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "Agregar Producto";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // HomeProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbxDepartament);
            this.Controls.Add(this.cbxMunicipality);
            this.Controls.Add(this.cbxStore);
            this.Controls.Add(this.label2);
            this.Name = "HomeProduct";
            this.Text = "HomeProduct";
            this.Load += new System.EventHandler(this.HomeProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbxDepartament;
        private System.Windows.Forms.ComboBox cbxMunicipality;
        private System.Windows.Forms.ComboBox cbxStore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSize;
        private System.Windows.Forms.Button button4;
    }
}