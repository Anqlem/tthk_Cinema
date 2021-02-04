using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaSeats
{
    public partial class Small : Form
    {
        private List<Label> _labels;
        private int xOffset = 10;
        private int yOffset = 10;
        SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|Tickets.mdf; Integrated Security = True");
        SqlCommand command;
        SqlDataAdapter adapter, adapter2;

        public Small()
        {
            InitializeComponent();
            //Image img = Image.FromFile(@"C:\Users\opilane\source\repos\CinemaSeats\Resources\redchair.png");

            connect.Open();

            _labels = new List<Label>();
            for (var i = 0; i <= 20; i++)
            {
                Label a = new Label
                {
                    Name = "chair" + i,
                    Height = 50,
                    Width = 100,
                    Size = new Size(70, 70),
                    BorderStyle = BorderStyle.Fixed3D,
                    BackColor = Color.Green
                    //Image = img

                };
                a.MouseClick += A_MouseClick;
                _labels.Add(a);

                // 581, 517
                var x = 0;
                var y = 0;

                foreach (var lbl in _labels)
                {
                    if (x >= 580)
                    {
                        x = 0;
                        y = y + lbl.Height + 2;
                    }

                    lbl.Location = new Point(x, y);
                    this.Controls.Add(lbl);
                    x += lbl.Width;
                }
            }
        }

        private void A_MouseClick(object sender, MouseEventArgs e)
        {
            var a = (Label)sender;
            if (a.BackColor == Color.Yellow)
            {
                a.BackColor = Color.Green;
            }
            else
            {
                a.BackColor = Color.Yellow;
            }
                
        }
    }
}
