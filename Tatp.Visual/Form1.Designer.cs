namespace Tatp.Visual
{
    partial class Form1
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
<<<<<<< HEAD
            this.sortStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deltaSize = new System.Windows.Forms.NumericUpDown();
            this.endSize = new System.Windows.Forms.NumericUpDown();
            this.startSize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПриложенииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.sortStop = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deltaSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startSize)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sortStart
            // 
            this.sortStart.Location = new System.Drawing.Point(12, 183);
            this.sortStart.Name = "sortStart";
            this.sortStart.Size = new System.Drawing.Size(121, 35);
            this.sortStart.TabIndex = 0;
            this.sortStart.Text = "Провести сортировку";
            this.sortStart.UseVisualStyleBackColor = true;
            this.sortStart.Click += new System.EventHandler(this.sortStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deltaSize);
            this.groupBox1.Controls.Add(this.endSize);
            this.groupBox1.Controls.Add(this.startSize);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 97);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Средства управления массивами";
            // 
            // deltaSize
            // 
            this.deltaSize.Location = new System.Drawing.Point(206, 65);
            this.deltaSize.Name = "deltaSize";
            this.deltaSize.Size = new System.Drawing.Size(43, 20);
            this.deltaSize.TabIndex = 7;
            // 
            // endSize
            // 
            this.endSize.Location = new System.Drawing.Point(206, 43);
            this.endSize.Name = "endSize";
            this.endSize.Size = new System.Drawing.Size(43, 20);
            this.endSize.TabIndex = 6;
            // 
            // startSize
            // 
            this.startSize.Location = new System.Drawing.Point(206, 21);
            this.startSize.Name = "startSize";
            this.startSize.Size = new System.Drawing.Size(43, 20);
            this.startSize.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Приращение размерности:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Конечное значение размерности:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Начальное значение размерности:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПриложенииToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.файлToolStripMenuItem.Text = "Приложение";
            // 
            // оПриложенииToolStripMenuItem
            // 
            this.оПриложенииToolStripMenuItem.Name = "оПриложенииToolStripMenuItem";
            this.оПриложенииToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.оПриложенииToolStripMenuItem.Text = "О приложении";
            // 
            // sortCombo
            // 
            this.sortCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortCombo.FormattingEnabled = true;
            this.sortCombo.Location = new System.Drawing.Point(12, 153);
            this.sortCombo.Name = "sortCombo";
            this.sortCombo.Size = new System.Drawing.Size(260, 21);
            this.sortCombo.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Выберите метод сортировки:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 230);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(284, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // sortStop
            // 
            this.sortStop.Enabled = false;
            this.sortStop.Location = new System.Drawing.Point(151, 183);
            this.sortStop.Name = "sortStop";
            this.sortStop.Size = new System.Drawing.Size(121, 35);
            this.sortStop.TabIndex = 6;
            this.sortStop.Text = "Остановить сортировку";
            this.sortStop.UseVisualStyleBackColor = true;
=======
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 67);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
>>>>>>> 951e7468580d7d9f1647dd4aded61ed55e1a7c55
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(284, 252);
            this.Controls.Add(this.sortStop);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sortCombo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sortStart);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Оценка сортировки";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deltaSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startSize)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
=======
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
>>>>>>> 951e7468580d7d9f1647dd4aded61ed55e1a7c55

        }

        #endregion

<<<<<<< HEAD
        private System.Windows.Forms.Button sortStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown deltaSize;
        private System.Windows.Forms.NumericUpDown endSize;
        private System.Windows.Forms.NumericUpDown startSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПриложенииToolStripMenuItem;
        private System.Windows.Forms.ComboBox sortCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Button sortStop;
=======
        private System.Windows.Forms.Button button1;
>>>>>>> 951e7468580d7d9f1647dd4aded61ed55e1a7c55
    }
}

