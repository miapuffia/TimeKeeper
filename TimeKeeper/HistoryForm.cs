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
	public partial class HistoryForm : Form {
		public HistoryForm() {
			InitializeComponent();

			ColumnHeader header = new ColumnHeader();
			header.Text = "";
			header.Name = "col1";
			header.Width = 1000;
			listView1.Columns.Add(header);
		}

		private void PopulateHistory() {
			listView1.Items.Clear();

			if(!File.Exists(Directory.GetCurrentDirectory() + "/history.txt")) {
				return;
			}

			string[] historyEntries = File.ReadAllLines(Directory.GetCurrentDirectory() + "/history.txt");

			string visibleDate = "";

			foreach(string entry in historyEntries) {
				DateTime date = new DateTime(Int64.Parse(entry.Substring(0, entry.IndexOf('|'))));

				string dateDate = date.ToString("yyyy-MM-dd");
				string dateTime = date.ToString("hh:mm:ss");
				string clockInOrOut = entry.Substring(entry.IndexOf('|') + 1, entry.LastIndexOf('|') - entry.IndexOf('|') - 1);
				string message = entry.Substring(entry.LastIndexOf('|') + 1);

				if(dateDate != visibleDate) {
					visibleDate = dateDate;

					listView1.Groups.Add(new ListViewGroup(visibleDate, HorizontalAlignment.Left));
				}

				listView1.Items.Add(clockInOrOut + " - " + dateTime + " - " + message);
				listView1.Items[listView1.Items.Count - 1].Group = listView1.Groups[listView1.Groups.Count - 1];
			}
		}

		private void clockInoutToolStripMenuItem_Click(object sender, EventArgs e) {
			FormNavigationManager.NavigateToForm<MainForm>(this);
		}

		private void alarmsToolStripMenuItem_Click(object sender, EventArgs e) {
			FormNavigationManager.NavigateToForm<AlarmsForm>(this);
		}

		public void OnNavigatedTo(Form fromForm) {
			PopulateHistory();
		}

		private void reportsToolStripMenuItem_Click(object sender, EventArgs e) {
			FormNavigationManager.NavigateToForm<ReportsForm>(this);
		}
	}
}
