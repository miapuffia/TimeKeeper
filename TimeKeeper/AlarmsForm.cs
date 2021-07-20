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
				int part1Index = entry.IndexOf('|');
				string timePart = part1Index == -1 ? entry : entry.Substring(0, part1Index);
				string daysPart = part1Index == -1 ? null : entry.Substring(part1Index + 1);

				AddAlarm(new DateTime(long.Parse(timePart)), daysPart == null ? null : daysPart.Select(chr => chr == '1').ToArray());
			}
		}

		private void AddAlarm(DateTime? dateTime = null, bool[] days = null) {
			AlarmControl alarmControl = new AlarmControl {
				TimeValue = dateTime,
				Anchor = AnchorStyles.None,
				SelectedDays = days,
			};

			alarmControl.DeleteButtonClickDelegate = (object sender, EventArgs e) => {
				tableLayoutPanel1.Controls.Remove(alarmControl);
			};

			tableLayoutPanel1.Controls.Add(alarmControl, 0, tableLayoutPanel1.RowCount - 1);

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
				foreach(Control control in tableLayoutPanel1.Controls) {
					AlarmControl alarmControl = (AlarmControl) control;

					sw.WriteLine(alarmControl.TimeValue.Value.Ticks + "|" + string.Join("", alarmControl.SelectedDays.Select(b => b ? '1' : '0')));
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
