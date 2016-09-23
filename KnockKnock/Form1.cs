using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnockKnock
{
    public partial class Form1 : Form
    {
        class JokeState
        {
            public string labelText;
            public string buttonText;
        }

        int clickCount = 1;
        List<JokeState> jokes = new List<JokeState>()
        {
            new JokeState() { labelText = "Knock, Knock!", buttonText = "Who's there?" },
            new JokeState() { labelText = "Abby", buttonText = "Abby who?" },
            new JokeState() { labelText = "Abby New Year!", buttonText = "Start Over" },
            new JokeState() { labelText = "Knock, Knock!", buttonText = "Who's there?" },
            new JokeState() { labelText = "Anee", buttonText = "Anee who?" },
            new JokeState() { labelText = "Anee one you like!", buttonText = "Start Over" },
            new JokeState() { labelText = "Knock, Knock!", buttonText = "Who's there?" },
            new JokeState() { labelText = "Robin", buttonText = "Robin who?" },
            new JokeState() { labelText = "Robin the piggy bank again!", buttonText = "Start Over" }
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            labelText.Text = jokes.ElementAt(clickCount).labelText;
            submitButton.Text = jokes.ElementAt(clickCount).buttonText;
            clickCount++;
            if (clickCount == jokes.Count())
            {
                clickCount = 0;
            }
        }
    }
}
