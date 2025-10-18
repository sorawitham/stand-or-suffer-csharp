using System;
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;

namespace StandOrSuffer
{
    public partial class Form1 : Form
    {
        private bool isRunning = false;
        private int lastHour = -1;
        private readonly HashSet<int> alertedMinutesThisHour = new HashSet<int>();
        private readonly Random rng = new Random();

        private readonly List<string> quips = new List<string>
        {
            "Stand or suffer. Your spine votes 'stand'.",
            "Up you go! Chairs are traps with cushions.",
            "Stand now. Future-you sends thanks.",
            "Stretch time! Don’t let the chair win today.",
            "Rise, human. Gravity has had enough fun.",
            "Legs called. They want circulation back.",
            "Micro break equals macro productivity.",
            "Hit pause. Be taller for 60 seconds.",
            "Chair: 0, You: 1 — if you stand now.",
            "Stand up and remind your blood about physics."
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Timer tick every second
            timerClock.Interval = 1000;
            timerClock.Tick += TimerClock_Tick;

            // Provide a safe default icon without requiring a .ico resource
            notifyIcon.Icon = System.Drawing.SystemIcons.Information;
            notifyIcon.Visible = true;

            // Default minutes
            numericMinute1.Value = 0;
            numericMinute2.Value = 15;
            numericMinute3.Value = 30;
            numericMinute4.Value = 45;
        }

        private void ButtonToggle_Click(object sender, EventArgs e)
        {
            isRunning = !isRunning;

            if (isRunning)
            {
                // Start
                timerClock.Start();
                lastHour = DateTime.Now.Hour;
                alertedMinutesThisHour.Clear();
                buttonToggle.Text = "Pause";

                notifyIcon.BalloonTipTitle = "Stand Reminder";
                notifyIcon.BalloonTipText = $"Running. Will remind you every hour at minutes {DescribeSelectedMinutes()}.";
                notifyIcon.ShowBalloonTip(3000);
            }
            else
            {
                // Pause
                timerClock.Stop();
                buttonToggle.Text = "Start";

                notifyIcon.BalloonTipTitle = "Stand Reminder";
                notifyIcon.BalloonTipText = "Paused. Your chair just smiled.";
                notifyIcon.ShowBalloonTip(2500);
            }
        }

        private void TimerClock_Tick(object sender, EventArgs e)
        {
            if (!isRunning) return;

            DateTime now = DateTime.Now;

            // New hour started? reset per-hour guard
            if (now.Hour != lastHour)
            {
                lastHour = now.Hour;
                alertedMinutesThisHour.Clear();
            }

            // Check if current minute is one of selected, trigger only at second == 0
            if (now.Second == 0)
            {
                var selected = GetSelectedMinutes();
                if (selected.Contains(now.Minute) && !alertedMinutesThisHour.Contains(now.Minute))
                {
                    alertedMinutesThisHour.Add(now.Minute);
                    FireReminder();
                }
            }
        }

        private HashSet<int> GetSelectedMinutes()
        {
            // Read four numeric inputs, keep distinct 0..59
            var set = new HashSet<int>();
            int m1 = (int)numericMinute1.Value;
            int m2 = (int)numericMinute2.Value;
            int m3 = (int)numericMinute3.Value;
            int m4 = (int)numericMinute4.Value;

            if (m1 >= 0 && m1 <= 59) set.Add(m1);
            if (m2 >= 0 && m2 <= 59) set.Add(m2);
            if (m3 >= 0 && m3 <= 59) set.Add(m3);
            if (m4 >= 0 && m4 <= 59) set.Add(m4);

            return set;
        }

        private string DescribeSelectedMinutes()
        {
            var set = new List<int>(GetSelectedMinutes());
            set.Sort();
            return string.Join(", ", set.ConvertAll(v => v.ToString("D2")));
        }

        private void FireReminder()
        {
            string msg = quips[rng.Next(quips.Count)];

            notifyIcon.BalloonTipTitle = "Stand Reminder";
            notifyIcon.BalloonTipText = msg;
            notifyIcon.ShowBalloonTip(7000);

            SystemSounds.Exclamation.Play();
        }
    }
}
