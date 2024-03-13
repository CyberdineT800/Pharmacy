namespace PharmacyDatabase
{
    partial class DrugType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrugType));
            label1 = new Label();
            label2 = new Label();
            deadlinetxt = new TextBox();
            label3 = new Label();
            typesCombo = new ComboBox();
            DatasView = new DataGridView();
            insertbtn = new Button();
            deletebtn = new Button();
            update = new Button();
            button1 = new Button();
            button4 = new Button();
            yeartxt = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)DatasView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(269, 9);
            label1.Name = "label1";
            label1.Size = new Size(275, 73);
            label1.TabIndex = 3;
            label1.Text = "Dori turi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 151);
            label2.Name = "label2";
            label2.Size = new Size(102, 24);
            label2.TabIndex = 4;
            label2.Text = "Dori turi : ";
            // 
            // deadlinetxt
            // 
            deadlinetxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            deadlinetxt.Location = new Point(659, 155);
            deadlinetxt.Name = "deadlinetxt";
            deadlinetxt.Size = new Size(129, 23);
            deadlinetxt.TabIndex = 7;
            deadlinetxt.TextChanged += deadlinetxt_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(511, 151);
            label3.Name = "label3";
            label3.Size = new Size(142, 24);
            label3.TabIndex = 6;
            label3.Text = "Muddati (oy) : ";
            // 
            // typesCombo
            // 
            typesCombo.FormattingEnabled = true;
            typesCombo.Items.AddRange(new object[] { "Kapsula", "Tabletka", "Shimiladigan", "Surkaladigan", "Sepiladigan", "Tomirga yuboriladigan" });
            typesCombo.Location = new Point(126, 151);
            typesCombo.Name = "typesCombo";
            typesCombo.Size = new Size(128, 23);
            typesCombo.TabIndex = 8;
            typesCombo.Text = "<turni tanlang>";
            typesCombo.SelectedIndexChanged += typesCombo_SelectedIndexChanged;
            // 
            // DatasView
            // 
            DatasView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DatasView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DatasView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DatasView.BackgroundColor = SystemColors.ButtonFace;
            DatasView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DatasView.Location = new Point(12, 262);
            DatasView.Name = "DatasView";
            DatasView.ReadOnly = true;
            DatasView.RowTemplate.Height = 25;
            DatasView.Size = new Size(776, 176);
            DatasView.TabIndex = 9;
            DatasView.CellClick += DatasView_CellClick;
            // 
            // insertbtn
            // 
            insertbtn.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            insertbtn.Location = new Point(12, 201);
            insertbtn.Name = "insertbtn";
            insertbtn.Size = new Size(173, 44);
            insertbtn.TabIndex = 10;
            insertbtn.Text = "Qo`shish";
            insertbtn.UseVisualStyleBackColor = true;
            insertbtn.Click += insertbtn_Click;
            // 
            // deletebtn
            // 
            deletebtn.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            deletebtn.Location = new Point(214, 201);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(173, 44);
            deletebtn.TabIndex = 11;
            deletebtn.Text = "O`chirish";
            deletebtn.UseVisualStyleBackColor = true;
            deletebtn.Click += deletebtn_Click;
            // 
            // update
            // 
            update.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            update.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            update.Location = new Point(413, 201);
            update.Name = "update";
            update.Size = new Size(173, 44);
            update.TabIndex = 12;
            update.Text = "Yangilash";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(618, 201);
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
            button4.Location = new Point(706, 201);
            button4.Name = "button4";
            button4.Size = new Size(82, 44);
            button4.TabIndex = 42;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // yeartxt
            // 
            yeartxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            yeartxt.Location = new Point(351, 150);
            yeartxt.Name = "yeartxt";
            yeartxt.Size = new Size(129, 23);
            yeartxt.TabIndex = 45;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(299, 150);
            label4.Name = "label4";
            label4.Size = new Size(56, 24);
            label4.TabIndex = 44;
            label4.Text = "Yili : ";
            // 
            // DrugType
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(yeartxt);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(update);
            Controls.Add(deletebtn);
            Controls.Add(insertbtn);
            Controls.Add(DatasView);
            Controls.Add(typesCombo);
            Controls.Add(deadlinetxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DrugType";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DrugType";
            FormClosing += DrugType_FormClosing;
            Load += DrugType_Load;
            ((System.ComponentModel.ISupportInitialize)DatasView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox deadlinetxt;
        private Label label3;
        private ComboBox typesCombo;
        private DataGridView DatasView;
        private Button insertbtn;
        private Button deletebtn;
        private Button update;
        private Button button1;
        private Button button4;
        private TextBox yeartxt;
        private Label label4;
    }
}