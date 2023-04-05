namespace Conversions_Ben_Leberg
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
            this.inputTextbox = new System.Windows.Forms.TextBox();
            this.convertLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.inputNumberTextbox = new System.Windows.Forms.TextBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.goButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputTextbox
            // 
            this.inputTextbox.Location = new System.Drawing.Point(309, 134);
            this.inputTextbox.Name = "inputTextbox";
            this.inputTextbox.Size = new System.Drawing.Size(82, 22);
            this.inputTextbox.TabIndex = 0;
            // 
            // convertLabel
            // 
            this.convertLabel.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertLabel.Location = new System.Drawing.Point(148, 121);
            this.convertLabel.Name = "convertLabel";
            this.convertLabel.Size = new System.Drawing.Size(435, 47);
            this.convertLabel.TabIndex = 1;
            this.convertLabel.Text = "CONVERT: ______ to: _____";
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(148, 235);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(435, 47);
            this.outputLabel.TabIndex = 2;
            this.outputLabel.Text = "ANSWER:";
            // 
            // inputNumberTextbox
            // 
            this.inputNumberTextbox.Location = new System.Drawing.Point(442, 134);
            this.inputNumberTextbox.Name = "inputNumberTextbox";
            this.inputNumberTextbox.Size = new System.Drawing.Size(67, 22);
            this.inputNumberTextbox.TabIndex = 3;
            // 
            // infoLabel
            // 
            this.infoLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(12, 282);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(776, 58);
            this.infoLabel.TabIndex = 4;
            this.infoLabel.Text = "1: Inch to Cm 2: Ft to Cm 3: Yards to Meters 4: Miles to Killometers";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(155, 159);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(138, 73);
            this.goButton.TabIndex = 5;
            this.goButton.Text = "GO";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.inputNumberTextbox);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.inputTextbox);
            this.Controls.Add(this.convertLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextbox;
        private System.Windows.Forms.Label convertLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox inputNumberTextbox;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button goButton;
    }
}

