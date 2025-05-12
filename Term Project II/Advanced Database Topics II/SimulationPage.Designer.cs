namespace Advanced_Database_Topics_II
{
    partial class SimulationPage
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
            this.dgwTop10 = new System.Windows.Forms.DataGridView();
            this.btnSimulateQ1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSimulateQ2 = new System.Windows.Forms.Button();
            this.btnSimulateQ3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEffectedRow = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTop10)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwTop10
            // 
            this.dgwTop10.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwTop10.BackgroundColor = System.Drawing.Color.White;
            this.dgwTop10.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTop10.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgwTop10.Location = new System.Drawing.Point(215, 0);
            this.dgwTop10.Name = "dgwTop10";
            this.dgwTop10.Size = new System.Drawing.Size(749, 481);
            this.dgwTop10.TabIndex = 0;
            // 
            // btnSimulateQ1
            // 
            this.btnSimulateQ1.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimulateQ1.Location = new System.Drawing.Point(27, 312);
            this.btnSimulateQ1.Name = "btnSimulateQ1";
            this.btnSimulateQ1.Size = new System.Drawing.Size(156, 43);
            this.btnSimulateQ1.TabIndex = 1;
            this.btnSimulateQ1.Text = "Simulate Query 1";
            this.btnSimulateQ1.UseVisualStyleBackColor = true;
            this.btnSimulateQ1.Click += new System.EventHandler(this.btnSimulateQ1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number Of Returned Row:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Duration:";
            // 
            // btnSimulateQ2
            // 
            this.btnSimulateQ2.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimulateQ2.Location = new System.Drawing.Point(27, 361);
            this.btnSimulateQ2.Name = "btnSimulateQ2";
            this.btnSimulateQ2.Size = new System.Drawing.Size(156, 43);
            this.btnSimulateQ2.TabIndex = 4;
            this.btnSimulateQ2.Text = "Simulate Query 2";
            this.btnSimulateQ2.UseVisualStyleBackColor = true;
            this.btnSimulateQ2.Click += new System.EventHandler(this.btnSimulateQ2_Click);
            // 
            // btnSimulateQ3
            // 
            this.btnSimulateQ3.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimulateQ3.Location = new System.Drawing.Point(27, 410);
            this.btnSimulateQ3.Name = "btnSimulateQ3";
            this.btnSimulateQ3.Size = new System.Drawing.Size(156, 43);
            this.btnSimulateQ3.TabIndex = 5;
            this.btnSimulateQ3.Text = "Simulate Query 3";
            this.btnSimulateQ3.UseVisualStyleBackColor = true;
            this.btnSimulateQ3.Click += new System.EventHandler(this.btnSimulateQ3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "________________________________________";
            // 
            // lblEffectedRow
            // 
            this.lblEffectedRow.AutoSize = true;
            this.lblEffectedRow.Location = new System.Drawing.Point(13, 45);
            this.lblEffectedRow.Name = "lblEffectedRow";
            this.lblEffectedRow.Size = new System.Drawing.Size(40, 20);
            this.lblEffectedRow.TabIndex = 7;
            this.lblEffectedRow.Text = "label4";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(13, 106);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(40, 20);
            this.lblDuration.TabIndex = 8;
            this.lblDuration.Text = "label5";
            // 
            // SimulationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 481);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblEffectedRow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSimulateQ3);
            this.Controls.Add(this.btnSimulateQ2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSimulateQ1);
            this.Controls.Add(this.dgwTop10);
            this.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SimulationPage";
            this.ShowIcon = false;
            this.Text = "SimulationPage";
            ((System.ComponentModel.ISupportInitialize)(this.dgwTop10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwTop10;
        private System.Windows.Forms.Button btnSimulateQ1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSimulateQ2;
        private System.Windows.Forms.Button btnSimulateQ3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEffectedRow;
        private System.Windows.Forms.Label lblDuration;
    }
}