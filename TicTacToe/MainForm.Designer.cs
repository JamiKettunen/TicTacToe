namespace TicTacToe
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.optOstarts = new System.Windows.Forms.RadioButton();
            this.optXstarts = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlGame = new System.Windows.Forms.Panel();
            this.btnTopRight = new System.Windows.Forms.Button();
            this.btnMiddleRight = new System.Windows.Forms.Button();
            this.btnBottomRight = new System.Windows.Forms.Button();
            this.btnBottomMiddle = new System.Windows.Forms.Button();
            this.btnBottomLeft = new System.Windows.Forms.Button();
            this.btnTopMiddle = new System.Windows.Forms.Button();
            this.btnMiddle = new System.Windows.Forms.Button();
            this.btnMiddleLeft = new System.Windows.Forms.Button();
            this.btnTopLeft = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.pnlGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(7, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game Settings";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(71, 44);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(66, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 44);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(55, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.optOstarts);
            this.groupBox2.Controls.Add(this.optXstarts);
            this.groupBox2.Location = new System.Drawing.Point(146, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(161, 69);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Start";
            // 
            // optOstarts
            // 
            this.optOstarts.AutoSize = true;
            this.optOstarts.Location = new System.Drawing.Point(85, 28);
            this.optOstarts.Name = "optOstarts";
            this.optOstarts.Size = new System.Drawing.Size(61, 17);
            this.optOstarts.TabIndex = 0;
            this.optOstarts.Text = "O starts";
            this.optOstarts.UseVisualStyleBackColor = true;
            // 
            // optXstarts
            // 
            this.optXstarts.AutoSize = true;
            this.optXstarts.Checked = true;
            this.optXstarts.Location = new System.Drawing.Point(17, 28);
            this.optXstarts.Name = "optXstarts";
            this.optXstarts.Size = new System.Drawing.Size(60, 17);
            this.optXstarts.TabIndex = 0;
            this.optXstarts.TabStop = true;
            this.optXstarts.Text = "X starts";
            this.optXstarts.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 326);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(328, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(42, 17);
            this.lblStatus.Text = "Ready!";
            // 
            // pnlGame
            // 
            this.pnlGame.Controls.Add(this.btnTopRight);
            this.pnlGame.Controls.Add(this.btnMiddleRight);
            this.pnlGame.Controls.Add(this.btnBottomRight);
            this.pnlGame.Controls.Add(this.btnBottomMiddle);
            this.pnlGame.Controls.Add(this.btnBottomLeft);
            this.pnlGame.Controls.Add(this.btnTopMiddle);
            this.pnlGame.Controls.Add(this.btnMiddle);
            this.pnlGame.Controls.Add(this.btnMiddleLeft);
            this.pnlGame.Controls.Add(this.btnTopLeft);
            this.pnlGame.Controls.Add(this.panel2);
            this.pnlGame.Controls.Add(this.panel1);
            this.pnlGame.Controls.Add(this.panel3);
            this.pnlGame.Controls.Add(this.panel4);
            this.pnlGame.Location = new System.Drawing.Point(64, 112);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(200, 200);
            this.pnlGame.TabIndex = 2;
            this.pnlGame.Visible = false;
            // 
            // btnTopRight
            // 
            this.btnTopRight.FlatAppearance.BorderSize = 0;
            this.btnTopRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopRight.Font = new System.Drawing.Font("Lucida Console", 36F);
            this.btnTopRight.Location = new System.Drawing.Point(141, 5);
            this.btnTopRight.Name = "btnTopRight";
            this.btnTopRight.Size = new System.Drawing.Size(54, 54);
            this.btnTopRight.TabIndex = 14;
            this.btnTopRight.Text = "X";
            this.btnTopRight.UseVisualStyleBackColor = true;
            this.btnTopRight.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnMiddleRight
            // 
            this.btnMiddleRight.FlatAppearance.BorderSize = 0;
            this.btnMiddleRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMiddleRight.Font = new System.Drawing.Font("Lucida Console", 36F);
            this.btnMiddleRight.Location = new System.Drawing.Point(141, 73);
            this.btnMiddleRight.Name = "btnMiddleRight";
            this.btnMiddleRight.Size = new System.Drawing.Size(54, 54);
            this.btnMiddleRight.TabIndex = 13;
            this.btnMiddleRight.Text = "X";
            this.btnMiddleRight.UseVisualStyleBackColor = true;
            this.btnMiddleRight.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnBottomRight
            // 
            this.btnBottomRight.FlatAppearance.BorderSize = 0;
            this.btnBottomRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBottomRight.Font = new System.Drawing.Font("Lucida Console", 36F);
            this.btnBottomRight.Location = new System.Drawing.Point(141, 141);
            this.btnBottomRight.Name = "btnBottomRight";
            this.btnBottomRight.Size = new System.Drawing.Size(54, 54);
            this.btnBottomRight.TabIndex = 12;
            this.btnBottomRight.Text = "X";
            this.btnBottomRight.UseVisualStyleBackColor = true;
            this.btnBottomRight.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnBottomMiddle
            // 
            this.btnBottomMiddle.FlatAppearance.BorderSize = 0;
            this.btnBottomMiddle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBottomMiddle.Font = new System.Drawing.Font("Lucida Console", 36F);
            this.btnBottomMiddle.Location = new System.Drawing.Point(73, 141);
            this.btnBottomMiddle.Name = "btnBottomMiddle";
            this.btnBottomMiddle.Size = new System.Drawing.Size(54, 54);
            this.btnBottomMiddle.TabIndex = 11;
            this.btnBottomMiddle.Text = "X";
            this.btnBottomMiddle.UseVisualStyleBackColor = true;
            this.btnBottomMiddle.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnBottomLeft
            // 
            this.btnBottomLeft.FlatAppearance.BorderSize = 0;
            this.btnBottomLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBottomLeft.Font = new System.Drawing.Font("Lucida Console", 36F);
            this.btnBottomLeft.Location = new System.Drawing.Point(5, 141);
            this.btnBottomLeft.Name = "btnBottomLeft";
            this.btnBottomLeft.Size = new System.Drawing.Size(54, 54);
            this.btnBottomLeft.TabIndex = 10;
            this.btnBottomLeft.Text = "X";
            this.btnBottomLeft.UseVisualStyleBackColor = true;
            this.btnBottomLeft.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnTopMiddle
            // 
            this.btnTopMiddle.FlatAppearance.BorderSize = 0;
            this.btnTopMiddle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopMiddle.Font = new System.Drawing.Font("Lucida Console", 36F);
            this.btnTopMiddle.Location = new System.Drawing.Point(73, 5);
            this.btnTopMiddle.Name = "btnTopMiddle";
            this.btnTopMiddle.Size = new System.Drawing.Size(54, 54);
            this.btnTopMiddle.TabIndex = 9;
            this.btnTopMiddle.Text = "X";
            this.btnTopMiddle.UseVisualStyleBackColor = true;
            this.btnTopMiddle.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnMiddle
            // 
            this.btnMiddle.FlatAppearance.BorderSize = 0;
            this.btnMiddle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMiddle.Font = new System.Drawing.Font("Lucida Console", 36F);
            this.btnMiddle.Location = new System.Drawing.Point(73, 73);
            this.btnMiddle.Name = "btnMiddle";
            this.btnMiddle.Size = new System.Drawing.Size(54, 54);
            this.btnMiddle.TabIndex = 8;
            this.btnMiddle.Text = "X";
            this.btnMiddle.UseVisualStyleBackColor = true;
            this.btnMiddle.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnMiddleLeft
            // 
            this.btnMiddleLeft.FlatAppearance.BorderSize = 0;
            this.btnMiddleLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMiddleLeft.Font = new System.Drawing.Font("Lucida Console", 36F);
            this.btnMiddleLeft.Location = new System.Drawing.Point(5, 73);
            this.btnMiddleLeft.Name = "btnMiddleLeft";
            this.btnMiddleLeft.Size = new System.Drawing.Size(54, 54);
            this.btnMiddleLeft.TabIndex = 7;
            this.btnMiddleLeft.Text = "X";
            this.btnMiddleLeft.UseVisualStyleBackColor = true;
            this.btnMiddleLeft.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnTopLeft
            // 
            this.btnTopLeft.FlatAppearance.BorderSize = 0;
            this.btnTopLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopLeft.Font = new System.Drawing.Font("Lucida Console", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopLeft.Location = new System.Drawing.Point(5, 5);
            this.btnTopLeft.Name = "btnTopLeft";
            this.btnTopLeft.Size = new System.Drawing.Size(54, 54);
            this.btnTopLeft.TabIndex = 6;
            this.btnTopLeft.Text = "X";
            this.btnTopLeft.UseVisualStyleBackColor = true;
            this.btnTopLeft.Click += new System.EventHandler(this.btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(131, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(6, 200);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(63, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(6, 200);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(0, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 6);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(3, 131);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 6);
            this.panel4.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 348);
            this.Controls.Add(this.pnlGame);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlGame.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton optOstarts;
        private System.Windows.Forms.RadioButton optXstarts;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTopRight;
        private System.Windows.Forms.Button btnMiddleRight;
        private System.Windows.Forms.Button btnBottomRight;
        private System.Windows.Forms.Button btnBottomMiddle;
        private System.Windows.Forms.Button btnBottomLeft;
        private System.Windows.Forms.Button btnTopMiddle;
        private System.Windows.Forms.Button btnMiddle;
        private System.Windows.Forms.Button btnMiddleLeft;
        private System.Windows.Forms.Button btnTopLeft;
        private System.Windows.Forms.Button btnReset;
    }
}

