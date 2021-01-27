
namespace TimeKeeper {
	partial class ReportsForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.clockInoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.alarmsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TimeSpent = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button1 = new System.Windows.Forms.Button();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.radioButton5 = new System.Windows.Forms.RadioButton();
			this.radioButton6 = new System.Windows.Forms.RadioButton();
			this.tableLayoutPanel1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.tableLayoutPanel5.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.button1, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 761);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clockInoutToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.alarmsToolStripMenuItem,
            this.reportsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(784, 29);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// clockInoutToolStripMenuItem
			// 
			this.clockInoutToolStripMenuItem.Name = "clockInoutToolStripMenuItem";
			this.clockInoutToolStripMenuItem.Size = new System.Drawing.Size(106, 25);
			this.clockInoutToolStripMenuItem.Text = "Clock in/out";
			this.clockInoutToolStripMenuItem.Click += new System.EventHandler(this.clockInoutToolStripMenuItem_Click);
			// 
			// historyToolStripMenuItem
			// 
			this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
			this.historyToolStripMenuItem.Size = new System.Drawing.Size(72, 25);
			this.historyToolStripMenuItem.Text = "History";
			this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
			// 
			// alarmsToolStripMenuItem
			// 
			this.alarmsToolStripMenuItem.Name = "alarmsToolStripMenuItem";
			this.alarmsToolStripMenuItem.Size = new System.Drawing.Size(71, 25);
			this.alarmsToolStripMenuItem.Text = "Alarms";
			this.alarmsToolStripMenuItem.Click += new System.EventHandler(this.alarmsToolStripMenuItem_Click);
			// 
			// reportsToolStripMenuItem
			// 
			this.reportsToolStripMenuItem.Enabled = false;
			this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
			this.reportsToolStripMenuItem.Size = new System.Drawing.Size(76, 25);
			this.reportsToolStripMenuItem.Text = "Reports";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Subject,
            this.TimeSpent});
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(20, 262);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(20);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dataGridView1.Size = new System.Drawing.Size(744, 479);
			this.dataGridView1.TabIndex = 3;
			// 
			// Subject
			// 
			this.Subject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Subject.HeaderText = "Subject";
			this.Subject.Name = "Subject";
			this.Subject.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// TimeSpent
			// 
			this.TimeSpent.HeaderText = "Time Spent";
			this.TimeSpent.Name = "TimeSpent";
			this.TimeSpent.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.TimeSpent.Width = 150;
			// 
			// button1
			// 
			this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button1.AutoSize = true;
			this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
			this.button1.Location = new System.Drawing.Point(284, 201);
			this.button1.Margin = new System.Windows.Forms.Padding(0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(215, 41);
			this.button1.TabIndex = 2;
			this.button1.Text = "Generate report";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.tableLayoutPanel2.AutoSize = true;
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 1, 0);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(111, 32);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(562, 166);
			this.tableLayoutPanel2.TabIndex = 4;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.tableLayoutPanel3.AutoSize = true;
			this.tableLayoutPanel3.ColumnCount = 2;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.dateTimePicker1, 1, 0);
			this.tableLayoutPanel3.Location = new System.Drawing.Point(20, 20);
			this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(20);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 2;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(396, 126);
			this.tableLayoutPanel3.TabIndex = 5;
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.AutoSize = true;
			this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel4.ColumnCount = 1;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Controls.Add(this.radioButton1, 0, 1);
			this.tableLayoutPanel4.Controls.Add(this.radioButton2, 0, 2);
			this.tableLayoutPanel4.Controls.Add(this.radioButton3, 0, 3);
			this.tableLayoutPanel4.Controls.Add(this.radioButton4, 0, 0);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 4;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.Size = new System.Drawing.Size(100, 120);
			this.tableLayoutPanel4.TabIndex = 0;
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Checked = true;
			this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.radioButton1.Location = new System.Drawing.Point(3, 33);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(90, 24);
			this.radioButton1.TabIndex = 0;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Week of:";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.radioButton2.Location = new System.Drawing.Point(3, 63);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(94, 24);
			this.radioButton2.TabIndex = 1;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Month of:";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.radioButton3.Location = new System.Drawing.Point(3, 93);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(83, 24);
			this.radioButton3.TabIndex = 2;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "Year of:";
			this.radioButton3.UseVisualStyleBackColor = true;
			// 
			// radioButton4
			// 
			this.radioButton4.AutoSize = true;
			this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.radioButton4.Location = new System.Drawing.Point(3, 3);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(77, 24);
			this.radioButton4.TabIndex = 3;
			this.radioButton4.TabStop = true;
			this.radioButton4.Text = "Day of:";
			this.radioButton4.UseVisualStyleBackColor = true;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.dateTimePicker1.Location = new System.Drawing.Point(109, 50);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(284, 26);
			this.dateTimePicker1.TabIndex = 1;
			// 
			// tableLayoutPanel5
			// 
			this.tableLayoutPanel5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.tableLayoutPanel5.AutoSize = true;
			this.tableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel5.ColumnCount = 1;
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel5.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel5.Controls.Add(this.radioButton5, 0, 1);
			this.tableLayoutPanel5.Controls.Add(this.radioButton6, 0, 2);
			this.tableLayoutPanel5.Location = new System.Drawing.Point(456, 41);
			this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.tableLayoutPanel5.Name = "tableLayoutPanel5";
			this.tableLayoutPanel5.RowCount = 3;
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel5.Size = new System.Drawing.Size(106, 83);
			this.tableLayoutPanel5.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Group by:";
			// 
			// radioButton5
			// 
			this.radioButton5.AutoSize = true;
			this.radioButton5.Checked = true;
			this.radioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.radioButton5.Location = new System.Drawing.Point(3, 26);
			this.radioButton5.Name = "radioButton5";
			this.radioButton5.Size = new System.Drawing.Size(81, 24);
			this.radioButton5.TabIndex = 1;
			this.radioButton5.TabStop = true;
			this.radioButton5.Text = "Subject";
			this.radioButton5.UseVisualStyleBackColor = true;
			this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
			// 
			// radioButton6
			// 
			this.radioButton6.AutoSize = true;
			this.radioButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.radioButton6.Location = new System.Drawing.Point(3, 56);
			this.radioButton6.Name = "radioButton6";
			this.radioButton6.Size = new System.Drawing.Size(55, 24);
			this.radioButton6.TabIndex = 2;
			this.radioButton6.Text = "Day";
			this.radioButton6.UseVisualStyleBackColor = true;
			this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
			// 
			// ReportsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 761);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "ReportsForm";
			this.Text = "ReportsForm";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel4.PerformLayout();
			this.tableLayoutPanel5.ResumeLayout(false);
			this.tableLayoutPanel5.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem clockInoutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem alarmsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
		private System.Windows.Forms.DataGridViewTextBoxColumn TimeSpent;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton radioButton5;
		private System.Windows.Forms.RadioButton radioButton6;
	}
}