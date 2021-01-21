
namespace ConcreteBeamCalculator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.calculateButton = new System.Windows.Forms.Button();
            this.mainTabpage = new System.Windows.Forms.TabControl();
            this.factorsTab = new System.Windows.Forms.TabPage();
            this.concreteFactorLabel = new System.Windows.Forms.Label();
            this.steelFactorLabel = new System.Windows.Forms.Label();
            this.concreteFactorTextbox = new System.Windows.Forms.TextBox();
            this.steelFactorTextbox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.depthTextbox = new System.Windows.Forms.TextBox();
            this.depthLabel = new System.Windows.Forms.Label();
            this.dimensionGroupbox = new System.Windows.Forms.GroupBox();
            this.steelAreaLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.steelAreaTextbox = new System.Windows.Forms.TextBox();
            this.widthTextbox = new System.Windows.Forms.TextBox();
            this.strengthGroupbox = new System.Windows.Forms.GroupBox();
            this.concreteStrengthLabel = new System.Windows.Forms.Label();
            this.steelStrengthLabel = new System.Windows.Forms.Label();
            this.concreteStrengthTextbox = new System.Windows.Forms.TextBox();
            this.steelStrengthTextbox = new System.Windows.Forms.TextBox();
            this.answerTextbox = new System.Windows.Forms.TextBox();
            this.factorsCheckbox = new System.Windows.Forms.CheckBox();
            this.mainTabpage.SuspendLayout();
            this.factorsTab.SuspendLayout();
            this.dimensionGroupbox.SuspendLayout();
            this.strengthGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.calculateButton.Location = new System.Drawing.Point(12, 293);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "&Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // mainTabpage
            // 
            this.mainTabpage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabpage.Controls.Add(this.factorsTab);
            this.mainTabpage.Controls.Add(this.tabPage2);
            this.mainTabpage.Location = new System.Drawing.Point(281, 13);
            this.mainTabpage.Name = "mainTabpage";
            this.mainTabpage.SelectedIndex = 0;
            this.mainTabpage.Size = new System.Drawing.Size(217, 272);
            this.mainTabpage.TabIndex = 1;
            // 
            // factorsTab
            // 
            this.factorsTab.Controls.Add(this.factorsCheckbox);
            this.factorsTab.Controls.Add(this.concreteFactorLabel);
            this.factorsTab.Controls.Add(this.steelFactorLabel);
            this.factorsTab.Controls.Add(this.concreteFactorTextbox);
            this.factorsTab.Controls.Add(this.steelFactorTextbox);
            this.factorsTab.Location = new System.Drawing.Point(4, 24);
            this.factorsTab.Name = "factorsTab";
            this.factorsTab.Padding = new System.Windows.Forms.Padding(3);
            this.factorsTab.Size = new System.Drawing.Size(209, 244);
            this.factorsTab.TabIndex = 0;
            this.factorsTab.Text = "Factors";
            this.factorsTab.UseVisualStyleBackColor = true;
            // 
            // concreteFactorLabel
            // 
            this.concreteFactorLabel.Location = new System.Drawing.Point(9, 56);
            this.concreteFactorLabel.Name = "concreteFactorLabel";
            this.concreteFactorLabel.Size = new System.Drawing.Size(70, 20);
            this.concreteFactorLabel.TabIndex = 3;
            this.concreteFactorLabel.Text = "Concrete";
            this.concreteFactorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // steelFactorLabel
            // 
            this.steelFactorLabel.Location = new System.Drawing.Point(9, 16);
            this.steelFactorLabel.Name = "steelFactorLabel";
            this.steelFactorLabel.Size = new System.Drawing.Size(70, 20);
            this.steelFactorLabel.TabIndex = 3;
            this.steelFactorLabel.Text = "Steel";
            this.steelFactorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // concreteFactorTextbox
            // 
            this.concreteFactorTextbox.ForeColor = System.Drawing.Color.Red;
            this.concreteFactorTextbox.Location = new System.Drawing.Point(85, 56);
            this.concreteFactorTextbox.Name = "concreteFactorTextbox";
            this.concreteFactorTextbox.Size = new System.Drawing.Size(100, 23);
            this.concreteFactorTextbox.TabIndex = 2;
            this.concreteFactorTextbox.Leave += new System.EventHandler(this.factorTextbox_Leave);
            // 
            // steelFactorTextbox
            // 
            this.steelFactorTextbox.ForeColor = System.Drawing.Color.Red;
            this.steelFactorTextbox.Location = new System.Drawing.Point(85, 16);
            this.steelFactorTextbox.Name = "steelFactorTextbox";
            this.steelFactorTextbox.Size = new System.Drawing.Size(100, 23);
            this.steelFactorTextbox.TabIndex = 2;
            this.steelFactorTextbox.Leave += new System.EventHandler(this.factorTextbox_Leave);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(209, 244);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // depthTextbox
            // 
            this.depthTextbox.ForeColor = System.Drawing.Color.Red;
            this.depthTextbox.Location = new System.Drawing.Point(134, 25);
            this.depthTextbox.Name = "depthTextbox";
            this.depthTextbox.Size = new System.Drawing.Size(100, 23);
            this.depthTextbox.TabIndex = 2;
            this.depthTextbox.Leave += new System.EventHandler(this.depthTextbox_Leave);
            // 
            // depthLabel
            // 
            this.depthLabel.Location = new System.Drawing.Point(18, 28);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(110, 23);
            this.depthLabel.TabIndex = 3;
            this.depthLabel.Text = "Depth (mm)";
            this.depthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dimensionGroupbox
            // 
            this.dimensionGroupbox.Controls.Add(this.steelAreaLabel);
            this.dimensionGroupbox.Controls.Add(this.widthLabel);
            this.dimensionGroupbox.Controls.Add(this.depthLabel);
            this.dimensionGroupbox.Controls.Add(this.steelAreaTextbox);
            this.dimensionGroupbox.Controls.Add(this.widthTextbox);
            this.dimensionGroupbox.Controls.Add(this.depthTextbox);
            this.dimensionGroupbox.Location = new System.Drawing.Point(12, 13);
            this.dimensionGroupbox.Name = "dimensionGroupbox";
            this.dimensionGroupbox.Size = new System.Drawing.Size(253, 127);
            this.dimensionGroupbox.TabIndex = 4;
            this.dimensionGroupbox.TabStop = false;
            this.dimensionGroupbox.Text = "Beam Properties";
            // 
            // steelAreaLabel
            // 
            this.steelAreaLabel.Location = new System.Drawing.Point(18, 83);
            this.steelAreaLabel.Name = "steelAreaLabel";
            this.steelAreaLabel.Size = new System.Drawing.Size(110, 20);
            this.steelAreaLabel.TabIndex = 3;
            this.steelAreaLabel.Text = "Steel Area (mm2)";
            this.steelAreaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // widthLabel
            // 
            this.widthLabel.Location = new System.Drawing.Point(18, 54);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(110, 20);
            this.widthLabel.TabIndex = 3;
            this.widthLabel.Text = "Width (mm)";
            this.widthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // steelAreaTextbox
            // 
            this.steelAreaTextbox.ForeColor = System.Drawing.Color.Red;
            this.steelAreaTextbox.Location = new System.Drawing.Point(134, 83);
            this.steelAreaTextbox.Name = "steelAreaTextbox";
            this.steelAreaTextbox.Size = new System.Drawing.Size(100, 23);
            this.steelAreaTextbox.TabIndex = 2;
            this.steelAreaTextbox.Leave += new System.EventHandler(this.depthTextbox_Leave);
            // 
            // widthTextbox
            // 
            this.widthTextbox.ForeColor = System.Drawing.Color.Red;
            this.widthTextbox.Location = new System.Drawing.Point(134, 54);
            this.widthTextbox.Name = "widthTextbox";
            this.widthTextbox.Size = new System.Drawing.Size(100, 23);
            this.widthTextbox.TabIndex = 2;
            this.widthTextbox.Leave += new System.EventHandler(this.depthTextbox_Leave);
            // 
            // strengthGroupbox
            // 
            this.strengthGroupbox.Controls.Add(this.concreteStrengthLabel);
            this.strengthGroupbox.Controls.Add(this.steelStrengthLabel);
            this.strengthGroupbox.Controls.Add(this.concreteStrengthTextbox);
            this.strengthGroupbox.Controls.Add(this.steelStrengthTextbox);
            this.strengthGroupbox.Location = new System.Drawing.Point(12, 156);
            this.strengthGroupbox.Name = "strengthGroupbox";
            this.strengthGroupbox.Size = new System.Drawing.Size(253, 127);
            this.strengthGroupbox.TabIndex = 4;
            this.strengthGroupbox.TabStop = false;
            this.strengthGroupbox.Text = "Material Strength";
            // 
            // concreteStrengthLabel
            // 
            this.concreteStrengthLabel.Location = new System.Drawing.Point(18, 54);
            this.concreteStrengthLabel.Name = "concreteStrengthLabel";
            this.concreteStrengthLabel.Size = new System.Drawing.Size(110, 20);
            this.concreteStrengthLabel.TabIndex = 3;
            this.concreteStrengthLabel.Text = "Concrete (MPa)";
            this.concreteStrengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // steelStrengthLabel
            // 
            this.steelStrengthLabel.Location = new System.Drawing.Point(18, 28);
            this.steelStrengthLabel.Name = "steelStrengthLabel";
            this.steelStrengthLabel.Size = new System.Drawing.Size(110, 23);
            this.steelStrengthLabel.TabIndex = 3;
            this.steelStrengthLabel.Text = "Steel (MPa)";
            this.steelStrengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // concreteStrengthTextbox
            // 
            this.concreteStrengthTextbox.ForeColor = System.Drawing.Color.Red;
            this.concreteStrengthTextbox.Location = new System.Drawing.Point(134, 54);
            this.concreteStrengthTextbox.Name = "concreteStrengthTextbox";
            this.concreteStrengthTextbox.Size = new System.Drawing.Size(100, 23);
            this.concreteStrengthTextbox.TabIndex = 2;
            this.concreteStrengthTextbox.Leave += new System.EventHandler(this.depthTextbox_Leave);
            // 
            // steelStrengthTextbox
            // 
            this.steelStrengthTextbox.ForeColor = System.Drawing.Color.Red;
            this.steelStrengthTextbox.Location = new System.Drawing.Point(134, 25);
            this.steelStrengthTextbox.Name = "steelStrengthTextbox";
            this.steelStrengthTextbox.Size = new System.Drawing.Size(100, 23);
            this.steelStrengthTextbox.TabIndex = 2;
            this.steelStrengthTextbox.Leave += new System.EventHandler(this.depthTextbox_Leave);
            // 
            // answerTextbox
            // 
            this.answerTextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.answerTextbox.Location = new System.Drawing.Point(128, 293);
            this.answerTextbox.Name = "answerTextbox";
            this.answerTextbox.ReadOnly = true;
            this.answerTextbox.Size = new System.Drawing.Size(366, 29);
            this.answerTextbox.TabIndex = 2;
            // 
            // factorsCheckbox
            // 
            this.factorsCheckbox.AutoSize = true;
            this.factorsCheckbox.Location = new System.Drawing.Point(85, 95);
            this.factorsCheckbox.Name = "factorsCheckbox";
            this.factorsCheckbox.Size = new System.Drawing.Size(91, 19);
            this.factorsCheckbox.TabIndex = 4;
            this.factorsCheckbox.Text = "Use Defaults";
            this.factorsCheckbox.UseVisualStyleBackColor = true;
            this.factorsCheckbox.CheckedChanged += new System.EventHandler(this.factorsCheckbox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 328);
            this.Controls.Add(this.mainTabpage);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.answerTextbox);
            this.Controls.Add(this.strengthGroupbox);
            this.Controls.Add(this.dimensionGroupbox);
            this.Name = "MainForm";
            this.Text = "Concrete Beam Calculator";
            this.mainTabpage.ResumeLayout(false);
            this.factorsTab.ResumeLayout(false);
            this.factorsTab.PerformLayout();
            this.dimensionGroupbox.ResumeLayout(false);
            this.dimensionGroupbox.PerformLayout();
            this.strengthGroupbox.ResumeLayout(false);
            this.strengthGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TabControl mainTabpage;
        private System.Windows.Forms.TabPage factorsTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox depthTextbox;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.GroupBox dimensionGroupbox;
        private System.Windows.Forms.Label steelAreaLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.TextBox steelAreaTextbox;
        private System.Windows.Forms.TextBox widthTextbox;
        private System.Windows.Forms.GroupBox strengthGroupbox;
        private System.Windows.Forms.Label concreteStrengthLabel;
        private System.Windows.Forms.Label steelStrengthLabel;
        private System.Windows.Forms.TextBox concreteStrengthTextbox;
        private System.Windows.Forms.TextBox steelStrengthTextbox;
        private System.Windows.Forms.Label concreteFactorLabel;
        private System.Windows.Forms.Label steelFactorLabel;
        private System.Windows.Forms.TextBox concreteFactorTextbox;
        private System.Windows.Forms.TextBox steelFactorTextbox;
        private System.Windows.Forms.TextBox answerTextbox;
        private System.Windows.Forms.CheckBox factorsCheckbox;
    }
}

