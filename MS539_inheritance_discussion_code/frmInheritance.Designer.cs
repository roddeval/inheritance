namespace MS539_inheritance_discussion_code
{
    partial class frmInheritance
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGoPart = new System.Windows.Forms.Button();
            this.cmbMake = new System.Windows.Forms.ComboBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGoTransmission = new System.Windows.Forms.Button();
            this.rbManual = new System.Windows.Forms.RadioButton();
            this.rbAutomatic = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGoEngine = new System.Windows.Forms.Button();
            this.tbCylinder = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbPart = new System.Windows.Forms.ListBox();
            this.lbTransmission = new System.Windows.Forms.ListBox();
            this.lbEngine = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGoPart);
            this.groupBox1.Controls.Add(this.cmbMake);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.tbModel);
            this.groupBox1.Controls.Add(this.tbYear);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(101, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Part";
            // 
            // btnGoPart
            // 
            this.btnGoPart.Location = new System.Drawing.Point(233, 146);
            this.btnGoPart.Name = "btnGoPart";
            this.btnGoPart.Size = new System.Drawing.Size(75, 23);
            this.btnGoPart.TabIndex = 8;
            this.btnGoPart.Text = "Build Part";
            this.btnGoPart.UseVisualStyleBackColor = true;
            this.btnGoPart.Click += new System.EventHandler(this.btnGoPart_Click);
            // 
            // cmbMake
            // 
            this.cmbMake.FormattingEnabled = true;
            this.cmbMake.Location = new System.Drawing.Point(98, 67);
            this.cmbMake.Name = "cmbMake";
            this.cmbMake.Size = new System.Drawing.Size(210, 21);
            this.cmbMake.TabIndex = 3;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(97, 120);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(211, 20);
            this.tbName.TabIndex = 7;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(97, 94);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(211, 20);
            this.tbModel.TabIndex = 5;
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(97, 35);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(211, 20);
            this.tbYear.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Make";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Year";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGoTransmission);
            this.groupBox2.Controls.Add(this.rbManual);
            this.groupBox2.Controls.Add(this.rbAutomatic);
            this.groupBox2.Location = new System.Drawing.Point(109, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 90);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transmission";
            // 
            // btnGoTransmission
            // 
            this.btnGoTransmission.Location = new System.Drawing.Point(225, 61);
            this.btnGoTransmission.Name = "btnGoTransmission";
            this.btnGoTransmission.Size = new System.Drawing.Size(75, 23);
            this.btnGoTransmission.TabIndex = 2;
            this.btnGoTransmission.Text = "Build Part";
            this.btnGoTransmission.UseVisualStyleBackColor = true;
            this.btnGoTransmission.Click += new System.EventHandler(this.btnGoTransmission_Click);
            // 
            // rbManual
            // 
            this.rbManual.AutoSize = true;
            this.rbManual.Location = new System.Drawing.Point(185, 29);
            this.rbManual.Name = "rbManual";
            this.rbManual.Size = new System.Drawing.Size(60, 17);
            this.rbManual.TabIndex = 1;
            this.rbManual.TabStop = true;
            this.rbManual.Text = "Manual";
            this.rbManual.UseVisualStyleBackColor = true;
            // 
            // rbAutomatic
            // 
            this.rbAutomatic.AutoSize = true;
            this.rbAutomatic.Location = new System.Drawing.Point(75, 29);
            this.rbAutomatic.Name = "rbAutomatic";
            this.rbAutomatic.Size = new System.Drawing.Size(72, 17);
            this.rbAutomatic.TabIndex = 0;
            this.rbAutomatic.TabStop = true;
            this.rbAutomatic.Text = "Automatic";
            this.rbAutomatic.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGoEngine);
            this.groupBox3.Controls.Add(this.tbCylinder);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(109, 358);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(333, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Engine";
            // 
            // btnGoEngine
            // 
            this.btnGoEngine.Location = new System.Drawing.Point(225, 71);
            this.btnGoEngine.Name = "btnGoEngine";
            this.btnGoEngine.Size = new System.Drawing.Size(75, 23);
            this.btnGoEngine.TabIndex = 2;
            this.btnGoEngine.Text = "Build Part";
            this.btnGoEngine.UseVisualStyleBackColor = true;
            this.btnGoEngine.Click += new System.EventHandler(this.btnGoEngine_Click);
            // 
            // tbCylinder
            // 
            this.tbCylinder.Location = new System.Drawing.Point(90, 35);
            this.tbCylinder.Name = "tbCylinder";
            this.tbCylinder.Size = new System.Drawing.Size(210, 20);
            this.tbCylinder.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cylinder";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lbPart
            // 
            this.lbPart.FormattingEnabled = true;
            this.lbPart.Location = new System.Drawing.Point(460, 68);
            this.lbPart.Name = "lbPart";
            this.lbPart.Size = new System.Drawing.Size(314, 95);
            this.lbPart.TabIndex = 1;
            // 
            // lbTransmission
            // 
            this.lbTransmission.FormattingEnabled = true;
            this.lbTransmission.Location = new System.Drawing.Point(460, 241);
            this.lbTransmission.Name = "lbTransmission";
            this.lbTransmission.Size = new System.Drawing.Size(314, 95);
            this.lbTransmission.TabIndex = 3;
            // 
            // lbEngine
            // 
            this.lbEngine.FormattingEnabled = true;
            this.lbEngine.Location = new System.Drawing.Point(460, 363);
            this.lbEngine.Name = "lbEngine";
            this.lbEngine.Size = new System.Drawing.Size(314, 95);
            this.lbEngine.TabIndex = 5;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(406, 532);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmInheritance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 641);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lbEngine);
            this.Controls.Add(this.lbTransmission);
            this.Controls.Add(this.lbPart);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmInheritance";
            this.Text = "frmInheritance";
            this.Load += new System.EventHandler(this.frmInheritance_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbMake;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbManual;
        private System.Windows.Forms.RadioButton rbAutomatic;
        private System.Windows.Forms.TextBox tbCylinder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGoPart;
        private System.Windows.Forms.Button btnGoTransmission;
        private System.Windows.Forms.Button btnGoEngine;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ListBox lbEngine;
        private System.Windows.Forms.ListBox lbTransmission;
        private System.Windows.Forms.ListBox lbPart;
        private System.Windows.Forms.Button btnClear;
    }
}