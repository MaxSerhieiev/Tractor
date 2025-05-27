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
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            findButton = new Button();
            label2 = new Label();
            yearBox = new TextBox();
            label1 = new Label();
            modelBox = new TextBox();
            dataGridView1 = new DataGridView();
            deleteButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(deleteButton);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(findButton);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(yearBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(modelBox);
            panel1.Location = new Point(12, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(560, 146);
            panel1.TabIndex = 0;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(343, 115);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(151, 23);
            textBox5.TabIndex = 14;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(343, 90);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(151, 23);
            textBox4.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(343, 62);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(151, 23);
            textBox3.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(343, 33);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(151, 23);
            textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(343, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 23);
            textBox1.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(260, 94);
            label7.Name = "label7";
            label7.Size = new Size(77, 15);
            label7.TabIndex = 9;
            label7.Text = "Кінська сила";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(281, 67);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 8;
            label6.Text = "Ціна";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(264, 39);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 7;
            label5.Text = "Потужність ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(276, 9);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 6;
            label4.Text = "Двигун ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(282, 120);
            label3.Name = "label3";
            label3.Size = new Size(23, 15);
            label3.TabIndex = 5;
            label3.Text = "Рік";
            // 
            // findButton
            // 
            findButton.Location = new Point(64, 73);
            findButton.Name = "findButton";
            findButton.Size = new Size(117, 27);
            findButton.TabIndex = 4;
            findButton.Text = "Знайти";
            findButton.UseVisualStyleBackColor = true;
            findButton.Click += findButton_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 47);
            label2.Name = "label2";
            label2.Size = new Size(23, 15);
            label2.TabIndex = 3;
            label2.Text = "Рік";
            // 
            // yearBox
            // 
            yearBox.Location = new Point(53, 44);
            yearBox.Name = "yearBox";
            yearBox.Size = new Size(151, 23);
            yearBox.TabIndex = 2;
            yearBox.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 1;
            label1.Text = "Модель";
            // 
            // modelBox
            // 
            modelBox.Location = new Point(53, 8);
            modelBox.Name = "modelBox";
            modelBox.Size = new Size(151, 23);
            modelBox.TabIndex = 0;
            modelBox.TextChanged += modelBox_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 158);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(560, 191);
            dataGridView1.TabIndex = 1;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(64, 108);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(117, 27);
            deleteButton.TabIndex = 15;
            deleteButton.Text = "Видалити";
            deleteButton.UseVisualStyleBackColor = true;
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
        private Label label3;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button deleteButton;
    }
}