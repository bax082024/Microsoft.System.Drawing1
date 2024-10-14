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

        Graphics g = 3.Graphics;
        g.DrawRectangle(Pens.Black, 50, 50, 200, 100);

        g.DrawEllipse(Pens.Blue, 300, 50, 200, 100);

        Font font = new Font("Arial", 16);
        g.DrawString("Hello, Graphics!", font, Brushes.Red, 150, 200);
    }
}
