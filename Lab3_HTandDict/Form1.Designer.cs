namespace Lab3_HTandDict
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
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.lbxDisplay = new System.Windows.Forms.ListBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblHashtable = new System.Windows.Forms.Label();
            this.Dictionary = new System.Windows.Forms.Label();
            this.btnHtAdd = new System.Windows.Forms.Button();
            this.btnHtRemove = new System.Windows.Forms.Button();
            this.btnHtDisplay = new System.Windows.Forms.Button();
            this.btnDictAdd = new System.Windows.Forms.Button();
            this.btnDictRemove = new System.Windows.Forms.Button();
            this.btnDictDisplay = new System.Windows.Forms.Button();
            this.btnForm2 = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.btnValues = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btncheckValue = new System.Windows.Forms.Button();
            this.lblCheck = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(98, 75);
            this.txtKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(155, 31);
            this.txtKey.TabIndex = 0;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(342, 75);
            this.txtValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(155, 31);
            this.txtValue.TabIndex = 1;
            // 
            // lbxDisplay
            // 
            this.lbxDisplay.FormattingEnabled = true;
            this.lbxDisplay.ItemHeight = 25;
            this.lbxDisplay.Location = new System.Drawing.Point(704, 75);
            this.lbxDisplay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbxDisplay.Name = "lbxDisplay";
            this.lbxDisplay.Size = new System.Drawing.Size(244, 279);
            this.lbxDisplay.TabIndex = 2;
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(98, 31);
            this.lblKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(40, 25);
            this.lblKey.TabIndex = 3;
            this.lblKey.Text = "Key";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(342, 31);
            this.lblValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(54, 25);
            this.lblValue.TabIndex = 4;
            this.lblValue.Text = "Value";
            // 
            // lblHashtable
            // 
            this.lblHashtable.AutoSize = true;
            this.lblHashtable.Location = new System.Drawing.Point(98, 215);
            this.lblHashtable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHashtable.Name = "lblHashtable";
            this.lblHashtable.Size = new System.Drawing.Size(91, 25);
            this.lblHashtable.TabIndex = 5;
            this.lblHashtable.Text = "Hashtable";
            // 
            // Dictionary
            // 
            this.Dictionary.AutoSize = true;
            this.Dictionary.Location = new System.Drawing.Point(98, 399);
            this.Dictionary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Dictionary.Name = "Dictionary";
            this.Dictionary.Size = new System.Drawing.Size(92, 25);
            this.Dictionary.TabIndex = 6;
            this.Dictionary.Text = "Dictionary";
            // 
            // btnHtAdd
            // 
            this.btnHtAdd.Location = new System.Drawing.Point(98, 290);
            this.btnHtAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHtAdd.Name = "btnHtAdd";
            this.btnHtAdd.Size = new System.Drawing.Size(118, 36);
            this.btnHtAdd.TabIndex = 7;
            this.btnHtAdd.Text = "Add";
            this.btnHtAdd.UseVisualStyleBackColor = true;
            this.btnHtAdd.Click += new System.EventHandler(this.btnHtAdd_Click);
            // 
            // btnHtRemove
            // 
            this.btnHtRemove.Location = new System.Drawing.Point(288, 290);
            this.btnHtRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHtRemove.Name = "btnHtRemove";
            this.btnHtRemove.Size = new System.Drawing.Size(118, 36);
            this.btnHtRemove.TabIndex = 8;
            this.btnHtRemove.Text = "Remove";
            this.btnHtRemove.UseVisualStyleBackColor = true;
            this.btnHtRemove.Click += new System.EventHandler(this.btnHtRemove_Click);
            // 
            // btnHtDisplay
            // 
            this.btnHtDisplay.Location = new System.Drawing.Point(475, 290);
            this.btnHtDisplay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHtDisplay.Name = "btnHtDisplay";
            this.btnHtDisplay.Size = new System.Drawing.Size(118, 36);
            this.btnHtDisplay.TabIndex = 9;
            this.btnHtDisplay.Text = "Display";
            this.btnHtDisplay.UseVisualStyleBackColor = true;
            this.btnHtDisplay.Click += new System.EventHandler(this.btnHtDisplay_Click);
            // 
            // btnDictAdd
            // 
            this.btnDictAdd.Location = new System.Drawing.Point(98, 444);
            this.btnDictAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDictAdd.Name = "btnDictAdd";
            this.btnDictAdd.Size = new System.Drawing.Size(118, 36);
            this.btnDictAdd.TabIndex = 10;
            this.btnDictAdd.Text = "Add";
            this.btnDictAdd.UseVisualStyleBackColor = true;
            this.btnDictAdd.Click += new System.EventHandler(this.btnDictAdd_Click);
            // 
            // btnDictRemove
            // 
            this.btnDictRemove.Location = new System.Drawing.Point(281, 444);
            this.btnDictRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDictRemove.Name = "btnDictRemove";
            this.btnDictRemove.Size = new System.Drawing.Size(118, 36);
            this.btnDictRemove.TabIndex = 11;
            this.btnDictRemove.Text = "Remove";
            this.btnDictRemove.UseVisualStyleBackColor = true;
            this.btnDictRemove.Click += new System.EventHandler(this.btnDictRemove_Click);
            // 
            // btnDictDisplay
            // 
            this.btnDictDisplay.Location = new System.Drawing.Point(475, 444);
            this.btnDictDisplay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDictDisplay.Name = "btnDictDisplay";
            this.btnDictDisplay.Size = new System.Drawing.Size(118, 36);
            this.btnDictDisplay.TabIndex = 12;
            this.btnDictDisplay.Text = "Display";
            this.btnDictDisplay.UseVisualStyleBackColor = true;
            this.btnDictDisplay.Click += new System.EventHandler(this.btnDictDisplay_Click);
            // 
            // btnForm2
            // 
            this.btnForm2.Location = new System.Drawing.Point(756, 444);
            this.btnForm2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(118, 36);
            this.btnForm2.TabIndex = 13;
            this.btnForm2.Text = "Form 2";
            this.btnForm2.UseVisualStyleBackColor = true;
            this.btnForm2.Click += new System.EventHandler(this.btnForm2_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(185, 334);
            this.Clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(118, 36);
            this.Clear.TabIndex = 14;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // btnValues
            // 
            this.btnValues.Location = new System.Drawing.Point(381, 334);
            this.btnValues.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnValues.Name = "btnValues";
            this.btnValues.Size = new System.Drawing.Size(118, 36);
            this.btnValues.TabIndex = 15;
            this.btnValues.Text = "Values";
            this.btnValues.UseVisualStyleBackColor = true;
            this.btnValues.Click += new System.EventHandler(this.btnValues_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(98, 491);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(118, 36);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btncheckValue
            // 
            this.btncheckValue.Location = new System.Drawing.Point(475, 488);
            this.btncheckValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncheckValue.Name = "btncheckValue";
            this.btncheckValue.Size = new System.Drawing.Size(134, 36);
            this.btncheckValue.TabIndex = 17;
            this.btncheckValue.Text = "Check Value";
            this.btncheckValue.UseVisualStyleBackColor = true;
            this.btncheckValue.Click += new System.EventHandler(this.btncheckValue_Click);
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.lblCheck.Location = new System.Drawing.Point(222, 491);
            this.lblCheck.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(59, 25);
            this.lblCheck.TabIndex = 18;
            this.lblCheck.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.lblCheck);
            this.Controls.Add(this.btncheckValue);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnValues);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.btnForm2);
            this.Controls.Add(this.btnDictDisplay);
            this.Controls.Add(this.btnDictRemove);
            this.Controls.Add(this.btnDictAdd);
            this.Controls.Add(this.btnHtDisplay);
            this.Controls.Add(this.btnHtRemove);
            this.Controls.Add(this.btnHtAdd);
            this.Controls.Add(this.Dictionary);
            this.Controls.Add(this.lblHashtable);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.lbxDisplay);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.txtKey);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtKey;
        private TextBox txtValue;
        private ListBox lbxDisplay;
        private Label lblKey;
        private Label lblValue;
        private Label lblHashtable;
        private Label Dictionary;
        private Button btnHtAdd;
        private Button btnHtRemove;
        private Button btnHtDisplay;
        private Button btnDictAdd;
        private Button btnDictRemove;
        private Button btnDictDisplay;
        private Button btnForm2;
        private Button Clear;
        private Button btnValues;
        private Button btnClear;
        private Button btncheckValue;
        private Label lblCheck;
    }
}