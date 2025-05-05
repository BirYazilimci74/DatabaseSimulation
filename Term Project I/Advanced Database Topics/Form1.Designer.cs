namespace Advanced_Database_Topics
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
            this.cbxIsolationLvl = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numUserA = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSimulate = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.numUserB = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUserA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUserB)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxIsolationLvl
            // 
            this.cbxIsolationLvl.FormattingEnabled = true;
            this.cbxIsolationLvl.Location = new System.Drawing.Point(162, 126);
            this.cbxIsolationLvl.Name = "cbxIsolationLvl";
            this.cbxIsolationLvl.Size = new System.Drawing.Size(183, 24);
            this.cbxIsolationLvl.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(379, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(941, 380);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "UserA (Update)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "UserB (Select)";
            // 
            // numUserA
            // 
            this.numUserA.Location = new System.Drawing.Point(47, 64);
            this.numUserA.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.numUserA.Name = "numUserA";
            this.numUserA.Size = new System.Drawing.Size(98, 22);
            this.numUserA.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Isolation Level:";
            // 
            // btnSimulate
            // 
            this.btnSimulate.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimulate.Location = new System.Drawing.Point(47, 366);
            this.btnSimulate.Name = "btnSimulate";
            this.btnSimulate.Size = new System.Drawing.Size(181, 39);
            this.btnSimulate.TabIndex = 7;
            this.btnSimulate.Text = "Simulate";
            this.btnSimulate.UseVisualStyleBackColor = true;
            this.btnSimulate.Click += new System.EventHandler(this.btnSimulate_ClickAsync);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(47, 185);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(295, 156);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(234, 366);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 39);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // numUserB
            // 
            this.numUserB.Location = new System.Drawing.Point(215, 64);
            this.numUserB.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.numUserB.Name = "numUserB";
            this.numUserB.Size = new System.Drawing.Size(98, 22);
            this.numUserB.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 450);
            this.Controls.Add(this.numUserB);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnSimulate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numUserA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbxIsolationLvl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Simulation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUserA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUserB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxIsolationLvl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSimulate;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.NumericUpDown numUserA;
        private System.Windows.Forms.NumericUpDown numUserB;
    }
}

