using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualCurs
{
    public partial class TrainForm : Form
    {
        public TrainForm()
        {
            InitializeComponent();
        }
        char tmp = ' ';
        int time=20;
        int score = 0;
        private void TrainForm_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            timeLabel.Visible = false;
            scoreLabel.Visible = false;


        }
        private void TrainForm_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            KeysConverter kc = new KeysConverter();
            string keyChar = kc.ConvertToString(e.KeyCode);

            if (tmp.ToString() == keyChar)
            {
                score++;
                scoreLabel.Text = "Очки:"+score.ToString();
                CharGen();
            }
            
        }
        void CharGen()
        {
            Random rand = new Random();
            tmp = (char)rand.Next('A', 'Z' + 1);
            label2.Text = tmp.ToString();
        }
        async void StartTimer()
        {
            while (time > 0)
            {
                time--;
                timeLabel.Text = "Время"+time.ToString();
                await Task.Delay(1000);

            }
            if(MessageBox.Show("Игра окончена!\n Вы набрали " + score.ToString() + " очков") == DialogResult.OK)
            {
                this.Close();
            }
           
        
        }

        private void startBttn_Click(object sender, EventArgs e)
        {
            startBttn.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            timeLabel.Visible = true;
            scoreLabel.Visible = true;

            CharGen();
            StartTimer();

        }
    }
}
