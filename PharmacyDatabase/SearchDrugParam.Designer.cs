namespace PharmacyDatabase
{
    partial class SearchByDrugParam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchByDrugParam));
            button1 = new Button();
            button4 = new Button();
            DatasView = new DataGridView();
            typesCombo = new ComboBox();
            deadline1txt = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            deadline2txt = new TextBox();
            hintCombo1 = new ComboBox();
            logicCombo = new ComboBox();
            hintCombo2 = new ComboBox();
            hintComboPrice2 = new ComboBox();
            logicComboPrice = new ComboBox();
            hintComboPrice1 = new ComboBox();
            price2txt = new TextBox();
            price1txt = new TextBox();
            label4 = new Label();
            label5 = new Label();
            nametxt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DatasView).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(706, 225);
            button1.Name = "button1";
            button1.Size = new Size(82, 30);
            button1.TabIndex = 52;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(706, 261);
            button4.Name = "button4";
            button4.Size = new Size(82, 30);
            button4.TabIndex = 51;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // DatasView
            // 
            DatasView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DatasView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DatasView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DatasView.BackgroundColor = SystemColors.ButtonFace;
            DatasView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DatasView.Location = new Point(12, 312);
            DatasView.Name = "DatasView";
            DatasView.ReadOnly = true;
            DatasView.RowTemplate.Height = 25;
            DatasView.Size = new Size(776, 176);
            DatasView.TabIndex = 49;
            // 
            // typesCombo
            // 
            typesCombo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            typesCombo.FormattingEnabled = true;
            typesCombo.Items.AddRange(new object[] { "Kapsula", "Tabletka", "Shimiladigan", "Surkaladigan", "Sepiladigan", "Tomirga yuboriladigan" });
            typesCombo.Location = new Point(617, 180);
            typesCombo.Name = "typesCombo";
            typesCombo.Size = new Size(171, 23);
            typesCombo.TabIndex = 48;
            typesCombo.Text = "<turni tanlang>";
            typesCombo.SelectedIndexChanged += typesCombo_SelectedIndexChanged;
            // 
            // deadline1txt
            // 
            deadline1txt.Location = new Point(236, 271);
            deadline1txt.Name = "deadline1txt";
            deadline1txt.Size = new Size(68, 21);
            deadline1txt.TabIndex = 47;
            deadline1txt.TextChanged += deadline1txt_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(12, 267);
            label3.Name = "label3";
            label3.Size = new Size(214, 24);
            label3.TabIndex = 46;
            label3.Text = "Saqlash muddati (oy) : ";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(509, 179);
            label2.Name = "label2";
            label2.Size = new Size(102, 24);
            label2.TabIndex = 45;
            label2.Text = "Dori turi : ";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(133, 9);
            label1.Name = "label1";
            label1.Size = new Size(582, 110);
            label1.TabIndex = 44;
            label1.Text = "Dori parametrlari bo`yicha\r\n               qidiruv";
            // 
            // deadline2txt
            // 
            deadline2txt.Location = new Point(517, 271);
            deadline2txt.Name = "deadline2txt";
            deadline2txt.Size = new Size(68, 21);
            deadline2txt.TabIndex = 53;
            deadline2txt.TextChanged += deadline2txt_TextChanged;
            // 
            // hintCombo1
            // 
            hintCombo1.FormattingEnabled = true;
            hintCombo1.Items.AddRange(new object[] { ">", ">=", "=", "<=", "<" });
            hintCombo1.Location = new Point(310, 271);
            hintCombo1.Name = "hintCombo1";
            hintCombo1.Size = new Size(63, 23);
            hintCombo1.TabIndex = 54;
            hintCombo1.SelectedIndexChanged += hintCombo1_SelectedIndexChanged;
            // 
            // logicCombo
            // 
            logicCombo.FormattingEnabled = true;
            logicCombo.Items.AddRange(new object[] { "AND", "OR" });
            logicCombo.Location = new Point(379, 271);
            logicCombo.Name = "logicCombo";
            logicCombo.Size = new Size(63, 23);
            logicCombo.TabIndex = 55;
            logicCombo.SelectedIndexChanged += logicCombo_SelectedIndexChanged;
            // 
            // hintCombo2
            // 
            hintCombo2.FormattingEnabled = true;
            hintCombo2.Items.AddRange(new object[] { ">", ">=", "=", "<=", "<" });
            hintCombo2.Location = new Point(448, 271);
            hintCombo2.Name = "hintCombo2";
            hintCombo2.Size = new Size(63, 23);
            hintCombo2.TabIndex = 56;
            hintCombo2.SelectedIndexChanged += hintCombo2_SelectedIndexChanged;
            // 
            // hintComboPrice2
            // 
            hintComboPrice2.FormattingEnabled = true;
            hintComboPrice2.Items.AddRange(new object[] { ">", ">=", "=", "<=", "<" });
            hintComboPrice2.Location = new Point(448, 226);
            hintComboPrice2.Name = "hintComboPrice2";
            hintComboPrice2.Size = new Size(63, 23);
            hintComboPrice2.TabIndex = 64;
            hintComboPrice2.SelectedIndexChanged += hintComboPrice2_SelectedIndexChanged;
            // 
            // logicComboPrice
            // 
            logicComboPrice.FormattingEnabled = true;
            logicComboPrice.Items.AddRange(new object[] { "AND", "OR" });
            logicComboPrice.Location = new Point(379, 226);
            logicComboPrice.Name = "logicComboPrice";
            logicComboPrice.Size = new Size(63, 23);
            logicComboPrice.TabIndex = 63;
            logicComboPrice.SelectedIndexChanged += logicComboPrice_SelectedIndexChanged;
            // 
            // hintComboPrice1
            // 
            hintComboPrice1.FormattingEnabled = true;
            hintComboPrice1.Items.AddRange(new object[] { ">", ">=", "=", "<=", "<" });
            hintComboPrice1.Location = new Point(310, 226);
            hintComboPrice1.Name = "hintComboPrice1";
            hintComboPrice1.Size = new Size(63, 23);
            hintComboPrice1.TabIndex = 62;
            hintComboPrice1.SelectedIndexChanged += hintComboPrice1_SelectedIndexChanged;
            // 
            // price2txt
            // 
            price2txt.Location = new Point(517, 226);
            price2txt.Name = "price2txt";
            price2txt.Size = new Size(68, 21);
            price2txt.TabIndex = 61;
            price2txt.TextChanged += price2txt_TextChanged;
            // 
            // price1txt
            // 
            price1txt.Location = new Point(236, 226);
            price1txt.Name = "price1txt";
            price1txt.Size = new Size(68, 21);
            price1txt.TabIndex = 59;
            price1txt.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Snow;
            label4.Location = new Point(12, 223);
            label4.Name = "label4";
            label4.Size = new Size(197, 24);
            label4.TabIndex = 58;
            label4.Text = "Dori narxi bo`yicha : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Snow;
            label5.Location = new Point(12, 179);
            label5.Name = "label5";
            label5.Size = new Size(115, 24);
            label5.TabIndex = 57;
            label5.Text = "Dori nomi : ";
            // 
            // nametxt
            // 
            nametxt.Location = new Point(133, 180);
            nametxt.Name = "nametxt";
            nametxt.Size = new Size(171, 21);
            nametxt.TabIndex = 65;
            nametxt.TextChanged += nametxt_TextChanged;
            // 
            // SearchByDrugParam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 503);
            Controls.Add(nametxt);
            Controls.Add(hintComboPrice2);
            Controls.Add(logicComboPrice);
            Controls.Add(hintComboPrice1);
            Controls.Add(price2txt);
            Controls.Add(price1txt);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(hintCombo2);
            Controls.Add(logicCombo);
            Controls.Add(hintCombo1);
            Controls.Add(deadline2txt);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(DatasView);
            Controls.Add(typesCombo);
            Controls.Add(deadline1txt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "SearchByDrugParam";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SearchByDrugParam";
            FormClosing += SearchByDrugType_FormClosing;
            Load += SearchByDrugType_Load;
            ((System.ComponentModel.ISupportInitialize)DatasView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button4;
        private DataGridView DatasView;
        private ComboBox typesCombo;
        private TextBox deadline1txt;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox deadline2txt;
        private ComboBox hintCombo1;
        private ComboBox logicCombo;
        private ComboBox hintCombo2;
        private ComboBox hintComboPrice2;
        private ComboBox logicComboPrice;
        private ComboBox hintComboPrice1;
        private TextBox price2txt;
        private TextBox price1txt;
        private Label label4;
        private Label label5;
        private TextBox nametxt;
    }
}