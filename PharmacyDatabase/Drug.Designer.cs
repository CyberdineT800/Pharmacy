namespace PharmacyDatabase
{
    partial class Drug
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Drug));
            update = new Button();
            deletebtn = new Button();
            insertbtn = new Button();
            DatasView = new DataGridView();
            typesCombo = new ComboBox();
            deadlinetxt = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            nametxt = new TextBox();
            label4 = new Label();
            firmtxt = new TextBox();
            pharmacytxt = new TextBox();
            label5 = new Label();
            label6 = new Label();
            diseasetxt = new TextBox();
            label7 = new Label();
            pricetxt = new TextBox();
            label8 = new Label();
            button1 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)DatasView).BeginInit();
            SuspendLayout();
            // 
            // update
            // 
            update.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            update.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            update.Location = new Point(413, 309);
            update.Name = "update";
            update.Size = new Size(173, 44);
            update.TabIndex = 22;
            update.Text = "Yangilash";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // deletebtn
            // 
            deletebtn.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            deletebtn.Location = new Point(214, 309);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(173, 44);
            deletebtn.TabIndex = 21;
            deletebtn.Text = "O`chirish";
            deletebtn.UseVisualStyleBackColor = true;
            deletebtn.Click += deletebtn_Click;
            // 
            // insertbtn
            // 
            insertbtn.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            insertbtn.Location = new Point(12, 309);
            insertbtn.Name = "insertbtn";
            insertbtn.Size = new Size(173, 44);
            insertbtn.TabIndex = 20;
            insertbtn.Text = "Qo`shish";
            insertbtn.UseVisualStyleBackColor = true;
            insertbtn.Click += insertbtn_Click;
            // 
            // DatasView
            // 
            DatasView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DatasView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DatasView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DatasView.BackgroundColor = SystemColors.ButtonFace;
            DatasView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DatasView.Location = new Point(12, 369);
            DatasView.Name = "DatasView";
            DatasView.ReadOnly = true;
            DatasView.RowTemplate.Height = 25;
            DatasView.Size = new Size(776, 176);
            DatasView.TabIndex = 19;
            DatasView.CellClick += DatasView_CellClick;
            // 
            // typesCombo
            // 
            typesCombo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            typesCombo.FormattingEnabled = true;
            typesCombo.Items.AddRange(new object[] { "Kapsula", "Tabletka", "Shimiladigan", "Surkaladigan", "Sepiladigan", "Tomirga yuboriladigan" });
            typesCombo.Location = new Point(623, 169);
            typesCombo.Name = "typesCombo";
            typesCombo.Size = new Size(158, 23);
            typesCombo.TabIndex = 18;
            typesCombo.Text = "<turni tanlang>";
            typesCombo.SelectedIndexChanged += typesCombo_SelectedIndexChanged;
            // 
            // deadlinetxt
            // 
            deadlinetxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            deadlinetxt.Location = new Point(623, 129);
            deadlinetxt.Name = "deadlinetxt";
            deadlinetxt.Size = new Size(158, 21);
            deadlinetxt.TabIndex = 17;
            deadlinetxt.TextChanged += deadlinetxt_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(399, 126);
            label3.Name = "label3";
            label3.Size = new Size(214, 24);
            label3.TabIndex = 16;
            label3.Text = "Saqlash muddati (oy) : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(16, 127);
            label2.Name = "label2";
            label2.Size = new Size(115, 24);
            label2.TabIndex = 15;
            label2.Text = "Dori nomi : ";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(296, 9);
            label1.Name = "label1";
            label1.Size = new Size(234, 73);
            label1.TabIndex = 14;
            label1.Text = "Dorilar";
            // 
            // nametxt
            // 
            nametxt.Location = new Point(144, 129);
            nametxt.Name = "nametxt";
            nametxt.Size = new Size(158, 21);
            nametxt.TabIndex = 24;
            nametxt.TextChanged += nametxt_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(16, 186);
            label4.Name = "label4";
            label4.Size = new Size(95, 24);
            label4.TabIndex = 25;
            label4.Text = "Firmasi : ";
            // 
            // firmtxt
            // 
            firmtxt.Location = new Point(144, 188);
            firmtxt.Name = "firmtxt";
            firmtxt.Size = new Size(158, 21);
            firmtxt.TabIndex = 26;
            firmtxt.TextChanged += firmtxt_TextChanged;
            // 
            // pharmacytxt
            // 
            pharmacytxt.Location = new Point(144, 243);
            pharmacytxt.Name = "pharmacytxt";
            pharmacytxt.Size = new Size(158, 21);
            pharmacytxt.TabIndex = 28;
            pharmacytxt.TextChanged += pharmacytxt_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(16, 241);
            label5.Name = "label5";
            label5.Size = new Size(109, 24);
            label5.TabIndex = 27;
            label5.Text = "Dorixona : ";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(511, 165);
            label6.Name = "label6";
            label6.Size = new Size(102, 24);
            label6.TabIndex = 29;
            label6.Text = "Dori turi : ";
            // 
            // diseasetxt
            // 
            diseasetxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            diseasetxt.Location = new Point(623, 214);
            diseasetxt.Name = "diseasetxt";
            diseasetxt.Size = new Size(158, 21);
            diseasetxt.TabIndex = 31;
            diseasetxt.TextChanged += diseasetxt_TextChanged;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(513, 210);
            label7.Name = "label7";
            label7.Size = new Size(100, 24);
            label7.TabIndex = 30;
            label7.Text = "Kasallik : ";
            // 
            // pricetxt
            // 
            pricetxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pricetxt.Location = new Point(623, 259);
            pricetxt.Name = "pricetxt";
            pricetxt.Size = new Size(158, 21);
            pricetxt.TabIndex = 33;
            pricetxt.TextChanged += pricetxt_TextChanged;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(537, 255);
            label8.Name = "label8";
            label8.Size = new Size(76, 24);
            label8.TabIndex = 32;
            label8.Text = "Narxi : ";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(618, 309);
            button1.Name = "button1";
            button1.Size = new Size(82, 44);
            button1.TabIndex = 43;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(706, 309);
            button4.Name = "button4";
            button4.Size = new Size(82, 44);
            button4.TabIndex = 42;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // Drug
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 557);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(pricetxt);
            Controls.Add(label8);
            Controls.Add(diseasetxt);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(pharmacytxt);
            Controls.Add(label5);
            Controls.Add(firmtxt);
            Controls.Add(label4);
            Controls.Add(nametxt);
            Controls.Add(update);
            Controls.Add(deletebtn);
            Controls.Add(insertbtn);
            Controls.Add(DatasView);
            Controls.Add(typesCombo);
            Controls.Add(deadlinetxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Drug";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Drug";
            FormClosing += Drug_FormClosing;
            Load += Drug_Load;
            ((System.ComponentModel.ISupportInitialize)DatasView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button update;
        private Button deletebtn;
        private Button insertbtn;
        private DataGridView DatasView;
        private ComboBox typesCombo;
        private TextBox deadlinetxt;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox nametxt;
        private Label label4;
        private TextBox firmtxt;
        private TextBox pharmacytxt;
        private Label label5;
        private Label label6;
        private TextBox diseasetxt;
        private Label label7;
        private TextBox pricetxt;
        private Label label8;
        private Button button1;
        private Button button4;
    }
}