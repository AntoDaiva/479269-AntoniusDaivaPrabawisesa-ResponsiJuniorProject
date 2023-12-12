namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            InserBtn = new Button();
            EditBtn = new Button();
            DeleteBtn = new Button();
            TbKaryawan = new TextBox();
            TbDep = new ComboBox();
            listBox1 = new ListBox();
            dgvData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 72);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 0;
            label1.Text = "Nama Karyawan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 107);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 1;
            label2.Text = "Dep. Karyawan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(111, 72);
            label3.Name = "label3";
            label3.Size = new Size(10, 15);
            label3.TabIndex = 2;
            label3.Text = ":";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(111, 107);
            label4.Name = "label4";
            label4.Size = new Size(10, 15);
            label4.TabIndex = 3;
            label4.Text = ":";
            // 
            // InserBtn
            // 
            InserBtn.Location = new Point(12, 144);
            InserBtn.Name = "InserBtn";
            InserBtn.Size = new Size(109, 23);
            InserBtn.TabIndex = 4;
            InserBtn.Text = "Insert";
            InserBtn.UseVisualStyleBackColor = true;
            InserBtn.Click += InserBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.Location = new Point(187, 144);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(109, 23);
            EditBtn.TabIndex = 5;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += EditBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(369, 144);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(109, 23);
            DeleteBtn.TabIndex = 6;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // TbKaryawan
            // 
            TbKaryawan.Location = new Point(127, 69);
            TbKaryawan.Name = "TbKaryawan";
            TbKaryawan.Size = new Size(169, 23);
            TbKaryawan.TabIndex = 7;
            // 
            // TbDep
            // 
            TbDep.FormattingEnabled = true;
            TbDep.Items.AddRange(new object[] { "HR", "ENG", "DEV", "PM", "FIN" });
            TbDep.Location = new Point(127, 104);
            TbDep.Name = "TbDep";
            TbDep.Size = new Size(169, 23);
            TbDep.TabIndex = 8;
            TbDep.SelectedIndexChanged += TbDep_SelectedIndexChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "ID Departemen:", "HR : HR", "ENG : Engineer", "dEV : Developer", "PM : Product M", "FIN : Finance" });
            listBox1.Location = new Point(358, 33);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 9;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(12, 182);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(466, 210);
            dgvData.TabIndex = 10;
            dgvData.CellClick += dgvData_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 450);
            Controls.Add(dgvData);
            Controls.Add(listBox1);
            Controls.Add(TbDep);
            Controls.Add(TbKaryawan);
            Controls.Add(DeleteBtn);
            Controls.Add(EditBtn);
            Controls.Add(InserBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button InserBtn;
        private Button EditBtn;
        private Button DeleteBtn;
        private TextBox TbKaryawan;
        private ComboBox TbDep;
        private ListBox listBox1;
        private DataGridView dgvData;
    }
}