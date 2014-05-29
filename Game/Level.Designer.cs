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
            this.lbGameOver = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpMeny.SuspendLayout();
            this.spillPanel.SuspendLayout();
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
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.540925F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.45908F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1045, 692);
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
            this.tlpMeny.Location = new System.Drawing.Point(4, 4);
            this.tlpMeny.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpMeny.Name = "tlpMeny";
            this.tlpMeny.RowCount = 1;
            this.tlpMeny.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMeny.Size = new System.Drawing.Size(1037, 51);
            this.tlpMeny.TabIndex = 0;
            // 
            // lblTid
            // 
            this.lblTid.AutoSize = true;
            this.lblTid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTid.Location = new System.Drawing.Point(4, 0);
            this.lblTid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTid.Name = "lblTid";
            this.lblTid.Size = new System.Drawing.Size(199, 51);
            this.lblTid.TabIndex = 0;
            this.lblTid.Text = "Tid igjen: ";
            // 
            // lblPoengsum
            // 
            this.lblPoengsum.AutoSize = true;
            this.lblPoengsum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPoengsum.Location = new System.Drawing.Point(211, 0);
            this.lblPoengsum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPoengsum.Name = "lblPoengsum";
            this.lblPoengsum.Size = new System.Drawing.Size(199, 51);
            this.lblPoengsum.TabIndex = 1;
            this.lblPoengsum.Text = "Poengsum:";
            // 
            // lblBrukernavn
            // 
            this.lblBrukernavn.AutoSize = true;
            this.lblBrukernavn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBrukernavn.Location = new System.Drawing.Point(418, 0);
            this.lblBrukernavn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBrukernavn.Name = "lblBrukernavn";
            this.lblBrukernavn.Size = new System.Drawing.Size(199, 51);
            this.lblBrukernavn.TabIndex = 2;
            this.lblBrukernavn.Text = "Brukernavn:";
            // 
            // btnStartSpill
            // 
            this.btnStartSpill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStartSpill.Location = new System.Drawing.Point(625, 4);
            this.btnStartSpill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStartSpill.Name = "btnStartSpill";
            this.btnStartSpill.Size = new System.Drawing.Size(199, 43);
            this.btnStartSpill.TabIndex = 3;
            this.btnStartSpill.Text = "Start";
            this.btnStartSpill.UseVisualStyleBackColor = true;
            this.btnStartSpill.Click += new System.EventHandler(this.btnStartSpill_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHelp.Location = new System.Drawing.Point(831, 2);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(203, 47);
            this.btnHelp.TabIndex = 4;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // spillPanel
            // 
            this.spillPanel.BackColor = System.Drawing.Color.SkyBlue;
            this.spillPanel.Controls.Add(this.lbGameOver);
            this.spillPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spillPanel.Location = new System.Drawing.Point(4, 63);
            this.spillPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spillPanel.Name = "spillPanel";
            this.spillPanel.Size = new System.Drawing.Size(1037, 625);
            this.spillPanel.TabIndex = 1;
            // 
            // timeLeftTimer
            // 
            this.timeLeftTimer.Interval = 1000;
            this.timeLeftTimer.Tick += new System.EventHandler(this.timeLeftTimer_Tick);
            // 
            // lbGameOver
            // 
            this.lbGameOver.AutoSize = true;
            this.lbGameOver.BackColor = System.Drawing.Color.Transparent;
            this.lbGameOver.Font = new System.Drawing.Font("Nasalization", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGameOver.ForeColor = System.Drawing.Color.DarkRed;
            this.lbGameOver.Location = new System.Drawing.Point(94, 234);
            this.lbGameOver.Name = "lbGameOver";
            this.lbGameOver.Size = new System.Drawing.Size(816, 107);
            this.lbGameOver.TabIndex = 1;
            this.lbGameOver.Text = "Game Over!";
            this.lbGameOver.Visible = false;
            // 
            // Level
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 692);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Level";
            this.Text = "Level 1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Level_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tlpMeny.ResumeLayout(false);
            this.tlpMeny.PerformLayout();
            this.spillPanel.ResumeLayout(false);
            this.spillPanel.PerformLayout();
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
        private System.Windows.Forms.Label lbGameOver;


    }
}