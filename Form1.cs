using System;
using System.Drawing;
using System.Windows.Forms;



namespace SimpleDrawingApp;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        Graphics g = e.Graphics;

        g.DrawRectangle(Pens.Black, 50, 50, 200, 100);

        g.DrawEllipse(Pens.Blue, 300, 50, 200, 100);




        g.DrawEllipse(Pens.Black, 100, 200, 200, 200);

        g.DrawEllipse(Pens.Black, 140, 250, 40, 40);

        g.DrawEllipse(Pens.Black, 220, 250, 40, 40);

        g.DrawLine(Pens.Black, 150, 330, 250, 330);

        

        Font font = new Font("Arial", 16);
        g.DrawString("Hello, Graphics!", font, Brushes.Red, 150, 400);

        g.DrawString("This is Fun!", font, Brushes.Red, 150, 450);
    }
}
