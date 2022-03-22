﻿
namespace DurakForm
{
    partial class frmDurakGame
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
            CardsLibrary.Card card2 = new CardsLibrary.Card();
            this.lblTrumpCard = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBox7 = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.playerSide = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.computerSide = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cbxTestCard = new CardBox.CardBox();
            this.SuspendLayout();
            // 
            // lblTrumpCard
            // 
            this.lblTrumpCard.AutoSize = true;
            this.lblTrumpCard.BackColor = System.Drawing.Color.Transparent;
            this.lblTrumpCard.Location = new System.Drawing.Point(1098, 427);
            this.lblTrumpCard.Name = "lblTrumpCard";
            this.lblTrumpCard.Size = new System.Drawing.Size(0, 13);
            this.lblTrumpCard.TabIndex = 0;
            this.lblTrumpCard.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.Image = global::DurakForm.Properties.Resources.StartGameSmaller;
            this.btnStart.Location = new System.Drawing.Point(1009, 227);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(191, 37);
            this.btnStart.TabIndex = 2;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.richTextBox2.Location = new System.Drawing.Point(323, 248);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(524, 149);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Image = global::DurakForm.Properties.Resources.RiverCards1;
            this.label1.Location = new System.Drawing.Point(703, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 28);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Image = global::DurakForm.Properties.Resources.WhoseTurn3;
            this.label2.Location = new System.Drawing.Point(997, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 214);
            this.label2.TabIndex = 5;
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(12, 248);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(102, 140);
            this.richTextBox3.TabIndex = 6;
            this.richTextBox3.Text = "";
            // 
            // richTextBox4
            // 
            this.richTextBox4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.richTextBox4.Location = new System.Drawing.Point(323, 54);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(524, 114);
            this.richTextBox4.TabIndex = 7;
            this.richTextBox4.Text = "";
            this.richTextBox4.TextChanged += new System.EventHandler(this.richTextBox4_TextChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Image = global::DurakForm.Properties.Resources.PlayersSide3;
            this.label3.Location = new System.Drawing.Point(703, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 29);
            this.label3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Image = global::DurakForm.Properties.Resources.ComputerSide1;
            this.label4.Location = new System.Drawing.Point(703, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 27);
            this.label4.TabIndex = 10;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Image = global::DurakForm.Properties.Resources.CardDecks1;
            this.label5.Location = new System.Drawing.Point(10, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 32);
            this.label5.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Image = global::DurakForm.Properties.Resources.Discarded;
            this.label6.Location = new System.Drawing.Point(14, 446);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 22);
            this.label6.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Image = global::DurakForm.Properties.Resources.Score;
            this.label7.Location = new System.Drawing.Point(11, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Score";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // richTextBox7
            // 
            this.richTextBox7.Location = new System.Drawing.Point(12, 37);
            this.richTextBox7.Name = "richTextBox7";
            this.richTextBox7.Size = new System.Drawing.Size(100, 96);
            this.richTextBox7.TabIndex = 15;
            this.richTextBox7.Text = "Computer:\n------------\nPlayer:";
            this.richTextBox7.TextChanged += new System.EventHandler(this.richTextBox7_TextChanged);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Image = global::DurakForm.Properties.Resources.Attack;
            this.label10.Location = new System.Drawing.Point(859, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 28);
            this.label10.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Image = global::DurakForm.Properties.Resources.Defend;
            this.label11.Location = new System.Drawing.Point(859, 329);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 30);
            this.label11.TabIndex = 19;
            // 
            // playerSide
            // 
            this.playerSide.BackColor = System.Drawing.SystemColors.Window;
            this.playerSide.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.playerSide.Image = global::DurakForm.Properties.Resources.TableWoodTexPlayerSide1;
            this.playerSide.Location = new System.Drawing.Point(324, 461);
            this.playerSide.Name = "playerSide";
            this.playerSide.Size = new System.Drawing.Size(524, 149);
            this.playerSide.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.No;
            this.label8.Image = global::DurakForm.Properties.Resources.TrumpCard1;
            this.label8.Location = new System.Drawing.Point(1076, 440);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 23);
            this.label8.TabIndex = 22;
            // 
            // computerSide
            // 
            this.computerSide.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.computerSide.Image = global::DurakForm.Properties.Resources.TableWoodTex1;
            this.computerSide.Location = new System.Drawing.Point(323, 54);
            this.computerSide.Name = "computerSide";
            this.computerSide.Size = new System.Drawing.Size(524, 114);
            this.computerSide.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Image = global::DurakForm.Properties.Resources.TableWoodTexRiver;
            this.label12.Location = new System.Drawing.Point(323, 248);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(524, 149);
            this.label12.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Image = global::DurakForm.Properties.Resources.ScoreCard;
            this.label14.Location = new System.Drawing.Point(9, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 98);
            this.label14.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(99, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 23);
            this.label15.TabIndex = 26;
            this.label15.Text = "0";
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(99, 99);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 23);
            this.label16.TabIndex = 27;
            this.label16.Text = "0";
            // 
            // label17
            // 
            this.label17.Image = global::DurakForm.Properties.Resources.PlayingCardBack;
            this.label17.Location = new System.Drawing.Point(12, 248);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(103, 140);
            this.label17.TabIndex = 28;
            // 
            // label18
            // 
            this.label18.Image = global::DurakForm.Properties.Resources.PlayingCardBack;
            this.label18.Location = new System.Drawing.Point(1079, 471);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(102, 145);
            this.label18.TabIndex = 29;
            // 
            // label19
            // 
            this.label19.Image = global::DurakForm.Properties.Resources.PlayingCardBack;
            this.label19.Location = new System.Drawing.Point(12, 470);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(102, 145);
            this.label19.TabIndex = 30;
            // 
            // label20
            // 
            this.label20.Image = global::DurakForm.Properties.Resources.PlayingCardBack;
            this.label20.Location = new System.Drawing.Point(155, 212);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(102, 145);
            this.label20.TabIndex = 31;
            // 
            // cbxTestCard
            // 
            card2.FaceUp = false;
            card2.Rank = CardsLibrary.RankEnum.Two;
            card2.Suit = CardsLibrary.SuitEnum.Clubs;
            card2.value = 0;
            this.cbxTestCard.Card = card2;
            this.cbxTestCard.CardOrientation = System.Windows.Forms.Orientation.Vertical;
            this.cbxTestCard.FaceUp = false;
            this.cbxTestCard.Location = new System.Drawing.Point(376, 471);
            this.cbxTestCard.Name = "cbxTestCard";
            this.cbxTestCard.Rank = CardsLibrary.RankEnum.Two;
            this.cbxTestCard.Size = new System.Drawing.Size(75, 107);
            this.cbxTestCard.Suit = CardsLibrary.SuitEnum.Clubs;
            this.cbxTestCard.TabIndex = 32;
            this.cbxTestCard.Click += new System.EventHandler(this.cbxTestCard_Click_1);
            // 
            // frmDurakGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DurakForm.Properties.Resources.AoKbB6q1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1218, 639);
            this.Controls.Add(this.cbxTestCard);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.playerSide);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.computerSide);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.richTextBox7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTrumpCard);
            this.Name = "frmDurakGame";
            this.Text = "Durak Game";
            this.Load += new System.EventHandler(this.frmDurakGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrumpCard;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label computerSide;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label playerSide;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private CardBox.CardBox cbxTestCard;
    }
}

