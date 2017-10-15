namespace MyRaceMonitor
{
    partial class GraphicalDisplay
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
            this.boxPanelLabel = new System.Windows.Forms.Label();
            this.boxPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // boxPanelLabel
            // 
            this.boxPanelLabel.AutoSize = true;
            this.boxPanelLabel.Location = new System.Drawing.Point(26, 25);
            this.boxPanelLabel.Name = "boxPanelLabel";
            this.boxPanelLabel.Size = new System.Drawing.Size(127, 13);
            this.boxPanelLabel.TabIndex = 3;
            this.boxPanelLabel.Tag = "";
            this.boxPanelLabel.Text = "Athletes Current Positions";
            // 
            // boxPanel
            // 
            this.boxPanel.BackColor = System.Drawing.Color.White;
            this.boxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxPanel.Location = new System.Drawing.Point(25, 42);
            this.boxPanel.Name = "boxPanel";
            this.boxPanel.Size = new System.Drawing.Size(600, 181);
            this.boxPanel.TabIndex = 2;
            // 
            // GraphicalDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 273);
            this.Controls.Add(this.boxPanelLabel);
            this.Controls.Add(this.boxPanel);
            this.Name = "GraphicalDisplay";
            this.Text = "GraphicalDisplay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label boxPanelLabel;
        private System.Windows.Forms.Panel boxPanel;
    }
}