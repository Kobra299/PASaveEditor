﻿namespace PASaveEditor {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.Label lOwnershipUnits;
            System.Windows.Forms.Label lBankLoanAmontUnits;
            System.Windows.Forms.Label lBankLoanAmount;
            System.Windows.Forms.Label lCreditRating;
            System.Windows.Forms.Label lCreditRatingUnits;
            System.Windows.Forms.Label lOwnership;
            System.Windows.Forms.Label lBalance;
            System.Windows.Forms.Label lBalanceUnits;
            System.Windows.Forms.ToolStripSeparator sReleasePrisonersSeparator;
            this.tabs = new System.Windows.Forms.TabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.xMisconduct = new System.Windows.Forms.CheckBox();
            this.xFogOfWar = new System.Windows.Forms.CheckBox();
            this.xFailureConditions = new System.Windows.Forms.CheckBox();
            this.xContinuousIntake = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cAmPm = new System.Windows.Forms.ComboBox();
            this.tTime = new System.Windows.Forms.MaskedTextBox();
            this.nDay = new System.Windows.Forms.NumericUpDown();
            this.lDay = new System.Windows.Forms.Label();
            this.lTime = new System.Windows.Forms.Label();
            this.tpFinance = new System.Windows.Forms.TabPage();
            this.nOwnership = new System.Windows.Forms.NumericUpDown();
            this.xUnlimitedFunds = new System.Windows.Forms.CheckBox();
            this.nBankLoanAmount = new System.Windows.Forms.NumericUpDown();
            this.nCreditRating = new System.Windows.Forms.NumericUpDown();
            this.nBalance = new System.Windows.Forms.NumericUpDown();
            this.tpPrisoners = new System.Windows.Forms.TabPage();
            this.tpResearch = new System.Windows.Forms.TabPage();
            this.clbResearch = new System.Windows.Forms.CheckedListBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.miShortcuts = new System.Windows.Forms.ToolStripMenuItem();
            this.miReleasePrisoners = new System.Windows.Forms.ToolStripMenuItem();
            this.miReleaseProtectiveCustody = new System.Windows.Forms.ToolStripMenuItem();
            this.miReleaseMinimumSecurity = new System.Windows.Forms.ToolStripMenuItem();
            this.miReleaseNormalSecurity = new System.Windows.Forms.ToolStripMenuItem();
            this.miReleaseMaximumSecurity = new System.Windows.Forms.ToolStripMenuItem();
            this.miReleaseSuperMax = new System.Windows.Forms.ToolStripMenuItem();
            this.miReleaseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.miRemoveTunnels = new System.Windows.Forms.ToolStripMenuItem();
            this.miUnlockAllResearch = new System.Windows.Forms.ToolStripMenuItem();
            this.miRemoveAllTrees = new System.Windows.Forms.ToolStripMenuItem();
            lOwnershipUnits = new System.Windows.Forms.Label();
            lBankLoanAmontUnits = new System.Windows.Forms.Label();
            lBankLoanAmount = new System.Windows.Forms.Label();
            lCreditRating = new System.Windows.Forms.Label();
            lCreditRatingUnits = new System.Windows.Forms.Label();
            lOwnership = new System.Windows.Forms.Label();
            lBalance = new System.Windows.Forms.Label();
            lBalanceUnits = new System.Windows.Forms.Label();
            sReleasePrisonersSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tabs.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nDay)).BeginInit();
            this.tpFinance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nOwnership)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBankLoanAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCreditRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBalance)).BeginInit();
            this.tpResearch.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lOwnershipUnits
            // 
            lOwnershipUnits.AutoSize = true;
            lOwnershipUnits.Location = new System.Drawing.Point(178, 121);
            lOwnershipUnits.Name = "lOwnershipUnits";
            lOwnershipUnits.Size = new System.Drawing.Size(15, 13);
            lOwnershipUnits.TabIndex = 15;
            lOwnershipUnits.Text = "%";
            // 
            // lBankLoanAmontUnits
            // 
            lBankLoanAmontUnits.AutoSize = true;
            lBankLoanAmontUnits.Location = new System.Drawing.Point(178, 69);
            lBankLoanAmontUnits.Name = "lBankLoanAmontUnits";
            lBankLoanAmontUnits.Size = new System.Drawing.Size(13, 13);
            lBankLoanAmontUnits.TabIndex = 13;
            lBankLoanAmontUnits.Text = "$";
            // 
            // lBankLoanAmount
            // 
            lBankLoanAmount.AutoSize = true;
            lBankLoanAmount.Location = new System.Drawing.Point(11, 69);
            lBankLoanAmount.Name = "lBankLoanAmount";
            lBankLoanAmount.Size = new System.Drawing.Size(93, 13);
            lBankLoanAmount.TabIndex = 5;
            lBankLoanAmount.Text = "Bank loan amount";
            // 
            // lCreditRating
            // 
            lCreditRating.AutoSize = true;
            lCreditRating.Location = new System.Drawing.Point(41, 95);
            lCreditRating.Name = "lCreditRating";
            lCreditRating.Size = new System.Drawing.Size(63, 13);
            lCreditRating.TabIndex = 4;
            lCreditRating.Text = "Credit rating";
            // 
            // lCreditRatingUnits
            // 
            lCreditRatingUnits.AutoSize = true;
            lCreditRatingUnits.Location = new System.Drawing.Point(178, 95);
            lCreditRatingUnits.Name = "lCreditRatingUnits";
            lCreditRatingUnits.Size = new System.Drawing.Size(15, 13);
            lCreditRatingUnits.TabIndex = 11;
            lCreditRatingUnits.Text = "%";
            // 
            // lOwnership
            // 
            lOwnership.AutoSize = true;
            lOwnership.Location = new System.Drawing.Point(47, 121);
            lOwnership.Name = "lOwnership";
            lOwnership.Size = new System.Drawing.Size(57, 13);
            lOwnership.TabIndex = 6;
            lOwnership.Text = "Ownership";
            // 
            // lBalance
            // 
            lBalance.AutoSize = true;
            lBalance.Location = new System.Drawing.Point(58, 43);
            lBalance.Name = "lBalance";
            lBalance.Size = new System.Drawing.Size(46, 13);
            lBalance.TabIndex = 3;
            lBalance.Text = "Balance";
            // 
            // lBalanceUnits
            // 
            lBalanceUnits.AutoSize = true;
            lBalanceUnits.Location = new System.Drawing.Point(178, 43);
            lBalanceUnits.Name = "lBalanceUnits";
            lBalanceUnits.Size = new System.Drawing.Size(13, 13);
            lBalanceUnits.TabIndex = 9;
            lBalanceUnits.Text = "$";
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tpGeneral);
            this.tabs.Controls.Add(this.tpFinance);
            this.tabs.Controls.Add(this.tpPrisoners);
            this.tabs.Controls.Add(this.tpResearch);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 24);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(484, 388);
            this.tabs.TabIndex = 0;
            // 
            // tpGeneral
            // 
            this.tpGeneral.Controls.Add(this.groupBox2);
            this.tpGeneral.Controls.Add(this.groupBox1);
            this.tpGeneral.Location = new System.Drawing.Point(4, 22);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Size = new System.Drawing.Size(476, 362);
            this.tpGeneral.TabIndex = 4;
            this.tpGeneral.Text = "General";
            this.tpGeneral.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.xMisconduct);
            this.groupBox2.Controls.Add(this.xFogOfWar);
            this.groupBox2.Controls.Add(this.xFailureConditions);
            this.groupBox2.Controls.Add(this.xContinuousIntake);
            this.groupBox2.Location = new System.Drawing.Point(8, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 123);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prison Settings";
            // 
            // xMisconduct
            // 
            this.xMisconduct.AutoSize = true;
            this.xMisconduct.Location = new System.Drawing.Point(23, 88);
            this.xMisconduct.Name = "xMisconduct";
            this.xMisconduct.Size = new System.Drawing.Size(81, 17);
            this.xMisconduct.TabIndex = 3;
            this.xMisconduct.Text = "Misconduct";
            this.xMisconduct.UseVisualStyleBackColor = true;
            // 
            // xFogOfWar
            // 
            this.xFogOfWar.AutoSize = true;
            this.xFogOfWar.Location = new System.Drawing.Point(23, 65);
            this.xFogOfWar.Name = "xFogOfWar";
            this.xFogOfWar.Size = new System.Drawing.Size(76, 17);
            this.xFogOfWar.TabIndex = 2;
            this.xFogOfWar.Text = "Fog of war";
            this.xFogOfWar.UseVisualStyleBackColor = true;
            // 
            // xFailureConditions
            // 
            this.xFailureConditions.AutoSize = true;
            this.xFailureConditions.Location = new System.Drawing.Point(23, 42);
            this.xFailureConditions.Name = "xFailureConditions";
            this.xFailureConditions.Size = new System.Drawing.Size(108, 17);
            this.xFailureConditions.TabIndex = 1;
            this.xFailureConditions.Text = "Failure conditions";
            this.xFailureConditions.UseVisualStyleBackColor = true;
            // 
            // xContinuousIntake
            // 
            this.xContinuousIntake.AutoSize = true;
            this.xContinuousIntake.Location = new System.Drawing.Point(23, 19);
            this.xContinuousIntake.Name = "xContinuousIntake";
            this.xContinuousIntake.Size = new System.Drawing.Size(111, 17);
            this.xContinuousIntake.TabIndex = 0;
            this.xContinuousIntake.Text = "Continuous intake";
            this.xContinuousIntake.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cAmPm);
            this.groupBox1.Controls.Add(this.tTime);
            this.groupBox1.Controls.Add(this.nDay);
            this.groupBox1.Controls.Add(this.lDay);
            this.groupBox1.Controls.Add(this.lTime);
            this.groupBox1.Location = new System.Drawing.Point(8, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 95);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "In-game time";
            // 
            // cAmPm
            // 
            this.cAmPm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cAmPm.FormattingEnabled = true;
            this.cAmPm.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cAmPm.Location = new System.Drawing.Point(108, 53);
            this.cAmPm.Name = "cAmPm";
            this.cAmPm.Size = new System.Drawing.Size(44, 21);
            this.cAmPm.TabIndex = 4;
            // 
            // tTime
            // 
            this.tTime.Location = new System.Drawing.Point(52, 53);
            this.tTime.Mask = "90:00";
            this.tTime.Name = "tTime";
            this.tTime.Size = new System.Drawing.Size(50, 20);
            this.tTime.TabIndex = 3;
            this.tTime.ValidatingType = typeof(System.DateTime);
            // 
            // nDay
            // 
            this.nDay.Location = new System.Drawing.Point(52, 27);
            this.nDay.Name = "nDay";
            this.nDay.Size = new System.Drawing.Size(50, 20);
            this.nDay.TabIndex = 2;
            // 
            // lDay
            // 
            this.lDay.AutoSize = true;
            this.lDay.Location = new System.Drawing.Point(20, 29);
            this.lDay.Name = "lDay";
            this.lDay.Size = new System.Drawing.Size(26, 13);
            this.lDay.TabIndex = 0;
            this.lDay.Text = "Day";
            // 
            // lTime
            // 
            this.lTime.AutoSize = true;
            this.lTime.Location = new System.Drawing.Point(16, 56);
            this.lTime.Name = "lTime";
            this.lTime.Size = new System.Drawing.Size(30, 13);
            this.lTime.TabIndex = 1;
            this.lTime.Text = "Time";
            // 
            // tpFinance
            // 
            this.tpFinance.Controls.Add(lOwnershipUnits);
            this.tpFinance.Controls.Add(this.nOwnership);
            this.tpFinance.Controls.Add(this.xUnlimitedFunds);
            this.tpFinance.Controls.Add(lBankLoanAmontUnits);
            this.tpFinance.Controls.Add(lBankLoanAmount);
            this.tpFinance.Controls.Add(this.nBankLoanAmount);
            this.tpFinance.Controls.Add(lCreditRating);
            this.tpFinance.Controls.Add(lCreditRatingUnits);
            this.tpFinance.Controls.Add(lOwnership);
            this.tpFinance.Controls.Add(this.nCreditRating);
            this.tpFinance.Controls.Add(lBalance);
            this.tpFinance.Controls.Add(lBalanceUnits);
            this.tpFinance.Controls.Add(this.nBalance);
            this.tpFinance.Location = new System.Drawing.Point(4, 22);
            this.tpFinance.Name = "tpFinance";
            this.tpFinance.Padding = new System.Windows.Forms.Padding(3);
            this.tpFinance.Size = new System.Drawing.Size(476, 362);
            this.tpFinance.TabIndex = 5;
            this.tpFinance.Text = "Finance";
            this.tpFinance.UseVisualStyleBackColor = true;
            // 
            // nOwnership
            // 
            this.nOwnership.Location = new System.Drawing.Point(110, 119);
            this.nOwnership.Name = "nOwnership";
            this.nOwnership.Size = new System.Drawing.Size(62, 20);
            this.nOwnership.TabIndex = 14;
            this.nOwnership.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // xUnlimitedFunds
            // 
            this.xUnlimitedFunds.AutoSize = true;
            this.xUnlimitedFunds.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.xUnlimitedFunds.Location = new System.Drawing.Point(26, 17);
            this.xUnlimitedFunds.Name = "xUnlimitedFunds";
            this.xUnlimitedFunds.Size = new System.Drawing.Size(98, 17);
            this.xUnlimitedFunds.TabIndex = 7;
            this.xUnlimitedFunds.Text = "Unlimited funds";
            this.xUnlimitedFunds.UseVisualStyleBackColor = true;
            // 
            // nBankLoanAmount
            // 
            this.nBankLoanAmount.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nBankLoanAmount.Location = new System.Drawing.Point(110, 67);
            this.nBankLoanAmount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nBankLoanAmount.Name = "nBankLoanAmount";
            this.nBankLoanAmount.Size = new System.Drawing.Size(62, 20);
            this.nBankLoanAmount.TabIndex = 12;
            // 
            // nCreditRating
            // 
            this.nCreditRating.Location = new System.Drawing.Point(110, 93);
            this.nCreditRating.Name = "nCreditRating";
            this.nCreditRating.Size = new System.Drawing.Size(62, 20);
            this.nCreditRating.TabIndex = 10;
            this.nCreditRating.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nBalance
            // 
            this.nBalance.Location = new System.Drawing.Point(110, 41);
            this.nBalance.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nBalance.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.nBalance.Name = "nBalance";
            this.nBalance.Size = new System.Drawing.Size(62, 20);
            this.nBalance.TabIndex = 8;
            // 
            // tpPrisoners
            // 
            this.tpPrisoners.Location = new System.Drawing.Point(4, 22);
            this.tpPrisoners.Name = "tpPrisoners";
            this.tpPrisoners.Size = new System.Drawing.Size(476, 362);
            this.tpPrisoners.TabIndex = 2;
            this.tpPrisoners.Text = "Prisoners";
            this.tpPrisoners.UseVisualStyleBackColor = true;
            // 
            // tpResearch
            // 
            this.tpResearch.Controls.Add(this.clbResearch);
            this.tpResearch.Location = new System.Drawing.Point(4, 22);
            this.tpResearch.Name = "tpResearch";
            this.tpResearch.Size = new System.Drawing.Size(476, 362);
            this.tpResearch.TabIndex = 3;
            this.tpResearch.Text = "Research";
            this.tpResearch.UseVisualStyleBackColor = true;
            // 
            // clbResearch
            // 
            this.clbResearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbResearch.FormattingEnabled = true;
            this.clbResearch.Location = new System.Drawing.Point(0, 0);
            this.clbResearch.Name = "clbResearch";
            this.clbResearch.Size = new System.Drawing.Size(476, 362);
            this.clbResearch.TabIndex = 0;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile,
            this.miShortcuts});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(484, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // miFile
            // 
            this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFileOpen,
            this.miFileSave,
            this.miFileSaveAs,
            this.miExit});
            this.miFile.Name = "miFile";
            this.miFile.Size = new System.Drawing.Size(37, 20);
            this.miFile.Text = "File";
            // 
            // miFileOpen
            // 
            this.miFileOpen.Name = "miFileOpen";
            this.miFileOpen.Size = new System.Drawing.Size(152, 22);
            this.miFileOpen.Text = "Open...";
            this.miFileOpen.Click += new System.EventHandler(this.miFileOpen_Click);
            // 
            // miFileSave
            // 
            this.miFileSave.Name = "miFileSave";
            this.miFileSave.Size = new System.Drawing.Size(152, 22);
            this.miFileSave.Text = "Save";
            // 
            // miFileSaveAs
            // 
            this.miFileSaveAs.Name = "miFileSaveAs";
            this.miFileSaveAs.Size = new System.Drawing.Size(152, 22);
            this.miFileSaveAs.Text = "Save As...";
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(152, 22);
            this.miExit.Text = "Exit";
            // 
            // miShortcuts
            // 
            this.miShortcuts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miReleasePrisoners,
            this.miRemoveTunnels,
            this.miUnlockAllResearch,
            this.miRemoveAllTrees});
            this.miShortcuts.Name = "miShortcuts";
            this.miShortcuts.Size = new System.Drawing.Size(69, 20);
            this.miShortcuts.Text = "Shortcuts";
            // 
            // miReleasePrisoners
            // 
            this.miReleasePrisoners.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miReleaseProtectiveCustody,
            this.miReleaseMinimumSecurity,
            this.miReleaseNormalSecurity,
            this.miReleaseMaximumSecurity,
            this.miReleaseSuperMax,
            sReleasePrisonersSeparator,
            this.miReleaseAll});
            this.miReleasePrisoners.Name = "miReleasePrisoners";
            this.miReleasePrisoners.Size = new System.Drawing.Size(173, 22);
            this.miReleasePrisoners.Text = "Release prisoners";
            // 
            // miReleaseProtectiveCustody
            // 
            this.miReleaseProtectiveCustody.Name = "miReleaseProtectiveCustody";
            this.miReleaseProtectiveCustody.Size = new System.Drawing.Size(174, 22);
            this.miReleaseProtectiveCustody.Text = "Protective Custody";
            this.miReleaseProtectiveCustody.Click += new System.EventHandler(this.miReleaseProtectiveCustody_Click);
            // 
            // miReleaseMinimumSecurity
            // 
            this.miReleaseMinimumSecurity.Name = "miReleaseMinimumSecurity";
            this.miReleaseMinimumSecurity.Size = new System.Drawing.Size(174, 22);
            this.miReleaseMinimumSecurity.Text = "Minimum Security";
            this.miReleaseMinimumSecurity.Click += new System.EventHandler(this.miReleaseMinimumSecurity_Click);
            // 
            // miReleaseNormalSecurity
            // 
            this.miReleaseNormalSecurity.Name = "miReleaseNormalSecurity";
            this.miReleaseNormalSecurity.Size = new System.Drawing.Size(174, 22);
            this.miReleaseNormalSecurity.Text = "Normal Security";
            this.miReleaseNormalSecurity.Click += new System.EventHandler(this.miReleaseNormalSecurity_Click);
            // 
            // miReleaseMaximumSecurity
            // 
            this.miReleaseMaximumSecurity.Name = "miReleaseMaximumSecurity";
            this.miReleaseMaximumSecurity.Size = new System.Drawing.Size(174, 22);
            this.miReleaseMaximumSecurity.Text = "Maximum Security";
            this.miReleaseMaximumSecurity.Click += new System.EventHandler(this.miReleaseMaximumSecurity_Click);
            // 
            // miReleaseSuperMax
            // 
            this.miReleaseSuperMax.Name = "miReleaseSuperMax";
            this.miReleaseSuperMax.Size = new System.Drawing.Size(174, 22);
            this.miReleaseSuperMax.Text = "SuperMax";
            this.miReleaseSuperMax.Click += new System.EventHandler(this.miReleaseSuperMax_Click);
            // 
            // sReleasePrisonersSeparator
            // 
            sReleasePrisonersSeparator.Name = "sReleasePrisonersSeparator";
            sReleasePrisonersSeparator.Size = new System.Drawing.Size(171, 6);
            // 
            // miReleaseAll
            // 
            this.miReleaseAll.Name = "miReleaseAll";
            this.miReleaseAll.Size = new System.Drawing.Size(174, 22);
            this.miReleaseAll.Text = "All";
            this.miReleaseAll.Click += new System.EventHandler(this.miReleaseAll_Click);
            // 
            // miRemoveTunnels
            // 
            this.miRemoveTunnels.Name = "miRemoveTunnels";
            this.miRemoveTunnels.Size = new System.Drawing.Size(173, 22);
            this.miRemoveTunnels.Text = "Remove tunnels";
            // 
            // miUnlockAllResearch
            // 
            this.miUnlockAllResearch.Name = "miUnlockAllResearch";
            this.miUnlockAllResearch.Size = new System.Drawing.Size(173, 22);
            this.miUnlockAllResearch.Text = "Unlock all research";
            this.miUnlockAllResearch.Click += new System.EventHandler(this.miUnlockAllResearch_Click);
            // 
            // miRemoveAllTrees
            // 
            this.miRemoveAllTrees.Name = "miRemoveAllTrees";
            this.miRemoveAllTrees.Size = new System.Drawing.Size(173, 22);
            this.miRemoveAllTrees.Text = "Remove all trees";
            this.miRemoveAllTrees.Click += new System.EventHandler(this.miRemoveAllTrees_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 412);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "MainForm";
            this.Text = "Prison Architect Save Editor";
            this.tabs.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nDay)).EndInit();
            this.tpFinance.ResumeLayout(false);
            this.tpFinance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nOwnership)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBankLoanAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCreditRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBalance)).EndInit();
            this.tpResearch.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.TabPage tpPrisoners;
        private System.Windows.Forms.TabPage tpResearch;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem miFile;
        private System.Windows.Forms.ToolStripMenuItem miFileOpen;
        private System.Windows.Forms.ToolStripMenuItem miFileSave;
        private System.Windows.Forms.ToolStripMenuItem miFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cAmPm;
        private System.Windows.Forms.MaskedTextBox tTime;
        private System.Windows.Forms.NumericUpDown nDay;
        private System.Windows.Forms.Label lDay;
        private System.Windows.Forms.Label lTime;
        private System.Windows.Forms.TabPage tpFinance;
        private System.Windows.Forms.NumericUpDown nOwnership;
        private System.Windows.Forms.CheckBox xUnlimitedFunds;
        private System.Windows.Forms.NumericUpDown nBankLoanAmount;
        private System.Windows.Forms.NumericUpDown nCreditRating;
        private System.Windows.Forms.NumericUpDown nBalance;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox xFailureConditions;
        private System.Windows.Forms.CheckBox xContinuousIntake;
        private System.Windows.Forms.CheckBox xFogOfWar;
        private System.Windows.Forms.CheckBox xMisconduct;
        private System.Windows.Forms.ToolStripMenuItem miShortcuts;
        private System.Windows.Forms.ToolStripMenuItem miReleasePrisoners;
        private System.Windows.Forms.ToolStripMenuItem miReleaseProtectiveCustody;
        private System.Windows.Forms.ToolStripMenuItem miReleaseMinimumSecurity;
        private System.Windows.Forms.ToolStripMenuItem miReleaseNormalSecurity;
        private System.Windows.Forms.ToolStripMenuItem miReleaseMaximumSecurity;
        private System.Windows.Forms.ToolStripMenuItem miReleaseSuperMax;
        private System.Windows.Forms.ToolStripMenuItem miReleaseAll;
        private System.Windows.Forms.ToolStripMenuItem miRemoveTunnels;
        private System.Windows.Forms.ToolStripMenuItem miUnlockAllResearch;
        private System.Windows.Forms.ToolStripMenuItem miRemoveAllTrees;
        private System.Windows.Forms.CheckedListBox clbResearch;
    }
}

