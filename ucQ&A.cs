using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatBot
{
    public partial class UcQandA : UserControl
    {
        private Label lblText;
        public UcQandA()
        {
            InitializeComponent();
            InitializeLabel();
        }
        private void InitializeLabel()
        {
            lblText = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Size = new Size(30, 30),
                Font = new Font("Arial", 18, FontStyle.Regular)
            };
            Controls.Add(lblText);
        }
        public void SetText(string selectedQuestion, string selectedAnswer)
        {
            lblText.Text = $"{selectedQuestion} \n\n\n {selectedAnswer}";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
