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
        class Joke
        {
            public string labelText;
            public string buttonText;
        }

        int clickCount = 1;
        List<Joke> jokes = new List<Joke>()
        {
            new Joke() { labelText = "Knock, Knock!", buttonText = "Who's there?" },
            new Joke() { labelText = "Abby", buttonText = "Abby who?" },
            new Joke() { labelText = "Abby New Year!", buttonText = "Start Over" },
            new Joke() { labelText = "Knock, Knock!", buttonText = "Who's there?" },
            new Joke() { labelText = "Anee", buttonText = "Anee who?" },
            new Joke() { labelText = "Anee one you like!", buttonText = "Start Over" },
            new Joke() { labelText = "Knock, Knock!", buttonText = "Who's there?" },
            new Joke() { labelText = "Robin", buttonText = "Robin who?" },
            new Joke() { labelText = "Robin the piggy bank again!", buttonText = "Start Over" }
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
