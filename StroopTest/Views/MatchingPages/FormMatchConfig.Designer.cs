﻿namespace TestPlatform.Views.MatchingPages
{
    partial class FormMatchConfig
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMatchConfig));
            this.panel1 = new System.Windows.Forms.Panel();
            this.othersGroupBox = new System.Windows.Forms.GroupBox();
            this.stimulusDistance = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.colorGroupBox = new System.Windows.Forms.GroupBox();
            this.DNMTSColorPanel = new System.Windows.Forms.Panel();
            this.DMTSColorPanel = new System.Windows.Forms.Panel();
            this.DMTSBackgroundColor = new System.Windows.Forms.Label();
            this.DNMTSBackgroundColor = new System.Windows.Forms.Label();
            this.DNMTSBackground = new System.Windows.Forms.Button();
            this.DMTSBackground = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timeGroupBox = new System.Windows.Forms.GroupBox();
            this.stimulusInterval = new System.Windows.Forms.NumericUpDown();
            this.stimulusExpoTime = new System.Windows.Forms.NumericUpDown();
            this.attemptInterval = new System.Windows.Forms.NumericUpDown();
            this.modelExpoTime = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listGroupBox = new System.Windows.Forms.GroupBox();
            this.openAudioListButton = new System.Windows.Forms.Button();
            this.openImgListButton = new System.Windows.Forms.Button();
            this.openColorListButton = new System.Windows.Forms.Button();
            this.openWordListButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wordLabel = new System.Windows.Forms.Label();
            this.expositionGroupBox = new System.Windows.Forms.GroupBox();
            this.randomAttemptTime = new System.Windows.Forms.CheckBox();
            this.randomOrder = new System.Windows.Forms.CheckBox();
            this.dispositionLabel = new System.Windows.Forms.Label();
            this.ExpoDisposition = new System.Windows.Forms.ComboBox();
            this.expositionType = new System.Windows.Forms.ComboBox();
            this.expositionTypeLabel = new System.Windows.Forms.Label();
            this.closeExpoAWithClick = new System.Windows.Forms.CheckBox();
            this.numExpoLabel = new System.Windows.Forms.Label();
            this.randomPosition = new System.Windows.Forms.CheckBox();
            this.expoSizeLabel = new System.Windows.Forms.Label();
            this.numExpo = new System.Windows.Forms.NumericUpDown();
            this.expositionSize = new System.Windows.Forms.NumericUpDown();
            this.stimulusNumberLabel = new System.Windows.Forms.Label();
            this.attemptNumber = new System.Windows.Forms.NumericUpDown();
            this.programName = new System.Windows.Forms.TextBox();
            this.programNameLabel = new System.Windows.Forms.Label();
            this.helpButton = new System.Windows.Forms.Button();
            this.instructionsBox = new System.Windows.Forms.TextBox();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.positionsComboBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.othersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stimulusDistance)).BeginInit();
            this.colorGroupBox.SuspendLayout();
            this.timeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stimulusInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stimulusExpoTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attemptInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelExpoTime)).BeginInit();
            this.listGroupBox.SuspendLayout();
            this.expositionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numExpo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expositionSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attemptNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.othersGroupBox);
            this.panel1.Controls.Add(this.colorGroupBox);
            this.panel1.Controls.Add(this.timeGroupBox);
            this.panel1.Controls.Add(this.listGroupBox);
            this.panel1.Controls.Add(this.expositionGroupBox);
            this.panel1.Controls.Add(this.programName);
            this.panel1.Controls.Add(this.programNameLabel);
            this.panel1.Controls.Add(this.helpButton);
            this.panel1.Controls.Add(this.instructionsBox);
            this.panel1.Controls.Add(this.instructionsLabel);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // othersGroupBox
            // 
            this.othersGroupBox.Controls.Add(this.positionsComboBox);
            this.othersGroupBox.Controls.Add(this.label11);
            this.othersGroupBox.Controls.Add(this.stimulusDistance);
            this.othersGroupBox.Controls.Add(this.label10);
            resources.ApplyResources(this.othersGroupBox, "othersGroupBox");
            this.othersGroupBox.Name = "othersGroupBox";
            this.othersGroupBox.TabStop = false;
            // 
            // stimulusDistance
            // 
            resources.ApplyResources(this.stimulusDistance, "stimulusDistance");
            this.stimulusDistance.Maximum = new decimal(new int[] {
            490,
            0,
            0,
            0});
            this.stimulusDistance.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.stimulusDistance.Name = "stimulusDistance";
            this.stimulusDistance.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // colorGroupBox
            // 
            this.colorGroupBox.Controls.Add(this.DNMTSColorPanel);
            this.colorGroupBox.Controls.Add(this.DMTSColorPanel);
            this.colorGroupBox.Controls.Add(this.DMTSBackgroundColor);
            this.colorGroupBox.Controls.Add(this.DNMTSBackgroundColor);
            this.colorGroupBox.Controls.Add(this.DNMTSBackground);
            this.colorGroupBox.Controls.Add(this.DMTSBackground);
            this.colorGroupBox.Controls.Add(this.label9);
            this.colorGroupBox.Controls.Add(this.label8);
            resources.ApplyResources(this.colorGroupBox, "colorGroupBox");
            this.colorGroupBox.Name = "colorGroupBox";
            this.colorGroupBox.TabStop = false;
            // 
            // DNMTSColorPanel
            // 
            this.DNMTSColorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DNMTSColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.DNMTSColorPanel, "DNMTSColorPanel");
            this.DNMTSColorPanel.Name = "DNMTSColorPanel";
            // 
            // DMTSColorPanel
            // 
            this.DMTSColorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.DMTSColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.DMTSColorPanel, "DMTSColorPanel");
            this.DMTSColorPanel.Name = "DMTSColorPanel";
            // 
            // DMTSBackgroundColor
            // 
            resources.ApplyResources(this.DMTSBackgroundColor, "DMTSBackgroundColor");
            this.DMTSBackgroundColor.Name = "DMTSBackgroundColor";
            // 
            // DNMTSBackgroundColor
            // 
            resources.ApplyResources(this.DNMTSBackgroundColor, "DNMTSBackgroundColor");
            this.DNMTSBackgroundColor.Name = "DNMTSBackgroundColor";
            // 
            // DNMTSBackground
            // 
            this.DNMTSBackground.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.DNMTSBackground, "DNMTSBackground");
            this.DNMTSBackground.Name = "DNMTSBackground";
            this.DNMTSBackground.UseVisualStyleBackColor = false;
            this.DNMTSBackground.Click += new System.EventHandler(this.DMNTSBackground_Click);
            // 
            // DMTSBackground
            // 
            this.DMTSBackground.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.DMTSBackground, "DMTSBackground");
            this.DMTSBackground.Name = "DMTSBackground";
            this.DMTSBackground.UseVisualStyleBackColor = false;
            this.DMTSBackground.Click += new System.EventHandler(this.DMTSBackground_Click);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // timeGroupBox
            // 
            this.timeGroupBox.Controls.Add(this.stimulusInterval);
            this.timeGroupBox.Controls.Add(this.stimulusExpoTime);
            this.timeGroupBox.Controls.Add(this.attemptInterval);
            this.timeGroupBox.Controls.Add(this.modelExpoTime);
            this.timeGroupBox.Controls.Add(this.label7);
            this.timeGroupBox.Controls.Add(this.label6);
            this.timeGroupBox.Controls.Add(this.label5);
            this.timeGroupBox.Controls.Add(this.label1);
            resources.ApplyResources(this.timeGroupBox, "timeGroupBox");
            this.timeGroupBox.Name = "timeGroupBox";
            this.timeGroupBox.TabStop = false;
            // 
            // stimulusInterval
            // 
            this.stimulusInterval.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            resources.ApplyResources(this.stimulusInterval, "stimulusInterval");
            this.stimulusInterval.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.stimulusInterval.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.stimulusInterval.Name = "stimulusInterval";
            this.stimulusInterval.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // stimulusExpoTime
            // 
            this.stimulusExpoTime.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            resources.ApplyResources(this.stimulusExpoTime, "stimulusExpoTime");
            this.stimulusExpoTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.stimulusExpoTime.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.stimulusExpoTime.Name = "stimulusExpoTime";
            this.stimulusExpoTime.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // attemptInterval
            // 
            this.attemptInterval.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            resources.ApplyResources(this.attemptInterval, "attemptInterval");
            this.attemptInterval.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.attemptInterval.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.attemptInterval.Name = "attemptInterval";
            this.attemptInterval.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // modelExpoTime
            // 
            this.modelExpoTime.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            resources.ApplyResources(this.modelExpoTime, "modelExpoTime");
            this.modelExpoTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.modelExpoTime.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.modelExpoTime.Name = "modelExpoTime";
            this.modelExpoTime.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // listGroupBox
            // 
            this.listGroupBox.Controls.Add(this.openAudioListButton);
            this.listGroupBox.Controls.Add(this.openImgListButton);
            this.listGroupBox.Controls.Add(this.openColorListButton);
            this.listGroupBox.Controls.Add(this.openWordListButton);
            this.listGroupBox.Controls.Add(this.label4);
            this.listGroupBox.Controls.Add(this.label3);
            this.listGroupBox.Controls.Add(this.label2);
            this.listGroupBox.Controls.Add(this.wordLabel);
            resources.ApplyResources(this.listGroupBox, "listGroupBox");
            this.listGroupBox.Name = "listGroupBox";
            this.listGroupBox.TabStop = false;
            this.listGroupBox.Enter += new System.EventHandler(this.listGroupBox_Enter);
            // 
            // openAudioListButton
            // 
            resources.ApplyResources(this.openAudioListButton, "openAudioListButton");
            this.openAudioListButton.Name = "openAudioListButton";
            this.openAudioListButton.UseVisualStyleBackColor = true;
            this.openAudioListButton.Click += new System.EventHandler(this.openAudioList_Click);
            this.openAudioListButton.Validating += new System.ComponentModel.CancelEventHandler(this.openAudioListButton_Validating);
            this.openAudioListButton.Validated += new System.EventHandler(this.openAudioListButton_Validated);
            // 
            // openImgListButton
            // 
            resources.ApplyResources(this.openImgListButton, "openImgListButton");
            this.openImgListButton.Name = "openImgListButton";
            this.openImgListButton.UseVisualStyleBackColor = true;
            this.openImgListButton.Click += new System.EventHandler(this.openImagesList_Click);
            this.openImgListButton.Validating += new System.ComponentModel.CancelEventHandler(this.openImgListButton_Validating);
            this.openImgListButton.Validated += new System.EventHandler(this.openImgListButton_Validated);
            // 
            // openColorListButton
            // 
            resources.ApplyResources(this.openColorListButton, "openColorListButton");
            this.openColorListButton.Name = "openColorListButton";
            this.openColorListButton.UseVisualStyleBackColor = true;
            this.openColorListButton.Click += new System.EventHandler(this.openColorsList_Click);
            this.openColorListButton.Validating += new System.ComponentModel.CancelEventHandler(this.openColorListButton_Validating);
            this.openColorListButton.Validated += new System.EventHandler(this.openColorListButton_Validated);
            // 
            // openWordListButton
            // 
            resources.ApplyResources(this.openWordListButton, "openWordListButton");
            this.openWordListButton.Name = "openWordListButton";
            this.openWordListButton.UseVisualStyleBackColor = true;
            this.openWordListButton.Click += new System.EventHandler(this.openWordsList_Click);
            this.openWordListButton.Validating += new System.ComponentModel.CancelEventHandler(this.openWordListButton_Validating);
            this.openWordListButton.Validated += new System.EventHandler(this.openWordListButton_Validated);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // wordLabel
            // 
            resources.ApplyResources(this.wordLabel, "wordLabel");
            this.wordLabel.Name = "wordLabel";
            // 
            // expositionGroupBox
            // 
            this.expositionGroupBox.Controls.Add(this.randomAttemptTime);
            this.expositionGroupBox.Controls.Add(this.randomOrder);
            this.expositionGroupBox.Controls.Add(this.dispositionLabel);
            this.expositionGroupBox.Controls.Add(this.ExpoDisposition);
            this.expositionGroupBox.Controls.Add(this.expositionType);
            this.expositionGroupBox.Controls.Add(this.expositionTypeLabel);
            this.expositionGroupBox.Controls.Add(this.closeExpoAWithClick);
            this.expositionGroupBox.Controls.Add(this.numExpoLabel);
            this.expositionGroupBox.Controls.Add(this.randomPosition);
            this.expositionGroupBox.Controls.Add(this.expoSizeLabel);
            this.expositionGroupBox.Controls.Add(this.numExpo);
            this.expositionGroupBox.Controls.Add(this.expositionSize);
            this.expositionGroupBox.Controls.Add(this.stimulusNumberLabel);
            this.expositionGroupBox.Controls.Add(this.attemptNumber);
            resources.ApplyResources(this.expositionGroupBox, "expositionGroupBox");
            this.expositionGroupBox.Name = "expositionGroupBox";
            this.expositionGroupBox.TabStop = false;
            // 
            // randomAttemptTime
            // 
            resources.ApplyResources(this.randomAttemptTime, "randomAttemptTime");
            this.randomAttemptTime.Name = "randomAttemptTime";
            this.randomAttemptTime.UseVisualStyleBackColor = true;
            // 
            // randomOrder
            // 
            resources.ApplyResources(this.randomOrder, "randomOrder");
            this.randomOrder.Name = "randomOrder";
            this.randomOrder.UseVisualStyleBackColor = true;
            // 
            // dispositionLabel
            // 
            resources.ApplyResources(this.dispositionLabel, "dispositionLabel");
            this.dispositionLabel.Name = "dispositionLabel";
            // 
            // ExpoDisposition
            // 
            this.ExpoDisposition.FormattingEnabled = true;
            this.ExpoDisposition.Items.AddRange(new object[] {
            resources.GetString("ExpoDisposition.Items")});
            resources.ApplyResources(this.ExpoDisposition, "ExpoDisposition");
            this.ExpoDisposition.Name = "ExpoDisposition";
            this.ExpoDisposition.Validating += new System.ComponentModel.CancelEventHandler(this.ExpoDisposition_Validating);
            this.ExpoDisposition.Validated += new System.EventHandler(this.ExpoDisposition_Validated);
            // 
            // expositionType
            // 
            this.expositionType.FormattingEnabled = true;
            this.expositionType.Items.AddRange(new object[] {
            resources.GetString("expositionType.Items"),
            resources.GetString("expositionType.Items1"),
            resources.GetString("expositionType.Items2")});
            resources.ApplyResources(this.expositionType, "expositionType");
            this.expositionType.Name = "expositionType";
            this.expositionType.SelectedIndexChanged += new System.EventHandler(this.expositionType_SelectedIndexChanged);
            this.expositionType.Validating += new System.ComponentModel.CancelEventHandler(this.expositionType_Validating);
            this.expositionType.Validated += new System.EventHandler(this.expositionType_Validated);
            // 
            // expositionTypeLabel
            // 
            resources.ApplyResources(this.expositionTypeLabel, "expositionTypeLabel");
            this.expositionTypeLabel.Name = "expositionTypeLabel";
            // 
            // closeExpoAWithClick
            // 
            resources.ApplyResources(this.closeExpoAWithClick, "closeExpoAWithClick");
            this.closeExpoAWithClick.Name = "closeExpoAWithClick";
            this.closeExpoAWithClick.UseVisualStyleBackColor = true;
            // 
            // numExpoLabel
            // 
            resources.ApplyResources(this.numExpoLabel, "numExpoLabel");
            this.numExpoLabel.Name = "numExpoLabel";
            // 
            // randomPosition
            // 
            resources.ApplyResources(this.randomPosition, "randomPosition");
            this.randomPosition.Name = "randomPosition";
            this.randomPosition.UseVisualStyleBackColor = true;
            // 
            // expoSizeLabel
            // 
            resources.ApplyResources(this.expoSizeLabel, "expoSizeLabel");
            this.expoSizeLabel.Name = "expoSizeLabel";
            // 
            // numExpo
            // 
            resources.ApplyResources(this.numExpo, "numExpo");
            this.numExpo.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numExpo.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numExpo.Name = "numExpo";
            this.numExpo.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // expositionSize
            // 
            resources.ApplyResources(this.expositionSize, "expositionSize");
            this.expositionSize.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.expositionSize.Name = "expositionSize";
            this.expositionSize.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // stimulusNumberLabel
            // 
            resources.ApplyResources(this.stimulusNumberLabel, "stimulusNumberLabel");
            this.stimulusNumberLabel.Name = "stimulusNumberLabel";
            // 
            // attemptNumber
            // 
            resources.ApplyResources(this.attemptNumber, "attemptNumber");
            this.attemptNumber.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.attemptNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.attemptNumber.Name = "attemptNumber";
            this.attemptNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // programName
            // 
            resources.ApplyResources(this.programName, "programName");
            this.programName.Name = "programName";
            this.programName.Validating += new System.ComponentModel.CancelEventHandler(this.programName_Validating);
            this.programName.Validated += new System.EventHandler(this.programName_Validated);
            // 
            // programNameLabel
            // 
            resources.ApplyResources(this.programNameLabel, "programNameLabel");
            this.programNameLabel.Name = "programNameLabel";
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.helpButton.BackgroundImage = global::TestPlatform.Properties.Resources.helpButton;
            resources.ApplyResources(this.helpButton, "helpButton");
            this.helpButton.Name = "helpButton";
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // instructionsBox
            // 
            this.instructionsBox.AcceptsReturn = true;
            this.instructionsBox.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.instructionsBox, "instructionsBox");
            this.instructionsBox.Name = "instructionsBox";
            // 
            // instructionsLabel
            // 
            resources.ApplyResources(this.instructionsLabel, "instructionsLabel");
            this.instructionsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.instructionsLabel.Name = "instructionsLabel";
            // 
            // cancelButton
            // 
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.Name = "saveButton";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // positionsComboBox
            // 
            this.positionsComboBox.FormattingEnabled = true;
            this.positionsComboBox.Items.AddRange(new object[] {
            resources.GetString("positionsComboBox.Items"),
            resources.GetString("positionsComboBox.Items1"),
            resources.GetString("positionsComboBox.Items2"),
            resources.GetString("positionsComboBox.Items3")});
            resources.ApplyResources(this.positionsComboBox, "positionsComboBox");
            this.positionsComboBox.Name = "positionsComboBox";
            this.positionsComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.positionsComboBox_Validating);
            this.positionsComboBox.Validated += new System.EventHandler(this.positionsComboBox_Validated);
            // 
            // FormMatchConfig
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.panel1);
            this.Name = "FormMatchConfig";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.othersGroupBox.ResumeLayout(false);
            this.othersGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stimulusDistance)).EndInit();
            this.colorGroupBox.ResumeLayout(false);
            this.colorGroupBox.PerformLayout();
            this.timeGroupBox.ResumeLayout(false);
            this.timeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stimulusInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stimulusExpoTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attemptInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelExpoTime)).EndInit();
            this.listGroupBox.ResumeLayout(false);
            this.listGroupBox.PerformLayout();
            this.expositionGroupBox.ResumeLayout(false);
            this.expositionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numExpo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expositionSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attemptNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox instructionsBox;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.TextBox programName;
        private System.Windows.Forms.Label programNameLabel;
        private System.Windows.Forms.GroupBox expositionGroupBox;
        private System.Windows.Forms.ComboBox expositionType;
        private System.Windows.Forms.Label expositionTypeLabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.NumericUpDown numExpo;
        private System.Windows.Forms.Label stimulusNumberLabel;
        private System.Windows.Forms.NumericUpDown expositionSize;
        private System.Windows.Forms.Label expoSizeLabel;
        private System.Windows.Forms.Label numExpoLabel;
        private System.Windows.Forms.NumericUpDown attemptNumber;
        private System.Windows.Forms.Label dispositionLabel;
        private System.Windows.Forms.ComboBox ExpoDisposition;
        private System.Windows.Forms.CheckBox closeExpoAWithClick;
        private System.Windows.Forms.CheckBox randomPosition;
        private System.Windows.Forms.CheckBox randomOrder;
        private System.Windows.Forms.GroupBox listGroupBox;
        private System.Windows.Forms.Button openAudioListButton;
        private System.Windows.Forms.Button openImgListButton;
        private System.Windows.Forms.Button openColorListButton;
        private System.Windows.Forms.Button openWordListButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label wordLabel;
        private System.Windows.Forms.GroupBox timeGroupBox;
        private System.Windows.Forms.NumericUpDown stimulusInterval;
        private System.Windows.Forms.NumericUpDown stimulusExpoTime;
        private System.Windows.Forms.NumericUpDown attemptInterval;
        private System.Windows.Forms.NumericUpDown modelExpoTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox colorGroupBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button DNMTSBackground;
        private System.Windows.Forms.Button DMTSBackground;
        private System.Windows.Forms.Label DMTSBackgroundColor;
        private System.Windows.Forms.Label DNMTSBackgroundColor;
        private System.Windows.Forms.Panel DNMTSColorPanel;
        private System.Windows.Forms.Panel DMTSColorPanel;
        private System.Windows.Forms.CheckBox randomAttemptTime;
        private System.Windows.Forms.GroupBox othersGroupBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown stimulusDistance;
        private System.Windows.Forms.ComboBox positionsComboBox;
        private System.Windows.Forms.Label label11;
    }
}
