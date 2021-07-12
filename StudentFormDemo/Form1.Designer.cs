namespace StudentFormDemo
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
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.rbtnProgramming = new System.Windows.Forms.RadioButton();
            this.rbtnWebDesign = new System.Windows.Forms.RadioButton();
            this.rbtnIT = new System.Windows.Forms.RadioButton();
            this.gboxMajor = new System.Windows.Forms.GroupBox();
            this.lblCourses = new System.Windows.Forms.Label();
            this.lblScores = new System.Windows.Forms.Label();
            this.cboxCIS101 = new System.Windows.Forms.CheckBox();
            this.cboxCIS102 = new System.Windows.Forms.CheckBox();
            this.cboxCIS103 = new System.Windows.Forms.CheckBox();
            this.cboxCIS104 = new System.Windows.Forms.CheckBox();
            this.txtScore1 = new System.Windows.Forms.TextBox();
            this.txtScore2 = new System.Windows.Forms.TextBox();
            this.txtScore3 = new System.Windows.Forms.TextBox();
            this.txtScore4 = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gboxMajor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(49, 43);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(58, 13);
            this.lblStudentID.TabIndex = 0;
            this.lblStudentID.Text = "Student ID";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(49, 86);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(49, 125);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(165, 43);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(100, 20);
            this.txtStudentID.TabIndex = 3;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(165, 86);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(165, 125);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 5;
            // 
            // rbtnProgramming
            // 
            this.rbtnProgramming.AutoSize = true;
            this.rbtnProgramming.Location = new System.Drawing.Point(33, 19);
            this.rbtnProgramming.Name = "rbtnProgramming";
            this.rbtnProgramming.Size = new System.Drawing.Size(86, 17);
            this.rbtnProgramming.TabIndex = 6;
            this.rbtnProgramming.TabStop = true;
            this.rbtnProgramming.Text = "Programming";
            this.rbtnProgramming.UseVisualStyleBackColor = true;
            // 
            // rbtnWebDesign
            // 
            this.rbtnWebDesign.AutoSize = true;
            this.rbtnWebDesign.Location = new System.Drawing.Point(33, 42);
            this.rbtnWebDesign.Name = "rbtnWebDesign";
            this.rbtnWebDesign.Size = new System.Drawing.Size(84, 17);
            this.rbtnWebDesign.TabIndex = 7;
            this.rbtnWebDesign.TabStop = true;
            this.rbtnWebDesign.Text = "Web Design";
            this.rbtnWebDesign.UseVisualStyleBackColor = true;
            // 
            // rbtnIT
            // 
            this.rbtnIT.AutoSize = true;
            this.rbtnIT.Location = new System.Drawing.Point(33, 65);
            this.rbtnIT.Name = "rbtnIT";
            this.rbtnIT.Size = new System.Drawing.Size(35, 17);
            this.rbtnIT.TabIndex = 8;
            this.rbtnIT.TabStop = true;
            this.rbtnIT.Text = "IT";
            this.rbtnIT.UseVisualStyleBackColor = true;
            // 
            // gboxMajor
            // 
            this.gboxMajor.Controls.Add(this.rbtnProgramming);
            this.gboxMajor.Controls.Add(this.rbtnIT);
            this.gboxMajor.Controls.Add(this.rbtnWebDesign);
            this.gboxMajor.Location = new System.Drawing.Point(52, 184);
            this.gboxMajor.Name = "gboxMajor";
            this.gboxMajor.Size = new System.Drawing.Size(213, 100);
            this.gboxMajor.TabIndex = 9;
            this.gboxMajor.TabStop = false;
            this.gboxMajor.Text = "Major";
            // 
            // lblCourses
            // 
            this.lblCourses.AutoSize = true;
            this.lblCourses.Location = new System.Drawing.Point(352, 19);
            this.lblCourses.Name = "lblCourses";
            this.lblCourses.Size = new System.Drawing.Size(45, 13);
            this.lblCourses.TabIndex = 10;
            this.lblCourses.Text = "Courses";
            // 
            // lblScores
            // 
            this.lblScores.AutoSize = true;
            this.lblScores.Location = new System.Drawing.Point(475, 17);
            this.lblScores.Name = "lblScores";
            this.lblScores.Size = new System.Drawing.Size(40, 13);
            this.lblScores.TabIndex = 11;
            this.lblScores.Text = "Scores";
            // 
            // cboxCIS101
            // 
            this.cboxCIS101.AutoSize = true;
            this.cboxCIS101.Location = new System.Drawing.Point(344, 42);
            this.cboxCIS101.Name = "cboxCIS101";
            this.cboxCIS101.Size = new System.Drawing.Size(64, 17);
            this.cboxCIS101.TabIndex = 12;
            this.cboxCIS101.Text = "CIS 101";
            this.cboxCIS101.UseVisualStyleBackColor = true;
            // 
            // cboxCIS102
            // 
            this.cboxCIS102.AutoSize = true;
            this.cboxCIS102.Location = new System.Drawing.Point(344, 69);
            this.cboxCIS102.Name = "cboxCIS102";
            this.cboxCIS102.Size = new System.Drawing.Size(64, 17);
            this.cboxCIS102.TabIndex = 13;
            this.cboxCIS102.Text = "CIS 102";
            this.cboxCIS102.UseVisualStyleBackColor = true;
            // 
            // cboxCIS103
            // 
            this.cboxCIS103.AutoSize = true;
            this.cboxCIS103.Location = new System.Drawing.Point(344, 95);
            this.cboxCIS103.Name = "cboxCIS103";
            this.cboxCIS103.Size = new System.Drawing.Size(64, 17);
            this.cboxCIS103.TabIndex = 14;
            this.cboxCIS103.Text = "CIS 103";
            this.cboxCIS103.UseVisualStyleBackColor = true;
            // 
            // cboxCIS104
            // 
            this.cboxCIS104.AutoSize = true;
            this.cboxCIS104.Location = new System.Drawing.Point(344, 122);
            this.cboxCIS104.Name = "cboxCIS104";
            this.cboxCIS104.Size = new System.Drawing.Size(64, 17);
            this.cboxCIS104.TabIndex = 15;
            this.cboxCIS104.Text = "CIS 104";
            this.cboxCIS104.UseVisualStyleBackColor = true;
            // 
            // txtScore1
            // 
            this.txtScore1.Location = new System.Drawing.Point(446, 40);
            this.txtScore1.Name = "txtScore1";
            this.txtScore1.Size = new System.Drawing.Size(100, 20);
            this.txtScore1.TabIndex = 16;
            // 
            // txtScore2
            // 
            this.txtScore2.Location = new System.Drawing.Point(446, 67);
            this.txtScore2.Name = "txtScore2";
            this.txtScore2.Size = new System.Drawing.Size(100, 20);
            this.txtScore2.TabIndex = 17;
            // 
            // txtScore3
            // 
            this.txtScore3.Location = new System.Drawing.Point(446, 93);
            this.txtScore3.Name = "txtScore3";
            this.txtScore3.Size = new System.Drawing.Size(100, 20);
            this.txtScore3.TabIndex = 18;
            // 
            // txtScore4
            // 
            this.txtScore4.Location = new System.Drawing.Point(446, 120);
            this.txtScore4.Name = "txtScore4";
            this.txtScore4.Size = new System.Drawing.Size(100, 20);
            this.txtScore4.TabIndex = 19;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(105, 330);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(99, 34);
            this.btnSubmit.TabIndex = 20;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(344, 330);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(202, 64);
            this.txtResult.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtScore4);
            this.Controls.Add(this.txtScore3);
            this.Controls.Add(this.txtScore2);
            this.Controls.Add(this.txtScore1);
            this.Controls.Add(this.cboxCIS104);
            this.Controls.Add(this.cboxCIS103);
            this.Controls.Add(this.cboxCIS102);
            this.Controls.Add(this.cboxCIS101);
            this.Controls.Add(this.lblScores);
            this.Controls.Add(this.lblCourses);
            this.Controls.Add(this.gboxMajor);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblStudentID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gboxMajor.ResumeLayout(false);
            this.gboxMajor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.RadioButton rbtnProgramming;
        private System.Windows.Forms.RadioButton rbtnWebDesign;
        private System.Windows.Forms.RadioButton rbtnIT;
        private System.Windows.Forms.GroupBox gboxMajor;
        private System.Windows.Forms.Label lblCourses;
        private System.Windows.Forms.Label lblScores;
        private System.Windows.Forms.CheckBox cboxCIS101;
        private System.Windows.Forms.CheckBox cboxCIS102;
        private System.Windows.Forms.CheckBox cboxCIS103;
        private System.Windows.Forms.CheckBox cboxCIS104;
        private System.Windows.Forms.TextBox txtScore1;
        private System.Windows.Forms.TextBox txtScore2;
        private System.Windows.Forms.TextBox txtScore3;
        private System.Windows.Forms.TextBox txtScore4;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label1;
    }
}

