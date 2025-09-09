namespace HospitalManagement
{
    partial class FrmBranch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBranch));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBranchId = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBranchName = new System.Windows.Forms.TextBox();
            this.btnBranchAdd = new System.Windows.Forms.Button();
            this.btnBranchDelete = new System.Windows.Forms.Button();
            this.btnBranchUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Branş İd:";
            // 
            // txtBranchId
            // 
            this.txtBranchId.Location = new System.Drawing.Point(150, 53);
            this.txtBranchId.Name = "txtBranchId";
            this.txtBranchId.Size = new System.Drawing.Size(266, 40);
            this.txtBranchId.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(425, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(475, 425);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "Branş Ad:";
            // 
            // txtBranchName
            // 
            this.txtBranchName.Location = new System.Drawing.Point(150, 123);
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.Size = new System.Drawing.Size(266, 40);
            this.txtBranchName.TabIndex = 1;
            // 
            // btnBranchAdd
            // 
            this.btnBranchAdd.Location = new System.Drawing.Point(80, 209);
            this.btnBranchAdd.Name = "btnBranchAdd";
            this.btnBranchAdd.Size = new System.Drawing.Size(121, 50);
            this.btnBranchAdd.TabIndex = 3;
            this.btnBranchAdd.Text = "Ekle";
            this.btnBranchAdd.UseVisualStyleBackColor = true;
            this.btnBranchAdd.Click += new System.EventHandler(this.btnBranchAdd_Click);
            // 
            // btnBranchDelete
            // 
            this.btnBranchDelete.Location = new System.Drawing.Point(295, 209);
            this.btnBranchDelete.Name = "btnBranchDelete";
            this.btnBranchDelete.Size = new System.Drawing.Size(121, 50);
            this.btnBranchDelete.TabIndex = 4;
            this.btnBranchDelete.Text = "Sil";
            this.btnBranchDelete.UseVisualStyleBackColor = true;
            this.btnBranchDelete.Click += new System.EventHandler(this.btnBranchDelete_Click);
            // 
            // btnBranchUpdate
            // 
            this.btnBranchUpdate.Location = new System.Drawing.Point(178, 297);
            this.btnBranchUpdate.Name = "btnBranchUpdate";
            this.btnBranchUpdate.Size = new System.Drawing.Size(137, 50);
            this.btnBranchUpdate.TabIndex = 5;
            this.btnBranchUpdate.Text = "Güncelle";
            this.btnBranchUpdate.UseVisualStyleBackColor = true;
            this.btnBranchUpdate.Click += new System.EventHandler(this.btnBranchUpdate_Click);
            // 
            // FrmBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(96)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(912, 445);
            this.Controls.Add(this.btnBranchUpdate);
            this.Controls.Add(this.btnBranchDelete);
            this.Controls.Add(this.btnBranchAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBranchName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBranchId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "FrmBranch";
            this.Text = "Branş Paneli";
            this.Load += new System.EventHandler(this.FrmBranch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBranchId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBranchName;
        private System.Windows.Forms.Button btnBranchAdd;
        private System.Windows.Forms.Button btnBranchDelete;
        private System.Windows.Forms.Button btnBranchUpdate;
    }
}