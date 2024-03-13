namespace PharmacyDatabase
{
    partial class Pharmacy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pharmacy));
            update = new Button();
            deletebtn = new Button();
            insertbtn = new Button();
            DatasView = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            nametxt = new TextBox();
            addresstxt = new TextBox();
            label3 = new Label();
            phonetxt = new TextBox();
            label4 = new Label();
            button1 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)DatasView).BeginInit();
            SuspendLayout();
            // 
            // update
            // 
            update.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            update.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            update.Location = new Point(419, 203);
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
            deletebtn.Location = new Point(220, 203);
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
            insertbtn.Location = new Point(18, 203);
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
            DatasView.Location = new Point(18, 264);
            DatasView.Name = "DatasView";
            DatasView.ReadOnly = true;
            DatasView.RowTemplate.Height = 25;
            DatasView.Size = new Size(776, 176);
            DatasView.TabIndex = 19;
            DatasView.CellClick += DatasView_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(18, 152);
            label2.Name = "label2";
            label2.Size = new Size(80, 24);
            label2.TabIndex = 15;
            label2.Text = "Nomi  : ";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(281, 9);
            label1.Name = "label1";
            label1.Size = new Size(286, 73);
            label1.TabIndex = 14;
            label1.Text = "Dorixona";
            // 
            // nametxt
            // 
            nametxt.Location = new Point(113, 151);
            nametxt.Name = "nametxt";
            nametxt.Size = new Size(129, 21);
            nametxt.TabIndex = 24;
            nametxt.TextChanged += nametxt_TextChanged;
            // 
            // addresstxt
            // 
            addresstxt.Anchor = AnchorStyles.Top;
            addresstxt.Location = new Point(376, 153);
            addresstxt.Name = "addresstxt";
            addresstxt.Size = new Size(129, 21);
            addresstxt.TabIndex = 26;
            addresstxt.TextChanged += addresstxt_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(272, 156);
            label3.Name = "label3";
            label3.Size = new Size(92, 24);
            label3.TabIndex = 25;
            label3.Text = "Manzil  : ";
            // 
            // phonetxt
            // 
            phonetxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            phonetxt.Location = new Point(665, 155);
            phonetxt.Name = "phonetxt";
            phonetxt.Size = new Size(129, 21);
            phonetxt.TabIndex = 28;
            phonetxt.TextChanged += phonetxt_TextChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(554, 156);
            label4.Name = "label4";
            label4.Size = new Size(97, 24);
            label4.TabIndex = 27;
            label4.Text = "Telefon  : ";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(624, 203);
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
            button4.Location = new Point(712, 203);
            button4.Name = "button4";
            button4.Size = new Size(82, 44);
            button4.TabIndex = 42;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // Pharmacy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(813, 450);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(phonetxt);
            Controls.Add(label4);
            Controls.Add(addresstxt);
            Controls.Add(label3);
            Controls.Add(nametxt);
            Controls.Add(update);
            Controls.Add(deletebtn);
            Controls.Add(insertbtn);
            Controls.Add(DatasView);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Pharmacy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pharmacy";
            FormClosing += Pharmacy_FormClosing;
            Load += Pharmacy_Load;
            ((System.ComponentModel.ISupportInitialize)DatasView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button update;
        private Button deletebtn;
        private Button insertbtn;
        private DataGridView DatasView;
        private Label label2;
        private Label label1;
        private TextBox nametxt;
        private TextBox addresstxt;
        private Label label3;
        private TextBox phonetxt;
        private Label label4;
        private Button button1;
        private Button button4;
    }
}