namespace Game
{
    partial class Level
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMeny = new System.Windows.Forms.TableLayoutPanel();
            this.lblTid = new System.Windows.Forms.Label();
            this.lblPoengsum = new System.Windows.Forms.Label();
            this.lblBrukernavn = new System.Windows.Forms.Label();
            this.btnStartSpill = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.spillPanel = new Game.levelSpillPanel();
            this.timeLeftTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpMeny.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tlpMeny, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.spillPanel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.540925F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.45908F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 562);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tlpMeny
            // 
            this.tlpMeny.ColumnCount = 5;
            this.tlpMeny.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMeny.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMeny.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMeny.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMeny.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMeny.Controls.Add(this.lblTid, 0, 0);
            this.tlpMeny.Controls.Add(this.lblPoengsum, 1, 0);
            this.tlpMeny.Controls.Add(this.lblBrukernavn, 2, 0);
            this.tlpMeny.Controls.Add(this.btnStartSpill, 3, 0);
            this.tlpMeny.Controls.Add(this.btnHelp, 4, 0);
            this.tlpMeny.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMeny.Location = new System.Drawing.Point(3, 3);
            this.tlpMeny.Name = "tlpMeny";
            this.tlpMeny.RowCount = 1;
            this.tlpMeny.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMeny.Size = new System.Drawing.Size(778, 41);
            this.tlpMeny.TabIndex = 0;
            // 
            // lblTid
            // 
            this.lblTid.AutoSize = true;
            this.lblTid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTid.Location = new System.Drawing.Point(3, 0);
            this.lblTid.Name = "lblTid";
            this.lblTid.Size = new System.Drawing.Size(149, 41);
            this.lblTid.TabIndex = 0;
            this.lblTid.Text = "Tid igjen: ";
            // 
            // lblPoengsum
            // 
            this.lblPoengsum.AutoSize = true;
            this.lblPoengsum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPoengsum.Location = new System.Drawing.Point(158, 0);
            this.lblPoengsum.Name = "lblPoengsum";
            this.lblPoengsum.Size = new System.Drawing.Size(149, 41);
            this.lblPoengsum.TabIndex = 1;
            this.lblPoengsum.Text = "Poengsum:";
            // 
            // lblBrukernavn
            // 
            this.lblBrukernavn.AutoSize = true;
            this.lblBrukernavn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBrukernavn.Location = new System.Drawing.Point(313, 0);
            this.lblBrukernavn.Name = "lblBrukernavn";
            this.lblBrukernavn.Size = new System.Drawing.Size(149, 41);
            this.lblBrukernavn.TabIndex = 2;
            this.lblBrukernavn.Text = "Brukernavn:";
            // 
            // btnStartSpill
            // 
            this.btnStartSpill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStartSpill.Location = new System.Drawing.Point(468, 3);
            this.btnStartSpill.Name = "btnStartSpill";
            this.btnStartSpill.Size = new System.Drawing.Size(149, 35);
            this.btnStartSpill.TabIndex = 3;
            this.btnStartSpill.Text = "Start";
            this.btnStartSpill.UseVisualStyleBackColor = true;
            this.btnStartSpill.Click += new System.EventHandler(this.btnStartSpill_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHelp.Location = new System.Drawing.Point(622, 2);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(2);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(154, 37);
            this.btnHelp.TabIndex = 4;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // spillPanel
            // 
            this.spillPanel.BackColor = System.Drawing.Color.SkyBlue;
            this.spillPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spillPanel.Location = new System.Drawing.Point(3, 50);
            this.spillPanel.Name = "spillPanel";
            this.spillPanel.Size = new System.Drawing.Size(778, 509);
            this.spillPanel.TabIndex = 1;
            // 
            // timeLeftTimer
            // 
            this.timeLeftTimer.Interval = 1000;
            this.timeLeftTimer.Tick += new System.EventHandler(this.timeLeftTimer_Tick);
            // 
            // Level
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Level";
            this.Text = "Level 1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Level_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tlpMeny.ResumeLayout(false);
            this.tlpMeny.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tlpMeny;
        private levelSpillPanel spillPanel;
        private System.Windows.Forms.Label lblTid;
        private System.Windows.Forms.Label lblPoengsum;
        private System.Windows.Forms.Label lblBrukernavn;
        private System.Windows.Forms.Button btnStartSpill;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Timer timeLeftTimer;


    }
}