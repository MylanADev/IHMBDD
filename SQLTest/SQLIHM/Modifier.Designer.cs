
namespace SQLIHM
{
    partial class Modifier
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
            this.groupBoxModifier = new System.Windows.Forms.GroupBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelSexe = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxSexe = new System.Windows.Forms.TextBox();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.groupBoxModifier.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxModifier
            // 
            this.groupBoxModifier.Controls.Add(this.buttonModifier);
            this.groupBoxModifier.Controls.Add(this.textBoxSexe);
            this.groupBoxModifier.Controls.Add(this.textBoxAge);
            this.groupBoxModifier.Controls.Add(this.textBoxPrenom);
            this.groupBoxModifier.Controls.Add(this.textBoxNom);
            this.groupBoxModifier.Controls.Add(this.textBoxID);
            this.groupBoxModifier.Controls.Add(this.labelSexe);
            this.groupBoxModifier.Controls.Add(this.labelAge);
            this.groupBoxModifier.Controls.Add(this.labelPrenom);
            this.groupBoxModifier.Controls.Add(this.labelNom);
            this.groupBoxModifier.Controls.Add(this.labelID);
            this.groupBoxModifier.Location = new System.Drawing.Point(13, 13);
            this.groupBoxModifier.Name = "groupBoxModifier";
            this.groupBoxModifier.Size = new System.Drawing.Size(329, 202);
            this.groupBoxModifier.TabIndex = 0;
            this.groupBoxModifier.TabStop = false;
            this.groupBoxModifier.Text = "Modifier";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(27, 41);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(24, 13);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID :";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(16, 65);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(35, 13);
            this.labelNom.TabIndex = 1;
            this.labelNom.Text = "Nom :";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(2, 87);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(49, 13);
            this.labelPrenom.TabIndex = 2;
            this.labelPrenom.Text = "Prénom :";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(19, 110);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(32, 13);
            this.labelAge.TabIndex = 3;
            this.labelAge.Text = "Âge :";
            // 
            // labelSexe
            // 
            this.labelSexe.AutoSize = true;
            this.labelSexe.Location = new System.Drawing.Point(14, 132);
            this.labelSexe.Name = "labelSexe";
            this.labelSexe.Size = new System.Drawing.Size(37, 13);
            this.labelSexe.TabIndex = 4;
            this.labelSexe.Text = "Sexe :";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(71, 38);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(252, 20);
            this.textBoxID.TabIndex = 5;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(71, 61);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(252, 20);
            this.textBoxNom.TabIndex = 6;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(71, 84);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(252, 20);
            this.textBoxPrenom.TabIndex = 7;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(71, 107);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(252, 20);
            this.textBoxAge.TabIndex = 8;
            // 
            // textBoxSexe
            // 
            this.textBoxSexe.Location = new System.Drawing.Point(71, 129);
            this.textBoxSexe.Name = "textBoxSexe";
            this.textBoxSexe.Size = new System.Drawing.Size(252, 20);
            this.textBoxSexe.TabIndex = 9;
            // 
            // buttonModifier
            // 
            this.buttonModifier.Location = new System.Drawing.Point(6, 173);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(317, 23);
            this.buttonModifier.TabIndex = 10;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // Modifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 227);
            this.Controls.Add(this.groupBoxModifier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Modifier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifier";
            this.groupBoxModifier.ResumeLayout(false);
            this.groupBoxModifier.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxModifier;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.TextBox textBoxSexe;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelSexe;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelID;
    }
}