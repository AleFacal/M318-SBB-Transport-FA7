namespace SwissTransportGUI
{
    partial class HauptForm
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AnzeigeStStationen = new System.Windows.Forms.DataGridView();
            this.AnzeigeEndeStationen = new System.Windows.Forms.DataGridView();
            this.EndVerbindung = new System.Windows.Forms.TextBox();
            this.StartVerbindung = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimeVerbindungen = new System.Windows.Forms.DateTimePicker();
            this.VerbindungenSuchen = new System.Windows.Forms.Button();
            this.ResultVerbindungen = new System.Windows.Forms.DataGridView();
            this.StationenSuche = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.StName = new System.Windows.Forms.TextBox();
            this.StSuche = new System.Windows.Forms.Button();
            this.StAnzeige = new System.Windows.Forms.DataGridView();
            this.AbfahrtsKarte = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.AbfahrtenSuche = new System.Windows.Forms.Button();
            this.AbfahrtStation = new System.Windows.Forms.TextBox();
            this.AbfahrtsFahrten = new System.Windows.Forms.DataGridView();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnzeigeStStationen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnzeigeEndeStationen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultVerbindungen)).BeginInit();
            this.StationenSuche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StAnzeige)).BeginInit();
            this.AbfahrtsKarte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AbfahrtsFahrten)).BeginInit();
            this.TabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer3);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1994, 811);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Verbindungen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.label2);
            this.splitContainer3.Panel1.Controls.Add(this.label1);
            this.splitContainer3.Panel1.Controls.Add(this.AnzeigeStStationen);
            this.splitContainer3.Panel1.Controls.Add(this.AnzeigeEndeStationen);
            this.splitContainer3.Panel1.Controls.Add(this.EndVerbindung);
            this.splitContainer3.Panel1.Controls.Add(this.StartVerbindung);
            this.splitContainer3.Panel1.Controls.Add(this.button1);
            this.splitContainer3.Panel1.Controls.Add(this.dateTimeVerbindungen);
            this.splitContainer3.Panel1.Controls.Add(this.VerbindungenSuchen);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.ResultVerbindungen);
            this.splitContainer3.Size = new System.Drawing.Size(1988, 805);
            this.splitContainer3.SplitterDistance = 373;
            this.splitContainer3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(755, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "EndStation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Startstation";
            // 
            // AnzeigeStStationen
            // 
            this.AnzeigeStStationen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AnzeigeStStationen.Location = new System.Drawing.Point(281, 160);
            this.AnzeigeStStationen.Name = "AnzeigeStStationen";
            this.AnzeigeStStationen.RowHeadersWidth = 62;
            this.AnzeigeStStationen.RowTemplate.Height = 33;
            this.AnzeigeStStationen.Size = new System.Drawing.Size(314, 194);
            this.AnzeigeStStationen.TabIndex = 7;
            this.AnzeigeStStationen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AnzeigeStStationen_CellContentClick);
            // 
            // AnzeigeEndeStationen
            // 
            this.AnzeigeEndeStationen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AnzeigeEndeStationen.Location = new System.Drawing.Point(755, 160);
            this.AnzeigeEndeStationen.Name = "AnzeigeEndeStationen";
            this.AnzeigeEndeStationen.RowHeadersWidth = 62;
            this.AnzeigeEndeStationen.RowTemplate.Height = 33;
            this.AnzeigeEndeStationen.Size = new System.Drawing.Size(314, 194);
            this.AnzeigeEndeStationen.TabIndex = 6;
            this.AnzeigeEndeStationen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AnzeigeEndeStationen_CellContentClick);
            // 
            // EndVerbindung
            // 
            this.EndVerbindung.Location = new System.Drawing.Point(755, 118);
            this.EndVerbindung.Name = "EndVerbindung";
            this.EndVerbindung.Size = new System.Drawing.Size(314, 31);
            this.EndVerbindung.TabIndex = 2;
            this.EndVerbindung.TextChanged += new System.EventHandler(this.EndVerbindung_TextChanged);
            // 
            // StartVerbindung
            // 
            this.StartVerbindung.Location = new System.Drawing.Point(281, 118);
            this.StartVerbindung.Name = "StartVerbindung";
            this.StartVerbindung.Size = new System.Drawing.Size(314, 31);
            this.StartVerbindung.TabIndex = 1;
            this.StartVerbindung.TextChanged += new System.EventHandler(this.StartVerbindung_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(632, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Change";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.StationenTausch);
            // 
            // dateTimeVerbindungen
            // 
            this.dateTimeVerbindungen.Location = new System.Drawing.Point(281, 160);
            this.dateTimeVerbindungen.Name = "dateTimeVerbindungen";
            this.dateTimeVerbindungen.Size = new System.Drawing.Size(788, 31);
            this.dateTimeVerbindungen.TabIndex = 4;
            // 
            // VerbindungenSuchen
            // 
            this.VerbindungenSuchen.Location = new System.Drawing.Point(281, 228);
            this.VerbindungenSuchen.Name = "VerbindungenSuchen";
            this.VerbindungenSuchen.Size = new System.Drawing.Size(788, 35);
            this.VerbindungenSuchen.TabIndex = 3;
            this.VerbindungenSuchen.Text = "Search";
            this.VerbindungenSuchen.UseVisualStyleBackColor = true;
            this.VerbindungenSuchen.TextChanged += new System.EventHandler(this.VerbindungenSuchen_Click);
            this.VerbindungenSuchen.Click += new System.EventHandler(this.VerbindungenSuchen_Click);
            // 
            // ResultVerbindungen
            // 
            this.ResultVerbindungen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ResultVerbindungen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultVerbindungen.Location = new System.Drawing.Point(0, 17);
            this.ResultVerbindungen.Name = "ResultVerbindungen";
            this.ResultVerbindungen.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.ResultVerbindungen.RowTemplate.Height = 33;
            this.ResultVerbindungen.Size = new System.Drawing.Size(1912, 586);
            this.ResultVerbindungen.TabIndex = 6;
            // 
            // StationenSuche
            // 
            this.StationenSuche.Controls.Add(this.splitContainer2);
            this.StationenSuche.Location = new System.Drawing.Point(4, 34);
            this.StationenSuche.Name = "StationenSuche";
            this.StationenSuche.Padding = new System.Windows.Forms.Padding(3);
            this.StationenSuche.Size = new System.Drawing.Size(1994, 811);
            this.StationenSuche.TabIndex = 2;
            this.StationenSuche.Text = "Stationen";
            this.StationenSuche.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.StName);
            this.splitContainer2.Panel1.Controls.Add(this.StSuche);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.StAnzeige);
            this.splitContainer2.Size = new System.Drawing.Size(1988, 805);
            this.splitContainer2.SplitterDistance = 579;
            this.splitContainer2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Station suchen";
            // 
            // StName
            // 
            this.StName.Location = new System.Drawing.Point(94, 56);
            this.StName.Name = "StName";
            this.StName.Size = new System.Drawing.Size(338, 31);
            this.StName.TabIndex = 1;
            // 
            // StSuche
            // 
            this.StSuche.Location = new System.Drawing.Point(94, 112);
            this.StSuche.Name = "StSuche";
            this.StSuche.Size = new System.Drawing.Size(338, 37);
            this.StSuche.TabIndex = 0;
            this.StSuche.Text = "Search";
            this.StSuche.UseVisualStyleBackColor = true;
            this.StSuche.Click += new System.EventHandler(this.StSuche_Click);
            // 
            // StAnzeige
            // 
            this.StAnzeige.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StAnzeige.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StAnzeige.Location = new System.Drawing.Point(3, 0);
            this.StAnzeige.Name = "StAnzeige";
            this.StAnzeige.RowHeadersWidth = 62;
            this.StAnzeige.RowTemplate.Height = 33;
            this.StAnzeige.Size = new System.Drawing.Size(807, 802);
            this.StAnzeige.TabIndex = 0;
            // 
            // AbfahrtsKarte
            // 
            this.AbfahrtsKarte.Controls.Add(this.splitContainer1);
            this.AbfahrtsKarte.Location = new System.Drawing.Point(4, 34);
            this.AbfahrtsKarte.Name = "AbfahrtsKarte";
            this.AbfahrtsKarte.Padding = new System.Windows.Forms.Padding(3);
            this.AbfahrtsKarte.Size = new System.Drawing.Size(1994, 811);
            this.AbfahrtsKarte.TabIndex = 1;
            this.AbfahrtsKarte.Text = "Abfahrtskarte";
            this.AbfahrtsKarte.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.AbfahrtenSuche);
            this.splitContainer1.Panel1.Controls.Add(this.AbfahrtStation);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer1.Panel2.Controls.Add(this.AbfahrtsFahrten);
            this.splitContainer1.Size = new System.Drawing.Size(1988, 805);
            this.splitContainer1.SplitterDistance = 588;
            this.splitContainer1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Abfahrtsstation";
            // 
            // AbfahrtenSuche
            // 
            this.AbfahrtenSuche.Location = new System.Drawing.Point(80, 104);
            this.AbfahrtenSuche.Name = "AbfahrtenSuche";
            this.AbfahrtenSuche.Size = new System.Drawing.Size(363, 38);
            this.AbfahrtenSuche.TabIndex = 1;
            this.AbfahrtenSuche.Text = "Search";
            this.AbfahrtenSuche.UseVisualStyleBackColor = true;
            this.AbfahrtenSuche.Click += new System.EventHandler(this.AbfahrtenSuche_Click);
            // 
            // AbfahrtStation
            // 
            this.AbfahrtStation.Location = new System.Drawing.Point(80, 54);
            this.AbfahrtStation.Name = "AbfahrtStation";
            this.AbfahrtStation.Size = new System.Drawing.Size(363, 31);
            this.AbfahrtStation.TabIndex = 0;
            // 
            // AbfahrtsFahrten
            // 
            this.AbfahrtsFahrten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AbfahrtsFahrten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AbfahrtsFahrten.Location = new System.Drawing.Point(3, -3);
            this.AbfahrtsFahrten.Name = "AbfahrtsFahrten";
            this.AbfahrtsFahrten.RowHeadersWidth = 62;
            this.AbfahrtsFahrten.RowTemplate.Height = 33;
            this.AbfahrtsFahrten.Size = new System.Drawing.Size(1383, 805);
            this.AbfahrtsFahrten.TabIndex = 0;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.AbfahrtsKarte);
            this.TabControl.Controls.Add(this.StationenSuche);
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(2002, 849);
            this.TabControl.TabIndex = 0;
            // 
            // HauptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 720);
            this.Controls.Add(this.TabControl);
            this.Name = "HauptForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AnzeigeStStationen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnzeigeEndeStationen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultVerbindungen)).EndInit();
            this.StationenSuche.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StAnzeige)).EndInit();
            this.AbfahrtsKarte.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AbfahrtsFahrten)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage tabPage1;
        private SplitContainer splitContainer3;
        private DataGridView AnzeigeEndeStationen;
        private TextBox EndVerbindung;
        private TextBox StartVerbindung;
        private Button button1;
        private DateTimePicker dateTimeVerbindungen;
        private Button VerbindungenSuchen;
        private DataGridView ResultVerbindungen;
        private TabPage StationenSuche;
        private SplitContainer splitContainer2;
        private TextBox StName;
        private Button StSuche;
        private DataGridView StAnzeige;
        private TabPage AbfahrtsKarte;
        private SplitContainer splitContainer1;
        private Button AbfahrtenSuche;
        private TextBox AbfahrtStation;
        private DataGridView AbfahrtsFahrten;
        private TabControl TabControl;
        private DataGridView AnzeigeStStationen;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
    }
}