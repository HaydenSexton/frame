namespace SimpleWindowsFormApp
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
            txtBoxInput = new TextBox();
            lblEnterText = new Label();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // txtBoxInput
            // 
            txtBoxInput.Location = new Point(347, 218);
            txtBoxInput.Name = "txtBoxInput";
            txtBoxInput.Size = new Size(195, 23);
            txtBoxInput.TabIndex = 1;
            txtBoxInput.TextChanged += textBox1_TextChanged;
            // 
            // lblEnterText
            // 
            lblEnterText.AutoSize = true;
            lblEnterText.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEnterText.Location = new Point(179, 213);
            lblEnterText.Name = "lblEnterText";
            lblEnterText.Size = new Size(133, 28);
            lblEnterText.TabIndex = 0;
            lblEnterText.Text = "Enter Text:";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(558, 220);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "&Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // Form1
            // 
            AcceptButton = btnSubmit;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSubmit);
            Controls.Add(lblEnterText);
            Controls.Add(txtBoxInput);
            Name = "Form1";
            Text = "Simple Windows Form App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxInput;
        private Label lblEnterText;
        private Button btnSubmit;
    }
}
