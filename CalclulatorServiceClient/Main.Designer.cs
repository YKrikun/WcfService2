namespace CalclulatorServiceClient
{
    partial class Main
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
            this.tbNumber1 = new System.Windows.Forms.TextBox();
            this.tbNumber2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbOperations = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNumber1
            // 
            this.tbNumber1.Location = new System.Drawing.Point(72, 13);
            this.tbNumber1.Name = "tbNumber1";
            this.tbNumber1.Size = new System.Drawing.Size(121, 20);
            this.tbNumber1.TabIndex = 0;
            // 
            // tbNumber2
            // 
            this.tbNumber2.Location = new System.Drawing.Point(72, 39);
            this.tbNumber2.Name = "tbNumber2";
            this.tbNumber2.Size = new System.Drawing.Size(121, 20);
            this.tbNumber2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number 2";
            // 
            // cbOperations
            // 
            this.cbOperations.FormattingEnabled = true;
            this.cbOperations.Items.AddRange(new object[] {
            "Add",
            "Subtract",
            "Multiply"});
            this.cbOperations.Location = new System.Drawing.Point(72, 65);
            this.cbOperations.Name = "cbOperations";
            this.cbOperations.Size = new System.Drawing.Size(121, 21);
            this.cbOperations.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Operation";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(72, 92);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 6;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseMnemonic = false;
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(72, 126);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(121, 20);
            this.tbResult.TabIndex = 7;
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbResult.Location = new System.Drawing.Point(13, 129);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(37, 13);
            this.lbResult.TabIndex = 8;
            this.lbResult.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 158);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbOperations);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNumber2);
            this.Controls.Add(this.tbNumber1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNumber1;
        private System.Windows.Forms.TextBox tbNumber2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbOperations;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label lbResult;
    }
}

