namespace DatabaseExample
{
    partial class AddCourse
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.semesterTB = new System.Windows.Forms.TextBox();
            this.programTB = new System.Windows.Forms.TextBox();
            this.prereqLB = new System.Windows.Forms.CheckedListBox();
            this.saveBN = new System.Windows.Forms.Button();
            this.updateBN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Semester:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Program:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prerequisite:";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(239, 23);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(300, 31);
            this.nameTB.TabIndex = 4;
            // 
            // semesterTB
            // 
            this.semesterTB.Location = new System.Drawing.Point(239, 72);
            this.semesterTB.Name = "semesterTB";
            this.semesterTB.Size = new System.Drawing.Size(300, 31);
            this.semesterTB.TabIndex = 5;
            // 
            // programTB
            // 
            this.programTB.Location = new System.Drawing.Point(239, 126);
            this.programTB.Name = "programTB";
            this.programTB.Size = new System.Drawing.Size(300, 31);
            this.programTB.TabIndex = 6;
            // 
            // prereqLB
            // 
            this.prereqLB.FormattingEnabled = true;
            this.prereqLB.Location = new System.Drawing.Point(239, 181);
            this.prereqLB.Name = "prereqLB";
            this.prereqLB.Size = new System.Drawing.Size(300, 264);
            this.prereqLB.TabIndex = 7;
            // 
            // saveBN
            // 
            this.saveBN.Location = new System.Drawing.Point(49, 358);
            this.saveBN.Name = "saveBN";
            this.saveBN.Size = new System.Drawing.Size(152, 44);
            this.saveBN.TabIndex = 8;
            this.saveBN.Text = "Save";
            this.saveBN.UseVisualStyleBackColor = true;
            this.saveBN.Click += new System.EventHandler(this.saveBN_Click);
            // 
            // updateBN
            // 
            this.updateBN.Location = new System.Drawing.Point(49, 264);
            this.updateBN.Name = "updateBN";
            this.updateBN.Size = new System.Drawing.Size(152, 72);
            this.updateBN.TabIndex = 9;
            this.updateBN.Text = "Update Prerequisites";
            this.updateBN.UseVisualStyleBackColor = true;
            this.updateBN.Click += new System.EventHandler(this.updateBN_Click);
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 481);
            this.Controls.Add(this.updateBN);
            this.Controls.Add(this.saveBN);
            this.Controls.Add(this.prereqLB);
            this.Controls.Add(this.programTB);
            this.Controls.Add(this.semesterTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCourse";
            this.Text = "Add Course";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox semesterTB;
        private System.Windows.Forms.TextBox programTB;
        private System.Windows.Forms.CheckedListBox prereqLB;
        private System.Windows.Forms.Button saveBN;
        private System.Windows.Forms.Button updateBN;
    }
}