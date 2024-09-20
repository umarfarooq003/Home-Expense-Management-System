namespace ExpenseManagment
{
    partial class VeiwExpenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VeiwExpenses));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DashBoard = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ExpenseNametextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.VeiwExpensepictureBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ExpensepictureBox = new System.Windows.Forms.PictureBox();
            this.VeiwIncome = new System.Windows.Forms.Label();
            this.VeiwIncomepictureBox = new System.Windows.Forms.PictureBox();
            this.IncomeLabel = new System.Windows.Forms.Label();
            this.IncomepictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Dashboardpicturebox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ShowBtn = new System.Windows.Forms.Button();
            this.Closebtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VeiwExpensepictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpensepictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VeiwIncomepictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncomepictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dashboardpicturebox)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(410, 238);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(746, 264);
            this.panel3.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(600, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 47);
            this.label3.TabIndex = 8;
            this.label3.Text = "Veiw Expense";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Housing",
            "Food",
            "Utility Bills",
            "Entertainment",
            "Insurance",
            "Internet and Cables",
            "Transportation",
            "Personal",
            "Home Repairs",
            "Health",
            "Housing",
            " Food and Groceries",
            " Household",
            " Travel",
            "Pets",
            " Vehicle",
            "Vacation"});
            this.comboBox1.Location = new System.Drawing.Point(394, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(254, 29);
            this.comboBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(389, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dashboard";
            // 
            // DashBoard
            // 
            this.DashBoard.AutoSize = true;
            this.DashBoard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashBoard.Location = new System.Drawing.Point(89, 104);
            this.DashBoard.Name = "DashBoard";
            this.DashBoard.Size = new System.Drawing.Size(93, 21);
            this.DashBoard.TabIndex = 1;
            this.DashBoard.Text = "Dashboard";
            this.DashBoard.Click += new System.EventHandler(this.DashBoard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(87, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Expense Name";
            // 
            // ExpenseNametextbox
            // 
            this.ExpenseNametextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpenseNametextbox.Location = new System.Drawing.Point(92, 58);
            this.ExpenseNametextbox.Multiline = true;
            this.ExpenseNametextbox.Name = "ExpenseNametextbox";
            this.ExpenseNametextbox.Size = new System.Drawing.Size(243, 29);
            this.ExpenseNametextbox.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(3, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 60);
            this.label6.TabIndex = 10;
            this.label6.Text = " Home Expense\r\n Management Sytem\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(89, 498);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Veiw Expense";
            // 
            // VeiwExpensepictureBox
            // 
            this.VeiwExpensepictureBox.Image = ((System.Drawing.Image)(resources.GetObject("VeiwExpensepictureBox.Image")));
            this.VeiwExpensepictureBox.Location = new System.Drawing.Point(10, 478);
            this.VeiwExpensepictureBox.Name = "VeiwExpensepictureBox";
            this.VeiwExpensepictureBox.Size = new System.Drawing.Size(64, 64);
            this.VeiwExpensepictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VeiwExpensepictureBox.TabIndex = 8;
            this.VeiwExpensepictureBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Expense";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ExpensepictureBox
            // 
            this.ExpensepictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ExpensepictureBox.Image")));
            this.ExpensepictureBox.Location = new System.Drawing.Point(10, 378);
            this.ExpensepictureBox.Name = "ExpensepictureBox";
            this.ExpensepictureBox.Size = new System.Drawing.Size(64, 64);
            this.ExpensepictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExpensepictureBox.TabIndex = 6;
            this.ExpensepictureBox.TabStop = false;
            // 
            // VeiwIncome
            // 
            this.VeiwIncome.AutoSize = true;
            this.VeiwIncome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VeiwIncome.Location = new System.Drawing.Point(89, 314);
            this.VeiwIncome.Name = "VeiwIncome";
            this.VeiwIncome.Size = new System.Drawing.Size(112, 21);
            this.VeiwIncome.TabIndex = 5;
            this.VeiwIncome.Text = " Veiw Income";
            this.VeiwIncome.Click += new System.EventHandler(this.VeiwIncome_Click);
            // 
            // VeiwIncomepictureBox
            // 
            this.VeiwIncomepictureBox.Image = ((System.Drawing.Image)(resources.GetObject("VeiwIncomepictureBox.Image")));
            this.VeiwIncomepictureBox.Location = new System.Drawing.Point(10, 284);
            this.VeiwIncomepictureBox.Name = "VeiwIncomepictureBox";
            this.VeiwIncomepictureBox.Size = new System.Drawing.Size(64, 64);
            this.VeiwIncomepictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VeiwIncomepictureBox.TabIndex = 4;
            this.VeiwIncomepictureBox.TabStop = false;
            // 
            // IncomeLabel
            // 
            this.IncomeLabel.AutoSize = true;
            this.IncomeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncomeLabel.Location = new System.Drawing.Point(89, 202);
            this.IncomeLabel.Name = "IncomeLabel";
            this.IncomeLabel.Size = new System.Drawing.Size(67, 21);
            this.IncomeLabel.TabIndex = 3;
            this.IncomeLabel.Text = "Income";
            this.IncomeLabel.Click += new System.EventHandler(this.IncomeLabel_Click);
            // 
            // IncomepictureBox
            // 
            this.IncomepictureBox.Image = ((System.Drawing.Image)(resources.GetObject("IncomepictureBox.Image")));
            this.IncomepictureBox.Location = new System.Drawing.Point(10, 182);
            this.IncomepictureBox.Name = "IncomepictureBox";
            this.IncomepictureBox.Size = new System.Drawing.Size(64, 64);
            this.IncomepictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IncomepictureBox.TabIndex = 2;
            this.IncomepictureBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.VeiwExpensepictureBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ExpensepictureBox);
            this.panel1.Controls.Add(this.VeiwIncome);
            this.panel1.Controls.Add(this.VeiwIncomepictureBox);
            this.panel1.Controls.Add(this.IncomeLabel);
            this.panel1.Controls.Add(this.IncomepictureBox);
            this.panel1.Controls.Add(this.DashBoard);
            this.panel1.Controls.Add(this.Dashboardpicturebox);
            this.panel1.Location = new System.Drawing.Point(2, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 573);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Dashboardpicturebox
            // 
            this.Dashboardpicturebox.Image = ((System.Drawing.Image)(resources.GetObject("Dashboardpicturebox.Image")));
            this.Dashboardpicturebox.Location = new System.Drawing.Point(10, 84);
            this.Dashboardpicturebox.Name = "Dashboardpicturebox";
            this.Dashboardpicturebox.Size = new System.Drawing.Size(64, 64);
            this.Dashboardpicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Dashboardpicturebox.TabIndex = 0;
            this.Dashboardpicturebox.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.SearchBtn);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ExpenseNametextbox);
            this.panel2.Location = new System.Drawing.Point(282, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(977, 113);
            this.panel2.TabIndex = 7;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Location = new System.Drawing.Point(750, 58);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(160, 33);
            this.SearchBtn.TabIndex = 11;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Location = new System.Drawing.Point(410, 529);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(107, 41);
            this.AddBtn.TabIndex = 10;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.Location = new System.Drawing.Point(559, 529);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(107, 41);
            this.UpdateBtn.TabIndex = 11;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(741, 529);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(107, 41);
            this.DeleteBtn.TabIndex = 12;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ShowBtn
            // 
            this.ShowBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowBtn.Location = new System.Drawing.Point(900, 529);
            this.ShowBtn.Name = "ShowBtn";
            this.ShowBtn.Size = new System.Drawing.Size(107, 41);
            this.ShowBtn.TabIndex = 13;
            this.ShowBtn.Text = "ShowData";
            this.ShowBtn.UseVisualStyleBackColor = true;
            this.ShowBtn.Click += new System.EventHandler(this.ShowBtn_Click);
            // 
            // Closebtn
            // 
            this.Closebtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Closebtn.Location = new System.Drawing.Point(1049, 529);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(107, 41);
            this.Closebtn.TabIndex = 14;
            this.Closebtn.Text = "Close";
            this.Closebtn.UseVisualStyleBackColor = true;
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(746, 264);
            this.dataGridView1.TabIndex = 0;
            // 
            // VeiwExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1281, 582);
            this.Controls.Add(this.Closebtn);
            this.Controls.Add(this.ShowBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "VeiwExpenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VeiwExpenses";
            this.Load += new System.EventHandler(this.VeiwExpenses_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VeiwExpensepictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpensepictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VeiwIncomepictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncomepictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dashboardpicturebox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DashBoard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ExpenseNametextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox VeiwExpensepictureBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox ExpensepictureBox;
        private System.Windows.Forms.Label VeiwIncome;
        private System.Windows.Forms.PictureBox VeiwIncomepictureBox;
        private System.Windows.Forms.Label IncomeLabel;
        private System.Windows.Forms.PictureBox IncomepictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Dashboardpicturebox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button ShowBtn;
        private System.Windows.Forms.Button Closebtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}