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
            this.comboBoxChooseAdapter = new System.Windows.Forms.ComboBox();
            this.labeledTextBoxPassword = new TenAndLitvinovWFControlLibrary.LabeledTextBox();
            this.labeledTextBoxSecret = new TenAndLitvinovWFControlLibrary.LabeledTextBox();
            this.labeledTextBoxApi = new TenAndLitvinovWFControlLibrary.LabeledTextBox();
            this.buttonAddKeyForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxChooseAdapter
            // 
            this.comboBoxChooseAdapter.FormattingEnabled = true;
            this.comboBoxChooseAdapter.Location = new System.Drawing.Point(10, 10);
            this.comboBoxChooseAdapter.Name = "comboBoxChooseAdapter";
            this.comboBoxChooseAdapter.Size = new System.Drawing.Size(200, 28);
            this.comboBoxChooseAdapter.TabIndex = 4;
            // 
            // labeledTextBoxPassword
            // 
            this.labeledTextBoxPassword.LabelColor = System.Drawing.Color.Black;
            this.labeledTextBoxPassword.LabelText = "password";
            this.labeledTextBoxPassword.Location = new System.Drawing.Point(10, 190);
            this.labeledTextBoxPassword.Name = "labeledTextBoxPassword";
            this.labeledTextBoxPassword.Size = new System.Drawing.Size(656, 41);
            this.labeledTextBoxPassword.TabIndex = 7;
            // 
            // labeledTextBoxSecret
            // 
            this.labeledTextBoxSecret.LabelColor = System.Drawing.Color.Black;
            this.labeledTextBoxSecret.LabelText = "secret";
            this.labeledTextBoxSecret.Location = new System.Drawing.Point(10, 130);
            this.labeledTextBoxSecret.Name = "labeledTextBoxSecret";
            this.labeledTextBoxSecret.Size = new System.Drawing.Size(656, 41);
            this.labeledTextBoxSecret.TabIndex = 6;
            // 
            // labeledTextBoxApi
            // 
            this.labeledTextBoxApi.LabelColor = System.Drawing.Color.Black;
            this.labeledTextBoxApi.LabelText = "api";
            this.labeledTextBoxApi.Location = new System.Drawing.Point(10, 70);
            this.labeledTextBoxApi.Name = "labeledTextBoxApi";
            this.labeledTextBoxApi.Size = new System.Drawing.Size(656, 41);
            this.labeledTextBoxApi.TabIndex = 5;
            // 
            // buttonAddKeyForm
            // 
            this.buttonAddKeyForm.Location = new System.Drawing.Point(283, 12);
            this.buttonAddKeyForm.Name = "buttonAddKeyForm";
            this.buttonAddKeyForm.Size = new System.Drawing.Size(75, 28);
            this.buttonAddKeyForm.TabIndex = 8;
            this.buttonAddKeyForm.Text = "Add key set";
            this.buttonAddKeyForm.UseVisualStyleBackColor = true;
            this.buttonAddKeyForm.Click += new System.EventHandler(this.buttonAddKeyForm_Click);
            // 
            // FormAddKeySet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 264);
            this.Controls.Add(this.buttonAddKeyForm);
            this.Controls.Add(this.labeledTextBoxPassword);
            this.Controls.Add(this.labeledTextBoxSecret);
            this.Controls.Add(this.labeledTextBoxApi);
            this.Controls.Add(this.comboBoxChooseAdapter);
            this.Name = "FormAddKeySet";
            this.Text = "FormAddKeySet";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxChooseAdapter;
        private TenAndLitvinovWFControlLibrary.LabeledTextBox labeledTextBoxApi;
        private TenAndLitvinovWFControlLibrary.LabeledTextBox labeledTextBoxSecret;
        private TenAndLitvinovWFControlLibrary.LabeledTextBox labeledTextBoxPassword;
        private System.Windows.Forms.Button buttonAddKeyForm;
    }
}