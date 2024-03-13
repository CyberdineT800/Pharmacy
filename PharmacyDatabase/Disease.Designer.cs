namespace PharmacyDatabase
{
    partial class Disease
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Disease));
            charactertxt = new TextBox();
            label3 = new Label();
            nametxt = new TextBox();
            update = new Button();
            deletebtn = new Button();
            insertbtn = new Button();
            DatasView = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)DatasView).BeginInit();
            SuspendLayout();
            // 
            // charactertxt
            // 
            charactertxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            charactertxt.Location = new Point(550, 150);
            charactertxt.Name = "charactertxt";
            charactertxt.Size = new Size(177, 21);
            charactertxt.TabIndex = 38;
            charactertxt.TextChanged += charactertxt_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(413, 146);
            label3.Name = "label3";
            label3.Size = new Size(107, 24);
            label3.TabIndex = 37;
            label3.Text = " Belgilari : ";
            // 
            // nametxt
            // 
            nametxt.Location = new Point(149, 150);
            nametxt.Name = "nametxt";
            nametxt.Size = new Size(178, 21);
            nametxt.TabIndex = 36;
            nametxt.TextChanged += nametxt_TextChanged;
            // 
            // update
            // 
            update.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            update.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            update.Location = new Point(413, 204);
            update.Name = "update";
            update.Size = new Size(173, 44);
            update.TabIndex = 34;
            update.Text = "Yangilash";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // deletebtn
            // 
            deletebtn.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            deletebtn.Location = new Point(214, 204);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(173, 44);
            deletebtn.TabIndex = 33;
            deletebtn.Text = "O`chirish";
            deletebtn.UseVisualStyleBackColor = true;
            deletebtn.Click += deletebtn_Click;
            // 
            // insertbtn
            // 
            insertbtn.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            insertbtn.Location = new Point(12, 204);
            insertbtn.Name = "insertbtn";
            insertbtn.Size = new Size(173, 44);
            insertbtn.TabIndex = 32;
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
            DatasView.Location = new Point(12, 265);
            DatasView.Name = "DatasView";
            DatasView.ReadOnly = true;
            DatasView.RowTemplate.Height = 25;
            DatasView.Size = new Size(776, 176);
            DatasView.TabIndex = 31;
            DatasView.CellClick += DatasView_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(54, 148);
            label2.Name = "label2";
            label2.Size = new Size(80, 24);
            label2.TabIndex = 30;
            label2.Text = "Nomi  : ";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(261, 9);
            label1.Name = "label1";
            label1.Size = new Size(337, 73);
            label1.TabIndex = 29;
            label1.Text = "Kasalliklar";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(618, 204);
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
            button4.Location = new Point(706, 204);
            button4.Name = "button4";
            button4.Size = new Size(82, 44);
            button4.TabIndex = 42;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // Disease
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(charactertxt);
            Controls.Add(label3);
            Controls.Add(nametxt);
            Controls.Add(update);
            Controls.Add(deletebtn);
            Controls.Add(insertbtn);
            Controls.Add(DatasView);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Disease";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Disease";
            FormClosing += Disease_FormClosing;
            Load += Disease_Load;
            ((System.ComponentModel.ISupportInitialize)DatasView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox charactertxt;
        private Label label3;
        private TextBox nametxt;
        private Button update;
        private Button deletebtn;
        private Button insertbtn;
        private DataGridView DatasView;
        private Label label2;
        private Label label1;
        private Button button1;
        private Button button4;
    }
}