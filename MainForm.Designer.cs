using System;
using System.Collections;

namespace BinauralBeatsv1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPattern = new System.Windows.Forms.ListBox();
            this.bPlay = new System.Windows.Forms.Button();
            this.bStop = new System.Windows.Forms.Button();
            this.lDescription = new System.Windows.Forms.Label();
            this.tVolume = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.lError = new System.Windows.Forms.Label();
            this.linkLabelTutorial = new System.Windows.Forms.LinkLabel();
            this.linkLabelC = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select wave pattern:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wave pattern description";
            // 
            // lbPattern
            // 
            this.lbPattern.FormattingEnabled = true;
            this.lbPattern.ItemHeight = 20;
            this.lbPattern.Location = new System.Drawing.Point(48, 83);
            this.lbPattern.Name = "lbPattern";
            this.lbPattern.Size = new System.Drawing.Size(149, 84);
            this.lbPattern.TabIndex = 2;
            this.lbPattern.SelectedIndexChanged += new System.EventHandler(this.lbPattern_SelectedIndexChanged);
            // 
            // bPlay
            // 
            this.bPlay.Location = new System.Drawing.Point(48, 361);
            this.bPlay.Name = "bPlay";
            this.bPlay.Size = new System.Drawing.Size(86, 30);
            this.bPlay.TabIndex = 3;
            this.bPlay.Text = "Play";
            this.bPlay.UseVisualStyleBackColor = true;
            this.bPlay.Click += new System.EventHandler(this.bPlay_Click);
            // 
            // bStop
            // 
            this.bStop.Location = new System.Drawing.Point(158, 361);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(86, 30);
            this.bStop.TabIndex = 4;
            this.bStop.Text = "Stop";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // lDescription
            // 
            this.lDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lDescription.Location = new System.Drawing.Point(295, 83);
            this.lDescription.MaximumSize = new System.Drawing.Size(500, 140);
            this.lDescription.Name = "lDescription";
            this.lDescription.Size = new System.Drawing.Size(435, 140);
            this.lDescription.TabIndex = 6;
            // 
            // tVolume
            // 
            this.tVolume.Location = new System.Drawing.Point(65, 230);
            this.tVolume.Maximum = 100;
            this.tVolume.Name = "tVolume";
            this.tVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tVolume.Size = new System.Drawing.Size(69, 104);
            this.tVolume.TabIndex = 7;
            this.tVolume.Scroll += new System.EventHandler(this.tVolume_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Volume";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Time";
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "HH:mm:ss";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(140, 230);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(97, 26);
            this.timePicker.TabIndex = 10;
            this.timePicker.Value = new System.DateTime(2020, 5, 23, 0, 1, 0, 0);
            // 
            // lError
            // 
            this.lError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lError.Location = new System.Drawing.Point(295, 251);
            this.lError.MaximumSize = new System.Drawing.Size(500, 140);
            this.lError.Name = "lError";
            this.lError.Size = new System.Drawing.Size(435, 140);
            this.lError.TabIndex = 11;
            // 
            // linkLabelTutorial
            // 
            this.linkLabelTutorial.AutoSize = true;
            this.linkLabelTutorial.Location = new System.Drawing.Point(484, 12);
            this.linkLabelTutorial.Name = "linkLabelTutorial";
            this.linkLabelTutorial.Size = new System.Drawing.Size(61, 20);
            this.linkLabelTutorial.TabIndex = 12;
            this.linkLabelTutorial.TabStop = true;
            this.linkLabelTutorial.Text = "Tutorial";
            this.linkLabelTutorial.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelTutorial_LinkClicked);
            this.linkLabelTutorial.DoubleClick += new System.EventHandler(this.linkLabelTutorial_DoubleClick);
            // 
            // linkLabelC
            // 
            this.linkLabelC.AutoSize = true;
            this.linkLabelC.Location = new System.Drawing.Point(557, 12);
            this.linkLabelC.Name = "linkLabelC";
            this.linkLabelC.Size = new System.Drawing.Size(176, 20);
            this.linkLabelC.TabIndex = 13;
            this.linkLabelC.TabStop = true;
            this.linkLabelC.Text = "(c) Victoria Kazachenko";
            this.linkLabelC.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelC_LinkClicked);
            this.linkLabelC.DoubleClick += new System.EventHandler(this.linkLabelC_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(48, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(422, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Seek medical advice before using it or use at your own risk!";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 422);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabelC);
            this.Controls.Add(this.linkLabelTutorial);
            this.Controls.Add(this.lError);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tVolume);
            this.Controls.Add(this.lDescription);
            this.Controls.Add(this.bStop);
            this.Controls.Add(this.bPlay);
            this.Controls.Add(this.lbPattern);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Binaural Beats v1";
            ((System.ComponentModel.ISupportInitialize)(this.tVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbPattern;
        private System.Windows.Forms.Button bPlay;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Label lDescription;
        private System.Windows.Forms.TrackBar tVolume;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Label lError;
        private System.Windows.Forms.LinkLabel linkLabelTutorial;
        private System.Windows.Forms.LinkLabel linkLabelC;
        private System.Windows.Forms.Label label3;
    }
}

