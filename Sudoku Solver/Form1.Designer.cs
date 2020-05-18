namespace Sudoku_Solver
{
    partial class mForm
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
            this.mTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.mButtonSolve = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // mTableLayoutPanel
            // 
            this.mTableLayoutPanel.AutoSize = true;
            this.mTableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.mTableLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mTableLayoutPanel.ColumnCount = 2;
            this.mTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mTableLayoutPanel.Location = new System.Drawing.Point(9, 12);
            this.mTableLayoutPanel.Name = "mTableLayoutPanel";
            this.mTableLayoutPanel.RowCount = 2;
            this.mTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mTableLayoutPanel.Size = new System.Drawing.Size(595, 597);
            this.mTableLayoutPanel.TabIndex = 1;
            // 
            // mButtonSolve
            // 
            this.mButtonSolve.Location = new System.Drawing.Point(239, 628);
            this.mButtonSolve.Name = "mButtonSolve";
            this.mButtonSolve.Size = new System.Drawing.Size(108, 44);
            this.mButtonSolve.TabIndex = 2;
            this.mButtonSolve.Text = "Solve Puzzle";
            this.mButtonSolve.UseVisualStyleBackColor = true;
            this.mButtonSolve.Click += new System.EventHandler(this.mButtonSolve_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(9, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 597);
            this.panel1.TabIndex = 0;
            // 
            // mForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(613, 684);
            this.Controls.Add(this.mButtonSolve);
            this.Controls.Add(this.mTableLayoutPanel);
            this.Controls.Add(this.panel1);
            this.Name = "mForm";
            this.Text = "Sudoku - Landon Grady";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mTableLayoutPanel;
        private System.Windows.Forms.Button mButtonSolve;
        private System.Windows.Forms.Panel panel1;
    }
}

