namespace Veritabani
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iLKODUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iLADIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sENEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yURTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOLULUKORANIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOPLAMOGRENCİDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alpDataSet1 = new Veritabani.alpDataSet1();
            this.alpTableAdapter = new Veritabani.alpDataSet1TableAdapters.alpTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alpDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iLKODUDataGridViewTextBoxColumn,
            this.iLADIDataGridViewTextBoxColumn,
            this.sENEDataGridViewTextBoxColumn,
            this.yURTDataGridViewTextBoxColumn,
            this.dOLULUKORANIDataGridViewTextBoxColumn,
            this.tOPLAMOGRENCİDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.alpBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(41, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(943, 262);
            this.dataGridView1.TabIndex = 0;
            // 
            // iLKODUDataGridViewTextBoxColumn
            // 
            this.iLKODUDataGridViewTextBoxColumn.DataPropertyName = "İLKODU ";
            this.iLKODUDataGridViewTextBoxColumn.HeaderText = "İLKODU ";
            this.iLKODUDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iLKODUDataGridViewTextBoxColumn.Name = "iLKODUDataGridViewTextBoxColumn";
            this.iLKODUDataGridViewTextBoxColumn.Width = 125;
            // 
            // iLADIDataGridViewTextBoxColumn
            // 
            this.iLADIDataGridViewTextBoxColumn.DataPropertyName = "İLADI";
            this.iLADIDataGridViewTextBoxColumn.HeaderText = "İLADI";
            this.iLADIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iLADIDataGridViewTextBoxColumn.Name = "iLADIDataGridViewTextBoxColumn";
            this.iLADIDataGridViewTextBoxColumn.Width = 125;
            // 
            // sENEDataGridViewTextBoxColumn
            // 
            this.sENEDataGridViewTextBoxColumn.DataPropertyName = "SENE ";
            this.sENEDataGridViewTextBoxColumn.HeaderText = "SENE ";
            this.sENEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sENEDataGridViewTextBoxColumn.Name = "sENEDataGridViewTextBoxColumn";
            this.sENEDataGridViewTextBoxColumn.Width = 125;
            // 
            // yURTDataGridViewTextBoxColumn
            // 
            this.yURTDataGridViewTextBoxColumn.DataPropertyName = "YURT";
            this.yURTDataGridViewTextBoxColumn.HeaderText = "YURT";
            this.yURTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yURTDataGridViewTextBoxColumn.Name = "yURTDataGridViewTextBoxColumn";
            this.yURTDataGridViewTextBoxColumn.Width = 125;
            // 
            // dOLULUKORANIDataGridViewTextBoxColumn
            // 
            this.dOLULUKORANIDataGridViewTextBoxColumn.DataPropertyName = "DOLULUKORANI";
            this.dOLULUKORANIDataGridViewTextBoxColumn.HeaderText = "DOLULUKORANI";
            this.dOLULUKORANIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dOLULUKORANIDataGridViewTextBoxColumn.Name = "dOLULUKORANIDataGridViewTextBoxColumn";
            this.dOLULUKORANIDataGridViewTextBoxColumn.Width = 125;
            // 
            // tOPLAMOGRENCİDataGridViewTextBoxColumn
            // 
            this.tOPLAMOGRENCİDataGridViewTextBoxColumn.DataPropertyName = "TOPLAMOGRENCİ";
            this.tOPLAMOGRENCİDataGridViewTextBoxColumn.HeaderText = "TOPLAMOGRENCİ";
            this.tOPLAMOGRENCİDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tOPLAMOGRENCİDataGridViewTextBoxColumn.Name = "tOPLAMOGRENCİDataGridViewTextBoxColumn";
            this.tOPLAMOGRENCİDataGridViewTextBoxColumn.Width = 125;
            // 
            // alpBindingSource
            // 
            this.alpBindingSource.DataMember = "alp";
            this.alpBindingSource.DataSource = this.alpDataSet1;
            // 
            // alpDataSet1
            // 
            this.alpDataSet1.DataSetName = "alpDataSet1";
            this.alpDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alpTableAdapter
            // 
            this.alpTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(602, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "Giriş";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(602, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 24);
            this.button2.TabIndex = 2;
            this.button2.Text = "Giriş";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(449, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(449, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(134, 22);
            this.textBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(302, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Şehir Giriniz";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(302, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Yurt Giriniz";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Veritabani.Properties.Resources.wp4514791_chalk_wallpapers__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1029, 484);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alpDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private alpDataSet1 alpDataSet1;
        private System.Windows.Forms.BindingSource alpBindingSource;
        private alpDataSet1TableAdapters.alpTableAdapter alpTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iLKODUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iLADIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sENEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yURTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOLULUKORANIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOPLAMOGRENCİDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}