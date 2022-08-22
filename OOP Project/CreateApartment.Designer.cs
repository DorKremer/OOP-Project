﻿namespace OOP_Project
{
    partial class CreateApartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateApartment));
            this.createBox = new System.Windows.Forms.Button();
            this.petsBox = new System.Windows.Forms.CheckBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.NumericUpDown();
            this.residentsBox = new System.Windows.Forms.NumericUpDown();
            this.roomCountBox = new System.Windows.Forms.NumericUpDown();
            this.floorBox = new System.Windows.Forms.NumericUpDown();
            this.zipCodeBox = new System.Windows.Forms.NumericUpDown();
            this.poolBox = new System.Windows.Forms.CheckBox();
            this.wifiBox = new System.Windows.Forms.CheckBox();
            this.elevatorBox = new System.Windows.Forms.CheckBox();
            this.porchBox = new System.Windows.Forms.CheckBox();
            this.successText = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomCountBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zipCodeBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // createBox
            // 
            this.createBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.createBox.Location = new System.Drawing.Point(30, 373);
            this.createBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.createBox.Name = "createBox";
            this.createBox.Size = new System.Drawing.Size(248, 75);
            this.createBox.TabIndex = 0;
            this.createBox.Text = "Add Apartment";
            this.createBox.UseVisualStyleBackColor = true;
            this.createBox.Click += new System.EventHandler(this.createBox_Click);
            this.createBox.Leave += new System.EventHandler(this.createBox_Leave);
            // 
            // petsBox
            // 
            this.petsBox.AutoSize = true;
            this.petsBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petsBox.Location = new System.Drawing.Point(7, 26);
            this.petsBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.petsBox.Name = "petsBox";
            this.petsBox.Size = new System.Drawing.Size(172, 22);
            this.petsBox.TabIndex = 1;
            this.petsBox.Text = "Are Pets Allowed?";
            this.petsBox.UseVisualStyleBackColor = true;
            // 
            // addressBox
            // 
            this.addressBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.addressBox.Location = new System.Drawing.Point(14, 31);
            this.addressBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(247, 24);
            this.addressBox.TabIndex = 3;
            this.addressBox.Text = "Enter Address...";
            this.addressBox.Click += new System.EventHandler(this.addressBox_Enter);
            this.addressBox.Leave += new System.EventHandler(this.addressBox_Leave);
            // 
            // descriptionBox
            // 
            this.descriptionBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.descriptionBox.Location = new System.Drawing.Point(16, 223);
            this.descriptionBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(247, 71);
            this.descriptionBox.TabIndex = 4;
            this.descriptionBox.Text = "Enter Description...";
            this.descriptionBox.Enter += new System.EventHandler(this.descriptionBox_Enter);
            this.descriptionBox.Leave += new System.EventHandler(this.descriptionBox_Leave);
            // 
            // priceBox
            // 
            this.priceBox.BackColor = System.Drawing.Color.White;
            this.priceBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.priceBox.ForeColor = System.Drawing.Color.Black;
            this.priceBox.Location = new System.Drawing.Point(15, 63);
            this.priceBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(248, 24);
            this.priceBox.TabIndex = 5;
            this.priceBox.ValueChanged += new System.EventHandler(this.priceBox_ValueChanged);
            // 
            // residentsBox
            // 
            this.residentsBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.residentsBox.Location = new System.Drawing.Point(14, 95);
            this.residentsBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.residentsBox.Name = "residentsBox";
            this.residentsBox.Size = new System.Drawing.Size(248, 24);
            this.residentsBox.TabIndex = 6;
            this.residentsBox.ValueChanged += new System.EventHandler(this.residentsBox_ValueChanged);
            // 
            // roomCountBox
            // 
            this.roomCountBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.roomCountBox.Location = new System.Drawing.Point(14, 127);
            this.roomCountBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.roomCountBox.Name = "roomCountBox";
            this.roomCountBox.Size = new System.Drawing.Size(248, 24);
            this.roomCountBox.TabIndex = 7;
            this.roomCountBox.ValueChanged += new System.EventHandler(this.roomCountBox_ValueChanged);
            // 
            // floorBox
            // 
            this.floorBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.floorBox.Location = new System.Drawing.Point(14, 159);
            this.floorBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.floorBox.Name = "floorBox";
            this.floorBox.Size = new System.Drawing.Size(248, 24);
            this.floorBox.TabIndex = 8;
            // 
            // zipCodeBox
            // 
            this.zipCodeBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.zipCodeBox.Location = new System.Drawing.Point(14, 191);
            this.zipCodeBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zipCodeBox.Name = "zipCodeBox";
            this.zipCodeBox.Size = new System.Drawing.Size(248, 24);
            this.zipCodeBox.TabIndex = 9;
            // 
            // poolBox
            // 
            this.poolBox.AutoSize = true;
            this.poolBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.poolBox.Location = new System.Drawing.Point(7, 56);
            this.poolBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.poolBox.Name = "poolBox";
            this.poolBox.Size = new System.Drawing.Size(161, 22);
            this.poolBox.TabIndex = 10;
            this.poolBox.Text = "Is There A Pool?";
            this.poolBox.UseVisualStyleBackColor = true;
            // 
            // wifiBox
            // 
            this.wifiBox.AutoSize = true;
            this.wifiBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.wifiBox.Location = new System.Drawing.Point(7, 90);
            this.wifiBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.wifiBox.Name = "wifiBox";
            this.wifiBox.Size = new System.Drawing.Size(141, 22);
            this.wifiBox.TabIndex = 11;
            this.wifiBox.Text = "Is There Wifi?";
            this.wifiBox.UseVisualStyleBackColor = true;
            // 
            // elevatorBox
            // 
            this.elevatorBox.AutoSize = true;
            this.elevatorBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.elevatorBox.Location = new System.Drawing.Point(7, 120);
            this.elevatorBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.elevatorBox.Name = "elevatorBox";
            this.elevatorBox.Size = new System.Drawing.Size(203, 22);
            this.elevatorBox.TabIndex = 12;
            this.elevatorBox.Text = "Is There An Elevator?";
            this.elevatorBox.UseVisualStyleBackColor = true;
            // 
            // porchBox
            // 
            this.porchBox.AutoSize = true;
            this.porchBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.porchBox.Location = new System.Drawing.Point(7, 150);
            this.porchBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.porchBox.Name = "porchBox";
            this.porchBox.Size = new System.Drawing.Size(172, 22);
            this.porchBox.TabIndex = 13;
            this.porchBox.Text = "Is There A Porch?";
            this.porchBox.UseVisualStyleBackColor = true;
            // 
            // successText
            // 
            this.successText.AutoSize = true;
            this.successText.ForeColor = System.Drawing.Color.Lime;
            this.successText.Location = new System.Drawing.Point(96, 402);
            this.successText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.successText.Name = "successText";
            this.successText.Size = new System.Drawing.Size(0, 16);
            this.successText.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.addressBox);
            this.groupBox1.Controls.Add(this.descriptionBox);
            this.groupBox1.Controls.Add(this.priceBox);
            this.groupBox1.Controls.Add(this.zipCodeBox);
            this.groupBox1.Controls.Add(this.residentsBox);
            this.groupBox1.Controls.Add(this.floorBox);
            this.groupBox1.Controls.Add(this.roomCountBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox1.Location = new System.Drawing.Point(30, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 346);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Register Apartment";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.petsBox);
            this.groupBox2.Controls.Add(this.poolBox);
            this.groupBox2.Controls.Add(this.wifiBox);
            this.groupBox2.Controls.Add(this.porchBox);
            this.groupBox2.Controls.Add(this.elevatorBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox2.Location = new System.Drawing.Point(637, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 192);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inofrmation for Guests";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(269, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Price";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(269, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Max Capacity Of Residents";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(269, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(275, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 14;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(269, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "How many Floors";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(269, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Zip Code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(269, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "How many Rooms";
            // 
            // CreateApartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(877, 475);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.successText);
            this.Controls.Add(this.createBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CreateApartment";
            this.Text = "Add An Apartment!";
            this.Load += new System.EventHandler(this.CreateApartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomCountBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zipCodeBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createBox;
        private System.Windows.Forms.CheckBox petsBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.NumericUpDown priceBox;
        private System.Windows.Forms.NumericUpDown residentsBox;
        private System.Windows.Forms.NumericUpDown roomCountBox;
        private System.Windows.Forms.NumericUpDown floorBox;
        private System.Windows.Forms.NumericUpDown zipCodeBox;
        private System.Windows.Forms.CheckBox poolBox;
        private System.Windows.Forms.CheckBox wifiBox;
        private System.Windows.Forms.CheckBox elevatorBox;
        private System.Windows.Forms.CheckBox porchBox;
        private System.Windows.Forms.Label successText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}