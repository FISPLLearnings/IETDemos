using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11ClickEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Button btn = new Button();
            btn.Text = "Click";
            btn.AutoSize = true;

            EventHandler handler = new EventHandler(ExecuteMeOnBtnClick);
            btn.Click += handler;

            this.Controls.Add(btn);
        }

        public void ExecuteMeOnBtnClick(object sender, EventArgs e)
        {
            MessageBox.Show("You Clicked on the button!");
        }
    }
}
