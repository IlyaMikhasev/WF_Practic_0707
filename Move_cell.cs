using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Practic_0707
{
    internal class Move_cell
    {
        Point _point;
        public Move_cell(Point Free_point) {
            _point = Free_point;
        }
        public Point FreeSpaceCheck(Point pButton) {
            if (up(pButton) || down(pButton) || left(pButton) || right(pButton)) {
                Point tmp = _point;
                (_point.X, _point.Y) = (pButton.X, pButton.Y);
                return tmp;
            }
            else { return pButton; }

        }
        private bool up(Point loc) {
            if (_point.Y == loc.Y - 142 && _point.X == loc.X)
            {
                return true;
            }
            else
            {
                return false;
            }       
        }
        private bool down(Point loc ) {
            if (_point.Y == loc.Y + 142 && _point.X == loc.X)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool left(Point loc) {
            if (_point.X == loc.X - 142 && _point.Y == loc.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool right(Point loc)
        {
            if (_point.X == loc.X + 142 && _point.Y == loc.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
