namespace Lab3_HTandDict
{
    partial class Form2
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
            this.btnForm1 = new System.Windows.Forms.Button();
            this.hs1 = new System.Windows.Forms.ListBox();
            this.hs2 = new System.Windows.Forms.ListBox();
            this.BtnAdd1 = new System.Windows.Forms.Button();
            this.btnRemove1 = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnAdd2 = new System.Windows.Forms.Button();
            this.btnRemove2 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubset = new System.Windows.Forms.Button();
            this.btnSuperset = new System.Windows.Forms.Button();
            this.btnIntersection = new System.Windows.Forms.Button();
            this.btnUnion = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblresult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnForm1
            // 
            this.btnForm1.Location = new System.Drawing.Point(647, 343);
            this.btnForm1.Name = "btnForm1";
            this.btnForm1.Size = new System.Drawing.Size(94, 29);
            this.btnForm1.TabIndex = 0;
            this.btnForm1.Text = "Form 1";
            this.btnForm1.UseVisualStyleBackColor = true;
            this.btnForm1.Click += new System.EventHandler(this.btnForm1_Click);
            // 
            // hs1
            // 
            this.hs1.FormattingEnabled = true;
            this.hs1.ItemHeight = 20;
            this.hs1.Location = new System.Drawing.Point(84, 30);
            this.hs1.Name = "hs1";
            this.hs1.Size = new System.Drawing.Size(150, 104);
            this.hs1.TabIndex = 1;
            // 
            // hs2
            // 
            this.hs2.FormattingEnabled = true;
            this.hs2.ItemHeight = 20;
            this.hs2.Location = new System.Drawing.Point(559, 30);
            this.hs2.Name = "hs2";
            this.hs2.Size = new System.Drawing.Size(150, 104);
            this.hs2.TabIndex = 2;
            // 
            // BtnAdd1
            // 
            this.BtnAdd1.Location = new System.Drawing.Point(101, 170);
            this.BtnAdd1.Name = "BtnAdd1";
            this.BtnAdd1.Size = new System.Drawing.Size(94, 29);
            this.BtnAdd1.TabIndex = 3;
            this.BtnAdd1.Text = "Add";
            this.BtnAdd1.UseVisualStyleBackColor = true;
            this.BtnAdd1.Click += new System.EventHandler(this.BtnAdd1_Click);
            // 
            // btnRemove1
            // 
            this.btnRemove1.Location = new System.Drawing.Point(201, 170);
            this.btnRemove1.Name = "btnRemove1";
            this.btnRemove1.Size = new System.Drawing.Size(94, 29);
            this.btnRemove1.TabIndex = 4;
            this.btnRemove1.Text = "Remove";
            this.btnRemove1.UseVisualStyleBackColor = true;
            this.btnRemove1.Click += new System.EventHandler(this.btnRemove1_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(285, 30);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(94, 29);
            this.btnDisplay.TabIndex = 5;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnAdd2
            // 
            this.btnAdd2.Location = new System.Drawing.Point(480, 170);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(94, 29);
            this.btnAdd2.TabIndex = 6;
            this.btnAdd2.Text = "Add";
            this.btnAdd2.UseVisualStyleBackColor = true;
            this.btnAdd2.Click += new System.EventHandler(this.btnAdd2_Click);
            // 
            // btnRemove2
            // 
            this.btnRemove2.Location = new System.Drawing.Point(580, 170);
            this.btnRemove2.Name = "btnRemove2";
            this.btnRemove2.Size = new System.Drawing.Size(94, 29);
            this.btnRemove2.TabIndex = 7;
            this.btnRemove2.Text = "Remove";
            this.btnRemove2.UseVisualStyleBackColor = true;
            this.btnRemove2.Click += new System.EventHandler(this.btnRemove2_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(385, 30);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 29);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSubset
            // 
            this.btnSubset.Location = new System.Drawing.Point(285, 105);
            this.btnSubset.Name = "btnSubset";
            this.btnSubset.Size = new System.Drawing.Size(94, 29);
            this.btnSubset.TabIndex = 9;
            this.btnSubset.Text = "Subset?";
            this.btnSubset.UseVisualStyleBackColor = true;
            this.btnSubset.Click += new System.EventHandler(this.btnSubset_Click);
            // 
            // btnSuperset
            // 
            this.btnSuperset.Location = new System.Drawing.Point(385, 105);
            this.btnSuperset.Name = "btnSuperset";
            this.btnSuperset.Size = new System.Drawing.Size(94, 29);
            this.btnSuperset.TabIndex = 10;
            this.btnSuperset.Text = "SuperSet?";
            this.btnSuperset.UseVisualStyleBackColor = true;
            this.btnSuperset.Click += new System.EventHandler(this.btnSuperset_Click);
            // 
            // btnIntersection
            // 
            this.btnIntersection.Location = new System.Drawing.Point(285, 65);
            this.btnIntersection.Name = "btnIntersection";
            this.btnIntersection.Size = new System.Drawing.Size(94, 29);
            this.btnIntersection.TabIndex = 11;
            this.btnIntersection.Text = "Intersection";
            this.btnIntersection.UseVisualStyleBackColor = true;
            this.btnIntersection.Click += new System.EventHandler(this.btnIntersection_Click);
            // 
            // btnUnion
            // 
            this.btnUnion.Location = new System.Drawing.Point(385, 65);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(94, 29);
            this.btnUnion.TabIndex = 12;
            this.btnUnion.Text = "Union";
            this.btnUnion.UseVisualStyleBackColor = true;
            this.btnUnion.Click += new System.EventHandler(this.btnUnion_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(319, 172);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 13;
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(356, 137);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(45, 20);
            this.lblresult.TabIndex = 14;
            this.lblresult.Text = "result";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(518, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 15;
            this.button1.Text = "Form 3";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnUnion);
            this.Controls.Add(this.btnIntersection);
            this.Controls.Add(this.btnSuperset);
            this.Controls.Add(this.btnSubset);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemove2);
            this.Controls.Add(this.btnAdd2);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnRemove1);
            this.Controls.Add(this.BtnAdd1);
            this.Controls.Add(this.hs2);
            this.Controls.Add(this.hs1);
            this.Controls.Add(this.btnForm1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnForm1;
        private ListBox hs1;
        private ListBox hs2;
        private Button BtnAdd1;
        private Button btnRemove1;
        private Button btnDisplay;
        private Button btnAdd2;
        private Button btnRemove2;
        private Button btnClear;
        private Button btnSubset;
        private Button btnSuperset;
        private Button btnIntersection;
        private Button btnUnion;
        private TextBox textBox1;
        private Label lblresult;
        private Button button1;
    }
}