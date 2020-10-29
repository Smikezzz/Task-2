namespace TASK1
{
    partial class frmGame
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnAttack = new System.Windows.Forms.Button();
            this.cmbEnemy = new System.Windows.Forms.ComboBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.lblPStats = new System.Windows.Forms.Label();
            this.lblMap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(510, 449);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(278, 105);
            this.richTextBox1.TabIndex = 20;
            this.richTextBox1.Text = "";
            // 
            // btnLeft
            // 
            this.btnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.Location = new System.Drawing.Point(269, 486);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 31);
            this.btnLeft.TabIndex = 19;
            this.btnLeft.Text = "←";
            this.btnLeft.UseVisualStyleBackColor = true;
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.Location = new System.Drawing.Point(343, 523);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 31);
            this.btnDown.TabIndex = 18;
            this.btnDown.Text = "↓";
            this.btnDown.UseVisualStyleBackColor = true;
            // 
            // btnRight
            // 
            this.btnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight.Location = new System.Drawing.Point(416, 486);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 31);
            this.btnRight.TabIndex = 17;
            this.btnRight.Text = "→";
            this.btnRight.UseVisualStyleBackColor = true;
            // 
            // btnAttack
            // 
            this.btnAttack.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttack.Location = new System.Drawing.Point(667, 384);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(121, 29);
            this.btnAttack.TabIndex = 16;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            // 
            // cmbEnemy
            // 
            this.cmbEnemy.FormattingEnabled = true;
            this.cmbEnemy.Location = new System.Drawing.Point(667, 419);
            this.cmbEnemy.Name = "cmbEnemy";
            this.cmbEnemy.Size = new System.Drawing.Size(121, 24);
            this.cmbEnemy.TabIndex = 15;
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.Location = new System.Drawing.Point(343, 449);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 31);
            this.btnUp.TabIndex = 14;
            this.btnUp.Text = "↑";
            this.btnUp.UseVisualStyleBackColor = true;
            // 
            // lblPStats
            // 
            this.lblPStats.AutoSize = true;
            this.lblPStats.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPStats.Location = new System.Drawing.Point(12, 478);
            this.lblPStats.Name = "lblPStats";
            this.lblPStats.Size = new System.Drawing.Size(146, 76);
            this.lblPStats.TabIndex = 13;
            this.lblPStats.Text = "Player Stats:\r\nHP: HP/MAX HP\r\nDamage: Damage\r\n[X,Y]";
            // 
            // lblMap
            // 
            this.lblMap.AutoSize = true;
            this.lblMap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMap.Location = new System.Drawing.Point(353, 192);
            this.lblMap.Name = "lblMap";
            this.lblMap.Size = new System.Drawing.Size(53, 24);
            this.lblMap.TabIndex = 12;
            this.lblMap.Text = "MAP";
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 566);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.cmbEnemy);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.lblPStats);
            this.Controls.Add(this.lblMap);
            this.Name = "frmGame";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.frmGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.ComboBox cmbEnemy;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Label lblPStats;
        private System.Windows.Forms.Label lblMap;
    }
}

