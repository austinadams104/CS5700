namespace MyRaceMonitor
{
    partial class ObserverCreatorForm
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
            this.gbObserverType = new System.Windows.Forms.GroupBox();
            this.rdGraphical = new System.Windows.Forms.RadioButton();
            this.rdList = new System.Windows.Forms.RadioButton();
            this.txtObserverTitle = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.btCreate = new System.Windows.Forms.Button();
            this.rdEmail = new System.Windows.Forms.RadioButton();
            this.rdCompare = new System.Windows.Forms.RadioButton();
            this.rdBestTimes = new System.Windows.Forms.RadioButton();
            this.gbObserverType.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbObserverType
            // 
            this.gbObserverType.Controls.Add(this.rdBestTimes);
            this.gbObserverType.Controls.Add(this.rdCompare);
            this.gbObserverType.Controls.Add(this.rdEmail);
            this.gbObserverType.Controls.Add(this.rdGraphical);
            this.gbObserverType.Controls.Add(this.rdList);
            this.gbObserverType.Location = new System.Drawing.Point(11, 10);
            this.gbObserverType.Name = "gbObserverType";
            this.gbObserverType.Size = new System.Drawing.Size(644, 46);
            this.gbObserverType.TabIndex = 9;
            this.gbObserverType.TabStop = false;
            this.gbObserverType.Text = "Observer Type";
            // 
            // rdGraphical
            // 
            this.rdGraphical.AutoSize = true;
            this.rdGraphical.Location = new System.Drawing.Point(114, 19);
            this.rdGraphical.Name = "rdGraphical";
            this.rdGraphical.Size = new System.Drawing.Size(107, 17);
            this.rdGraphical.TabIndex = 1;
            this.rdGraphical.TabStop = true;
            this.rdGraphical.Text = "Graphical Display";
            this.rdGraphical.UseVisualStyleBackColor = true;
            // 
            // rdList
            // 
            this.rdList.AutoSize = true;
            this.rdList.Checked = true;
            this.rdList.Location = new System.Drawing.Point(6, 19);
            this.rdList.Name = "rdList";
            this.rdList.Size = new System.Drawing.Size(78, 17);
            this.rdList.TabIndex = 0;
            this.rdList.TabStop = true;
            this.rdList.Text = "List Display";
            this.rdList.UseVisualStyleBackColor = true;
            // 
            // txtObserverTitle
            // 
            this.txtObserverTitle.Location = new System.Drawing.Point(44, 62);
            this.txtObserverTitle.Name = "txtObserverTitle";
            this.txtObserverTitle.Size = new System.Drawing.Size(585, 20);
            this.txtObserverTitle.TabIndex = 8;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(8, 65);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 13);
            this.titleLabel.TabIndex = 7;
            this.titleLabel.Text = "Title:";
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(210, 88);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 6;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btCreate
            // 
            this.btCreate.Location = new System.Drawing.Point(324, 88);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(93, 23);
            this.btCreate.TabIndex = 5;
            this.btCreate.Text = "Create Observer";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // rdEmail
            // 
            this.rdEmail.AutoSize = true;
            this.rdEmail.Location = new System.Drawing.Point(242, 19);
            this.rdEmail.Name = "rdEmail";
            this.rdEmail.Size = new System.Drawing.Size(111, 17);
            this.rdEmail.TabIndex = 2;
            this.rdEmail.TabStop = true;
            this.rdEmail.Text = "Email Notifications";
            this.rdEmail.UseVisualStyleBackColor = true;
            // 
            // rdCompare
            // 
            this.rdCompare.AutoSize = true;
            this.rdCompare.Location = new System.Drawing.Point(373, 19);
            this.rdCompare.Name = "rdCompare";
            this.rdCompare.Size = new System.Drawing.Size(116, 17);
            this.rdCompare.TabIndex = 3;
            this.rdCompare.TabStop = true;
            this.rdCompare.Text = "Athlete Comparison";
            this.rdCompare.UseVisualStyleBackColor = true;
            // 
            // rdBestTimes
            // 
            this.rdBestTimes.AutoSize = true;
            this.rdBestTimes.Location = new System.Drawing.Point(511, 19);
            this.rdBestTimes.Name = "rdBestTimes";
            this.rdBestTimes.Size = new System.Drawing.Size(77, 17);
            this.rdBestTimes.TabIndex = 4;
            this.rdBestTimes.TabStop = true;
            this.rdBestTimes.Text = "Best Times";
            this.rdBestTimes.UseVisualStyleBackColor = true;
            // 
            // ObserverCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 131);
            this.Controls.Add(this.gbObserverType);
            this.Controls.Add(this.txtObserverTitle);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btCreate);
            this.Name = "ObserverCreatorForm";
            this.Text = "ObserverCreatorForm";
            this.gbObserverType.ResumeLayout(false);
            this.gbObserverType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbObserverType;
        private System.Windows.Forms.RadioButton rdBestTimes;
        private System.Windows.Forms.RadioButton rdCompare;
        private System.Windows.Forms.RadioButton rdEmail;
        private System.Windows.Forms.RadioButton rdGraphical;
        private System.Windows.Forms.RadioButton rdList;
        private System.Windows.Forms.TextBox txtObserverTitle;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btCreate;
    }
}