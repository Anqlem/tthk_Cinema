﻿using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace CinemaSeats
{
    public partial class Form1 : Form
    {
        public Button small, medium, big;
        public Form1()
        {
            Height = 300;
            Width = 300;
            Text = "Cinema";
            small = new Button
            {
                Size = new Size(80, 50),
                Location = new Point(100, 30),
                Text = "Small"
            };
            medium = new Button
            {
                Size = new Size(80, 50),
                Location = new Point(100, 85),
                Text = "Medium"
            };
            big = new Button
            {
                Size = new Size(80, 50),
                Location = new Point(100, 140),
                Text = "Big"
            };
            big.Click += Big_Click;
            medium.Click += Medium_Click;
            small.Click += Small_Click;

            this.Controls.Add(small);
            this.Controls.Add(medium);
            this.Controls.Add(big);
        }

        private void Small_Click(object sender, EventArgs e)
        {
            Small sml = new Small();
            sml.Show();
        }

        private void Medium_Click(object sender, EventArgs e)
        {
            Medium mdm = new Medium();
            mdm.Show();
        }

        private void Big_Click(object sender, EventArgs e)
        {
            Big bg = new Big();
            bg.Show();
        }
    }
}