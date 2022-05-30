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

namespace NIM
{
    public partial class Form1 : Form
    {
        int sirky = 0;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Startgame_Click(object sender, EventArgs e)
        {
            sirky = rnd.Next(5, 25);
            numlbl.Text = sirky.ToString();
            sirka1pb.Visible = true;
            sirka1btn.Visible = true;
            sirka2pb.Visible = true;
            sirka2btn.Visible = true;
            sirka3pb.Visible = true;
            sirka3btn.Visible = true;
            sirkaboxpb.Visible = true;
            numlbl.Visible = true;
            sirkylbl.Visible = true;
            Startgame.Visible = false;

        }

        private void sirka1btn_Click(object sender, EventArgs e)
        {
            btn(false);
            sirky -= 1;
            numlbl.Text = sirky.ToString();
            Wait(1000);
            no();
            enemy();
        }

        private void sirka2btn_Click(object sender, EventArgs e)
        {
            btn(false);
            sirky -= 2;
            numlbl.Text = sirky.ToString();
            Wait(1000);
            no();
            enemy();
        }

        private void sirka3btn_Click(object sender, EventArgs e)
        {
            btn(false);
            sirky -= 3;
            numlbl.Text = sirky.ToString();
            Wait(1000);
            no();
            enemy();
        }

        private void enemy()
        {
            btn(true);
            sirky -= rnd.Next(1, 3);
            numlbl.Text = sirky.ToString();
            yes();
        }
        private void Wait(int time)
        {
            Thread thread = new Thread(delegate ()
            {
                Thread.Sleep(time);
            });
            thread.Start();
            while (thread.IsAlive)
                Application.DoEvents();
        }

        private void yes()
        {
            if (sirky <= 1)
            {
                gamelostlbl.Visible = true;
                sirka1pb.Visible = false;
                sirka1btn.Visible = false;
                sirka2pb.Visible = false;
                sirka2btn.Visible = false;
                sirka3pb.Visible = false;
                sirka3btn.Visible = false;
                sirkaboxpb.Visible = false;
                numlbl.Visible = false;
                sirkylbl.Visible = false;
                Startgame.Visible = false;
                end.Visible = true;
                again.Visible = true;
            }
        }
        private void no()
        {
            if(sirky <= 1)
            {
                gamewonlbl.Visible = true;
                sirka1pb.Visible = false;
                sirka1btn.Visible = false;
                sirka2pb.Visible = false;
                sirka2btn.Visible = false;
                sirka3pb.Visible = false;
                sirka3btn.Visible = false;
                sirkaboxpb.Visible = false;
                numlbl.Visible = false;
                sirkylbl.Visible = false;
                Startgame.Visible = false;
                end.Visible = true;
                again.Visible = true;
            }
        }
        private void btn(bool akce)
        {
            sirka1btn.Enabled = akce;
            sirka2btn.Enabled = akce;
            sirka3btn.Enabled = akce;
        }

        private void end_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void again_Click(object sender, EventArgs e)
        {
            sirky = rnd.Next(5, 25);
            numlbl.Text = sirky.ToString();
            sirka1pb.Visible = true;
            sirka1btn.Visible = true;
            sirka2pb.Visible = true;
            sirka2btn.Visible = true;
            sirka3pb.Visible = true;
            sirka3btn.Visible = true;
            sirkaboxpb.Visible = true;
            numlbl.Visible = true;
            sirkylbl.Visible = true;
            Startgame.Visible = false;
            gamewonlbl.Visible = false;
            gamelostlbl.Visible = false;
        }
    }
}

