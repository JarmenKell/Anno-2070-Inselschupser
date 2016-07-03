using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Anno_2070_Inselschupser
{
    public partial class Bild : Form
    {
        public Bild()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Bild_FormClosing);
        }

        void Bild_FormClosing(object sender, FormClosingEventArgs e)
        {
            Editor.opened = false;
        }

        public void repaint(int[,] map, int mapsize)
        {
            Height = mapsize + 40;
            Width = mapsize + 20;
            Graphics picture = this.CreateGraphics();
            picture.Clear(Color.Black);
            picture.DrawLine(new Pen(Color.Blue, 1), 0, mapsize / 2, mapsize / 2, 0);
            picture.DrawLine(new Pen(Color.Blue, 1), mapsize / 2, 0, mapsize, mapsize / 2);
            picture.DrawLine(new Pen(Color.Blue, 1), mapsize, mapsize / 2, mapsize / 2, mapsize);
            picture.DrawLine(new Pen(Color.Blue, 1), mapsize / 2, mapsize, 0, mapsize / 2);

            Pen[] islandtype = new Pen[5];
            islandtype[0] = new Pen(Color.Yellow, 1);
            islandtype[1] = new Pen(Color.Blue, 1);
            islandtype[2] = new Pen(Color.LightYellow, 1);
            islandtype[3] = new Pen(Color.LightBlue, 1);
            islandtype[4] = new Pen(Color.Red, 1);
            for (int i = 0; i < map.GetLength(0); i++)
            {
                picture.DrawRectangle(islandtype[map[i, 1]], map[i, 2], map[i, 3], map[i, 4], map[i, 4]);
                picture.DrawString(map[i, 0].ToString(), new Font("Arial", 12), new SolidBrush(Color.White), map[i, 2], map[i, 3]);
            }
        }
    }
}
