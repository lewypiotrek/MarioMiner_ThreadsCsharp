namespace MarioMiner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelScore1 = new System.Windows.Forms.Label();
            this.labelScore2 = new System.Windows.Forms.Label();
            this.labelStone = new System.Windows.Forms.Label();
            this.labelGold = new System.Windows.Forms.Label();
            this.buttonSell = new System.Windows.Forms.Button();
            this.buttonHire = new System.Windows.Forms.Button();
            this.buttonLearn = new System.Windows.Forms.Button();
            this.labelCostLvl = new System.Windows.Forms.Label();
            this.labelCostLearn = new System.Windows.Forms.Label();
            this.labelCostHire = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelLevelVal = new System.Windows.Forms.Label();
            this.labelLevel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelScore1
            // 
            this.labelScore1.AutoSize = true;
            this.labelScore1.BackColor = System.Drawing.Color.Transparent;
            this.labelScore1.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelScore1.Location = new System.Drawing.Point(571, 9);
            this.labelScore1.Name = "labelScore1";
            this.labelScore1.Size = new System.Drawing.Size(74, 26);
            this.labelScore1.TabIndex = 0;
            this.labelScore1.Text = "STONE:";
            // 
            // labelScore2
            // 
            this.labelScore2.AutoSize = true;
            this.labelScore2.BackColor = System.Drawing.Color.Transparent;
            this.labelScore2.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelScore2.Location = new System.Drawing.Point(571, 44);
            this.labelScore2.Name = "labelScore2";
            this.labelScore2.Size = new System.Drawing.Size(64, 26);
            this.labelScore2.TabIndex = 1;
            this.labelScore2.Text = "GOLD:";
            // 
            // labelStone
            // 
            this.labelStone.AutoSize = true;
            this.labelStone.BackColor = System.Drawing.Color.Transparent;
            this.labelStone.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStone.Location = new System.Drawing.Point(678, 9);
            this.labelStone.Name = "labelStone";
            this.labelStone.Size = new System.Drawing.Size(24, 26);
            this.labelStone.TabIndex = 2;
            this.labelStone.Text = "0";
            // 
            // labelGold
            // 
            this.labelGold.AutoSize = true;
            this.labelGold.BackColor = System.Drawing.Color.Transparent;
            this.labelGold.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGold.Location = new System.Drawing.Point(678, 44);
            this.labelGold.Name = "labelGold";
            this.labelGold.Size = new System.Drawing.Size(24, 26);
            this.labelGold.TabIndex = 3;
            this.labelGold.Text = "0";
            // 
            // buttonSell
            // 
            this.buttonSell.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSell.Location = new System.Drawing.Point(25, 10);
            this.buttonSell.Name = "buttonSell";
            this.buttonSell.Size = new System.Drawing.Size(182, 34);
            this.buttonSell.TabIndex = 4;
            this.buttonSell.Text = "SELL STONE";
            this.buttonSell.UseVisualStyleBackColor = true;
            this.buttonSell.Click += new System.EventHandler(this.buttonSell_Click);
            // 
            // buttonHire
            // 
            this.buttonHire.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonHire.Location = new System.Drawing.Point(25, 64);
            this.buttonHire.Name = "buttonHire";
            this.buttonHire.Size = new System.Drawing.Size(182, 34);
            this.buttonHire.TabIndex = 5;
            this.buttonHire.Text = "HIRE LUIGI";
            this.buttonHire.UseVisualStyleBackColor = true;
            this.buttonHire.Click += new System.EventHandler(this.buttonHire_Click);
            // 
            // buttonLearn
            // 
            this.buttonLearn.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLearn.Location = new System.Drawing.Point(27, 121);
            this.buttonLearn.Name = "buttonLearn";
            this.buttonLearn.Size = new System.Drawing.Size(181, 62);
            this.buttonLearn.TabIndex = 6;
            this.buttonLearn.Text = "DEVELOP YOUR SKILLS";
            this.buttonLearn.UseVisualStyleBackColor = true;
            this.buttonLearn.Click += new System.EventHandler(this.buttonLearn_Click);
            // 
            // labelCostLvl
            // 
            this.labelCostLvl.AutoSize = true;
            this.labelCostLvl.BackColor = System.Drawing.Color.Transparent;
            this.labelCostLvl.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCostLvl.Location = new System.Drawing.Point(24, 186);
            this.labelCostLvl.Name = "labelCostLvl";
            this.labelCostLvl.Size = new System.Drawing.Size(43, 19);
            this.labelCostLvl.TabIndex = 7;
            this.labelCostLvl.Text = "COST:";
            // 
            // labelCostLearn
            // 
            this.labelCostLearn.AutoSize = true;
            this.labelCostLearn.BackColor = System.Drawing.Color.Transparent;
            this.labelCostLearn.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCostLearn.Location = new System.Drawing.Point(70, 186);
            this.labelCostLearn.Name = "labelCostLearn";
            this.labelCostLearn.Size = new System.Drawing.Size(17, 19);
            this.labelCostLearn.TabIndex = 8;
            this.labelCostLearn.Text = "0";
            // 
            // labelCostHire
            // 
            this.labelCostHire.AutoSize = true;
            this.labelCostHire.BackColor = System.Drawing.Color.Transparent;
            this.labelCostHire.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCostHire.Location = new System.Drawing.Point(68, 99);
            this.labelCostHire.Name = "labelCostHire";
            this.labelCostHire.Size = new System.Drawing.Size(17, 19);
            this.labelCostHire.TabIndex = 10;
            this.labelCostHire.Text = "0";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.BackColor = System.Drawing.Color.Transparent;
            this.labelCost.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCost.Location = new System.Drawing.Point(22, 99);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(46, 19);
            this.labelCost.TabIndex = 9;
            this.labelCost.Text = "COST: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(69, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "150 Stone = 100 Gold";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(23, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "COST: ";
            // 
            // labelLevelVal
            // 
            this.labelLevelVal.AutoSize = true;
            this.labelLevelVal.BackColor = System.Drawing.Color.Transparent;
            this.labelLevelVal.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLevelVal.Location = new System.Drawing.Point(176, 186);
            this.labelLevelVal.Name = "labelLevelVal";
            this.labelLevelVal.Size = new System.Drawing.Size(17, 19);
            this.labelLevelVal.TabIndex = 15;
            this.labelLevelVal.Text = "0";
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.BackColor = System.Drawing.Color.Transparent;
            this.labelLevel.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLevel.Location = new System.Drawing.Point(130, 186);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(43, 19);
            this.labelLevel.TabIndex = 14;
            this.labelLevel.Text = "LEVEL:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.labelLevelVal);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCostHire);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelCostLearn);
            this.Controls.Add(this.labelCostLvl);
            this.Controls.Add(this.buttonLearn);
            this.Controls.Add(this.buttonHire);
            this.Controls.Add(this.buttonSell);
            this.Controls.Add(this.labelGold);
            this.Controls.Add(this.labelStone);
            this.Controls.Add(this.labelScore2);
            this.Controls.Add(this.labelScore1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Mario Miner | Piotr Lewandowski";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelScore1;
        private System.Windows.Forms.Label labelScore2;
        private System.Windows.Forms.Label labelStone;
        private System.Windows.Forms.Label labelGold;
        private System.Windows.Forms.Button buttonSell;
        private System.Windows.Forms.Button buttonHire;
        private System.Windows.Forms.Button buttonLearn;
        private System.Windows.Forms.Label labelCostLvl;
        private System.Windows.Forms.Label labelCostLearn;
        private System.Windows.Forms.Label labelCostHire;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelLevelVal;
        private System.Windows.Forms.Label labelLevel;
    }
}

