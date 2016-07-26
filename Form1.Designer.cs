namespace Assignment6_7GuessingGame
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
            this.BtnStart = new System.Windows.Forms.Button();
            this.ggTable = new System.Windows.Forms.TableLayoutPanel();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblLives = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(240, 393);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 23);
            this.BtnStart.TabIndex = 1;
            this.BtnStart.Text = "Start Game";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.startButton_Click);
            // 
            // ggTable
            // 
            this.ggTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.ggTable.ColumnCount = 10;
            this.ggTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ggTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ggTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ggTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ggTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ggTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ggTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ggTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ggTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ggTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ggTable.Location = new System.Drawing.Point(12, 12);
            this.ggTable.Name = "ggTable";
            this.ggTable.RowCount = 10;
            this.ggTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ggTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ggTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ggTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ggTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ggTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ggTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ggTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ggTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ggTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ggTable.Size = new System.Drawing.Size(527, 341);
            this.ggTable.TabIndex = 2;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(598, 36);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(35, 13);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "label1";
            // 
            // lblLives
            // 
            this.lblLives.AutoSize = true;
            this.lblLives.Location = new System.Drawing.Point(598, 61);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(35, 13);
            this.lblLives.TabIndex = 4;
            this.lblLives.Text = "label2";
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Location = new System.Drawing.Point(575, 393);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(121, 23);
            this.btnPlayAgain.TabIndex = 5;
            this.btnPlayAgain.Text = "Play Again (y/n)";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(572, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Message";
            // 
            // txtBoxMessage
            // 
            this.txtBoxMessage.Location = new System.Drawing.Point(575, 179);
            this.txtBoxMessage.Multiline = true;
            this.txtBoxMessage.Name = "txtBoxMessage";
            this.txtBoxMessage.Size = new System.Drawing.Size(154, 104);
            this.txtBoxMessage.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 458);
            this.Controls.Add(this.txtBoxMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.lblLives);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.ggTable);
            this.Controls.Add(this.BtnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.TableLayoutPanel ggTable;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblLives;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxMessage;
    }
}

