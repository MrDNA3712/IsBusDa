using System.Globalization;

namespace Is_Bus_da
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            update_times();
            update_timer();
        }

        private void update_times()
        {
            Label[] name_labels = { name_label0, name_label1, name_label2, name_label3, name_label4 };
            Label[] time_labels = { time_label0, time_label1, time_label2, time_label3, time_label4 };
            Label[] remaining_labels = { remaining_label0, remaining_label1, remaining_label2, remaining_label3, remaining_label4 };
            DepartureInfo[] infos = Program.get_departure_info(Program.RWS_stop_id, Program.RWS_dir_id);
            for (int i = 0; i < infos.Length; i++)
            {
                if (infos[i] != null)
                {
                    name_labels[i].Text = String.Format("{0} {1}", infos[i].Line, infos[i].destination);
                    time_labels[i].Text = infos[i].actualDeparture.ToString("HH:mm", CultureInfo.GetCultureInfo("de-DE"));
                    TimeSpan remaining = infos[i].actualDeparture - DateTime.Now;
                    string remaining_minutes = Math.Floor(remaining.TotalMinutes).ToString();
                    if (remaining_minutes.Equals("0"))
                    {
                        remaining_labels[i].Text = "Jetzt";
                    }
                    else
                    {
                        remaining_labels[i].Text = String.Format("in {0} min", remaining_minutes);
                    }
                    if (infos[i].delay > 0)
                    {
                        time_labels[i].ForeColor = System.Drawing.Color.Red;
                        remaining_labels[i].ForeColor = System.Drawing.Color.Red;
                    }
                    else if(infos[i].delay == 0)
                    {
                        time_labels[i].ForeColor = name_labels[i].ForeColor;
                        remaining_labels[i].ForeColor = name_labels[i].ForeColor;
                    }
                    else
                    {
                        time_labels[i].ForeColor = System.Drawing.Color.Green;
                        remaining_labels[i].ForeColor = System.Drawing.Color.Green;
                    }

                }
                else
                {
                    name_labels[i].Text = "";
                    time_labels[i].Text = "";
                    remaining_labels[i].Text = "";
                }
            }
        }

        private void update_timer()
        {
            if (autoUpdateCheckBox.Checked)
            {
                timer1.Interval = (int)autoUpdatesMinutes.Value * 60 * 1000;
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            update_times();
            update_timer();
        }

        private void autoUpdateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            update_timer();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            update_times();
            update_timer();
        }

        private void autoUpdatesMinutes_ValueChanged(object sender, EventArgs e)
        {
            update_timer();
        }
    }
}