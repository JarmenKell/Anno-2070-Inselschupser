namespace Anno_2070_Inselschupser
{
    partial class Editor
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.size = new System.Windows.Forms.ComboBox();
            this.generate = new System.Windows.Forms.Button();
            this.leftto = new System.Windows.Forms.MaskedTextBox();
            this.toright = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.k = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.left = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.top = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rect = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid
            // 
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.k,
            this.Type,
            this.left,
            this.top,
            this.Rect});
            this.datagrid.Location = new System.Drawing.Point(12, 41);
            this.datagrid.Name = "datagrid";
            this.datagrid.Size = new System.Drawing.Size(355, 348);
            this.datagrid.TabIndex = 0;
            // 
            // save
            // 
            this.save.AutoSize = true;
            this.save.Location = new System.Drawing.Point(12, 12);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(65, 23);
            this.save.TabIndex = 1;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mapsize";
            // 
            // size
            // 
            this.size.FormattingEnabled = true;
            this.size.Items.AddRange(new object[] {
            "Big",
            "Medium",
            "Small",
            "Mega"});
            this.size.Location = new System.Drawing.Point(171, 11);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(58, 21);
            this.size.TabIndex = 3;
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(238, 9);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(76, 23);
            this.generate.TabIndex = 4;
            this.generate.Text = "Update";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // leftto
            // 
            this.leftto.Location = new System.Drawing.Point(320, 12);
            this.leftto.Mask = "0";
            this.leftto.Name = "leftto";
            this.leftto.Size = new System.Drawing.Size(15, 20);
            this.leftto.TabIndex = 5;
            this.leftto.Text = "1";
            // 
            // toright
            // 
            this.toright.Location = new System.Drawing.Point(352, 12);
            this.toright.Mask = "0";
            this.toright.Name = "toright";
            this.toright.Size = new System.Drawing.Size(15, 20);
            this.toright.TabIndex = 6;
            this.toright.Text = "2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "to";
            // 
            // k
            // 
            this.k.HeaderText = "Index";
            this.k.Name = "k";
            this.k.ReadOnly = true;
            this.k.Width = 40;
            // 
            // Type
            // 
            this.Type.HeaderText = "Islandtype";
            this.Type.Items.AddRange(new object[] {
            "Normal Island",
            "Underwaterplateau",
            "Main Island",
            "E.T.O.",
            "Pirate Island"});
            this.Type.Name = "Type";
            this.Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Type.Width = 125;
            // 
            // left
            // 
            this.left.HeaderText = "x pos";
            this.left.Name = "left";
            this.left.Width = 40;
            // 
            // top
            // 
            this.top.HeaderText = "y pos";
            this.top.Name = "top";
            this.top.Width = 40;
            // 
            // Rect
            // 
            this.Rect.HeaderText = "Size";
            this.Rect.Items.AddRange(new object[] {
            "256",
            "240",
            "224",
            "208",
            "192",
            "176",
            "160",
            "144",
            "128",
            "112",
            "96"});
            this.Rect.Name = "Rect";
            this.Rect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Rect.Width = 50;
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 401);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toright);
            this.Controls.Add(this.leftto);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.size);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.datagrid);
            this.Name = "Editor";
            this.Text = "Anno 2070 Inselschupser";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox size;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.MaskedTextBox leftto;
        private System.Windows.Forms.MaskedTextBox toright;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn k;
        private System.Windows.Forms.DataGridViewComboBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn left;
        private System.Windows.Forms.DataGridViewTextBoxColumn top;
        private System.Windows.Forms.DataGridViewComboBoxColumn Rect;
    }
}

