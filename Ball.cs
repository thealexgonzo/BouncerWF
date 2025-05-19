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
    private Pen _p = new Pen(Color.Black);

    public void Display(Graphics g)
    {
        _x++;
        _y++;
        g.DrawEllipse(_p, _x, _y, 50, 50);
    }
}
