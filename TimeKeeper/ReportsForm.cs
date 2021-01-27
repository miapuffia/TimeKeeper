using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeKeeper {
	public partial class ReportsForm : Form {
		public ReportsForm() {
			InitializeComponent();
		}

		private void clockInoutToolStripMenuItem_Click(object sender, EventArgs e) {
			FormNavigationManager.NavigateToForm<MainForm>(this);
		}

		private void historyToolStripMenuItem_Click(object sender, EventArgs e) {
			FormNavigationManager.NavigateToForm<HistoryForm>(this);
		}

		private void alarmsToolStripMenuItem_Click(object sender, EventArgs e) {
			FormNavigationManager.NavigateToForm<AlarmsForm>(this);
		}

		private void button1_Click(object sender, EventArgs e) {
			dataGridView1.Rows.Clear();

			if(!File.Exists(Directory.GetCurrentDirectory() + "/history.txt")) {
				return;
			}

			List<String[]> rowsToAdd = new List<string[]>();

			CultureInfo myCI = new CultureInfo("en-US");
			Calendar myCal = myCI.Calendar;

			string[] historyEntries = File.ReadAllLines(Directory.GetCurrentDirectory() + "/history.txt");

			DateTime clockInDateTime = DateTime.MinValue;

			for(int i = 0; i < historyEntries.Length; i++) {
				String entry = historyEntries[i];

				DateTime date = new DateTime(Int64.Parse(entry.Substring(0, entry.IndexOf('|'))));

				if(
					(
						radioButton4.Checked
						&& date.Date != dateTimePicker1.Value.Date
					) || (
						radioButton1.Checked
						&& (
							date.Year != dateTimePicker1.Value.Year
							|| myCal.GetWeekOfYear(date, CalendarWeekRule.FirstDay, DayOfWeek.Monday) != myCal.GetWeekOfYear(dateTimePicker1.Value, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
						)
					) || (
						radioButton2.Checked
						&& (
							date.Year != dateTimePicker1.Value.Year
							|| date.Month != dateTimePicker1.Value.Month
						)
					) || (
						radioButton3.Checked
						&& date.Year != dateTimePicker1.Value.Year
					)
				) {
					continue;
				}

				string clockInOrOut = entry.Substring(entry.IndexOf('|') + 1, entry.LastIndexOf('|') - entry.IndexOf('|') - 1);

				if(clockInOrOut == "IN") {
					clockInDateTime = date;

					continue;
				}

				string message = entry.Substring(entry.LastIndexOf('|') + 1);

				if(radioButton5.Checked) {
					int existingRow = rowsToAdd.FindIndex(item => item[0] == message);

					if(existingRow == -1) {
						rowsToAdd.Add(new string[] { message, ((date - clockInDateTime).TotalSeconds / 60 / 60) + "" });
					} else {
						rowsToAdd[existingRow][1] = (double.Parse(rowsToAdd[existingRow][1]) + ((date - clockInDateTime).TotalSeconds) / 60 / 60) + "";
					}
				} else if(radioButton6.Checked) {
					int existingRow = rowsToAdd.FindIndex(item => item[0] == date.ToString("M/d/yyyy"));

					if(existingRow == -1) {
						rowsToAdd.Add(new string[] { date.ToString("M/d/yyyy"), ((date - clockInDateTime).TotalSeconds / 60 / 60) + "" });
					} else {
						rowsToAdd[existingRow][1] = (double.Parse(rowsToAdd[existingRow][1]) + ((date - clockInDateTime).TotalSeconds) / 60 / 60) + "";
					}
				}
			}

			foreach(String[] row in rowsToAdd) {
				dataGridView1.Rows.Add(new string[] { row[0], double.Parse(row[1]).ToString("0.##") });
			}

			if(rowsToAdd.Count > 0) {
				dataGridView1.Rows.Add(new string[] { "Total", rowsToAdd.Select(r => double.Parse(r[1])).Sum().ToString("0.##") });

				int lastRowIndex = dataGridView1.Rows.GetLastRow(DataGridViewElementStates.None);
				Font defaultFont = dataGridView1.DefaultCellStyle.Font;

				for(int i = 0; i < dataGridView1.Rows[lastRowIndex].Cells.Count; i++) {
					dataGridView1.Rows[lastRowIndex].Cells[i].Style = new DataGridViewCellStyle();
					dataGridView1.Rows[lastRowIndex].Cells[i].Style.Font = new Font(defaultFont, FontStyle.Bold);
				}
			}
		}

		private void radioButton5_CheckedChanged(object sender, EventArgs e) {
			if((sender as RadioButton).Checked) {
				dataGridView1.Columns[0].HeaderText = "Subject";
			}
		}

		private void radioButton6_CheckedChanged(object sender, EventArgs e) {
			if((sender as RadioButton).Checked) {
				dataGridView1.Columns[0].HeaderText = "Day";
			}
		}
	}
}
