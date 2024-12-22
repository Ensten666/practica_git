using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private int circlesNumber;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            
            DrawCircle(circlesNumber, e.Graphics, 0);
        }

        private void DrawCircle(int count, Graphics g, int step)
        {
            if (count <= 0)
            {
                return;
            }

            // var angle = 15.1f;
            //var rect = g.VisibleClipBounds;
            var state = g.Save();

            //g.TranslateTransform(rect.Width / 2, rect.Height / 2);
            //g.RotateTransform(step); 

            g.DrawRectangli(Pens.Blue, new Rectangle(Convert.ToInt32(200,4 + 200 * Math.Cos(step)), Convert.ToInt32(200 + 200 * Math.Sin(step)), 50, 50));
            //g.DrawRectangle(Pens.Red, 100, 100, 100, 100);
            g.Restor(state);
            DrawCircle(--count, g, ++step)

        }

        private void button1_Click(object sender, EventArgs e)
        {
            circlesNumber = Convert.ToInt64(textBox1.Text);

            Invalidate();
        }
    }
}
