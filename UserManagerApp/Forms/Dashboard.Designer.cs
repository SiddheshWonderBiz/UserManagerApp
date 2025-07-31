namespace UserManagerApp.Forms
{
    partial class Dashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            fontDialog1 = new FontDialog();
            lblWelcome = new Label();
            lblEmail = new Label();
            btnLogout = new Button();
            dataGridView1 = new DataGridView();
            btnCalculator = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblWelcome.BackColor = Color.FromArgb(61, 205, 88);
            lblWelcome.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.ImageAlign = ContentAlignment.MiddleLeft;
            lblWelcome.Location = new Point(0, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(964, 39);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome";
            lblWelcome.TextAlign = ContentAlignment.MiddleLeft;
            lblWelcome.Click += lblWelcome_Click;
            // 
            // lblEmail
            // 
            lblEmail.BackColor = Color.FromArgb(61, 205, 88);
            lblEmail.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(0, 39);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(964, 39);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email";
            lblEmail.TextAlign = ContentAlignment.MiddleLeft;
            lblEmail.Click += lblEmail_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.White;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.FromArgb(61, 205, 88);
            btnLogout.Location = new Point(809, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(132, 48);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(964, 362);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnCalculator
            // 
            btnCalculator.BackColor = Color.FromArgb(0, 192, 0);
            btnCalculator.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalculator.ForeColor = Color.White;
            btnCalculator.Location = new Point(657, 12);
            btnCalculator.Name = "btnCalculator";
            btnCalculator.Size = new Size(132, 48);
            btnCalculator.TabIndex = 4;
            btnCalculator.Text = "Calculator";
            btnCalculator.UseVisualStyleBackColor = false;
            btnCalculator.Click += btnCalculator_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(964, 442);
            Controls.Add(btnCalculator);
            Controls.Add(dataGridView1);
            Controls.Add(btnLogout);
            Controls.Add(lblEmail);
            Controls.Add(lblWelcome);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FontDialog fontDialog1;
        private Label lblWelcome;
        private Label lblEmail;
        private Button btnLogout;
        private DataGridView dataGridView1;
        private Button btnCalculator;
    }
}
