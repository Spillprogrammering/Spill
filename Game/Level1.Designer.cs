﻿namespace Game
{
    partial class Level1
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
            this.tlpSpill = new System.Windows.Forms.TableLayoutPanel();
            this.tlpToppPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblPoengsum = new System.Windows.Forms.Label();
            this.lblTid = new System.Windows.Forms.Label();
            this.lblBruker = new System.Windows.Forms.Label();
            this.tlpLevel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpSpill.SuspendLayout();
            this.tlpToppPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpSpill
            // 
            this.tlpSpill.ColumnCount = 1;
            this.tlpSpill.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSpill.Controls.Add(this.tlpToppPanel, 0, 0);
            this.tlpSpill.Controls.Add(this.tlpLevel1, 0, 1);
            this.tlpSpill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSpill.Location = new System.Drawing.Point(0, 0);
            this.tlpSpill.Name = "tlpSpill";
            this.tlpSpill.RowCount = 2;
            this.tlpSpill.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.494208F));
            this.tlpSpill.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.50579F));
            this.tlpSpill.Size = new System.Drawing.Size(784, 562);
            this.tlpSpill.TabIndex = 0;
            // 
            // tlpToppPanel
            // 
            this.tlpToppPanel.ColumnCount = 3;
            this.tlpToppPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpToppPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpToppPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 229F));
            this.tlpToppPanel.Controls.Add(this.lblPoengsum, 0, 0);
            this.tlpToppPanel.Controls.Add(this.lblTid, 1, 0);
            this.tlpToppPanel.Controls.Add(this.lblBruker, 2, 0);
            this.tlpToppPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpToppPanel.Location = new System.Drawing.Point(3, 3);
            this.tlpToppPanel.Name = "tlpToppPanel";
            this.tlpToppPanel.RowCount = 1;
            this.tlpToppPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpToppPanel.Size = new System.Drawing.Size(778, 41);
            this.tlpToppPanel.TabIndex = 0;
            // 
            // lblPoengsum
            // 
            this.lblPoengsum.AutoSize = true;
            this.lblPoengsum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPoengsum.Location = new System.Drawing.Point(3, 0);
            this.lblPoengsum.Name = "lblPoengsum";
            this.lblPoengsum.Size = new System.Drawing.Size(268, 41);
            this.lblPoengsum.TabIndex = 0;
            this.lblPoengsum.Text = "Poengsum";
            this.lblPoengsum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTid
            // 
            this.lblTid.AutoSize = true;
            this.lblTid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTid.Location = new System.Drawing.Point(277, 0);
            this.lblTid.Name = "lblTid";
            this.lblTid.Size = new System.Drawing.Size(268, 41);
            this.lblTid.TabIndex = 1;
            this.lblTid.Text = "Tid";
            this.lblTid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBruker
            // 
            this.lblBruker.AutoSize = true;
            this.lblBruker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBruker.Location = new System.Drawing.Point(551, 0);
            this.lblBruker.Name = "lblBruker";
            this.lblBruker.Size = new System.Drawing.Size(224, 41);
            this.lblBruker.TabIndex = 2;
            this.lblBruker.Text = "Brukernavn";
            this.lblBruker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpLevel1
            // 
            this.tlpLevel1.ColumnCount = 3;
            this.tlpLevel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpLevel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpLevel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpLevel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLevel1.Location = new System.Drawing.Point(3, 50);
            this.tlpLevel1.Name = "tlpLevel1";
            this.tlpLevel1.RowCount = 3;
            this.tlpLevel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpLevel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpLevel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpLevel1.Size = new System.Drawing.Size(778, 509);
            this.tlpLevel1.TabIndex = 1;
            // 
            // Level1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.tlpSpill);
            this.Name = "Level1";
            this.Text = "Level 1";
            this.tlpSpill.ResumeLayout(false);
            this.tlpToppPanel.ResumeLayout(false);
            this.tlpToppPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpSpill;
        private System.Windows.Forms.TableLayoutPanel tlpToppPanel;
        private System.Windows.Forms.Label lblPoengsum;
        private System.Windows.Forms.Label lblTid;
        private System.Windows.Forms.Label lblBruker;
        private System.Windows.Forms.TableLayoutPanel tlpLevel1;
    }
}