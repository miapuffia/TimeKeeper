using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeKeeper {
	public static class FormNavigationManager {
		private static List<Form> forms = new List<Form>();

		public static void SetStartForm(Form startForm) {
			forms.Add(startForm);

			CallOnNavigatedTo(startForm, startForm);
		}

		public static void NavigateToForm<T>(Form fromForm) {
			foreach(Form existingForm in forms) {
				if(existingForm.GetType() == typeof(T)) {
					Form castForm = (Form) existingForm;

					castForm.Show();
					castForm.Location = fromForm.Location;

					fromForm.Hide();

					CallOnNavigatedTo(fromForm, castForm);

					return;
				}
			}

			Form newForm = (Form) Activator.CreateInstance(typeof(T));
			forms.Add(newForm);

			newForm.Show();
			newForm.Location = fromForm.Location;
			newForm.FormClosing += (object sender, FormClosingEventArgs e) => { Application.Exit(); };

			fromForm.Hide();

			CallOnNavigatedTo(fromForm, newForm);
		}

		private static void CallOnNavigatedTo(Form fromForm, Form toForm) {
			Type T = toForm.GetType();

			foreach(MethodInfo m in T.GetMethods()) {
				if(m.Name == "OnNavigatedTo") {
					m.Invoke(toForm, new Object[] { fromForm });
				}
			}
		}
	}
}
