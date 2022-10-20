namespace Lab3_HTandDict
{
    partial class Form3
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
            this.ss1 = new System.Windows.Forms.ListBox();
            this.ss2 = new System.Windows.Forms.ListBox();
            this.btndisplay = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnintersect = new System.Windows.Forms.Button();
            this.btnUnion = new System.Windows.Forms.Button();
            this.btnSubset = new System.Windows.Forms.Button();
            this.tnSuperSet = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAdd1 = new System.Windows.Forms.Button();
            this.btnRemove1 = new System.Windows.Forms.Button();
            this.btnForm3 = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ss1
            // 
            this.ss1.FormattingEnabled = true;
            this.ss1.ItemHeight = 25;
            this.ss1.Location = new System.Drawing.Point(68, 69);
            this.ss1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ss1.Name = "ss1";
            this.ss1.Size = new System.Drawing.Size(186, 129);
            this.ss1.TabIndex = 0;
            this.ss1.SelectedIndexChanged += new System.EventHandler(this.ss1_SelectedIndexChanged);
            // 
            // ss2
            // 
            this.ss2.FormattingEnabled = true;
            this.ss2.ItemHeight = 25;
            this.ss2.Location = new System.Drawing.Point(754, 69);
            this.ss2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ss2.Name = "ss2";
            this.ss2.Size = new System.Drawing.Size(186, 129);
            this.ss2.TabIndex = 1;
            // 
            // btndisplay
            // 
            this.btndisplay.Location = new System.Drawing.Point(344, 69);
            this.btndisplay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btndisplay.Name = "btndisplay";
            this.btndisplay.Size = new System.Drawing.Size(118, 36);
            this.btndisplay.TabIndex = 2;
            this.btndisplay.Text = "Display";
            this.btndisplay.UseVisualStyleBackColor = true;
            this.btndisplay.Click += new System.EventHandler(this.btndisplay_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(568, 69);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(118, 36);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnintersect
            // 
            this.btnintersect.Location = new System.Drawing.Point(344, 112);
            this.btnintersect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnintersect.Name = "btnintersect";
            this.btnintersect.Size = new System.Drawing.Size(118, 36);
            this.btnintersect.TabIndex = 4;
            this.btnintersect.Text = "Intersection";
            this.btnintersect.UseVisualStyleBackColor = true;
            this.btnintersect.Click += new System.EventHandler(this.btnintersect_Click);
            // 
            // btnUnion
            // 
            this.btnUnion.Location = new System.Drawing.Point(568, 112);
            this.btnUnion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(118, 36);
            this.btnUnion.TabIndex = 5;
            this.btnUnion.Text = "Union";
            this.btnUnion.UseVisualStyleBackColor = true;
            this.btnUnion.Click += new System.EventHandler(this.btnUnion_Click);
            // 
            // btnSubset
            // 
            this.btnSubset.Location = new System.Drawing.Point(344, 162);
            this.btnSubset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubset.Name = "btnSubset";
            this.btnSubset.Size = new System.Drawing.Size(118, 36);
            this.btnSubset.TabIndex = 6;
            this.btnSubset.Text = "Subset?";
            this.btnSubset.UseVisualStyleBackColor = true;
            this.btnSubset.Click += new System.EventHandler(this.btnSubset_Click);
            // 
            // tnSuperSet
            // 
            this.tnSuperSet.Location = new System.Drawing.Point(568, 162);
            this.tnSuperSet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tnSuperSet.Name = "tnSuperSet";
            this.tnSuperSet.Size = new System.Drawing.Size(118, 36);
            this.tnSuperSet.TabIndex = 7;
            this.tnSuperSet.Text = "SuperSet?";
            this.tnSuperSet.UseVisualStyleBackColor = true;
            this.tnSuperSet.Click += new System.EventHandler(this.tnSuperSet_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(68, 238);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 36);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(256, 238);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(118, 36);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(429, 249);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 31);
            this.textBox1.TabIndex = 10;
            // 
            // btnAdd1
            // 
            this.btnAdd1.Location = new System.Drawing.Point(660, 246);
            this.btnAdd1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(118, 36);
            this.btnAdd1.TabIndex = 11;
            this.btnAdd1.Text = "Add";
            this.btnAdd1.UseVisualStyleBackColor = true;
            this.btnAdd1.Click += new System.EventHandler(this.btnAdd1_Click);
            // 
            // btnRemove1
            // 
            this.btnRemove1.Location = new System.Drawing.Point(808, 246);
            this.btnRemove1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemove1.Name = "btnRemove1";
            this.btnRemove1.Size = new System.Drawing.Size(118, 36);
            this.btnRemove1.TabIndex = 12;
            this.btnRemove1.Text = "Remove";
            this.btnRemove1.UseVisualStyleBackColor = true;
            this.btnRemove1.Click += new System.EventHandler(this.btnRemove1_Click);
            // 
            // btnForm3
            // 
            this.btnForm3.Location = new System.Drawing.Point(808, 408);
            this.btnForm3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnForm3.Name = "btnForm3";
            this.btnForm3.Size = new System.Drawing.Size(118, 36);
            this.btnForm3.TabIndex = 13;
            this.btnForm3.Text = "Form2";
            this.btnForm3.UseVisualStyleBackColor = true;
            this.btnForm3.Click += new System.EventHandler(this.btnForm3_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(481, 211);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(59, 25);
            this.lblResult.TabIndex = 14;
            this.lblResult.Text = "Result";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnForm3);
            this.Controls.Add(this.btnRemove1);
            this.Controls.Add(this.btnAdd1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tnSuperSet);
            this.Controls.Add(this.btnSubset);
            this.Controls.Add(this.btnUnion);
            this.Controls.Add(this.btnintersect);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btndisplay);
            this.Controls.Add(this.ss2);
            this.Controls.Add(this.ss1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox ss1;
        private ListBox ss2;
        private Button btndisplay;
        private Button btnClear;
        private Button btnintersect;
        private Button btnUnion;
        private Button btnSubset;
        private Button tnSuperSet;
        private Button btnAdd;
        private Button btnRemove;
        private TextBox textBox1;
        private Button btnAdd1;
        private Button btnRemove1;
        private Button btnForm3;
        private Label lblResult;
    }
}