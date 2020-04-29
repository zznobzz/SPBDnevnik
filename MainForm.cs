using SPBDnevnik.Workers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SPBDnevnik
{
    public partial class MainForm : Form
    {
        public static Dictionary<long, string> myEducations = new Dictionary<long, string>();
        public MainForm()
        {
            InitializeComponent();
            if (SPBDnevnik.Properties.Settings.Default.login == "" && Properties.Settings.Default.password == "")
            {
                MessageBox.Show("Логин и пароль не указаны\n укажите их в настройках!", "Внимание!");
            }

        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            var SettingsForm = new SettingsForm();
            SettingsForm.Show();
        }

        private async void debugBTN_Click(object sender, EventArgs e)
        {
            await WebWorker.Connect();
            if (WebWorker.cc.Count > 0)
            {
                debugBTN.BackColor = System.Drawing.Color.Green;
                debug2BTN.Visible = true;
                var json = await WebWorker.GetJson("https://dnevnik2.petersburgedu.ru/api/journal/person/related-child-list");
                var eduJSON = JsonWorker.FromJson(json);
                foreach (var item in eduJSON.Data.Items)
                {
                    myEducations.Add(item.Educations[0].EducationId, $"{item.Surname} {item.Firstname} {item.Middlename}");
                }
                childCB.DataSource = new BindingSource(myEducations, null);
                childCB.DisplayMember = "Value";
                childCB.ValueMember = "Key";
            }
            else
            {
                debugBTN.BackColor = System.Drawing.Color.Red;
            }
        }

        private async void debug2BTN_Click(object sender, EventArgs e)
        {
            debugRTB.Text = "";
            string dateFrom = $"&p_datetime_from={fromDTP.Value.ToShortDateString()}";
            string dateTo = $"&p_datetime_to={toDTP.Value.ToShortDateString()}";
            string eid = $"&p_educations[]={childCB.SelectedValue}";
            string dataUrl = $"https://dnevnik2.petersburgedu.ru/api/journal/lesson/list-by-education?p_limit=100{dateFrom}" +
                $"{dateTo}{eid}";
            var json = await WebWorker.GetJson(dataUrl);
            var lessonJSON = JsonWorker.FromJson(json);
            foreach (var item in lessonJSON.Data.Items)
            {
                debugRTB.Text += "--------------------------------\n";
                debugRTB.Text += item.SubjectName + "\n" + item.DatetimeFrom + "\n" + item.ContentName + "\n"
                    + item.ContentDescription + "\n";
                debugRTB.Text += "Задания:  \n";
                foreach (var task in item.Tasks)
                {
                    debugRTB.Text += "*----" + task.TaskKindName + "\n";
                    debugRTB.Text += task.TaskName + "\n";
                    foreach (var file in task.Files)
                    {
                        debugRTB.Text += $"Имя файла: {Properties.Settings.Default.saveFolder}\\{file.FileName}\n";
                        WebWorker.GetAttach(file.FileName, file.Uuid);
                    }

                }
                //Скачивание файла вложения в папку.


                foreach (var estimate in item.Estimates)
                {
                    debugRTB.Text += "Оценка: " + estimate.EstimateValueName + "\n";

                }
                debugRTB.Text += "--------------------------------\n";


            }
        }
    }
}
