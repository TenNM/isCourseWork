namespace isCourseWork
{
    partial class FormAddKeySet
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labeledTextBox3 = new TenAndLitvinovWFControlLibrary.LabeledTextBox();
            this.labeledTextBox2 = new TenAndLitvinovWFControlLibrary.LabeledTextBox();
            this.labeledTextBox1 = new TenAndLitvinovWFControlLibrary.LabeledTextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(10, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 28);
            this.comboBox1.TabIndex = 4;
            // 
            // labeledTextBox3
            // 
            this.labeledTextBox3.LabelColor = System.Drawing.Color.Black;
            this.labeledTextBox3.LabelText = "password";
            this.labeledTextBox3.Location = new System.Drawing.Point(10, 190);
            this.labeledTextBox3.Name = "labeledTextBox3";
            this.labeledTextBox3.Size = new System.Drawing.Size(656, 41);
            this.labeledTextBox3.TabIndex = 7;
            // 
            // labeledTextBox2
            // 
            this.labeledTextBox2.LabelColor = System.Drawing.Color.Black;
            this.labeledTextBox2.LabelText = "secret";
            this.labeledTextBox2.Location = new System.Drawing.Point(10, 130);
            this.labeledTextBox2.Name = "labeledTextBox2";
            this.labeledTextBox2.Size = new System.Drawing.Size(656, 41);
            this.labeledTextBox2.TabIndex = 6;
            // 
            // labeledTextBox1
            // 
            this.labeledTextBox1.LabelColor = System.Drawing.Color.Black;
            this.labeledTextBox1.LabelText = "api";
            this.labeledTextBox1.Location = new System.Drawing.Point(10, 70);
            this.labeledTextBox1.Name = "labeledTextBox1";
            this.labeledTextBox1.Size = new System.Drawing.Size(656, 41);
            this.labeledTextBox1.TabIndex = 5;
            // 
            // FormAddKeySet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 264);
            this.Controls.Add(this.labeledTextBox3);
            this.Controls.Add(this.labeledTextBox2);
            this.Controls.Add(this.labeledTextBox1);
            this.Controls.Add(this.comboBox1);
            this.Name = "FormAddKeySet";
            this.Text = "FormAddKeySet";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private TenAndLitvinovWFControlLibrary.LabeledTextBox labeledTextBox1;
        private TenAndLitvinovWFControlLibrary.LabeledTextBox labeledTextBox2;
        private TenAndLitvinovWFControlLibrary.LabeledTextBox labeledTextBox3;
    }
}