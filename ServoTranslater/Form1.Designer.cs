﻿namespace ServoTranslater
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Gamma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alpha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GammaPW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlphaPW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FiPW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TetaPW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Z = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Gamma,
            this.Alpha,
            this.Fi,
            this.Teta,
            this.XX,
            this.YY,
            this.ZZ,
            this.GammaPW,
            this.AlphaPW,
            this.FiPW,
            this.TetaPW});
            this.dataGridView2.Location = new System.Drawing.Point(190, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(758, 297);
            this.dataGridView2.TabIndex = 6;
            // 
            // Gamma
            // 
            this.Gamma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gamma.HeaderText = "Gamma";
            this.Gamma.Name = "Gamma";
            this.Gamma.ReadOnly = true;
            // 
            // Alpha
            // 
            this.Alpha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Alpha.HeaderText = "Alpha";
            this.Alpha.Name = "Alpha";
            this.Alpha.ReadOnly = true;
            // 
            // Fi
            // 
            this.Fi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fi.HeaderText = "Fi";
            this.Fi.Name = "Fi";
            this.Fi.ReadOnly = true;
            // 
            // Teta
            // 
            this.Teta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Teta.HeaderText = "Teta";
            this.Teta.Name = "Teta";
            this.Teta.ReadOnly = true;
            // 
            // XX
            // 
            this.XX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.XX.HeaderText = "XX";
            this.XX.Name = "XX";
            this.XX.ReadOnly = true;
            // 
            // YY
            // 
            this.YY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.YY.HeaderText = "YY";
            this.YY.Name = "YY";
            this.YY.ReadOnly = true;
            // 
            // ZZ
            // 
            this.ZZ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ZZ.HeaderText = "ZZ";
            this.ZZ.Name = "ZZ";
            this.ZZ.ReadOnly = true;
            // 
            // GammaPW
            // 
            this.GammaPW.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GammaPW.HeaderText = "GammaPW";
            this.GammaPW.Name = "GammaPW";
            this.GammaPW.ReadOnly = true;
            // 
            // AlphaPW
            // 
            this.AlphaPW.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AlphaPW.HeaderText = "AlphaPW";
            this.AlphaPW.Name = "AlphaPW";
            this.AlphaPW.ReadOnly = true;
            // 
            // FiPW
            // 
            this.FiPW.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FiPW.HeaderText = "FiPW";
            this.FiPW.Name = "FiPW";
            this.FiPW.ReadOnly = true;
            // 
            // TetaPW
            // 
            this.TetaPW.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TetaPW.HeaderText = "TetaPW";
            this.TetaPW.Name = "TetaPW";
            this.TetaPW.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(954, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Translate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y,
            this.Z});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(172, 297);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // X
            // 
            this.X.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.X.HeaderText = "X";
            this.X.Name = "X";
            // 
            // Y
            // 
            this.Y.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Y.HeaderText = "Y";
            this.Y.Name = "Y";
            // 
            // Z
            // 
            this.Z.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Z.HeaderText = "Z";
            this.Z.Name = "Z";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(954, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "To executer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 315);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(936, 185);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 512);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Form1";
            this.Text = "ServoTranslater";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn Z;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gamma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alpha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teta;
        private System.Windows.Forms.DataGridViewTextBoxColumn XX;
        private System.Windows.Forms.DataGridViewTextBoxColumn YY;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn GammaPW;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlphaPW;
        private System.Windows.Forms.DataGridViewTextBoxColumn FiPW;
        private System.Windows.Forms.DataGridViewTextBoxColumn TetaPW;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

