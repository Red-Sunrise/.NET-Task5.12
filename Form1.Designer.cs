namespace Task5
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.AddCarriageButton = new System.Windows.Forms.Button();
            this.ClearListButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonPlaybackSpeed = new System.Windows.Forms.Button();
            this.numericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonModelName = new System.Windows.Forms.Button();
            this.buttonVolume = new System.Windows.Forms.Button();
            this.textBoxModelName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownVolume = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxOrder = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MaxDuration = new System.Windows.Forms.NumericUpDown();
            this.MinDuration = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LabelModelName = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelVolume = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelPlaybackSpeed = new System.Windows.Forms.Label();
            this.labelPlays = new System.Windows.Forms.Label();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vScrollBar1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 351);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Videos List";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.LargeChange = 1;
            this.vScrollBar1.Location = new System.Drawing.Point(251, 5);
            this.vScrollBar1.Maximum = 0;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(22, 404);
            this.vScrollBar1.TabIndex = 0;
            this.vScrollBar1.ValueChanged += new System.EventHandler(this.ChangeScrollerValue);
            // 
            // AddCarriageButton
            // 
            this.AddCarriageButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCarriageButton.Location = new System.Drawing.Point(292, 17);
            this.AddCarriageButton.Name = "AddCarriageButton";
            this.AddCarriageButton.Size = new System.Drawing.Size(108, 38);
            this.AddCarriageButton.TabIndex = 1;
            this.AddCarriageButton.Text = "Add Video";
            this.AddCarriageButton.UseVisualStyleBackColor = true;
            this.AddCarriageButton.Click += new System.EventHandler(this.AddCarriageButton_Click);
            // 
            // ClearListButton
            // 
            this.ClearListButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearListButton.Location = new System.Drawing.Point(406, 17);
            this.ClearListButton.Name = "ClearListButton";
            this.ClearListButton.Size = new System.Drawing.Size(142, 38);
            this.ClearListButton.TabIndex = 2;
            this.ClearListButton.Text = "Clear Videos List";
            this.ClearListButton.UseVisualStyleBackColor = true;
            this.ClearListButton.Click += new System.EventHandler(this.ClearListButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonPlaybackSpeed);
            this.groupBox2.Controls.Add(this.numericUpDownSpeed);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.buttonModelName);
            this.groupBox2.Controls.Add(this.buttonVolume);
            this.groupBox2.Controls.Add(this.textBoxModelName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.numericUpDownVolume);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboBoxOrder);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.MaxDuration);
            this.groupBox2.Controls.Add(this.MinDuration);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(288, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 301);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // buttonPlaybackSpeed
            // 
            this.buttonPlaybackSpeed.Location = new System.Drawing.Point(183, 238);
            this.buttonPlaybackSpeed.Name = "buttonPlaybackSpeed";
            this.buttonPlaybackSpeed.Size = new System.Drawing.Size(69, 23);
            this.buttonPlaybackSpeed.TabIndex = 26;
            this.buttonPlaybackSpeed.Text = "Change";
            this.buttonPlaybackSpeed.UseVisualStyleBackColor = true;
            this.buttonPlaybackSpeed.Click += new System.EventHandler(this.buttonPlaybackSpeed_Click);
            // 
            // numericUpDownSpeed
            // 
            this.numericUpDownSpeed.Location = new System.Drawing.Point(98, 241);
            this.numericUpDownSpeed.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSpeed.Name = "numericUpDownSpeed";
            this.numericUpDownSpeed.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownSpeed.TabIndex = 25;
            this.numericUpDownSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Playback Speed:";
            // 
            // buttonModelName
            // 
            this.buttonModelName.Location = new System.Drawing.Point(183, 207);
            this.buttonModelName.Name = "buttonModelName";
            this.buttonModelName.Size = new System.Drawing.Size(69, 23);
            this.buttonModelName.TabIndex = 23;
            this.buttonModelName.Text = "Change";
            this.buttonModelName.UseVisualStyleBackColor = true;
            this.buttonModelName.Click += new System.EventHandler(this.buttonModelName_Click);
            // 
            // buttonVolume
            // 
            this.buttonVolume.Location = new System.Drawing.Point(183, 177);
            this.buttonVolume.Name = "buttonVolume";
            this.buttonVolume.Size = new System.Drawing.Size(69, 23);
            this.buttonVolume.TabIndex = 22;
            this.buttonVolume.Text = "Change";
            this.buttonVolume.UseVisualStyleBackColor = true;
            this.buttonVolume.Click += new System.EventHandler(this.buttonVolume_Click);
            // 
            // textBoxModelName
            // 
            this.textBoxModelName.Location = new System.Drawing.Point(77, 209);
            this.textBoxModelName.Name = "textBoxModelName";
            this.textBoxModelName.Size = new System.Drawing.Size(100, 20);
            this.textBoxModelName.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Model Name:";
            // 
            // numericUpDownVolume
            // 
            this.numericUpDownVolume.Location = new System.Drawing.Point(98, 183);
            this.numericUpDownVolume.Name = "numericUpDownVolume";
            this.numericUpDownVolume.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownVolume.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Volume:";
            // 
            // comboBoxOrder
            // 
            this.comboBoxOrder.FormattingEnabled = true;
            this.comboBoxOrder.Items.AddRange(new object[] {
            "no order",
            "Duration"});
            this.comboBoxOrder.Location = new System.Drawing.Point(53, 37);
            this.comboBoxOrder.Name = "comboBoxOrder";
            this.comboBoxOrder.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOrder.TabIndex = 17;
            this.comboBoxOrder.Text = "no order";
            this.comboBoxOrder.TextChanged += new System.EventHandler(this.UpdateVideosListFilters);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Order:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "max";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "min";
            // 
            // MaxDuration
            // 
            this.MaxDuration.Location = new System.Drawing.Point(189, 113);
            this.MaxDuration.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.MaxDuration.Name = "MaxDuration";
            this.MaxDuration.Size = new System.Drawing.Size(53, 20);
            this.MaxDuration.TabIndex = 3;
            this.MaxDuration.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.MaxDuration.ValueChanged += new System.EventHandler(this.UpdateVideosListFilters);
            // 
            // MinDuration
            // 
            this.MinDuration.Location = new System.Drawing.Point(98, 113);
            this.MinDuration.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.MinDuration.Name = "MinDuration";
            this.MinDuration.Size = new System.Drawing.Size(53, 20);
            this.MinDuration.TabIndex = 2;
            this.MinDuration.ValueChanged += new System.EventHandler(this.UpdateVideosListFilters);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Duration (in minutes):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 399);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Model Name:";
            // 
            // LabelModelName
            // 
            this.LabelModelName.AutoSize = true;
            this.LabelModelName.Location = new System.Drawing.Point(88, 399);
            this.LabelModelName.Name = "LabelModelName";
            this.LabelModelName.Size = new System.Drawing.Size(69, 13);
            this.LabelModelName.TabIndex = 19;
            this.LabelModelName.Text = "VideoPlayer1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 421);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Volume =";
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Location = new System.Drawing.Point(88, 421);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(25, 13);
            this.labelVolume.TabIndex = 21;
            this.labelVolume.Text = "100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Video Player";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(207, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "State:";
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(250, 399);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(10, 13);
            this.labelState.TabIndex = 24;
            this.labelState.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(154, 421);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Playback Speed:";
            // 
            // labelPlaybackSpeed
            // 
            this.labelPlaybackSpeed.AutoSize = true;
            this.labelPlaybackSpeed.Location = new System.Drawing.Point(253, 421);
            this.labelPlaybackSpeed.Name = "labelPlaybackSpeed";
            this.labelPlaybackSpeed.Size = new System.Drawing.Size(13, 13);
            this.labelPlaybackSpeed.TabIndex = 26;
            this.labelPlaybackSpeed.Text = "1";
            // 
            // labelPlays
            // 
            this.labelPlays.Location = new System.Drawing.Point(327, 390);
            this.labelPlays.Name = "labelPlays";
            this.labelPlays.Size = new System.Drawing.Size(245, 53);
            this.labelPlays.TabIndex = 27;
            // 
            // buttonPause
            // 
            this.buttonPause.Location = new System.Drawing.Point(91, 369);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(75, 23);
            this.buttonPause.TabIndex = 28;
            this.buttonPause.Text = "Pause";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(172, 369);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(70, 23);
            this.buttonStop.TabIndex = 29;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.labelPlays);
            this.Controls.Add(this.labelPlaybackSpeed);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelVolume);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.LabelModelName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ClearListButton);
            this.Controls.Add(this.AddCarriageButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "VideoPlayer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button AddCarriageButton;
        private System.Windows.Forms.Button ClearListButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown MaxDuration;
        private System.Windows.Forms.NumericUpDown MinDuration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxOrder;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LabelModelName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownVolume;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxModelName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonModelName;
        private System.Windows.Forms.Button buttonVolume;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelPlaybackSpeed;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonPlaybackSpeed;
        private System.Windows.Forms.Label labelPlays;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonStop;
    }
}