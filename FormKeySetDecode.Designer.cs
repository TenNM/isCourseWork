namespace isCourseWork
{
    partial class FormKeySetDecode
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
            this.labelDecodeWarning = new System.Windows.Forms.Label();
            this.labeledTextBoxDecodePass = new TenAndLitvinovWFControlLibrary.LabeledTextBox();
            this.buttonDecodeKeySet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDecodeWarning
            // 
            this.labelDecodeWarning.AutoSize = true;
            this.labelDecodeWarning.Location = new System.Drawing.Point(10, 10);
            this.labelDecodeWarning.Name = "labelDecodeWarning";
            this.labelDecodeWarning.Size = new System.Drawing.Size(363, 20);
            this.labelDecodeWarning.TabIndex = 0;
            this.labelDecodeWarning.Text = "After decoding all added adapters will be removed!";
            // 
            // labeledTextBoxDecodePass
            // 
            this.labeledTextBoxDecodePass.LabelColor = System.Drawing.Color.Black;
            this.labeledTextBoxDecodePass.LabelText = "Password";
            this.labeledTextBoxDecodePass.Location = new System.Drawing.Point(10, 70);
            this.labeledTextBoxDecodePass.Name = "labeledTextBoxDecodePass";
            this.labeledTextBoxDecodePass.Size = new System.Drawing.Size(125, 41);
            this.labeledTextBoxDecodePass.TabIndex = 1;
            // 
            // buttonDecodeKeySet
            // 
            this.buttonDecodeKeySet.Location = new System.Drawing.Point(220, 70);
            this.buttonDecodeKeySet.Name = "buttonDecodeKeySet";
            this.buttonDecodeKeySet.Size = new System.Drawing.Size(100, 50);
            this.buttonDecodeKeySet.TabIndex = 2;
            this.buttonDecodeKeySet.Text = "Decode";
            this.buttonDecodeKeySet.UseVisualStyleBackColor = true;
            this.buttonDecodeKeySet.Click += new System.EventHandler(this.buttonDecodeKeySet_Click);
            // 
            // FormKeySetDecode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 144);
            this.Controls.Add(this.buttonDecodeKeySet);
            this.Controls.Add(this.labeledTextBoxDecodePass);
            this.Controls.Add(this.labelDecodeWarning);
            this.Name = "FormKeySetDecode";
            this.Text = "FormKeySetDecode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDecodeWarning;
        private TenAndLitvinovWFControlLibrary.LabeledTextBox labeledTextBoxDecodePass;
        private System.Windows.Forms.Button buttonDecodeKeySet;
    }
}