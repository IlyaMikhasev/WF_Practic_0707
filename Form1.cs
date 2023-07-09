using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Practic_0707
{
    public partial class Form1 : Form
    {
        Move_cell move_cell;
        Point _free_P;
        List<Button> _ButtonPoints;
        List<(int, int)> _TruePoints = new List<(int, int)> {(0,0),(142,0),(284,0),(426,0),
                                                          (0,142),(142,142),(284,142),(426,142),
                                                          (0,284),(142,284),(284,284),(426,284),
                                                          (0,426),(142,426),(284,426),(426,426)};
        public Form1()
        {                    
            InitializeComponent();
            shufleTheCells();
            move_cell = new Move_cell(_free_P);
        }
        private void shufleTheCells() {
            Random rnd = new Random(DateTime.UtcNow.Millisecond);
            _ButtonPoints = new List<Button>() {button1,button2,button3,button4,button5,button6,
            button7,button8,button9,button10,button11,button12,button13,button14,button15};
            List<(int, int)> valuesLoc =new List<(int, int)>( _TruePoints);
            for (int j = 0; j < _ButtonPoints.Count; j++)
            {
                int i = rnd.Next(valuesLoc.Count - 1);
                _free_P = new Point(valuesLoc[i].Item1, valuesLoc[i].Item2);
                valuesLoc.RemoveAt(i);
                _ButtonPoints[j].Location = _free_P;
            }
            _free_P = new Point(valuesLoc.Last().Item1, valuesLoc.Last().Item2);
        }
        private bool ReadinessCheck(List<Button> ButtonPoints, List<(int, int)> TruePoints)
        {
            bool res = false;
            for (int i = 0; i < ButtonPoints.Count - 1; i++) {
                if ((TruePoints[i].Item1, TruePoints[i].Item2) == (ButtonPoints[i].Location.X, ButtonPoints[i].Location.Y))
                {
                    res = true;
                }
                else { 
                   return res = false;
                }            
            }
            return res;
        }
        private void callMbox() {
            var click= MessageBox.Show("Продолжить игру?", "Пятнашки собранны поздравляю!", MessageBoxButtons.RetryCancel);
            if (DialogResult.Retry == click)
                shufleTheCells();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Location = move_cell.FreeSpaceCheck(button1.Location);
            if(ReadinessCheck(_ButtonPoints,_TruePoints))
                callMbox();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            button2.Location = move_cell.FreeSpaceCheck(button2.Location);
            if (ReadinessCheck(_ButtonPoints, _TruePoints))
                callMbox();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            button3.Location = move_cell.FreeSpaceCheck(button3.Location); 
            if (ReadinessCheck(_ButtonPoints, _TruePoints))
                callMbox();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            button4.Location = move_cell.FreeSpaceCheck(button4.Location);
            if (ReadinessCheck(_ButtonPoints, _TruePoints))
                callMbox();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            button5.Location = move_cell.FreeSpaceCheck(button5.Location);
            if (ReadinessCheck(_ButtonPoints, _TruePoints))
                callMbox();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            button6.Location = move_cell.FreeSpaceCheck(button6.Location);
            if (ReadinessCheck(_ButtonPoints, _TruePoints))
                callMbox();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            button7.Location = move_cell.FreeSpaceCheck(button7.Location);
            if (ReadinessCheck(_ButtonPoints, _TruePoints))
                callMbox();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            button8.Location = move_cell.FreeSpaceCheck(button8.Location);
            if (ReadinessCheck(_ButtonPoints, _TruePoints))
                callMbox();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            button9.Location = move_cell.FreeSpaceCheck(button9.Location);
            if (ReadinessCheck(_ButtonPoints, _TruePoints))
                callMbox();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            button10.Location = move_cell.FreeSpaceCheck(button10.Location);
            if (ReadinessCheck(_ButtonPoints, _TruePoints))
                callMbox();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            button11.Location = move_cell.FreeSpaceCheck(button11.Location);
            if (ReadinessCheck(_ButtonPoints, _TruePoints))
                callMbox();
        }
        private void button12_Click(object sender, EventArgs e)
        {
            button12.Location = move_cell.FreeSpaceCheck(button12.Location);
            if (ReadinessCheck(_ButtonPoints, _TruePoints))
                callMbox();
        }
        private void button13_Click(object sender, EventArgs e)
        {
            button13.Location = move_cell.FreeSpaceCheck(button13.Location);
            if (ReadinessCheck(_ButtonPoints, _TruePoints))
                callMbox();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.Location = move_cell.FreeSpaceCheck(button14.Location);
            if (ReadinessCheck(_ButtonPoints, _TruePoints))
                callMbox();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.Location = move_cell.FreeSpaceCheck(button15.Location);
            if (ReadinessCheck(_ButtonPoints, _TruePoints))
                callMbox();
        }
    }
}
