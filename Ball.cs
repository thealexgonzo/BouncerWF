using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouncerWF;

public class Ball
{
    private int _x = 100;
    private int _y = 100;
    private int _dx = 0;
    private int _dy = -1;
    private Pen _p = new Pen(Color.Black);

    public void Update()
    {
        _x += _dx;
        _y += _dy;
    }

    public void Display(Graphics g)
    {
        //Update();
        
        g.DrawEllipse(_p, _x, _y, 50, 50);
    }
}
