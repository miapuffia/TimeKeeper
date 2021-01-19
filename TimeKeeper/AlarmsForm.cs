using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeKeeper {
	public partial class AlarmsForm : Form {
		public AlarmsForm() {
			InitializeComponent();

			PopulateAlarms();
		}

		private void PopulateAlarms() {
			if(!File.Exists(Directory.GetCurrentDirectory() + "/alarms.txt")) {
				return;
			}

			while(tableLayoutPanel1.RowStyles.Count > 1) {
				tableLayoutPanel1.RowStyles.RemoveAt(tableLayoutPanel1.RowStyles.Count - 1);
			}

			tableLayoutPanel1.RowStyles[0] = new RowStyle(SizeType.Percent, 100F);

			tableLayoutPanel1.RowCount = tableLayoutPanel1.RowStyles.Count;

			string[] alarmEntries = File.ReadAllLines(Directory.GetCurrentDirectory() + "/alarms.txt");

			foreach(string entry in alarmEntries) {
				AddAlarm(new DateTime(long.Parse(entry)));
			}
		}

		private void AddAlarm(DateTime? dateTime = null) {
			tableLayoutPanel1.SuspendLayout();

			TableLayoutPanel alarmTable = new TableLayoutPanel {
				ColumnCount = 2,
				RowCount = 1,
				BackColor = Color.White,
				AutoSize = true,
				Padding = new Padding(20),
				Anchor = AnchorStyles.None,
			};

			alarmTable.SuspendLayout();

			alarmTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			alarmTable.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

			alarmTable.RowStyles.Add(new RowStyle(SizeType.AutoSize));

			alarmTable.ColumnCount = alarmTable.ColumnStyles.Count;
			alarmTable.RowCount = alarmTable.RowStyles.Count;

			DateTimePicker alarmTime = new DateTimePicker {
				Format = DateTimePickerFormat.Time,
				ShowUpDown = true,
				Font = new Font(button1.Font.FontFamily, 12),
				Value = dateTime ?? DateTime.MinValue.AddYears(2000),
			};

			alarmTable.Controls.Add(alarmTime, 0, 0);

			alarmTable.ResumeLayout();

			tableLayoutPanel1.Controls.Add(alarmTable, 0, tableLayoutPanel1.RowCount - 1);

			tableLayoutPanel1.RowStyles[tableLayoutPanel1.RowCount - 1].SizeType = SizeType.AutoSize;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.RowCount = tableLayoutPanel1.RowStyles.Count;

			tableLayoutPanel1.ResumeLayout();
		}

		private void clockInoutToolStripMenuItem_Click(object sender, EventArgs e) {
			FormNavigationManager.NavigateToForm<MainForm>(this);
		}

		private void historyToolStripMenuItem_Click(object sender, EventArgs e) {
			FormNavigationManager.NavigateToForm<HistoryForm>(this);
		}

		private void button1_Click(object sender, EventArgs e) {
			AddAlarm();
		}

		private void button2_Click(object sender, EventArgs e) {
			File.Delete(Directory.GetCurrentDirectory() + "/alarms.txt");

			using(StreamWriter sw = File.AppendText(Directory.GetCurrentDirectory() + "/alarms.txt")) {
				foreach(DateTimePicker dateTimePicker in GetAllControls<DateTimePicker>(tableLayoutPanel1)) {
					sw.WriteLine(dateTimePicker.Value.Ticks);
				}
			}
		}

		//This is a beautiful piece of code!
		public IEnumerable<T> GetAllControls<T>(Control control) where T : Control {
			var controls = control.Controls.Cast<Control>();

			return controls.SelectMany(ctrl => GetAllControls<T>(ctrl))
									  .Concat(controls)
									  .Where(c => c.GetType() == typeof(T))
									  .Cast<T>();
		}

		private void reportsToolStripMenuItem_Click(object sender, EventArgs e) {
			FormNavigationManager.NavigateToForm<ReportsForm>(this);
		}
	}
}
