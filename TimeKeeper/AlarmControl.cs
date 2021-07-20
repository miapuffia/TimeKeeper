using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeKeeper {
    public partial class AlarmControl : UserControl {
        public delegate void OnDeleteButtonClickDelegate(object sender, EventArgs e);
        public OnDeleteButtonClickDelegate DeleteButtonClickDelegate = null;

        public DateTime? TimeValue {
            get {
                return dateTimePicker1.Value;
            }
            set {
                if(value == null) {
                    dateTimePicker1.Value = DateTime.MinValue.AddYears(2000);
                    return;
                }

                dateTimePicker1.Value = value.Value;
            }
        }

        public bool[] SelectedDays {
            get {
                return new bool[] {
                    checkBox1.Checked,
                    checkBox2.Checked,
                    checkBox3.Checked,
                    checkBox4.Checked,
                    checkBox5.Checked,
                    checkBox6.Checked,
                    checkBox7.Checked,
                };
            }
            set {
                if(value == null || value.Length != 7) {
                    return;
                }

                checkBox1.Checked = value[0];
                checkBox2.Checked = value[1];
                checkBox3.Checked = value[2];
                checkBox4.Checked = value[3];
                checkBox5.Checked = value[4];
                checkBox6.Checked = value[5];
                checkBox7.Checked = value[6];
            }
        }

        public AlarmControl() {
            InitializeComponent();
        }

        private void deleteButton_Click(object sender, EventArgs e) {
            DeleteButtonClickDelegate?.Invoke(sender, e);
        }
    }
}
