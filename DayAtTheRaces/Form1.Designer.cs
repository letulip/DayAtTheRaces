namespace DayAtTheRaces
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbxRaceTrack = new System.Windows.Forms.PictureBox();
            this.pbxSantasLittleHelper = new System.Windows.Forms.PictureBox();
            this.pbxLightning = new System.Windows.Forms.PictureBox();
            this.pbxMcQuinn = new System.Windows.Forms.PictureBox();
            this.pbxRabbitSlayer = new System.Windows.Forms.PictureBox();
            this.gbxBettingParlor = new System.Windows.Forms.GroupBox();
            this.lblAlsBet = new System.Windows.Forms.Label();
            this.lblBobsBet = new System.Windows.Forms.Label();
            this.lblJoesBet = new System.Windows.Forms.Label();
            this.lblBets = new System.Windows.Forms.Label();
            this.numudDogNumber = new System.Windows.Forms.NumericUpDown();
            this.lblBucksOnDog = new System.Windows.Forms.Label();
            this.numudBet = new System.Windows.Forms.NumericUpDown();
            this.btnStartRace = new System.Windows.Forms.Button();
            this.btnBets = new System.Windows.Forms.Button();
            this.lblBettorName = new System.Windows.Forms.Label();
            this.rbtnAl = new System.Windows.Forms.RadioButton();
            this.rbtnBob = new System.Windows.Forms.RadioButton();
            this.rbtnJoe = new System.Windows.Forms.RadioButton();
            this.lblMinimumBet = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxRaceTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSantasLittleHelper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLightning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMcQuinn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRabbitSlayer)).BeginInit();
            this.gbxBettingParlor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numudDogNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numudBet)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxRaceTrack
            // 
            this.pbxRaceTrack.Image = ((System.Drawing.Image)(resources.GetObject("pbxRaceTrack.Image")));
            this.pbxRaceTrack.Location = new System.Drawing.Point(4, 3);
            this.pbxRaceTrack.Name = "pbxRaceTrack";
            this.pbxRaceTrack.Size = new System.Drawing.Size(708, 200);
            this.pbxRaceTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxRaceTrack.TabIndex = 0;
            this.pbxRaceTrack.TabStop = false;
            // 
            // pbxSantasLittleHelper
            // 
            this.pbxSantasLittleHelper.Image = ((System.Drawing.Image)(resources.GetObject("pbxSantasLittleHelper.Image")));
            this.pbxSantasLittleHelper.Location = new System.Drawing.Point(13, 13);
            this.pbxSantasLittleHelper.Name = "pbxSantasLittleHelper";
            this.pbxSantasLittleHelper.Size = new System.Drawing.Size(75, 20);
            this.pbxSantasLittleHelper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxSantasLittleHelper.TabIndex = 1;
            this.pbxSantasLittleHelper.TabStop = false;
            // 
            // pbxLightning
            // 
            this.pbxLightning.Image = ((System.Drawing.Image)(resources.GetObject("pbxLightning.Image")));
            this.pbxLightning.Location = new System.Drawing.Point(13, 61);
            this.pbxLightning.Name = "pbxLightning";
            this.pbxLightning.Size = new System.Drawing.Size(75, 20);
            this.pbxLightning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxLightning.TabIndex = 2;
            this.pbxLightning.TabStop = false;
            // 
            // pbxMcQuinn
            // 
            this.pbxMcQuinn.Image = ((System.Drawing.Image)(resources.GetObject("pbxMcQuinn.Image")));
            this.pbxMcQuinn.Location = new System.Drawing.Point(13, 116);
            this.pbxMcQuinn.Name = "pbxMcQuinn";
            this.pbxMcQuinn.Size = new System.Drawing.Size(75, 20);
            this.pbxMcQuinn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxMcQuinn.TabIndex = 3;
            this.pbxMcQuinn.TabStop = false;
            // 
            // pbxRabbitSlayer
            // 
            this.pbxRabbitSlayer.Image = ((System.Drawing.Image)(resources.GetObject("pbxRabbitSlayer.Image")));
            this.pbxRabbitSlayer.Location = new System.Drawing.Point(13, 168);
            this.pbxRabbitSlayer.Name = "pbxRabbitSlayer";
            this.pbxRabbitSlayer.Size = new System.Drawing.Size(75, 20);
            this.pbxRabbitSlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxRabbitSlayer.TabIndex = 4;
            this.pbxRabbitSlayer.TabStop = false;
            // 
            // gbxBettingParlor
            // 
            this.gbxBettingParlor.Controls.Add(this.lblAlsBet);
            this.gbxBettingParlor.Controls.Add(this.lblBobsBet);
            this.gbxBettingParlor.Controls.Add(this.lblJoesBet);
            this.gbxBettingParlor.Controls.Add(this.lblBets);
            this.gbxBettingParlor.Controls.Add(this.numudDogNumber);
            this.gbxBettingParlor.Controls.Add(this.lblBucksOnDog);
            this.gbxBettingParlor.Controls.Add(this.numudBet);
            this.gbxBettingParlor.Controls.Add(this.btnStartRace);
            this.gbxBettingParlor.Controls.Add(this.btnBets);
            this.gbxBettingParlor.Controls.Add(this.lblBettorName);
            this.gbxBettingParlor.Controls.Add(this.rbtnAl);
            this.gbxBettingParlor.Controls.Add(this.rbtnBob);
            this.gbxBettingParlor.Controls.Add(this.rbtnJoe);
            this.gbxBettingParlor.Controls.Add(this.lblMinimumBet);
            this.gbxBettingParlor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxBettingParlor.Location = new System.Drawing.Point(4, 210);
            this.gbxBettingParlor.Name = "gbxBettingParlor";
            this.gbxBettingParlor.Size = new System.Drawing.Size(708, 155);
            this.gbxBettingParlor.TabIndex = 5;
            this.gbxBettingParlor.TabStop = false;
            this.gbxBettingParlor.Text = "Betting Parlor";
            // 
            // lblAlsBet
            // 
            this.lblAlsBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAlsBet.Location = new System.Drawing.Point(205, 94);
            this.lblAlsBet.Name = "lblAlsBet";
            this.lblAlsBet.Size = new System.Drawing.Size(276, 20);
            this.lblAlsBet.TabIndex = 13;
            this.lblAlsBet.Text = "Al bets to nothing";
            // 
            // lblBobsBet
            // 
            this.lblBobsBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBobsBet.Location = new System.Drawing.Point(205, 67);
            this.lblBobsBet.Name = "lblBobsBet";
            this.lblBobsBet.Size = new System.Drawing.Size(276, 20);
            this.lblBobsBet.TabIndex = 12;
            this.lblBobsBet.Text = "Bob bets to nothing";
            // 
            // lblJoesBet
            // 
            this.lblJoesBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJoesBet.Location = new System.Drawing.Point(205, 41);
            this.lblJoesBet.Name = "lblJoesBet";
            this.lblJoesBet.Size = new System.Drawing.Size(276, 20);
            this.lblJoesBet.TabIndex = 11;
            this.lblJoesBet.Text = "Joe bets to nothing";
            // 
            // lblBets
            // 
            this.lblBets.AutoSize = true;
            this.lblBets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBets.Location = new System.Drawing.Point(202, 20);
            this.lblBets.Name = "lblBets";
            this.lblBets.Size = new System.Drawing.Size(43, 16);
            this.lblBets.TabIndex = 10;
            this.lblBets.Text = "Bets:";
            // 
            // numudDogNumber
            // 
            this.numudDogNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numudDogNumber.Location = new System.Drawing.Point(334, 123);
            this.numudDogNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numudDogNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numudDogNumber.Name = "numudDogNumber";
            this.numudDogNumber.Size = new System.Drawing.Size(49, 22);
            this.numudDogNumber.TabIndex = 9;
            this.numudDogNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numudDogNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblBucksOnDog
            // 
            this.lblBucksOnDog.AutoSize = true;
            this.lblBucksOnDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBucksOnDog.Location = new System.Drawing.Point(199, 125);
            this.lblBucksOnDog.Name = "lblBucksOnDog";
            this.lblBucksOnDog.Size = new System.Drawing.Size(129, 16);
            this.lblBucksOnDog.TabIndex = 8;
            this.lblBucksOnDog.Text = "bucks on dog No.";
            // 
            // numudBet
            // 
            this.numudBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numudBet.Location = new System.Drawing.Point(140, 123);
            this.numudBet.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numudBet.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numudBet.Name = "numudBet";
            this.numudBet.Size = new System.Drawing.Size(53, 22);
            this.numudBet.TabIndex = 7;
            this.numudBet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numudBet.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnStartRace
            // 
            this.btnStartRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStartRace.Location = new System.Drawing.Point(561, 48);
            this.btnStartRace.Name = "btnStartRace";
            this.btnStartRace.Size = new System.Drawing.Size(103, 66);
            this.btnStartRace.TabIndex = 6;
            this.btnStartRace.Text = "START THE RACE!";
            this.btnStartRace.UseVisualStyleBackColor = true;
            this.btnStartRace.Click += new System.EventHandler(this.btnStartRace_Click);
            // 
            // btnBets
            // 
            this.btnBets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBets.Location = new System.Drawing.Point(59, 122);
            this.btnBets.Name = "btnBets";
            this.btnBets.Size = new System.Drawing.Size(75, 23);
            this.btnBets.TabIndex = 5;
            this.btnBets.Text = "BETS";
            this.btnBets.UseVisualStyleBackColor = true;
            this.btnBets.Click += new System.EventHandler(this.btnBets_Click);
            // 
            // lblBettorName
            // 
            this.lblBettorName.AutoSize = true;
            this.lblBettorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBettorName.Location = new System.Drawing.Point(8, 125);
            this.lblBettorName.Name = "lblBettorName";
            this.lblBettorName.Size = new System.Drawing.Size(49, 16);
            this.lblBettorName.TabIndex = 4;
            this.lblBettorName.Text = "Name";
            // 
            // rbtnAl
            // 
            this.rbtnAl.AutoSize = true;
            this.rbtnAl.Location = new System.Drawing.Point(9, 94);
            this.rbtnAl.Name = "rbtnAl";
            this.rbtnAl.Size = new System.Drawing.Size(38, 20);
            this.rbtnAl.TabIndex = 3;
            this.rbtnAl.TabStop = true;
            this.rbtnAl.Text = "Al";
            this.rbtnAl.UseVisualStyleBackColor = true;
            this.rbtnAl.CheckedChanged += new System.EventHandler(this.rbtnAl_CheckedChanged);
            // 
            // rbtnBob
            // 
            this.rbtnBob.AutoSize = true;
            this.rbtnBob.Location = new System.Drawing.Point(9, 67);
            this.rbtnBob.Name = "rbtnBob";
            this.rbtnBob.Size = new System.Drawing.Size(51, 20);
            this.rbtnBob.TabIndex = 2;
            this.rbtnBob.TabStop = true;
            this.rbtnBob.Text = "Bob";
            this.rbtnBob.UseVisualStyleBackColor = true;
            this.rbtnBob.CheckedChanged += new System.EventHandler(this.rbtnBob_CheckedChanged);
            // 
            // rbtnJoe
            // 
            this.rbtnJoe.AutoSize = true;
            this.rbtnJoe.Location = new System.Drawing.Point(9, 40);
            this.rbtnJoe.Name = "rbtnJoe";
            this.rbtnJoe.Size = new System.Drawing.Size(49, 20);
            this.rbtnJoe.TabIndex = 1;
            this.rbtnJoe.TabStop = true;
            this.rbtnJoe.Text = "Joe";
            this.rbtnJoe.UseVisualStyleBackColor = true;
            this.rbtnJoe.CheckedChanged += new System.EventHandler(this.rbtnJoe_CheckedChanged);
            // 
            // lblMinimumBet
            // 
            this.lblMinimumBet.AutoSize = true;
            this.lblMinimumBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMinimumBet.Location = new System.Drawing.Point(7, 20);
            this.lblMinimumBet.Name = "lblMinimumBet";
            this.lblMinimumBet.Size = new System.Drawing.Size(118, 16);
            this.lblMinimumBet.TabIndex = 0;
            this.lblMinimumBet.Text = "Minimum bet: $0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 368);
            this.Controls.Add(this.gbxBettingParlor);
            this.Controls.Add(this.pbxRabbitSlayer);
            this.Controls.Add(this.pbxMcQuinn);
            this.Controls.Add(this.pbxLightning);
            this.Controls.Add(this.pbxSantasLittleHelper);
            this.Controls.Add(this.pbxRaceTrack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Day at the races";
            ((System.ComponentModel.ISupportInitialize)(this.pbxRaceTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSantasLittleHelper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLightning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMcQuinn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRabbitSlayer)).EndInit();
            this.gbxBettingParlor.ResumeLayout(false);
            this.gbxBettingParlor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numudDogNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numudBet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxRaceTrack;
        private System.Windows.Forms.PictureBox pbxSantasLittleHelper;
        private System.Windows.Forms.PictureBox pbxLightning;
        private System.Windows.Forms.PictureBox pbxMcQuinn;
        private System.Windows.Forms.PictureBox pbxRabbitSlayer;
        private System.Windows.Forms.GroupBox gbxBettingParlor;
        private System.Windows.Forms.Label lblMinimumBet;
        private System.Windows.Forms.RadioButton rbtnBob;
        private System.Windows.Forms.RadioButton rbtnJoe;
        private System.Windows.Forms.RadioButton rbtnAl;
        private System.Windows.Forms.Button btnStartRace;
        private System.Windows.Forms.Button btnBets;
        private System.Windows.Forms.Label lblBettorName;
        private System.Windows.Forms.NumericUpDown numudBet;
        private System.Windows.Forms.Label lblBucksOnDog;
        private System.Windows.Forms.NumericUpDown numudDogNumber;
        private System.Windows.Forms.Label lblBets;
        private System.Windows.Forms.Label lblAlsBet;
        private System.Windows.Forms.Label lblBobsBet;
        private System.Windows.Forms.Label lblJoesBet;
        private System.Windows.Forms.Timer timer1;
    }
}

