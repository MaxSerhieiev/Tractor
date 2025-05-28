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
            modelBox1 = new TextBox();
            label8 = new Label();
            addButton = new Button();
            deleteButton = new Button();
            yearBox1 = new TextBox();
            horsepowerBox = new TextBox();
            priceBox = new TextBox();
            powerBox = new TextBox();
            engineBox = new TextBox();
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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(modelBox1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(addButton);
            panel1.Controls.Add(deleteButton);
            panel1.Controls.Add(yearBox1);
            panel1.Controls.Add(horsepowerBox);
            panel1.Controls.Add(priceBox);
            panel1.Controls.Add(powerBox);
            panel1.Controls.Add(engineBox);
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
            panel1.Size = new Size(560, 170);
            panel1.TabIndex = 0;
            // 
            // modelBox1
            // 
            modelBox1.Location = new Point(294, 8);
            modelBox1.Name = "modelBox1";
            modelBox1.Size = new Size(122, 23);
            modelBox1.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(234, 8);
            label8.Name = "label8";
            label8.Size = new Size(50, 15);
            label8.TabIndex = 17;
            label8.Text = "Модель";
            // 
            // addButton
            // 
            addButton.Location = new Point(370, 108);
            addButton.Name = "addButton";
            addButton.Size = new Size(117, 26);
            addButton.TabIndex = 16;
            addButton.Text = "Додати";
            addButton.UseVisualStyleBackColor = true;
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
            // yearBox1
            // 
            yearBox1.Location = new Point(475, 9);
            yearBox1.Name = "yearBox1";
            yearBox1.Size = new Size(77, 23);
            yearBox1.TabIndex = 14;
            yearBox1.TextChanged += textBox5_TextChanged;
            // 
            // horsepowerBox
            // 
            horsepowerBox.Location = new Point(294, 67);
            horsepowerBox.Name = "horsepowerBox";
            horsepowerBox.Size = new Size(122, 23);
            horsepowerBox.TabIndex = 13;
            horsepowerBox.TextChanged += textBox4_TextChanged;
            // 
            // priceBox
            // 
            priceBox.Location = new Point(475, 69);
            priceBox.Name = "priceBox";
            priceBox.Size = new Size(77, 23);
            priceBox.TabIndex = 12;
            // 
            // powerBox
            // 
            powerBox.Location = new Point(294, 35);
            powerBox.Name = "powerBox";
            powerBox.Size = new Size(122, 23);
            powerBox.TabIndex = 11;
            // 
            // engineBox
            // 
            engineBox.Location = new Point(475, 40);
            engineBox.Name = "engineBox";
            engineBox.Size = new Size(77, 23);
            engineBox.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(216, 69);
            label7.Name = "label7";
            label7.Size = new Size(77, 15);
            label7.TabIndex = 9;
            label7.Text = "Кінська сила";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(430, 75);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 8;
            label6.Text = "Ціна";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(220, 39);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 7;
            label5.Text = "Потужність ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(422, 40);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 6;
            label4.Text = "Двигун ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(434, 8);
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
            dataGridView1.Location = new Point(12, 182);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(560, 173);
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
        private Label label3;
        private TextBox yearBox1;
        private TextBox horsepowerBox;
        private TextBox priceBox;
        private TextBox powerBox;
        private TextBox engineBox;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button deleteButton;
        private Button addButton;
        private TextBox modelBox1;
        private Label label8;
    }
}