namespace Shorthand.VSAddins.JsonVisualizer
{
    partial class SettingsDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsDialog));
            this.wbViewer = new System.Windows.Forms.WebBrowser();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBrowseString = new System.Windows.Forms.Button();
            this.btnBrowseNumber = new System.Windows.Forms.Button();
            this.btnBrowseBoolean = new System.Windows.Forms.Button();
            this.btnBrowseNull = new System.Windows.Forms.Button();
            this.btnBrowseKey = new System.Windows.Forms.Button();
            this.btnBrowseBrackets = new System.Windows.Forms.Button();
            this.btnBrowseBraces = new System.Windows.Forms.Button();
            this.btnBrowseBackground = new System.Windows.Forms.Button();
            this.txtNumberColor = new System.Windows.Forms.TextBox();
            this.txtBooleanColor = new System.Windows.Forms.TextBox();
            this.txtNullColor = new System.Windows.Forms.TextBox();
            this.txtKeyColor = new System.Windows.Forms.TextBox();
            this.txtBracketsColor = new System.Windows.Forms.TextBox();
            this.txtBracesColor = new System.Windows.Forms.TextBox();
            this.txtBackgroundColor = new System.Windows.Forms.TextBox();
            this.txtStringColor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblBackground = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.lblNull = new System.Windows.Forms.Label();
            this.lblBoolean = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblString = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wbViewer
            // 
            this.wbViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wbViewer.Location = new System.Drawing.Point(257, 0);
            this.wbViewer.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbViewer.Name = "wbViewer";
            this.wbViewer.Size = new System.Drawing.Size(540, 520);
            this.wbViewer.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btnBrowseString);
            this.groupBox1.Controls.Add(this.btnBrowseNumber);
            this.groupBox1.Controls.Add(this.btnBrowseBoolean);
            this.groupBox1.Controls.Add(this.btnBrowseNull);
            this.groupBox1.Controls.Add(this.btnBrowseKey);
            this.groupBox1.Controls.Add(this.btnBrowseBrackets);
            this.groupBox1.Controls.Add(this.btnBrowseBraces);
            this.groupBox1.Controls.Add(this.btnBrowseBackground);
            this.groupBox1.Controls.Add(this.txtNumberColor);
            this.groupBox1.Controls.Add(this.txtBooleanColor);
            this.groupBox1.Controls.Add(this.txtNullColor);
            this.groupBox1.Controls.Add(this.txtKeyColor);
            this.groupBox1.Controls.Add(this.txtBracketsColor);
            this.groupBox1.Controls.Add(this.txtBracesColor);
            this.groupBox1.Controls.Add(this.txtBackgroundColor);
            this.groupBox1.Controls.Add(this.txtStringColor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.lblBackground);
            this.groupBox1.Controls.Add(this.lblKey);
            this.groupBox1.Controls.Add(this.lblNull);
            this.groupBox1.Controls.Add(this.lblBoolean);
            this.groupBox1.Controls.Add(this.lblNumber);
            this.groupBox1.Controls.Add(this.lblString);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 496);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Colors";
            // 
            // btnBrowseString
            // 
            this.btnBrowseString.Location = new System.Drawing.Point(209, 30);
            this.btnBrowseString.Name = "btnBrowseString";
            this.btnBrowseString.Size = new System.Drawing.Size(24, 20);
            this.btnBrowseString.TabIndex = 3;
            this.btnBrowseString.Text = "...";
            this.btnBrowseString.UseVisualStyleBackColor = true;
            this.btnBrowseString.Click += new System.EventHandler(this.btnBrowseClick);
            // 
            // btnBrowseNumber
            // 
            this.btnBrowseNumber.Location = new System.Drawing.Point(209, 56);
            this.btnBrowseNumber.Name = "btnBrowseNumber";
            this.btnBrowseNumber.Size = new System.Drawing.Size(24, 20);
            this.btnBrowseNumber.TabIndex = 3;
            this.btnBrowseNumber.Text = "...";
            this.btnBrowseNumber.UseVisualStyleBackColor = true;
            this.btnBrowseNumber.Click += new System.EventHandler(this.btnBrowseClick);
            // 
            // btnBrowseBoolean
            // 
            this.btnBrowseBoolean.Location = new System.Drawing.Point(209, 80);
            this.btnBrowseBoolean.Name = "btnBrowseBoolean";
            this.btnBrowseBoolean.Size = new System.Drawing.Size(24, 20);
            this.btnBrowseBoolean.TabIndex = 3;
            this.btnBrowseBoolean.Text = "...";
            this.btnBrowseBoolean.UseVisualStyleBackColor = true;
            this.btnBrowseBoolean.Click += new System.EventHandler(this.btnBrowseClick);
            // 
            // btnBrowseNull
            // 
            this.btnBrowseNull.Location = new System.Drawing.Point(209, 108);
            this.btnBrowseNull.Name = "btnBrowseNull";
            this.btnBrowseNull.Size = new System.Drawing.Size(24, 20);
            this.btnBrowseNull.TabIndex = 3;
            this.btnBrowseNull.Text = "...";
            this.btnBrowseNull.UseVisualStyleBackColor = true;
            this.btnBrowseNull.Click += new System.EventHandler(this.btnBrowseClick);
            // 
            // btnBrowseKey
            // 
            this.btnBrowseKey.Location = new System.Drawing.Point(209, 134);
            this.btnBrowseKey.Name = "btnBrowseKey";
            this.btnBrowseKey.Size = new System.Drawing.Size(24, 20);
            this.btnBrowseKey.TabIndex = 3;
            this.btnBrowseKey.Text = "...";
            this.btnBrowseKey.UseVisualStyleBackColor = true;
            this.btnBrowseKey.Click += new System.EventHandler(this.btnBrowseClick);
            // 
            // btnBrowseBrackets
            // 
            this.btnBrowseBrackets.Location = new System.Drawing.Point(209, 186);
            this.btnBrowseBrackets.Name = "btnBrowseBrackets";
            this.btnBrowseBrackets.Size = new System.Drawing.Size(24, 20);
            this.btnBrowseBrackets.TabIndex = 3;
            this.btnBrowseBrackets.Text = "...";
            this.btnBrowseBrackets.UseVisualStyleBackColor = true;
            this.btnBrowseBrackets.Click += new System.EventHandler(this.btnBrowseClick);
            // 
            // btnBrowseBraces
            // 
            this.btnBrowseBraces.Location = new System.Drawing.Point(209, 160);
            this.btnBrowseBraces.Name = "btnBrowseBraces";
            this.btnBrowseBraces.Size = new System.Drawing.Size(24, 20);
            this.btnBrowseBraces.TabIndex = 3;
            this.btnBrowseBraces.Text = "...";
            this.btnBrowseBraces.UseVisualStyleBackColor = true;
            this.btnBrowseBraces.Click += new System.EventHandler(this.btnBrowseClick);
            // 
            // btnBrowseBackground
            // 
            this.btnBrowseBackground.Location = new System.Drawing.Point(209, 212);
            this.btnBrowseBackground.Name = "btnBrowseBackground";
            this.btnBrowseBackground.Size = new System.Drawing.Size(24, 20);
            this.btnBrowseBackground.TabIndex = 3;
            this.btnBrowseBackground.Text = "...";
            this.btnBrowseBackground.UseVisualStyleBackColor = true;
            this.btnBrowseBackground.Click += new System.EventHandler(this.btnBrowseClick);
            // 
            // txtNumberColor
            // 
            this.txtNumberColor.Location = new System.Drawing.Point(133, 56);
            this.txtNumberColor.Name = "txtNumberColor";
            this.txtNumberColor.Size = new System.Drawing.Size(70, 20);
            this.txtNumberColor.TabIndex = 2;
            // 
            // txtBooleanColor
            // 
            this.txtBooleanColor.Location = new System.Drawing.Point(133, 82);
            this.txtBooleanColor.Name = "txtBooleanColor";
            this.txtBooleanColor.Size = new System.Drawing.Size(70, 20);
            this.txtBooleanColor.TabIndex = 2;
            // 
            // txtNullColor
            // 
            this.txtNullColor.Location = new System.Drawing.Point(133, 108);
            this.txtNullColor.Name = "txtNullColor";
            this.txtNullColor.Size = new System.Drawing.Size(70, 20);
            this.txtNullColor.TabIndex = 2;
            // 
            // txtKeyColor
            // 
            this.txtKeyColor.Location = new System.Drawing.Point(133, 134);
            this.txtKeyColor.Name = "txtKeyColor";
            this.txtKeyColor.Size = new System.Drawing.Size(70, 20);
            this.txtKeyColor.TabIndex = 2;
            // 
            // txtBracketsColor
            // 
            this.txtBracketsColor.Location = new System.Drawing.Point(133, 186);
            this.txtBracketsColor.Name = "txtBracketsColor";
            this.txtBracketsColor.Size = new System.Drawing.Size(70, 20);
            this.txtBracketsColor.TabIndex = 2;
            // 
            // txtBracesColor
            // 
            this.txtBracesColor.Location = new System.Drawing.Point(133, 160);
            this.txtBracesColor.Name = "txtBracesColor";
            this.txtBracesColor.Size = new System.Drawing.Size(70, 20);
            this.txtBracesColor.TabIndex = 2;
            // 
            // txtBackgroundColor
            // 
            this.txtBackgroundColor.Location = new System.Drawing.Point(133, 212);
            this.txtBackgroundColor.Name = "txtBackgroundColor";
            this.txtBackgroundColor.Size = new System.Drawing.Size(70, 20);
            this.txtBackgroundColor.TabIndex = 2;
            // 
            // txtStringColor
            // 
            this.txtStringColor.Location = new System.Drawing.Point(133, 30);
            this.txtStringColor.Name = "txtStringColor";
            this.txtStringColor.Size = new System.Drawing.Size(70, 20);
            this.txtStringColor.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Brackets []";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(158, 467);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Braces {}";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(77, 467);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblBackground
            // 
            this.lblBackground.AutoSize = true;
            this.lblBackground.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBackground.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackground.Location = new System.Drawing.Point(6, 212);
            this.lblBackground.Name = "lblBackground";
            this.lblBackground.Size = new System.Drawing.Size(108, 18);
            this.lblBackground.TabIndex = 0;
            this.lblBackground.Text = "Background";
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblKey.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKey.Location = new System.Drawing.Point(6, 134);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(38, 18);
            this.lblKey.TabIndex = 0;
            this.lblKey.Text = "Key";
            // 
            // lblNull
            // 
            this.lblNull.AutoSize = true;
            this.lblNull.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNull.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNull.Location = new System.Drawing.Point(6, 108);
            this.lblNull.Name = "lblNull";
            this.lblNull.Size = new System.Drawing.Size(48, 18);
            this.lblNull.TabIndex = 0;
            this.lblNull.Text = "Null";
            // 
            // lblBoolean
            // 
            this.lblBoolean.AutoSize = true;
            this.lblBoolean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBoolean.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoolean.Location = new System.Drawing.Point(6, 82);
            this.lblBoolean.Name = "lblBoolean";
            this.lblBoolean.Size = new System.Drawing.Size(78, 18);
            this.lblBoolean.TabIndex = 0;
            this.lblBoolean.Text = "Boolean";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNumber.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(6, 56);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(68, 18);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Number";
            // 
            // lblString
            // 
            this.lblString.AutoSize = true;
            this.lblString.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblString.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblString.Location = new System.Drawing.Point(6, 30);
            this.lblString.Name = "lblString";
            this.lblString.Size = new System.Drawing.Size(68, 18);
            this.lblString.TabIndex = 0;
            this.lblString.Text = "String";
            // 
            // SettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 520);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.wbViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsDialog";
            this.Text = "Shorthand Json Visualizer";
            this.Load += new System.EventHandler(this.SettingsDialog_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbViewer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblString;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lblBoolean;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblBackground;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label lblNull;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtNumberColor;
        private System.Windows.Forms.TextBox txtBooleanColor;
        private System.Windows.Forms.TextBox txtNullColor;
        private System.Windows.Forms.TextBox txtKeyColor;
        private System.Windows.Forms.TextBox txtBackgroundColor;
        private System.Windows.Forms.TextBox txtStringColor;
        private System.Windows.Forms.Button btnBrowseString;
        private System.Windows.Forms.Button btnBrowseNumber;
        private System.Windows.Forms.Button btnBrowseBoolean;
        private System.Windows.Forms.Button btnBrowseNull;
        private System.Windows.Forms.Button btnBrowseKey;
        private System.Windows.Forms.Button btnBrowseBackground;
        private System.Windows.Forms.Button btnBrowseBrackets;
        private System.Windows.Forms.Button btnBrowseBraces;
        private System.Windows.Forms.TextBox txtBracketsColor;
        private System.Windows.Forms.TextBox txtBracesColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}