namespace Tractor.Forms
{
    partial class MainForm
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
            panel1 = new Panel();
            findButton = new Button();
            label2 = new Label();
            yearBox = new TextBox();
            label1 = new Label();
            modelBox = new TextBox();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(findButton);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(yearBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(modelBox);
            panel1.Location = new Point(94, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(409, 140);
            panel1.TabIndex = 0;
            // 
            // findButton
            // 
            findButton.Location = new Point(162, 105);
            findButton.Name = "findButton";
            findButton.Size = new Size(117, 27);
            findButton.TabIndex = 4;
            findButton.Text = "Знайти";
            findButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 75);
            label2.Name = "label2";
            label2.Size = new Size(23, 15);
            label2.TabIndex = 3;
            label2.Text = "Рік";
            // 
            // yearBox
            // 
            yearBox.Location = new Point(103, 72);
            yearBox.Name = "yearBox";
            yearBox.Size = new Size(259, 23);
            yearBox.TabIndex = 2;
            yearBox.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 1;
            label1.Text = "Модель";
            // 
            // modelBox
            // 
            modelBox.Location = new Point(103, 27);
            modelBox.Name = "modelBox";
            modelBox.Size = new Size(259, 23);
            modelBox.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 152);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(560, 197);
            dataGridView1.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            MinimumSize = new Size(600, 400);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button findButton;
        private Label label2;
        private TextBox yearBox;
        private Label label1;
        private TextBox modelBox;
        private DataGridView dataGridView1;
    }
}