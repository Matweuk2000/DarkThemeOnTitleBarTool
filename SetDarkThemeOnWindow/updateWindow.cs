using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SetDarkThemeOnWindow
{
    public partial class updateWindow : Form
    {
        bool xm;

        public updateWindow(bool m)
        {
            InitializeComponent();
            xm = m;
        }

        private void updateWindow_Load(object sender, EventArgs e)
        {
            if (xm)
            {
                Console.WriteLine("Window updated!");
            }
        }
    }
}
