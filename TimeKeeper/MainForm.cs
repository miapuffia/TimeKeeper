using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeKeeper {
	public partial class MainForm : Form {
		private bool clockedIn = false;
		private readonly List<AlarmControl> alarmControls = new List<AlarmControl>();

		public MainForm() {
			InitializeComponent();

			FormNavigationManager.SetStartForm(this);
		}

		private void button1_Click(object sender, EventArgs e) {
			if(textBox1.Text == "") {
				tableLayoutPanel2.BackColor = Color.Red;

				return;
			} else {
				tableLayoutPanel2.BackColor = Color.Transparent;
			}

			if(clockedIn) { //Need to clock out
				button1.Text = "Clock in";
				textBox1.ReadOnly = false;

				using(StreamWriter sw = File.AppendText(Directory.GetCurrentDirectory() + "/history.txt")) {
					sw.WriteLine(DateTime.Now.Ticks + "|OUT|" + textBox1.Text);
				}
			} else { //Need to clock in
				button1.Text = "Clock out";
				textBox1.ReadOnly = true;

				using(StreamWriter sw = File.AppendText(Directory.GetCurrentDirectory() + "/history.txt")) {
					sw.WriteLine(DateTime.Now.Ticks + "|IN|" + textBox1.Text);
				}
			}

			clockedIn = !clockedIn;
		}

		private void historyToolStripMenuItem_Click(object sender, EventArgs e) {
			FormNavigationManager.NavigateToForm<HistoryForm>(this);
		}

		private void button2_Click(object sender, EventArgs e) {
			if(clockedIn) { //Need to clock out
				button1.Text = "Clock in";
				textBox1.ReadOnly = false;
			} else { //Need to clock in
				button1.Text = "Clock out";
				textBox1.ReadOnly = false;
			}

			clockedIn = !clockedIn;
		}

		private void alarmsToolStripMenuItem_Click(object sender, EventArgs e) {
			FormNavigationManager.NavigateToForm<AlarmsForm>(this);
		}

		private void timer1_Tick(object sender, EventArgs e) {
			DateTime now = DateTime.Now;

			foreach(AlarmControl alarmControl in alarmControls) {
				if(
					alarmControl.TimeValue.Value.Hour == now.Hour
					&& alarmControl.TimeValue.Value.Minute == now.Minute
					&& alarmControl.TimeValue.Value.Second == now.Second
					&& alarmControl.SelectedDays[((int) now.DayOfWeek)]
				) {
					SoundPlayer player = new SoundPlayer("ping.wav");
					player.Play();

					Task.Run(() => {
						ChangeTaskbarRed();
						Thread.Sleep(1000);
						ChangeTaskbarDefault();
						Thread.Sleep(1000);
						ChangeTaskbarRed();
						Thread.Sleep(1000);
						ChangeTaskbarDefault();
					});
				}
			}
		}

		private static void ChangeTaskbarDefault() {
			using(PowerShell PowerShellInstance = PowerShell.Create()) {
				//PowerShellInstance.AddScript(@"Set-ItemProperty -Path 'HKCU:\Control Panel\Desktop' -Name AutoColorization -Value $(1) -Force");
				PowerShellInstance.AddScript(@"Set-ItemProperty -Path 'HKCU:\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize' -Name EnableTransparency -Value $(1) -Force");
				PowerShellInstance.AddScript(@"Set-ItemProperty -Path 'HKCU:\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize' -Name ColorPrevalence -Value $(0) -Force");
				PowerShellInstance.AddScript(@"Set-ItemProperty -Path 'HKCU:\Software\Microsoft\Windows\DWM' -Name ColorizationColor -Value $(0xc40078d7) -Force");
				PowerShellInstance.AddScript(@"Set-ItemProperty -Path 'HKCU:\Software\Microsoft\Windows\DWM' -Name ColorizationAfterglow -Value $(0xc40078d7) -Force");
				PowerShellInstance.AddScript(@"Set-ItemProperty -Path 'HKCU:\Software\Microsoft\Windows\DWM' -Name ColorizationGlassAttribute -Value $(1) -Force");
				//PowerShellInstance.AddScript(@"Set-ItemProperty -Path 'HKCU:\Software\Microsoft\Windows\DWM' -Name AccentColor -Value $(0xffd77800) -Force");
				//PowerShellInstance.AddScript(@"Set-ItemProperty -Path 'HKCU:\Software\Microsoft\Windows\CurrentVersion\Explorer\Accent' -Name StartColorMenu -Value $(0xff9e5a00) -Force");
				//PowerShellInstance.AddScript(@"Set-ItemProperty -Path 'HKCU:\Software\Microsoft\Windows\CurrentVersion\Themes\History' -Name Autocolor -Value $(0) -Force");

				PowerShellInstance.Invoke();
			}

			Process process = new Process {
				StartInfo = new ProcessStartInfo("Windows 10 color control.exe", "-accent_color 0xff2997cc"),
			};

			process.Start();
		}

		private static void ChangeTaskbarRed() {
			using(PowerShell PowerShellInstance = PowerShell.Create()) {
				//PowerShellInstance.AddScript(@"Set-ItemProperty -Path 'HKCU:\Control Panel\Desktop' -Name AutoColorization -Value $(0) -Force");
				PowerShellInstance.AddScript(@"Set-ItemProperty -Path 'HKCU:\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize' -Name EnableTransparency -Value $(0) -Force");
				PowerShellInstance.AddScript(@"Set-ItemProperty -Path 'HKCU:\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize' -Name ColorPrevalence -Value $(1) -Force");
				PowerShellInstance.AddScript(@"Set-ItemProperty -Path 'HKCU:\Software\Microsoft\Windows\DWM' -Name ColorizationColor -Value $(0xc4ff0000) -Force");
				PowerShellInstance.AddScript(@"Set-ItemProperty -Path 'HKCU:\Software\Microsoft\Windows\DWM' -Name ColorizationAfterglow -Value $(0xc4ff0000) -Force");
				PowerShellInstance.AddScript(@"Set-ItemProperty -Path 'HKCU:\Software\Microsoft\Windows\DWM' -Name ColorizationGlassAttribute -Value $(0) -Force");
				//PowerShellInstance.AddScript(@"Set-ItemProperty -Path 'HKCU:\Software\Microsoft\Windows\DWM' -Name AccentColor -Value $(0xc4ff0000) -Force");
				//PowerShellInstance.AddScript(@"Set-ItemProperty -Path 'HKCU:\Software\Microsoft\Windows\CurrentVersion\Explorer\Accent' -Name StartColorMenu -Value $(0xc4ff0000) -Force");
				//PowerShellInstance.AddScript(@"Set-ItemProperty -Path 'HKCU:\Software\Microsoft\Windows\CurrentVersion\Themes\History' -Name Autocolor -Value $(0xc4ff0000) -Force");

				PowerShellInstance.Invoke();
			}

			Process process = new Process {
				StartInfo = new ProcessStartInfo("Windows 10 color control.exe", "-accent_color 0xffff0000"),
			};

			process.Start();
		}

		private void InitializeAlarmDateTimes() {
			if(!File.Exists(Directory.GetCurrentDirectory() + "/alarms.txt")) {
				return;
			}

			alarmControls.Clear();

			string[] alarmEntries = File.ReadAllLines(Directory.GetCurrentDirectory() + "/alarms.txt");

			foreach(string entry in alarmEntries) {
				int part1Index = entry.IndexOf('|');
				string timePart = part1Index == -1 ? entry : entry.Substring(0, part1Index);
				string daysPart = part1Index == -1 ? null : entry.Substring(part1Index + 1);

				AlarmControl alarmControl = new AlarmControl {
					TimeValue = new DateTime(long.Parse(timePart)),
					SelectedDays = daysPart == null ? null : daysPart.Select(chr => chr == '1').ToArray(),
				};

				alarmControls.Add(alarmControl);
			}
		}

		public void OnNavigatedTo(Form fromForm) {
			InitializeAlarmDateTimes();
		}

		private void reportsToolStripMenuItem_Click(object sender, EventArgs e) {
			FormNavigationManager.NavigateToForm<ReportsForm>(this);
		}
	}
}
