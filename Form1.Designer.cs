namespace Gpax
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btData = new Button();
            label1 = new Label();
            tbGpa = new TextBox();
            label2 = new Label();
            tbGpax = new TextBox();
            label3 = new Label();
            label4 = new Label();
            tbGpaMax = new TextBox();
            tbGpaMin = new TextBox();
            tbStudentCount = new TextBox();
            StudentCount = new Label();
            GPAX = new GroupBox();
            button1 = new Button();
            GPAX.SuspendLayout();
            SuspendLayout();
            // 
            // btData
            // 
            btData.Location = new Point(434, 18);
            btData.Name = "btData";
            btData.Size = new Size(273, 183);
            btData.TabIndex = 0;
            btData.Text = "Add DATA";
            btData.UseVisualStyleBackColor = true;
            btData.Click += btData_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 33);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 1;
            label1.Text = "Input GPA";
            // 
            // tbGpa
            // 
            tbGpa.Location = new Point(120, 30);
            tbGpa.Name = "tbGpa";
            tbGpa.Size = new Size(237, 23);
            tbGpa.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 73);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 3;
            label2.Text = "GPAX";
            // 
            // tbGpax
            // 
            tbGpax.Location = new Point(120, 70);
            tbGpax.Name = "tbGpax";
            tbGpax.Size = new Size(237, 23);
            tbGpax.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 111);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 5;
            label3.Text = "GPA MAX";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 144);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 6;
            label4.Text = "GPA MIN";
            // 
            // tbGpaMax
            // 
            tbGpaMax.Location = new Point(120, 108);
            tbGpaMax.Name = "tbGpaMax";
            tbGpaMax.Size = new Size(237, 23);
            tbGpaMax.TabIndex = 7;
            // 
            // tbGpaMin
            // 
            tbGpaMin.Location = new Point(120, 144);
            tbGpaMin.Name = "tbGpaMin";
            tbGpaMin.Size = new Size(237, 23);
            tbGpaMin.TabIndex = 8;
            // 
            // tbStudentCount
            // 
            tbStudentCount.Location = new Point(120, 183);
            tbStudentCount.Name = "tbStudentCount";
            tbStudentCount.Size = new Size(237, 23);
            tbStudentCount.TabIndex = 9;
            // 
            // StudentCount
            // 
            StudentCount.AutoSize = true;
            StudentCount.Location = new Point(32, 186);
            StudentCount.Name = "StudentCount";
            StudentCount.Size = new Size(81, 15);
            StudentCount.TabIndex = 10;
            StudentCount.Text = "StudentCount";
            // 
            // GPAX
            // 
            GPAX.Controls.Add(StudentCount);
            GPAX.Controls.Add(tbStudentCount);
            GPAX.Controls.Add(tbGpaMin);
            GPAX.Controls.Add(tbGpaMax);
            GPAX.Controls.Add(label4);
            GPAX.Controls.Add(label3);
            GPAX.Controls.Add(tbGpax);
            GPAX.Controls.Add(label2);
            GPAX.Controls.Add(tbGpa);
            GPAX.Controls.Add(label1);
            GPAX.Controls.Add(btData);
            GPAX.Location = new Point(24, 29);
            GPAX.Name = "GPAX";
            GPAX.Size = new Size(730, 232);
            GPAX.TabIndex = 11;
            GPAX.TabStop = false;
            GPAX.Text = "GPAX";
            // 
            // button1
            // 
            button1.Location = new Point(24, 300);
            button1.Name = "button1";
            button1.Size = new Size(730, 48);
            button1.TabIndex = 11;
            button1.Text = "Clear DATA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 394);
            Controls.Add(button1);
            Controls.Add(GPAX);
            Name = "Form1";
            Text = "Form1";
            GPAX.ResumeLayout(false);
            GPAX.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btData;
        private Label label1;
        private TextBox tbGpa;
        private Label label2;
        private TextBox tbGpax;
        private Label label3;
        private Label label4;
        private TextBox tbGpaMax;
        private TextBox tbGpaMin;
        private TextBox tbStudentCount;
        private Label StudentCount;
        private GroupBox GPAX;
        private Button button1;
    }
}
