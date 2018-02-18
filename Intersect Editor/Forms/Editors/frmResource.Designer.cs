﻿using DarkUI.Controls;

namespace Intersect.Editor.Classes
{
    partial class FrmResource
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmResource));
            this.grpResources = new DarkUI.Controls.DarkGroupBox();
            this.lstResources = new System.Windows.Forms.ListBox();
            this.grpGeneral = new DarkUI.Controls.DarkGroupBox();
            this.nudMaxHp = new DarkUI.Controls.DarkNumericUpDown();
            this.nudMinHp = new DarkUI.Controls.DarkNumericUpDown();
            this.nudSpawnDuration = new DarkUI.Controls.DarkNumericUpDown();
            this.cmbAnimation = new DarkUI.Controls.DarkComboBox();
            this.btnRequirements = new DarkUI.Controls.DarkButton();
            this.lblAnimation = new System.Windows.Forms.Label();
            this.lblMaxHp = new System.Windows.Forms.Label();
            this.lblSpawnDuration = new System.Windows.Forms.Label();
            this.chkWalkableAfter = new DarkUI.Controls.DarkCheckBox();
            this.chkWalkableBefore = new DarkUI.Controls.DarkCheckBox();
            this.cmbToolType = new DarkUI.Controls.DarkComboBox();
            this.lblToolType = new System.Windows.Forms.Label();
            this.lblHP = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new DarkUI.Controls.DarkTextBox();
            this.grpGraphics = new DarkUI.Controls.DarkGroupBox();
            this.exhaustedGraphicContainer = new System.Windows.Forms.Panel();
            this.picEndResource = new System.Windows.Forms.PictureBox();
            this.initalGraphicContainer = new System.Windows.Forms.Panel();
            this.picInitialResource = new System.Windows.Forms.PictureBox();
            this.cmbEndSprite = new DarkUI.Controls.DarkComboBox();
            this.lblPic2 = new System.Windows.Forms.Label();
            this.cmbInitialSprite = new DarkUI.Controls.DarkComboBox();
            this.lblPic = new System.Windows.Forms.Label();
            this.tmrRender = new System.Windows.Forms.Timer(this.components);
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.grpDrops = new DarkUI.Controls.DarkGroupBox();
            this.btnDropRemove = new DarkUI.Controls.DarkButton();
            this.btnDropAdd = new DarkUI.Controls.DarkButton();
            this.lstDrops = new System.Windows.Forms.ListBox();
            this.nudDropAmount = new DarkUI.Controls.DarkNumericUpDown();
            this.nudDropChance = new DarkUI.Controls.DarkNumericUpDown();
            this.cmbDropItem = new DarkUI.Controls.DarkComboBox();
            this.lblDropAmount = new System.Windows.Forms.Label();
            this.lblDropChance = new System.Windows.Forms.Label();
            this.lblDropItem = new System.Windows.Forms.Label();
            this.btnCancel = new DarkUI.Controls.DarkButton();
            this.btnSave = new DarkUI.Controls.DarkButton();
            this.toolStrip = new DarkUI.Controls.DarkToolStrip();
            this.toolStripItemNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripItemDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripItemCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripItemPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripItemUndo = new System.Windows.Forms.ToolStripButton();
            this.grpResources.SuspendLayout();
            this.grpGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxHp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinHp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpawnDuration)).BeginInit();
            this.grpGraphics.SuspendLayout();
            this.exhaustedGraphicContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEndResource)).BeginInit();
            this.initalGraphicContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInitialResource)).BeginInit();
            this.pnlContainer.SuspendLayout();
            this.grpDrops.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDropAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDropChance)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpResources
            // 
            this.grpResources.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpResources.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpResources.Controls.Add(this.lstResources);
            this.grpResources.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpResources.Location = new System.Drawing.Point(12, 39);
            this.grpResources.Name = "grpResources";
            this.grpResources.Size = new System.Drawing.Size(203, 437);
            this.grpResources.TabIndex = 14;
            this.grpResources.TabStop = false;
            this.grpResources.Text = "Resources";
            // 
            // lstResources
            // 
            this.lstResources.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.lstResources.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstResources.ForeColor = System.Drawing.Color.Gainsboro;
            this.lstResources.FormattingEnabled = true;
            this.lstResources.Location = new System.Drawing.Point(6, 19);
            this.lstResources.Name = "lstResources";
            this.lstResources.Size = new System.Drawing.Size(191, 405);
            this.lstResources.TabIndex = 1;
            this.lstResources.SelectedIndexChanged += new System.EventHandler(this.lstResources_Click);
            this.lstResources.KeyDown += new System.Windows.Forms.KeyEventHandler(this.itemList_KeyDown);
            // 
            // grpGeneral
            // 
            this.grpGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpGeneral.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpGeneral.Controls.Add(this.nudMaxHp);
            this.grpGeneral.Controls.Add(this.nudMinHp);
            this.grpGeneral.Controls.Add(this.nudSpawnDuration);
            this.grpGeneral.Controls.Add(this.cmbAnimation);
            this.grpGeneral.Controls.Add(this.btnRequirements);
            this.grpGeneral.Controls.Add(this.lblAnimation);
            this.grpGeneral.Controls.Add(this.lblMaxHp);
            this.grpGeneral.Controls.Add(this.lblSpawnDuration);
            this.grpGeneral.Controls.Add(this.chkWalkableAfter);
            this.grpGeneral.Controls.Add(this.chkWalkableBefore);
            this.grpGeneral.Controls.Add(this.cmbToolType);
            this.grpGeneral.Controls.Add(this.lblToolType);
            this.grpGeneral.Controls.Add(this.lblHP);
            this.grpGeneral.Controls.Add(this.lblName);
            this.grpGeneral.Controls.Add(this.txtName);
            this.grpGeneral.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpGeneral.Location = new System.Drawing.Point(0, 0);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Size = new System.Drawing.Size(223, 281);
            this.grpGeneral.TabIndex = 15;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "General";
            // 
            // nudMaxHp
            // 
            this.nudMaxHp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudMaxHp.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudMaxHp.Location = new System.Drawing.Point(75, 104);
            this.nudMaxHp.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudMaxHp.Name = "nudMaxHp";
            this.nudMaxHp.Size = new System.Drawing.Size(135, 20);
            this.nudMaxHp.TabIndex = 42;
            this.nudMaxHp.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudMaxHp.ValueChanged += new System.EventHandler(this.nudMaxHp_ValueChanged);
            // 
            // nudMinHp
            // 
            this.nudMinHp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudMinHp.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudMinHp.Location = new System.Drawing.Point(75, 78);
            this.nudMinHp.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudMinHp.Name = "nudMinHp";
            this.nudMinHp.Size = new System.Drawing.Size(135, 20);
            this.nudMinHp.TabIndex = 41;
            this.nudMinHp.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudMinHp.ValueChanged += new System.EventHandler(this.nudMinHp_ValueChanged);
            // 
            // nudSpawnDuration
            // 
            this.nudSpawnDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudSpawnDuration.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudSpawnDuration.Location = new System.Drawing.Point(9, 140);
            this.nudSpawnDuration.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudSpawnDuration.Name = "nudSpawnDuration";
            this.nudSpawnDuration.Size = new System.Drawing.Size(201, 20);
            this.nudSpawnDuration.TabIndex = 40;
            this.nudSpawnDuration.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudSpawnDuration.ValueChanged += new System.EventHandler(this.nudSpawnDuration_ValueChanged);
            // 
            // cmbAnimation
            // 
            this.cmbAnimation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbAnimation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbAnimation.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbAnimation.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbAnimation.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbAnimation.ButtonIcon")));
            this.cmbAnimation.DrawDropdownHoverOutline = false;
            this.cmbAnimation.DrawFocusRectangle = false;
            this.cmbAnimation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAnimation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnimation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAnimation.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbAnimation.FormattingEnabled = true;
            this.cmbAnimation.Location = new System.Drawing.Point(9, 179);
            this.cmbAnimation.Name = "cmbAnimation";
            this.cmbAnimation.Size = new System.Drawing.Size(201, 21);
            this.cmbAnimation.TabIndex = 39;
            this.cmbAnimation.Text = null;
            this.cmbAnimation.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbAnimation.SelectedIndexChanged += new System.EventHandler(this.cmbAnimation_SelectedIndexChanged);
            // 
            // btnRequirements
            // 
            this.btnRequirements.Location = new System.Drawing.Point(6, 252);
            this.btnRequirements.Name = "btnRequirements";
            this.btnRequirements.Padding = new System.Windows.Forms.Padding(5);
            this.btnRequirements.Size = new System.Drawing.Size(204, 23);
            this.btnRequirements.TabIndex = 38;
            this.btnRequirements.Text = "Harvesting Requirements";
            this.btnRequirements.Click += new System.EventHandler(this.btnRequirements_Click);
            // 
            // lblAnimation
            // 
            this.lblAnimation.AutoSize = true;
            this.lblAnimation.Location = new System.Drawing.Point(6, 162);
            this.lblAnimation.Name = "lblAnimation";
            this.lblAnimation.Size = new System.Drawing.Size(56, 13);
            this.lblAnimation.TabIndex = 36;
            this.lblAnimation.Text = "Animation:";
            // 
            // lblMaxHp
            // 
            this.lblMaxHp.AutoSize = true;
            this.lblMaxHp.Location = new System.Drawing.Point(6, 106);
            this.lblMaxHp.Name = "lblMaxHp";
            this.lblMaxHp.Size = new System.Drawing.Size(48, 13);
            this.lblMaxHp.TabIndex = 35;
            this.lblMaxHp.Text = "Max HP:";
            // 
            // lblSpawnDuration
            // 
            this.lblSpawnDuration.AutoSize = true;
            this.lblSpawnDuration.Location = new System.Drawing.Point(6, 127);
            this.lblSpawnDuration.Name = "lblSpawnDuration";
            this.lblSpawnDuration.Size = new System.Drawing.Size(86, 13);
            this.lblSpawnDuration.TabIndex = 32;
            this.lblSpawnDuration.Text = "Spawn Duration:";
            // 
            // chkWalkableAfter
            // 
            this.chkWalkableAfter.Location = new System.Drawing.Point(6, 229);
            this.chkWalkableAfter.Name = "chkWalkableAfter";
            this.chkWalkableAfter.Size = new System.Drawing.Size(211, 17);
            this.chkWalkableAfter.TabIndex = 31;
            this.chkWalkableAfter.Text = "Walkable after resource removal?";
            this.chkWalkableAfter.CheckedChanged += new System.EventHandler(this.chkWalkableAfter_CheckedChanged);
            // 
            // chkWalkableBefore
            // 
            this.chkWalkableBefore.Location = new System.Drawing.Point(6, 206);
            this.chkWalkableBefore.Name = "chkWalkableBefore";
            this.chkWalkableBefore.Size = new System.Drawing.Size(211, 17);
            this.chkWalkableBefore.TabIndex = 30;
            this.chkWalkableBefore.Text = "Walkable before resource removal?";
            this.chkWalkableBefore.CheckedChanged += new System.EventHandler(this.chkWalkableBefore_CheckedChanged);
            // 
            // cmbToolType
            // 
            this.cmbToolType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbToolType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbToolType.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbToolType.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbToolType.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbToolType.ButtonIcon")));
            this.cmbToolType.DrawDropdownHoverOutline = false;
            this.cmbToolType.DrawFocusRectangle = false;
            this.cmbToolType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbToolType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbToolType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbToolType.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbToolType.FormattingEnabled = true;
            this.cmbToolType.Location = new System.Drawing.Point(75, 46);
            this.cmbToolType.Name = "cmbToolType";
            this.cmbToolType.Size = new System.Drawing.Size(135, 21);
            this.cmbToolType.TabIndex = 29;
            this.cmbToolType.Text = null;
            this.cmbToolType.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbToolType.SelectedIndexChanged += new System.EventHandler(this.cmbToolType_SelectedIndexChanged);
            // 
            // lblToolType
            // 
            this.lblToolType.AutoSize = true;
            this.lblToolType.Location = new System.Drawing.Point(6, 49);
            this.lblToolType.Name = "lblToolType";
            this.lblToolType.Size = new System.Drawing.Size(58, 13);
            this.lblToolType.TabIndex = 28;
            this.lblToolType.Text = "Tool Type:";
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Location = new System.Drawing.Point(6, 80);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(45, 13);
            this.lblHP.TabIndex = 16;
            this.lblHP.Text = "Min HP:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtName.Location = new System.Drawing.Point(75, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(135, 20);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // grpGraphics
            // 
            this.grpGraphics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpGraphics.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpGraphics.Controls.Add(this.exhaustedGraphicContainer);
            this.grpGraphics.Controls.Add(this.initalGraphicContainer);
            this.grpGraphics.Controls.Add(this.cmbEndSprite);
            this.grpGraphics.Controls.Add(this.lblPic2);
            this.grpGraphics.Controls.Add(this.cmbInitialSprite);
            this.grpGraphics.Controls.Add(this.lblPic);
            this.grpGraphics.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpGraphics.Location = new System.Drawing.Point(0, 282);
            this.grpGraphics.Name = "grpGraphics";
            this.grpGraphics.Size = new System.Drawing.Size(706, 454);
            this.grpGraphics.TabIndex = 16;
            this.grpGraphics.TabStop = false;
            this.grpGraphics.Text = "Graphics";
            // 
            // exhaustedGraphicContainer
            // 
            this.exhaustedGraphicContainer.AutoScroll = true;
            this.exhaustedGraphicContainer.Controls.Add(this.picEndResource);
            this.exhaustedGraphicContainer.Location = new System.Drawing.Point(365, 62);
            this.exhaustedGraphicContainer.Name = "exhaustedGraphicContainer";
            this.exhaustedGraphicContainer.Size = new System.Drawing.Size(330, 386);
            this.exhaustedGraphicContainer.TabIndex = 25;
            // 
            // picEndResource
            // 
            this.picEndResource.Location = new System.Drawing.Point(0, 0);
            this.picEndResource.Name = "picEndResource";
            this.picEndResource.Size = new System.Drawing.Size(182, 290);
            this.picEndResource.TabIndex = 2;
            this.picEndResource.TabStop = false;
            // 
            // initalGraphicContainer
            // 
            this.initalGraphicContainer.AutoScroll = true;
            this.initalGraphicContainer.Controls.Add(this.picInitialResource);
            this.initalGraphicContainer.Location = new System.Drawing.Point(13, 62);
            this.initalGraphicContainer.Name = "initalGraphicContainer";
            this.initalGraphicContainer.Size = new System.Drawing.Size(330, 386);
            this.initalGraphicContainer.TabIndex = 24;
            // 
            // picInitialResource
            // 
            this.picInitialResource.Location = new System.Drawing.Point(0, 0);
            this.picInitialResource.Name = "picInitialResource";
            this.picInitialResource.Size = new System.Drawing.Size(180, 290);
            this.picInitialResource.TabIndex = 2;
            this.picInitialResource.TabStop = false;
            // 
            // cmbEndSprite
            // 
            this.cmbEndSprite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbEndSprite.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbEndSprite.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbEndSprite.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbEndSprite.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbEndSprite.ButtonIcon")));
            this.cmbEndSprite.DrawDropdownHoverOutline = false;
            this.cmbEndSprite.DrawFocusRectangle = false;
            this.cmbEndSprite.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEndSprite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEndSprite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEndSprite.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbEndSprite.FormattingEnabled = true;
            this.cmbEndSprite.Items.AddRange(new object[] {
            "None"});
            this.cmbEndSprite.Location = new System.Drawing.Point(365, 32);
            this.cmbEndSprite.Name = "cmbEndSprite";
            this.cmbEndSprite.Size = new System.Drawing.Size(196, 21);
            this.cmbEndSprite.TabIndex = 16;
            this.cmbEndSprite.Text = "None";
            this.cmbEndSprite.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbEndSprite.SelectedIndexChanged += new System.EventHandler(this.cmbEndSprite_SelectedIndexChanged);
            // 
            // lblPic2
            // 
            this.lblPic2.AutoSize = true;
            this.lblPic2.Location = new System.Drawing.Point(362, 16);
            this.lblPic2.Name = "lblPic2";
            this.lblPic2.Size = new System.Drawing.Size(96, 13);
            this.lblPic2.TabIndex = 15;
            this.lblPic2.Text = "Removed Graphic:";
            // 
            // cmbInitialSprite
            // 
            this.cmbInitialSprite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbInitialSprite.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbInitialSprite.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbInitialSprite.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbInitialSprite.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbInitialSprite.ButtonIcon")));
            this.cmbInitialSprite.DrawDropdownHoverOutline = false;
            this.cmbInitialSprite.DrawFocusRectangle = false;
            this.cmbInitialSprite.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbInitialSprite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInitialSprite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbInitialSprite.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbInitialSprite.FormattingEnabled = true;
            this.cmbInitialSprite.Items.AddRange(new object[] {
            "None"});
            this.cmbInitialSprite.Location = new System.Drawing.Point(13, 32);
            this.cmbInitialSprite.Name = "cmbInitialSprite";
            this.cmbInitialSprite.Size = new System.Drawing.Size(195, 21);
            this.cmbInitialSprite.TabIndex = 14;
            this.cmbInitialSprite.Text = "None";
            this.cmbInitialSprite.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbInitialSprite.SelectedIndexChanged += new System.EventHandler(this.cmbInitialSprite_SelectedIndexChanged);
            // 
            // lblPic
            // 
            this.lblPic.AutoSize = true;
            this.lblPic.Location = new System.Drawing.Point(10, 16);
            this.lblPic.Name = "lblPic";
            this.lblPic.Size = new System.Drawing.Size(74, 13);
            this.lblPic.TabIndex = 13;
            this.lblPic.Text = "Initial Graphic:";
            // 
            // tmrRender
            // 
            this.tmrRender.Enabled = true;
            this.tmrRender.Interval = 10;
            this.tmrRender.Tick += new System.EventHandler(this.tmrRender_Tick);
            // 
            // pnlContainer
            // 
            this.pnlContainer.AutoScroll = true;
            this.pnlContainer.Controls.Add(this.grpDrops);
            this.pnlContainer.Controls.Add(this.grpGeneral);
            this.pnlContainer.Controls.Add(this.grpGraphics);
            this.pnlContainer.Location = new System.Drawing.Point(221, 39);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(731, 458);
            this.pnlContainer.TabIndex = 18;
            this.pnlContainer.Visible = false;
            // 
            // grpDrops
            // 
            this.grpDrops.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpDrops.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpDrops.Controls.Add(this.btnDropRemove);
            this.grpDrops.Controls.Add(this.btnDropAdd);
            this.grpDrops.Controls.Add(this.lstDrops);
            this.grpDrops.Controls.Add(this.nudDropAmount);
            this.grpDrops.Controls.Add(this.nudDropChance);
            this.grpDrops.Controls.Add(this.cmbDropItem);
            this.grpDrops.Controls.Add(this.lblDropAmount);
            this.grpDrops.Controls.Add(this.lblDropChance);
            this.grpDrops.Controls.Add(this.lblDropItem);
            this.grpDrops.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpDrops.Location = new System.Drawing.Point(231, 0);
            this.grpDrops.Name = "grpDrops";
            this.grpDrops.Size = new System.Drawing.Size(226, 281);
            this.grpDrops.TabIndex = 31;
            this.grpDrops.TabStop = false;
            this.grpDrops.Text = "Drops";
            // 
            // btnDropRemove
            // 
            this.btnDropRemove.Location = new System.Drawing.Point(126, 252);
            this.btnDropRemove.Name = "btnDropRemove";
            this.btnDropRemove.Padding = new System.Windows.Forms.Padding(5);
            this.btnDropRemove.Size = new System.Drawing.Size(75, 23);
            this.btnDropRemove.TabIndex = 64;
            this.btnDropRemove.Text = "Remove";
            this.btnDropRemove.Click += new System.EventHandler(this.btnDropRemove_Click);
            // 
            // btnDropAdd
            // 
            this.btnDropAdd.Location = new System.Drawing.Point(6, 252);
            this.btnDropAdd.Name = "btnDropAdd";
            this.btnDropAdd.Padding = new System.Windows.Forms.Padding(5);
            this.btnDropAdd.Size = new System.Drawing.Size(75, 23);
            this.btnDropAdd.TabIndex = 63;
            this.btnDropAdd.Text = "Add";
            this.btnDropAdd.Click += new System.EventHandler(this.btnDropAdd_Click);
            // 
            // lstDrops
            // 
            this.lstDrops.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.lstDrops.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstDrops.ForeColor = System.Drawing.Color.Gainsboro;
            this.lstDrops.FormattingEnabled = true;
            this.lstDrops.Location = new System.Drawing.Point(9, 19);
            this.lstDrops.Name = "lstDrops";
            this.lstDrops.Size = new System.Drawing.Size(192, 93);
            this.lstDrops.TabIndex = 62;
            this.lstDrops.SelectedIndexChanged += new System.EventHandler(this.lstDrops_SelectedIndexChanged);
            // 
            // nudDropAmount
            // 
            this.nudDropAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudDropAmount.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudDropAmount.Location = new System.Drawing.Point(6, 173);
            this.nudDropAmount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudDropAmount.Name = "nudDropAmount";
            this.nudDropAmount.Size = new System.Drawing.Size(195, 20);
            this.nudDropAmount.TabIndex = 61;
            this.nudDropAmount.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudDropAmount.ValueChanged += new System.EventHandler(this.nudDropAmount_ValueChanged);
            // 
            // nudDropChance
            // 
            this.nudDropChance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudDropChance.DecimalPlaces = 2;
            this.nudDropChance.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudDropChance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudDropChance.Location = new System.Drawing.Point(6, 219);
            this.nudDropChance.Name = "nudDropChance";
            this.nudDropChance.Size = new System.Drawing.Size(195, 20);
            this.nudDropChance.TabIndex = 60;
            this.nudDropChance.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudDropChance.ValueChanged += new System.EventHandler(this.nudDropChance_ValueChanged);
            // 
            // cmbDropItem
            // 
            this.cmbDropItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbDropItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbDropItem.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbDropItem.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbDropItem.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbDropItem.ButtonIcon")));
            this.cmbDropItem.DrawDropdownHoverOutline = false;
            this.cmbDropItem.DrawFocusRectangle = false;
            this.cmbDropItem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDropItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDropItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDropItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbDropItem.FormattingEnabled = true;
            this.cmbDropItem.Location = new System.Drawing.Point(6, 131);
            this.cmbDropItem.Name = "cmbDropItem";
            this.cmbDropItem.Size = new System.Drawing.Size(195, 21);
            this.cmbDropItem.TabIndex = 17;
            this.cmbDropItem.Text = null;
            this.cmbDropItem.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbDropItem.SelectedIndexChanged += new System.EventHandler(this.cmbDropItem_SelectedIndexChanged);
            // 
            // lblDropAmount
            // 
            this.lblDropAmount.AutoSize = true;
            this.lblDropAmount.Location = new System.Drawing.Point(3, 157);
            this.lblDropAmount.Name = "lblDropAmount";
            this.lblDropAmount.Size = new System.Drawing.Size(46, 13);
            this.lblDropAmount.TabIndex = 15;
            this.lblDropAmount.Text = "Amount:";
            // 
            // lblDropChance
            // 
            this.lblDropChance.AutoSize = true;
            this.lblDropChance.Location = new System.Drawing.Point(3, 202);
            this.lblDropChance.Name = "lblDropChance";
            this.lblDropChance.Size = new System.Drawing.Size(64, 13);
            this.lblDropChance.TabIndex = 13;
            this.lblDropChance.Text = "Chance (%):";
            // 
            // lblDropItem
            // 
            this.lblDropItem.AutoSize = true;
            this.lblDropItem.Location = new System.Drawing.Point(3, 114);
            this.lblDropItem.Name = "lblDropItem";
            this.lblDropItem.Size = new System.Drawing.Size(30, 13);
            this.lblDropItem.TabIndex = 11;
            this.lblDropItem.Text = "Item:";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(762, 503);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5);
            this.btnCancel.Size = new System.Drawing.Size(190, 27);
            this.btnCancel.TabIndex = 44;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(566, 503);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5);
            this.btnSave.Size = new System.Drawing.Size(190, 27);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.toolStrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripItemNew,
            this.toolStripSeparator1,
            this.toolStripItemDelete,
            this.toolStripSeparator2,
            this.toolStripItemCopy,
            this.toolStripItemPaste,
            this.toolStripSeparator3,
            this.toolStripItemUndo});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(5, 0, 1, 0);
            this.toolStrip.Size = new System.Drawing.Size(957, 25);
            this.toolStrip.TabIndex = 47;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripItemNew
            // 
            this.toolStripItemNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripItemNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripItemNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripItemNew.Image")));
            this.toolStripItemNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripItemNew.Name = "toolStripItemNew";
            this.toolStripItemNew.Size = new System.Drawing.Size(23, 22);
            this.toolStripItemNew.Text = "New";
            this.toolStripItemNew.Click += new System.EventHandler(this.toolStripItemNew_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripItemDelete
            // 
            this.toolStripItemDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripItemDelete.Enabled = false;
            this.toolStripItemDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripItemDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripItemDelete.Image")));
            this.toolStripItemDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripItemDelete.Name = "toolStripItemDelete";
            this.toolStripItemDelete.Size = new System.Drawing.Size(23, 22);
            this.toolStripItemDelete.Text = "Delete";
            this.toolStripItemDelete.Click += new System.EventHandler(this.toolStripItemDelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripItemCopy
            // 
            this.toolStripItemCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripItemCopy.Enabled = false;
            this.toolStripItemCopy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripItemCopy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripItemCopy.Image")));
            this.toolStripItemCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripItemCopy.Name = "toolStripItemCopy";
            this.toolStripItemCopy.Size = new System.Drawing.Size(23, 22);
            this.toolStripItemCopy.Text = "Copy";
            this.toolStripItemCopy.Click += new System.EventHandler(this.toolStripItemCopy_Click);
            // 
            // toolStripItemPaste
            // 
            this.toolStripItemPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripItemPaste.Enabled = false;
            this.toolStripItemPaste.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripItemPaste.Image = ((System.Drawing.Image)(resources.GetObject("toolStripItemPaste.Image")));
            this.toolStripItemPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripItemPaste.Name = "toolStripItemPaste";
            this.toolStripItemPaste.Size = new System.Drawing.Size(23, 22);
            this.toolStripItemPaste.Text = "Paste";
            this.toolStripItemPaste.Click += new System.EventHandler(this.toolStripItemPaste_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripItemUndo
            // 
            this.toolStripItemUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripItemUndo.Enabled = false;
            this.toolStripItemUndo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripItemUndo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripItemUndo.Image")));
            this.toolStripItemUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripItemUndo.Name = "toolStripItemUndo";
            this.toolStripItemUndo.Size = new System.Drawing.Size(23, 22);
            this.toolStripItemUndo.Text = "Undo";
            this.toolStripItemUndo.Click += new System.EventHandler(this.toolStripItemUndo_Click);
            // 
            // FrmResource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(957, 537);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpResources);
            this.Controls.Add(this.pnlContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "FrmResource";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resource Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmResource_FormClosed);
            this.Load += new System.EventHandler(this.frmResource_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_KeyDown);
            this.grpResources.ResumeLayout(false);
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxHp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinHp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpawnDuration)).EndInit();
            this.grpGraphics.ResumeLayout(false);
            this.grpGraphics.PerformLayout();
            this.exhaustedGraphicContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picEndResource)).EndInit();
            this.initalGraphicContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picInitialResource)).EndInit();
            this.pnlContainer.ResumeLayout(false);
            this.grpDrops.ResumeLayout(false);
            this.grpDrops.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDropAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDropChance)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DarkGroupBox grpResources;
        private System.Windows.Forms.ListBox lstResources;
        private DarkGroupBox grpGeneral;
        private DarkGroupBox grpGraphics;
        private System.Windows.Forms.Label lblName;
        private DarkTextBox txtName;
        private System.Windows.Forms.Label lblHP;
        private DarkCheckBox chkWalkableAfter;
        private DarkCheckBox chkWalkableBefore;
        private DarkComboBox cmbToolType;
        private System.Windows.Forms.Label lblToolType;
        private DarkComboBox cmbEndSprite;
        private System.Windows.Forms.Label lblPic2;
        private DarkComboBox cmbInitialSprite;
        private System.Windows.Forms.Label lblPic;
        private System.Windows.Forms.Label lblSpawnDuration;
        public System.Windows.Forms.PictureBox picEndResource;
        public System.Windows.Forms.PictureBox picInitialResource;
        private System.Windows.Forms.Label lblMaxHp;
        private System.Windows.Forms.Label lblAnimation;
        private System.Windows.Forms.Timer tmrRender;
        private System.Windows.Forms.Panel pnlContainer;
        private DarkButton btnSave;
        private DarkButton btnCancel;
        private DarkToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripItemNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripItemDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripButton toolStripItemCopy;
        public System.Windows.Forms.ToolStripButton toolStripItemPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ToolStripButton toolStripItemUndo;
        private System.Windows.Forms.Panel exhaustedGraphicContainer;
        private System.Windows.Forms.Panel initalGraphicContainer;
        private DarkButton btnRequirements;
        private DarkComboBox cmbAnimation;
        private DarkNumericUpDown nudSpawnDuration;
        private DarkNumericUpDown nudMaxHp;
        private DarkNumericUpDown nudMinHp;
        private DarkGroupBox grpDrops;
        private DarkButton btnDropRemove;
        private DarkButton btnDropAdd;
        private System.Windows.Forms.ListBox lstDrops;
        private DarkNumericUpDown nudDropAmount;
        private DarkNumericUpDown nudDropChance;
        private DarkComboBox cmbDropItem;
        private System.Windows.Forms.Label lblDropAmount;
        private System.Windows.Forms.Label lblDropChance;
        private System.Windows.Forms.Label lblDropItem;
    }
}