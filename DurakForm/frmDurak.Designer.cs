
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
            this.lblTrumpCard = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBox7 = new System.Windows.Forms.RichTextBox();
            this.lblAttack = new System.Windows.Forms.Label();
            this.lblDefend = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.flowPlayersHand = new System.Windows.Forms.FlowLayoutPanel();
            this.flowComputersHand = new System.Windows.Forms.FlowLayoutPanel();
            this.flowRiverHand = new System.Windows.Forms.FlowLayoutPanel();
            this.flpTrumpCard = new System.Windows.Forms.FlowLayoutPanel();
            this.PlayerLabel = new System.Windows.Forms.Label();
            this.ComputerLabel = new System.Windows.Forms.Label();
            this.RiverLabel = new System.Windows.Forms.Label();
            this.CardsRemainingLabel = new System.Windows.Forms.Label();
            this.testlabel = new System.Windows.Forms.Label();
            this.btnTake = new System.Windows.Forms.Button();
            this.btnOkay = new System.Windows.Forms.Button();
            this.flpDiscarded = new System.Windows.Forms.FlowLayoutPanel();
            this.flpDeck = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTrump = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.rdo52Deck = new System.Windows.Forms.RadioButton();
            this.rdo36Deck = new System.Windows.Forms.RadioButton();
            this.rdo20Deck = new System.Windows.Forms.RadioButton();
            this.btnLogs = new System.Windows.Forms.Button();
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
            // 
            // richTextBox7
            // 
            this.richTextBox7.Location = new System.Drawing.Point(12, 37);
            this.richTextBox7.Name = "richTextBox7";
            this.richTextBox7.Size = new System.Drawing.Size(100, 96);
            this.richTextBox7.TabIndex = 15;
            this.richTextBox7.Text = "Computer:\n------------\nPlayer:";
            // 
            // lblAttack
            // 
            this.lblAttack.BackColor = System.Drawing.Color.Transparent;
            this.lblAttack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAttack.Image = global::DurakForm.Properties.Resources.Attack;
            this.lblAttack.Location = new System.Drawing.Point(859, 274);
            this.lblAttack.Name = "lblAttack";
            this.lblAttack.Size = new System.Drawing.Size(76, 28);
            this.lblAttack.TabIndex = 18;
            // 
            // lblDefend
            // 
            this.lblDefend.BackColor = System.Drawing.Color.Transparent;
            this.lblDefend.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDefend.Image = global::DurakForm.Properties.Resources.Defend;
            this.lblDefend.Location = new System.Drawing.Point(859, 329);
            this.lblDefend.Name = "lblDefend";
            this.lblDefend.Size = new System.Drawing.Size(76, 30);
            this.lblDefend.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.No;
            this.label8.Image = global::DurakForm.Properties.Resources.TrumpCard1;
            this.label8.Location = new System.Drawing.Point(1071, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 23);
            this.label8.TabIndex = 22;
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
            // flowPlayersHand
            // 
            this.flowPlayersHand.AutoScroll = true;
            this.flowPlayersHand.BackgroundImage = global::DurakForm.Properties.Resources.TableWoodTexRiver;
            this.flowPlayersHand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowPlayersHand.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowPlayersHand.Location = new System.Drawing.Point(323, 458);
            this.flowPlayersHand.Margin = new System.Windows.Forms.Padding(1);
            this.flowPlayersHand.Name = "flowPlayersHand";
            this.flowPlayersHand.Size = new System.Drawing.Size(538, 146);
            this.flowPlayersHand.TabIndex = 33;
            // 
            // flowComputersHand
            // 
            this.flowComputersHand.AutoScroll = true;
            this.flowComputersHand.BackgroundImage = global::DurakForm.Properties.Resources.TableWoodTexRiver;
            this.flowComputersHand.Location = new System.Drawing.Point(316, 49);
            this.flowComputersHand.Name = "flowComputersHand";
            this.flowComputersHand.Size = new System.Drawing.Size(538, 146);
            this.flowComputersHand.TabIndex = 34;
            // 
            // flowRiverHand
            // 
            this.flowRiverHand.BackgroundImage = global::DurakForm.Properties.Resources.TableWoodTexRiver;
            this.flowRiverHand.Location = new System.Drawing.Point(316, 243);
            this.flowRiverHand.Name = "flowRiverHand";
            this.flowRiverHand.Size = new System.Drawing.Size(538, 151);
            this.flowRiverHand.TabIndex = 35;
            // 
            // flpTrumpCard
            // 
            this.flpTrumpCard.BackgroundImage = global::DurakForm.Properties.Resources.TableWoodTexRiver;
            this.flpTrumpCard.Location = new System.Drawing.Point(1086, 402);
            this.flpTrumpCard.Name = "flpTrumpCard";
            this.flpTrumpCard.Size = new System.Drawing.Size(80, 114);
            this.flpTrumpCard.TabIndex = 36;
            // 
            // PlayerLabel
            // 
            this.PlayerLabel.AutoSize = true;
            this.PlayerLabel.Location = new System.Drawing.Point(884, 380);
            this.PlayerLabel.Name = "PlayerLabel";
            this.PlayerLabel.Size = new System.Drawing.Size(35, 13);
            this.PlayerLabel.TabIndex = 37;
            this.PlayerLabel.Text = "label9";
            // 
            // ComputerLabel
            // 
            this.ComputerLabel.AutoSize = true;
            this.ComputerLabel.Location = new System.Drawing.Point(887, 82);
            this.ComputerLabel.Name = "ComputerLabel";
            this.ComputerLabel.Size = new System.Drawing.Size(41, 13);
            this.ComputerLabel.TabIndex = 38;
            this.ComputerLabel.Text = "label12";
            // 
            // RiverLabel
            // 
            this.RiverLabel.AutoSize = true;
            this.RiverLabel.Location = new System.Drawing.Point(206, 380);
            this.RiverLabel.Name = "RiverLabel";
            this.RiverLabel.Size = new System.Drawing.Size(41, 13);
            this.RiverLabel.TabIndex = 39;
            this.RiverLabel.Text = "label13";
            this.RiverLabel.Click += new System.EventHandler(this.RiverLabel_Click);
            // 
            // CardsRemainingLabel
            // 
            this.CardsRemainingLabel.AutoSize = true;
            this.CardsRemainingLabel.Location = new System.Drawing.Point(42, 402);
            this.CardsRemainingLabel.Name = "CardsRemainingLabel";
            this.CardsRemainingLabel.Size = new System.Drawing.Size(0, 13);
            this.CardsRemainingLabel.TabIndex = 40;
            // 
            // testlabel
            // 
            this.testlabel.AutoSize = true;
            this.testlabel.Location = new System.Drawing.Point(184, 82);
            this.testlabel.Name = "testlabel";
            this.testlabel.Size = new System.Drawing.Size(35, 13);
            this.testlabel.TabIndex = 41;
            this.testlabel.Text = "label9";
            // 
            // btnTake
            // 
            this.btnTake.Location = new System.Drawing.Point(890, 476);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(75, 23);
            this.btnTake.TabIndex = 42;
            this.btnTake.Text = "Take";
            this.btnTake.UseVisualStyleBackColor = true;
            this.btnTake.Click += new System.EventHandler(this.btnTake_Click_1);
            // 
            // btnOkay
            // 
            this.btnOkay.Location = new System.Drawing.Point(890, 552);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(75, 23);
            this.btnOkay.TabIndex = 43;
            this.btnOkay.Text = "Okay";
            this.btnOkay.UseVisualStyleBackColor = true;
            this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click_1);
            // 
            // flpDiscarded
            // 
            this.flpDiscarded.BackgroundImage = global::DurakForm.Properties.Resources.TableWoodTexRiver;
            this.flpDiscarded.Location = new System.Drawing.Point(24, 476);
            this.flpDiscarded.Name = "flpDiscarded";
            this.flpDiscarded.Size = new System.Drawing.Size(80, 114);
            this.flpDiscarded.TabIndex = 37;
            // 
            // flpDeck
            // 
            this.flpDeck.BackgroundImage = global::DurakForm.Properties.Resources.TableWoodTexRiver;
            this.flpDeck.Location = new System.Drawing.Point(22, 247);
            this.flpDeck.Name = "flpDeck";
            this.flpDeck.Size = new System.Drawing.Size(80, 114);
            this.flpDeck.TabIndex = 38;
            // 
            // lblTrump
            // 
            this.lblTrump.AutoSize = true;
            this.lblTrump.Location = new System.Drawing.Point(1076, 552);
            this.lblTrump.Name = "lblTrump";
            this.lblTrump.Size = new System.Drawing.Size(35, 13);
            this.lblTrump.TabIndex = 44;
            this.lblTrump.Text = "label1";
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnHelp.Image = global::DurakForm.Properties.Resources.HelpButtonSmall;
            this.btnHelp.Location = new System.Drawing.Point(1009, 274);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(191, 37);
            this.btnHelp.TabIndex = 45;
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // rdo52Deck
            // 
            this.rdo52Deck.AutoSize = true;
            this.rdo52Deck.Location = new System.Drawing.Point(1058, 329);
            this.rdo52Deck.Name = "rdo52Deck";
            this.rdo52Deck.Size = new System.Drawing.Size(37, 17);
            this.rdo52Deck.TabIndex = 46;
            this.rdo52Deck.Text = "52";
            this.rdo52Deck.UseVisualStyleBackColor = true;
            // 
            // rdo36Deck
            // 
            this.rdo36Deck.AutoSize = true;
            this.rdo36Deck.Checked = true;
            this.rdo36Deck.Location = new System.Drawing.Point(1101, 329);
            this.rdo36Deck.Name = "rdo36Deck";
            this.rdo36Deck.Size = new System.Drawing.Size(37, 17);
            this.rdo36Deck.TabIndex = 47;
            this.rdo36Deck.TabStop = true;
            this.rdo36Deck.Text = "36";
            this.rdo36Deck.UseVisualStyleBackColor = true;
            // 
            // rdo20Deck
            // 
            this.rdo20Deck.AutoSize = true;
            this.rdo20Deck.Location = new System.Drawing.Point(1148, 329);
            this.rdo20Deck.Name = "rdo20Deck";
            this.rdo20Deck.Size = new System.Drawing.Size(37, 17);
            this.rdo20Deck.TabIndex = 48;
            this.rdo20Deck.Text = "20";
            this.rdo20Deck.UseVisualStyleBackColor = true;
            // 
            // btnLogs
            // 
            this.btnLogs.Location = new System.Drawing.Point(209, 274);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Size = new System.Drawing.Size(75, 23);
            this.btnLogs.TabIndex = 50;
            this.btnLogs.Text = "Logs";
            this.btnLogs.UseVisualStyleBackColor = true;
            this.btnLogs.Click += new System.EventHandler(this.btnLogs_Click);
            // 
            // frmDurakGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DurakForm.Properties.Resources.AoKbB6q1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1218, 639);
            this.Controls.Add(this.btnLogs);
            this.Controls.Add(this.rdo20Deck);
            this.Controls.Add(this.rdo36Deck);
            this.Controls.Add(this.rdo52Deck);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblTrump);
            this.Controls.Add(this.flpDeck);
            this.Controls.Add(this.flpDiscarded);
            this.Controls.Add(this.btnOkay);
            this.Controls.Add(this.btnTake);
            this.Controls.Add(this.testlabel);
            this.Controls.Add(this.CardsRemainingLabel);
            this.Controls.Add(this.RiverLabel);
            this.Controls.Add(this.ComputerLabel);
            this.Controls.Add(this.PlayerLabel);
            this.Controls.Add(this.flpTrumpCard);
            this.Controls.Add(this.flowRiverHand);
            this.Controls.Add(this.flowComputersHand);
            this.Controls.Add(this.flowPlayersHand);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblDefend);
            this.Controls.Add(this.lblAttack);
            this.Controls.Add(this.richTextBox7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBox7;
        private System.Windows.Forms.Label lblAttack;
        private System.Windows.Forms.Label lblDefend;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.FlowLayoutPanel flowPlayersHand;
        private System.Windows.Forms.FlowLayoutPanel flowComputersHand;
        private System.Windows.Forms.FlowLayoutPanel flowRiverHand;
        private System.Windows.Forms.FlowLayoutPanel flpTrumpCard;
        private System.Windows.Forms.Label PlayerLabel;
        private System.Windows.Forms.Label ComputerLabel;
        private System.Windows.Forms.Label RiverLabel;
        private System.Windows.Forms.Label CardsRemainingLabel;
        private System.Windows.Forms.Label testlabel;
        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.Button btnOkay;
        private System.Windows.Forms.FlowLayoutPanel flpDiscarded;
        private System.Windows.Forms.FlowLayoutPanel flpDeck;
        private System.Windows.Forms.Label lblTrump;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.RadioButton rdo52Deck;
        private System.Windows.Forms.RadioButton rdo36Deck;
        private System.Windows.Forms.RadioButton rdo20Deck;
        private System.Windows.Forms.Button btnLogs;
    }
}

