namespace RestClientFormTest
{
    partial class MainRestClientForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.urlList = new System.Windows.Forms.DataGridView();
            this.Url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LengthAnswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.urlList)).BeginInit();
            this.SuspendLayout();
            // 
            // urlList
            // 
            this.urlList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.urlList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Url,
            this.Status,
            this.LengthAnswer});
            this.urlList.Location = new System.Drawing.Point(12, 122);
            this.urlList.Name = "urlList";
            this.urlList.Size = new System.Drawing.Size(1093, 757);
            this.urlList.TabIndex = 0;
            // 
            // Url
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Url.DefaultCellStyle = dataGridViewCellStyle2;
            this.Url.HeaderText = "Url";
            this.Url.Name = "Url";
            this.Url.Width = 850;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // LengthAnswer
            // 
            this.LengthAnswer.HeaderText = "Length of the answer";
            this.LengthAnswer.Name = "LengthAnswer";
            this.LengthAnswer.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1030, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainRestClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 891);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.urlList);
            this.Name = "MainRestClientForm";
            this.Text = "Тестирование RestAli";
            this.Load += new System.EventHandler(this.MainRestClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.urlList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView urlList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Url;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn LengthAnswer;
        private System.Windows.Forms.Button button1;
    }
}

