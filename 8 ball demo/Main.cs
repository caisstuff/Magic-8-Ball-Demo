using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using _8ball.Properties;
namespace _8ball
{
    public partial class Main : Form
    {
        Random r = new Random();
        int charnumb =0;
        string[] replies = {"It is certain.",
                         "It is decidedly so.",
                         "Without a doubt.",
                         "Yes definitely.",
                         "You may rely on it.",
                         "As I see it, yes.",
                         "Most likely.",
                         "Outlook good.",
                         "Yes.",
                         "Signs point to yes.",
                         "Reply hazy, Try again.",
                         "Ask again later.",
                         "Better not tell you now.",
                         "Cannot predict now.",
                         "Concentrate and ask again.",
                         "Don't count on it.",
                         "My reply is no.",
                         "My Sources say no.",
                         "Outlook not so good.",
                         "Very doubtful.",
                        };
        public Main() //nothing much here to see.
        {
            InitializeComponent();
        }

        private void Answerb_Click(object sender, EventArgs e) //the fun part.
        {
            charnumb = Questionbox.Text.Length; //trying to make this not low quality.
            if (charnumb > 4) {
                if (Settingsconfig.Default.AccessibleShakeDisable == false) {
                    Answerb.Enabled = false;
                    Access.Enabled = false;
                    InfoCredbutton.Enabled = false;
                //thank you stack overflow, you are my bestie.
                    var original = this.Location;
                    var rndshk = new Random(1337);
                    const int shake_amp = 10; //code forked from Hans Passant https://stackoverflow.com/questions/16689741/shake-form-on-screen Hope I'm not doing anything wrong as this is my first time.
                    for (int i = 0; i < 10; i++)
                    {
                        this.Location = new Point(original.X + r.Next(-shake_amp,shake_amp), original.X + r.Next(-shake_amp,shake_amp));
                        System.Threading.Thread.Sleep(20);
                    }
                    this.Location = original;
                    Answerb.Enabled = true;
                    Access.Enabled = true;
                    InfoCredbutton.Enabled = true;
                }//this check is to make sure if someone can't handle animations, this will skip.
                int answer = r.Next(replies.Length);
                var result = MessageBox.Show(replies[answer], "Truthful Answer - Magic 8 Ball Demo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                if (result == DialogResult.OK) {
                Questionbox.Clear();
                }
        }
            else {
                MessageBox.Show("Not enough input to answer your question!", "Type some more. - Magic 8 Ball Demo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Questionbox_Enter(object sender, KeyEventArgs e) //returning with an answer.
        {
            if(e.KeyCode == Keys.Enter){
            Answerb_Click(this, new EventArgs());
            }
        }

        private void InfoCredbutton_Click(object sender, EventArgs e) //this is for credits.
        {
            Credits ac = new Credits();
            ac.ShowDialog();
        }

        private void Access_Click(object sender, EventArgs e)// this is for accessibility settings.
        {
            AccessibleSetting aa = new AccessibleSetting();
            aa.ShowDialog();
        }
    }
}
