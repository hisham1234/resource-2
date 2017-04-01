namespace IP
{
    partial class viewLectureSchedule
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.resourceAllocationDataSet13 = new IP.ResourceAllocationDataSet13();
            this.batchesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.batchesTableAdapter = new IP.ResourceAllocationDataSet13TableAdapters.BatchesTableAdapter();
            this.resourceAllocationDataSet14 = new IP.ResourceAllocationDataSet14();
            this.modulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modulesTableAdapter = new IP.ResourceAllocationDataSet14TableAdapters.ModulesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceAllocationDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batchesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceAllocationDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.batchesBindingSource;
            this.comboBox1.DisplayMember = "B_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(153, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Batch";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Module";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.modulesBindingSource;
            this.comboBox2.DisplayMember = "Module_id";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(153, 90);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "View Time Table";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(78, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(637, 231);
            this.dataGridView1.TabIndex = 5;
            // 
            // resourceAllocationDataSet13
            // 
            this.resourceAllocationDataSet13.DataSetName = "ResourceAllocationDataSet13";
            this.resourceAllocationDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // batchesBindingSource
            // 
            this.batchesBindingSource.DataMember = "Batches";
            this.batchesBindingSource.DataSource = this.resourceAllocationDataSet13;
            // 
            // batchesTableAdapter
            // 
            this.batchesTableAdapter.ClearBeforeFill = true;
            // 
            // resourceAllocationDataSet14
            // 
            this.resourceAllocationDataSet14.DataSetName = "ResourceAllocationDataSet14";
            this.resourceAllocationDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // modulesBindingSource
            // 
            this.modulesBindingSource.DataMember = "Modules";
            this.modulesBindingSource.DataSource = this.resourceAllocationDataSet14;
            // 
            // modulesTableAdapter
            // 
            this.modulesTableAdapter.ClearBeforeFill = true;
            // 
            // viewLectureSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 417);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "viewLectureSchedule";
            this.Text = "viewLectureSchedule";
            this.Load += new System.EventHandler(this.viewLectureSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceAllocationDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batchesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceAllocationDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ResourceAllocationDataSet13 resourceAllocationDataSet13;
        private System.Windows.Forms.BindingSource batchesBindingSource;
        private ResourceAllocationDataSet13TableAdapters.BatchesTableAdapter batchesTableAdapter;
        private ResourceAllocationDataSet14 resourceAllocationDataSet14;
        private System.Windows.Forms.BindingSource modulesBindingSource;
        private ResourceAllocationDataSet14TableAdapters.ModulesTableAdapter modulesTableAdapter;
    }
}