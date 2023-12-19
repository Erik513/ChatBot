using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;

namespace ChatBot
{
    public partial class Form1 : Form
    {
        private List<Tuple<string, string>> faqList;
        private bool isDragging;
        private Point lastLocation;
        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private const int SW_MAXIMIZE = 3;

        private void dragPanel_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastLocation = e.Location;
        }

        private void dragPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int deltaX = e.Location.X - lastLocation.X;
                int deltaY = e.Location.Y - lastLocation.Y;
                this.Location = new Point(this.Location.X + deltaX, this.Location.Y + deltaY);
            }
        }

        private void dragPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            if (this.Top <= Screen.PrimaryScreen.WorkingArea.Top)
            {
                ShowWindow(this.Handle, SW_MAXIMIZE);
            }
        }
        private void FensterSchließen(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WindowMaximize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                CenterToScreen();
                this.WindowState = FormWindowState.Normal;
            }
        }
        private void FlowLayoutPanelQuestions_Resize(object sender, EventArgs e)
        {
            foreach (Control control in flowLayoutPanelQuestions.Controls)
            {
                if (control is Button btn)
                {
                    btn.Width = flowLayoutPanelQuestions.Width - SystemInformation.VerticalScrollBarWidth - 10;
                }
            }
        }

        private void WindowMinimize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private List<string> suggestions = new List<string>
        {
            " ",
            "Anmeldung",
            "Ausbildung",
            "Block",
            "Cisco",
            "Daily",
            "Englisch",
            "Fachbereich",
            "Feedback",
            "Final",
            "Gruppe",
            "Ideen",
            "Info",
            "Infotheke",
            "Input",
            "Kamera",
            "Kurs",
            "Lehrer",
            "Lernfeld",
            "Lernfeld 1",
            "Methoden",
            "Mikrofon",
            "Moodle",
            "Noten",
            "Online",
            "Open-Learning",
            "Packet Tracer",
            "Passwort",
            "Powerpoint",
            "Präsentation",
            "Projekt",
            "Raspberry Pi",
            "Reflexionsgespräch",
            "Schlüssel",
            "Schulmail",
            "Software",
            "Szenarien",
            "Team",
            "Tricks",
            "WuG",
        };
        private UcQandA ucQandA1 = new UcQandA()
        {
            Location = new Point(9, 58),
            Anchor = AnchorStyles.Left & AnchorStyles.Right & AnchorStyles.Top & AnchorStyles.Bottom,
            Dock = DockStyle.Fill
        };
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
            panelLeiste.MouseDown += dragPanel_MouseDown;
            panelLeiste.MouseMove += dragPanel_MouseMove;
            panelLeiste.MouseUp += dragPanel_MouseUp;
            txtSearch.KeyPress += txtQuestion_KeyPress;
            flowLayoutPanelQuestions.Resize += FlowLayoutPanelQuestions_Resize;
            flowLayoutPanelQuestions.AutoScroll = true;

            txtSearch.TextChanged += TxtSearch_TextChanged;

            Controls.Add(ucQandA1);
            ucQandA1.Visible = false;

            faqList = new List<Tuple<string, string>>
            {
                new Tuple<string, string>("Wie funktioniert die Anmeldung bei Moodle?", 
                "In deinem Ersten Tag bekommst du deine Schulmail und das Passwort von der Schule."),
                new Tuple<string, string>("Wie komme ich zu den Lernfeldern in Moodle?", 
                "Wenn du dich in Moodle angemeldet hast, gehst du in den Fachbereich Informationstechnik und dann klickst du auf Fachinformatiker: innen & IT-Systemelektroniker: innen (HK) und dann auf Lernfelder."),
                new Tuple<string, string>("Was ist Infotheke und wie komme ich drauf?", 
                "Die Infotheke ist deine Lernplattform, wo die ganzen Informationen sind, die du brauchst, um dein Projekt zu bearbeiten oder um dein Wissen zu verstärken. Du findest sie in den Fachbereich Informationstechnik."),
                new Tuple<string, string>("Wo finde ich meinen Klassenkursbereich?", 
                "Wenn du dich in Moodle angemeldet hast, gehst du in den Fachbereich Informationstechnik und dann klickst du auf Fachinformatiker: innen & IT-Systemelektroniker: innen (HK), dann Klassenbereiche."),
                new Tuple<string, string>("Wo finde ich die Infos über die Ausbildung?", 
                "Wenn du dich in Moodle angemeldet hast, gehst du in den Fachbereich Informationstechnik und dann klickst du auf Fachinformatiker: innen & IT-Systemelektroniker: innen (HK)."),
                new Tuple<string, string>("Wo und wie kann ich Open-Learning Kurse finden?", 
                "In deinem Klassenbereich findest du sie, aber bei Suche Open-Learning geben, dann kommst du direkt drauf."),
                new Tuple<string, string>("Wer ist mein Klassenlehrer?", 
                "Das findest du in deinem Klassenbereich unter “Informationen, Forum und Blockpläne, Archiv” und dann auf Klassenteam klicken. Dort findest du deine Klassenlehren und deine Klassenteams."),
                new Tuple<string, string>("Was ist ein Einschreibeschlüssel und wo finde ich den?", 
                "Du bekommst den Schlüssel von der Schule und du brauchst ihn, um deine Kurse freizuschalten."),
                new Tuple<string, string>("Wann findet sich im Schulblock Fachenglisch/WuG statt?", 
                "Es ist unterschiedlich von einer Klasse zu der anderen in der Planung soll das stehen, wann du Englisch und wann du WuG hast. Meistens ist es aber so, dass in jedem Block ein Fach von den Beiden stattfindet."),
                new Tuple<string, string>("Wie arbeitet man Online?", 
                "Am bestens organisierst du das mit deinem Team, wie ihr das machen wollt, aber die Schule gibt euch die Möglichkeit von zuhause zu arbeiten. Wichtig ist aber, wenn es sich um Inputs, Daily oder Final handelt, dann muss man seine Kamera und Mikrofon freischalten."),
                new Tuple<string, string>("Kann man die Lehrer auch Online erreichen?", 
                "Klar, man kann die Lehrer auch Online erreichen, da du immer eine E-Mail an Sie schreiben kannst."),
                new Tuple<string, string>("Werden die Noten für jeden einzeln gegeben oder für die ganze Gruppe?", 
                "Es ist immer unterschiedlich, aber du und deine Gruppe können meistens entscheiden, wie ihr das haben wollt."),
                
                new Tuple<string, string>("Was ist mit den Szenarien gemeint?", 
                "Die Szenarien sind die unterschiedlich und man kann immer eine auswählen, um zu sehen, wie man arbeiten möchte, z.B. Es gibt Szenarien, wo man mit seinen eigenen Ideen arbeiten möchte und es gibt auch Szenarien, wo man etwas ergänzen soll, was von der Schule gefördert ist."),
                new Tuple<string, string>("Soll man das Lernfeld 1 im eigenen Unternehmen vorbereiten?", 
                "Am bestens ja, aber ist es auch deine Entscheidung. Besprich das mit deinem Unternehmen und guck mal, ob sie etwas Bestimmtes haben wollen."),
                new Tuple<string, string>("Ist eine Präsentation in PowerPoint notwendig?", 
                "Nein, wichtig ist das du es gut vorstellen kannst, wenn du das Gefühl hast, dass du besser mit PowerPoint arbeitest, dann mach das wie es dir am bestens passt."),
                new Tuple<string, string>("Wie stellen wir am Ende des Blocks unser Projekt vor?", 
                "Du kannst das mit deinem Lehrer besprechen, aber am meistens machen Gruppen ein Fach/Feedbacks Gespräch mit dem Lehrer."),
                new Tuple<string, string>("Was ist ein Reflexionsgespräch?", 
                "Ist das Gespräch mit dem Lehrer, um euer Projekt vorzustellen und um Noten und Feedbacks zu bekommen."),
                new Tuple<string, string>("Wie arbeite ich in einem Team?", 
                "Es gibt immer verschiedene Methoden wie man in einem Team arbeitet. Wichtig ist aber, dass jeder aus der Gruppe etwas macht und dass ihr euch gut organisiert."),
                new Tuple<string, string>("Wie kann ich gut recherchieren in Internet?", 
                "Es gibt auf Google bestimmte Tricks, die dir gut helfen können. Suche nach “Richtig googlen” und du findest bestimmt viele Sachen, die dir helfen können."),
                new Tuple<string, string>("Was ist Packet Tracer?", 
                "Ist eine Software von Cisco, die dir ermöglicht, Netzwerke und Arbeitsplätze zu simulieren, bevor du das umsetzt."),
                new Tuple<string, string>("Wie arbeite ich auf Packet Tracer?", 
                "Es gibt viele Informationen, die du im Internet finden kannst, wie man mit Packet Tracer arbeiten kannst. Ich empfehle dir, die Einführung von Cisco zu schauen."),
                new Tuple<string, string>("Was ist ein Raspberry Pi?", 
                "Ist ein Mini-PC, der für bestimmte Anwendungen benutzt werden kann. Man kann mit Raspberry Pi viele schöne kleine Projekte macht. Raspberry kann für Studenten oder Schüler besonders gut sein, da er den ermöglicht, verschiedene Systeme von null einzurichten."),
                new Tuple<string, string>("Was für Projekte kann man mit dem Raspberry Pi machen?", 
                "Man kann mit dem Raspberry Pi viele Projekte machen. Z.B. IoT (Internet of Things) also Smarthome, Temperaturüberwachungssystem, Mediacenter, Spielplattform und viele andere Sachen."),
            };

            foreach (var faq in faqList)
            {
                AddQuestionButton(faq.Item1);
            }
            DisplayAllSuggestions();
        }
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string userInput = txtSearch.Text.Trim().ToLower();

            var filteredSuggestions = suggestions
                .Where(s => s.ToLower().Contains(userInput))
                .ToList();

            listBoxSuggestions.DataSource = filteredSuggestions;

            listBoxSuggestions.Visible = true;

            if (filteredSuggestions.Count == 0)
            {
                listBoxSuggestions.Visible = true;
            }
        }
        private void listBoxSuggestions_Click(object sender, EventArgs e)
        {
            if (listBoxSuggestions.SelectedItem != null)
            {
                txtSearch.Text = listBoxSuggestions.SelectedItem.ToString();
            }
            txtSearch.Focus();
        }
        private void DisplayAllSuggestions()
        {
            listBoxSuggestions.DataSource = suggestions;
            listBoxSuggestions.Visible = true;
        }

        private void AddQuestionButton(string question)
        {
            Button btn = new Button
            {
                Text = question,
                Tag = question,
                Anchor = AnchorStyles.Top & AnchorStyles.Left & AnchorStyles.Right,
                Width = flowLayoutPanelQuestions.Width - SystemInformation.VerticalScrollBarWidth - 10,
                Height = 30,
                TextAlign = ContentAlignment.MiddleLeft,
                Margin = new Padding(5),
                FlatStyle = FlatStyle.Flat
            };
            btn.MouseEnter += (sender, e) => btn.BackColor = Color.FromArgb(255, 128, 255);
            btn.MouseLeave += (sender, e) => btn.BackColor = default;

            btn.Click += QuestionButton_Click;

            flowLayoutPanelQuestions.Controls.Add(btn);
        }

        private void QuestionButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string selectedQuestion = (string)btn.Tag;

            // Finde die passende Antwort zur ausgewählten Frage
            string selectedAnswer = faqList.FirstOrDefault(x => x.Item1 == selectedQuestion)?.Item2;
            ShowUcQandA(selectedQuestion, selectedAnswer);
        }

        private void ShowUcQandA(string selectedQuestion, string selectedAnswer)
        {
            ucQandA1.Visible = true;
            ucQandA1.BringToFront();
            ucQandA1.SetText(selectedQuestion, selectedAnswer);
        }
        private void HideUcQandA()
        {
            ucQandA1.Visible = false;
        }
        private void ShowAnswerWindow(string question, string answer)
        {
            //MessageBox.Show($"{question}\n\n{answer}", "Frage und Antwort");
        }

        private void txtQuestion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                flowLayoutPanelQuestions.Visible = true;
                AddQuestionButtons();
            }
            HideUcQandA();
        }

        private void AddQuestionButtons()
        {
            string userInput = txtSearch.Text.ToLower();
            // Durchsuche die Frage-Antwort-Liste nach Übereinstimmungen
            var matchingQuestions = faqList.Where(x => x.Item1.ToLower().Contains(userInput) || x.Item2.ToLower().Contains(userInput));
            if (matchingQuestions.Count() == 0) 
            {
                MessageBox.Show("Keine Ergebnis gefunden", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Clear();
                return;
            }
            
            // Aktualisiere die Buttons basierend auf den übereinstimmenden Fragen
            flowLayoutPanelQuestions.Controls.Clear();
            foreach (var faq in matchingQuestions)
            {
                AddQuestionButton(faq.Item1);
            }
            txtSearch.Clear();
        }
    }
}
