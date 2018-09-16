namespace fernandezsaavedraricardo.Channel9
{
    partial class Frm_principal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reader = new System.Windows.Forms.RichTextBox();
            this.btn_more = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.link = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 100);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select the article that you are interested and read it!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Channel 9 RSS";
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.title,
            this.description,
            this.link});
            this.grid.Dock = System.Windows.Forms.DockStyle.Top;
            this.grid.Location = new System.Drawing.Point(0, 100);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(876, 176);
            this.grid.TabIndex = 0;
            this.grid.SelectionChanged += new System.EventHandler(this.grid_SelectionChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reader);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 276);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(876, 134);
            this.panel2.TabIndex = 3;
            // 
            // reader
            // 
            this.reader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reader.Location = new System.Drawing.Point(0, 0);
            this.reader.Name = "reader";
            this.reader.Size = new System.Drawing.Size(876, 134);
            this.reader.TabIndex = 0;
            this.reader.Text = "";
            // 
            // btn_more
            // 
            this.btn_more.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_more.Location = new System.Drawing.Point(0, 0);
            this.btn_more.Name = "btn_more";
            this.btn_more.Size = new System.Drawing.Size(876, 35);
            this.btn_more.TabIndex = 1;
            this.btn_more.Text = "See more on Website";
            this.btn_more.UseVisualStyleBackColor = true;
            this.btn_more.Click += new System.EventHandler(this.btn_more_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_more);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 415);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(876, 35);
            this.panel3.TabIndex = 4;
            // 
            // date
            // 
            dataGridViewCellStyle1.Format = "g";
            dataGridViewCellStyle1.NullValue = null;
            this.date.DefaultCellStyle = dataGridViewCellStyle1;
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // title
            // 
            this.title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.title.HeaderText = "Title";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.Width = 50;
            // 
            // description
            // 
            this.description.HeaderText = "description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Visible = false;
            // 
            // link
            // 
            this.link.HeaderText = "Link";
            this.link.Name = "link";
            this.link.ReadOnly = true;
            this.link.Visible = false;
            // 
            // Frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_principal";
            this.Text = "Channel 9 Reader";
            this.Load += new System.EventHandler(this.Frm_principal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox reader;
        private System.Windows.Forms.Button btn_more;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn link;
    }
}

