namespace isCourseWork
{
    partial class FormSetPassAndName
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
            this.labeledTextBoxName = new TenAndLitvinovWFControlLibrary.LabeledTextBox();
            this.labeledTextBoxPass = new TenAndLitvinovWFControlLibrary.LabeledTextBox();
            this.buttonSetPassAndNameOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labeledTextBoxName
            // 
            this.labeledTextBoxName.LabelColor = System.Drawing.Color.Black;
            this.labeledTextBoxName.LabelText = "Name of KeySet";
            this.labeledTextBoxName.Location = new System.Drawing.Point(10, 10);
            this.labeledTextBoxName.Name = "labeledTextBoxName";
            this.labeledTextBoxName.Size = new System.Drawing.Size(184, 41);
            this.labeledTextBoxName.TabIndex = 0;
            // 
            // labeledTextBoxPass
            // 
            this.labeledTextBoxPass.LabelColor = System.Drawing.Color.Black;
            this.labeledTextBoxPass.LabelText = "Password";
            this.labeledTextBoxPass.Location = new System.Drawing.Point(10, 70);
            this.labeledTextBoxPass.Name = "labeledTextBoxPass";
            this.labeledTextBoxPass.Size = new System.Drawing.Size(184, 41);
            this.labeledTextBoxPass.TabIndex = 1;
            // 
            // buttonSetPassAndNameOk
            // 
            this.buttonSetPassAndNameOk.Location = new System.Drawing.Point(220, 24);
            this.buttonSetPassAndNameOk.Name = "buttonSetPassAndNameOk";
            this.buttonSetPassAndNameOk.Size = new System.Drawing.Size(100, 100);
            this.buttonSetPassAndNameOk.TabIndex = 2;
            this.buttonSetPassAndNameOk.Text = "Ok";
            this.buttonSetPassAndNameOk.UseVisualStyleBackColor = true;
            this.buttonSetPassAndNameOk.Click += new System.EventHandler(this.buttonSetPassAndNameOk_Click);
            // 
            // FormSetPassAndName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 144);
            this.Controls.Add(this.buttonSetPassAndNameOk);
            this.Controls.Add(this.labeledTextBoxPass);
            this.Controls.Add(this.labeledTextBoxName);
            this.Name = "FormSetPassAndName";
            this.Text = "FormSetPassAndName";
            this.ResumeLayout(false);

        }

        #endregion

        private TenAndLitvinovWFControlLibrary.LabeledTextBox labeledTextBoxName;
        private TenAndLitvinovWFControlLibrary.LabeledTextBox labeledTextBoxPass;
        private System.Windows.Forms.Button buttonSetPassAndNameOk;
    }
}