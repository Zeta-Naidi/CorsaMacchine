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

namespace CorsaMacchine
{
    public partial class Form1 : Form
    {
        public Random rnd;
        public Form1()
        {
            InitializeComponent();
            rnd = new Random();
        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker BGW = sender as BackgroundWorker;
            PictureBox Car = (PictureBox)e.Argument;

            while (Car.Location.X < pbPista.Width - Car.Width +pbPista.Location.X)
            {
                if (!BGW.CancellationPending)
                {
                    Thread.Sleep(rnd.Next(0, 10));
                    int x = rnd.Next(0, 4);
                    BGW.ReportProgress(x, Car);
                }
            }
            if (!BGW.CancellationPending)
            { e.Result = Car; }
            backgroundWorker1.CancelAsync();
            backgroundWorker2.CancelAsync();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            PictureBox Car = (PictureBox)e.UserState;
            int x = Car.Location.X + e.ProgressPercentage;
            Car.Location = new Point(x, Car.Location.Y);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var Car = e.Result as PictureBox;
            if (Car == null) { MessageBox.Show("PAREGGIO"); }
            else if (Car.Name == pbCar1.ToString()) { MessageBox.Show("THE WINNER IS BLACK CAR"); }
            else  { MessageBox.Show("THE WINNER IS RED CAR"); }
        }

        public void Reposition()
        {
            pbCar1.Location = new Point(pbPista.Location.X, pbCar1.Location.Y);
            pbCar2.Location = new Point(pbPista.Location.X, pbCar2.Location.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reposition();
            backgroundWorker1.RunWorkerAsync(pbCar1);
            backgroundWorker2.RunWorkerAsync(pbCar2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
            backgroundWorker2.CancelAsync();
        }
    }
}
