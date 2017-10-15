namespace MyRaceMonitor
{
    partial class MainForm
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
            this.lvObservers = new System.Windows.Forms.ListView();
            this.observersLabel = new System.Windows.Forms.Label();
            this.btSubscribe = new System.Windows.Forms.Button();
            this.btUnscribe = new System.Windows.Forms.Button();
            this.lvObservedAthletes = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.observedBallsLabel = new System.Windows.Forms.Label();
            this.otherBallLabel = new System.Windows.Forms.Label();
            this.lvCurrentAthlete = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbRaceEvent = new System.Windows.Forms.ComboBox();
            this.cbRaceCourse = new System.Windows.Forms.ComboBox();
            this.btCreateObserver = new System.Windows.Forms.Button();
            this.btStartRace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvObservers
            // 
            this.lvObservers.Location = new System.Drawing.Point(13, 33);
            this.lvObservers.Margin = new System.Windows.Forms.Padding(4);
            this.lvObservers.MultiSelect = false;
            this.lvObservers.Name = "lvObservers";
            this.lvObservers.Size = new System.Drawing.Size(262, 118);
            this.lvObservers.TabIndex = 31;
            this.lvObservers.UseCompatibleStateImageBehavior = false;
            this.lvObservers.View = System.Windows.Forms.View.List;
            // 
            // observersLabel
            // 
            this.observersLabel.AutoSize = true;
            this.observersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.observersLabel.Location = new System.Drawing.Point(13, 13);
            this.observersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.observersLabel.Name = "observersLabel";
            this.observersLabel.Size = new System.Drawing.Size(75, 15);
            this.observersLabel.TabIndex = 30;
            this.observersLabel.Text = "Observers:";
            // 
            // btSubscribe
            // 
            this.btSubscribe.Location = new System.Drawing.Point(322, 326);
            this.btSubscribe.Margin = new System.Windows.Forms.Padding(4);
            this.btSubscribe.Name = "btSubscribe";
            this.btSubscribe.Size = new System.Drawing.Size(55, 26);
            this.btSubscribe.TabIndex = 29;
            this.btSubscribe.Text = "<";
            this.btSubscribe.UseVisualStyleBackColor = true;
            this.btSubscribe.Click += new System.EventHandler(this.btSubscribe_Click);
            // 
            // btUnscribe
            // 
            this.btUnscribe.Location = new System.Drawing.Point(322, 371);
            this.btUnscribe.Margin = new System.Windows.Forms.Padding(4);
            this.btUnscribe.Name = "btUnscribe";
            this.btUnscribe.Size = new System.Drawing.Size(55, 26);
            this.btUnscribe.TabIndex = 28;
            this.btUnscribe.Text = ">";
            this.btUnscribe.UseVisualStyleBackColor = true;
            this.btUnscribe.Click += new System.EventHandler(this.btUnscribe_Click);
            // 
            // lvObservedAthletes
            // 
            this.lvObservedAthletes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader8});
            this.lvObservedAthletes.FullRowSelect = true;
            this.lvObservedAthletes.Location = new System.Drawing.Point(10, 233);
            this.lvObservedAthletes.Margin = new System.Windows.Forms.Padding(4);
            this.lvObservedAthletes.Name = "lvObservedAthletes";
            this.lvObservedAthletes.Size = new System.Drawing.Size(303, 310);
            this.lvObservedAthletes.TabIndex = 27;
            this.lvObservedAthletes.UseCompatibleStateImageBehavior = false;
            this.lvObservedAthletes.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Bib#";
            this.columnHeader4.Width = 45;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Name";
            this.columnHeader5.Width = 111;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Age";
            this.columnHeader6.Width = 37;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Status";
            this.columnHeader8.Width = 104;
            // 
            // observedBallsLabel
            // 
            this.observedBallsLabel.AutoSize = true;
            this.observedBallsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.observedBallsLabel.Location = new System.Drawing.Point(9, 211);
            this.observedBallsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.observedBallsLabel.Name = "observedBallsLabel";
            this.observedBallsLabel.Size = new System.Drawing.Size(103, 15);
            this.observedBallsLabel.TabIndex = 26;
            this.observedBallsLabel.Text = "Subscribed To:";
            // 
            // otherBallLabel
            // 
            this.otherBallLabel.AutoSize = true;
            this.otherBallLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherBallLabel.Location = new System.Drawing.Point(395, 211);
            this.otherBallLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.otherBallLabel.Name = "otherBallLabel";
            this.otherBallLabel.Size = new System.Drawing.Size(113, 15);
            this.otherBallLabel.TabIndex = 25;
            this.otherBallLabel.Text = "Current Athletes:";
            // 
            // lvCurrentAthlete
            // 
            this.lvCurrentAthlete.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader7});
            this.lvCurrentAthlete.FullRowSelect = true;
            this.lvCurrentAthlete.Location = new System.Drawing.Point(385, 233);
            this.lvCurrentAthlete.Margin = new System.Windows.Forms.Padding(4);
            this.lvCurrentAthlete.Name = "lvCurrentAthlete";
            this.lvCurrentAthlete.Size = new System.Drawing.Size(303, 310);
            this.lvCurrentAthlete.TabIndex = 24;
            this.lvCurrentAthlete.UseCompatibleStateImageBehavior = false;
            this.lvCurrentAthlete.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Bib#";
            this.columnHeader1.Width = 45;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 111;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Age";
            this.columnHeader3.Width = 37;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Status";
            this.columnHeader7.Width = 104;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(382, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Race Event:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(382, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Race Course:";
            // 
            // cbRaceEvent
            // 
            this.cbRaceEvent.FormattingEnabled = true;
            this.cbRaceEvent.Items.AddRange(new object[] {
            "Color Fun Run (5k)",
            "Run for a Cure (10k)",
            "Logan Half-Marathon (13.1 miles)",
            "Miserable Marathon (26.2 miles)",
            "Wasatch Back Ragnar (200 miles)"});
            this.cbRaceEvent.Location = new System.Drawing.Point(473, 82);
            this.cbRaceEvent.Margin = new System.Windows.Forms.Padding(4);
            this.cbRaceEvent.Name = "cbRaceEvent";
            this.cbRaceEvent.Size = new System.Drawing.Size(209, 21);
            this.cbRaceEvent.TabIndex = 21;
            this.cbRaceEvent.SelectedIndexChanged += new System.EventHandler(this.cbRaceEvent_SelectedIndexChanged);
            // 
            // cbRaceCourse
            // 
            this.cbRaceCourse.FormattingEnabled = true;
            this.cbRaceCourse.Items.AddRange(new object[] {
            "Short Race Simulation",
            "Long Race Simulation"});
            this.cbRaceCourse.Location = new System.Drawing.Point(473, 39);
            this.cbRaceCourse.Margin = new System.Windows.Forms.Padding(4);
            this.cbRaceCourse.Name = "cbRaceCourse";
            this.cbRaceCourse.Size = new System.Drawing.Size(209, 21);
            this.cbRaceCourse.TabIndex = 20;
            this.cbRaceCourse.SelectedIndexChanged += new System.EventHandler(this.cbRaceCourse_SelectedIndexChanged);
            // 
            // btCreateObserver
            // 
            this.btCreateObserver.Location = new System.Drawing.Point(10, 157);
            this.btCreateObserver.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btCreateObserver.Name = "btCreateObserver";
            this.btCreateObserver.Size = new System.Drawing.Size(119, 24);
            this.btCreateObserver.TabIndex = 32;
            this.btCreateObserver.Text = "New Observer";
            this.btCreateObserver.UseVisualStyleBackColor = true;
            this.btCreateObserver.Click += new System.EventHandler(this.btCreateObserver_Click);
            // 
            // btStartRace
            // 
            this.btStartRace.Location = new System.Drawing.Point(440, 132);
            this.btStartRace.Margin = new System.Windows.Forms.Padding(4);
            this.btStartRace.Name = "btStartRace";
            this.btStartRace.Size = new System.Drawing.Size(189, 49);
            this.btStartRace.TabIndex = 19;
            this.btStartRace.Text = "Start Race";
            this.btStartRace.UseVisualStyleBackColor = true;
            this.btStartRace.Click += new System.EventHandler(this.btStartRace_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 560);
            this.Controls.Add(this.lvObservers);
            this.Controls.Add(this.observersLabel);
            this.Controls.Add(this.btSubscribe);
            this.Controls.Add(this.btUnscribe);
            this.Controls.Add(this.lvObservedAthletes);
            this.Controls.Add(this.observedBallsLabel);
            this.Controls.Add(this.otherBallLabel);
            this.Controls.Add(this.lvCurrentAthlete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbRaceEvent);
            this.Controls.Add(this.cbRaceCourse);
            this.Controls.Add(this.btCreateObserver);
            this.Controls.Add(this.btStartRace);
            this.Name = "MainForm";
            this.Text = "Race Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvObservers;
        private System.Windows.Forms.Label observersLabel;
        private System.Windows.Forms.Button btSubscribe;
        private System.Windows.Forms.Button btUnscribe;
        private System.Windows.Forms.ListView lvObservedAthletes;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label observedBallsLabel;
        private System.Windows.Forms.Label otherBallLabel;
        private System.Windows.Forms.ListView lvCurrentAthlete;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbRaceEvent;
        private System.Windows.Forms.ComboBox cbRaceCourse;
        private System.Windows.Forms.Button btCreateObserver;
        private System.Windows.Forms.Button btStartRace;
    }
}