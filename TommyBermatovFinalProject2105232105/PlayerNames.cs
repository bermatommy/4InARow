using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4InARow
{
    public partial class PlayerNames : Form
    {
        private Settings settings;
        public PlayerNames(Settings settings)
        {
            InitializeComponent();
            this.settings = settings;
        }
        /// <summary>
        /// if the textBox is empty so change its backcolor
        /// if entered text, give it to settings that transfer it
        /// to gameboard to show the name of who is playing
        /// </summary>
        private void btn_ok_Click(object sender, EventArgs e)
        {
            bool ok = true;
            if (tb_name1.Text.Length == 0) // check that user entered text
            {
                ok = false;
                tb_name1.BackColor = Color.MistyRose;
            }

            if (tb_name2.Text.Length == 0)
            {
                ok = false;
                tb_name2.BackColor = Color.MistyRose;
            }

            if (ok)
            {
                settings.SetName1(tb_name1.Text);
                settings.SetName2(tb_name2.Text);
                this.Dispose();
            }
        }

        /// <summary>
        /// if textbox text is changed so change the backcolor
        /// </summary>
        private void tb_name_TextChanged(object sender, EventArgs e)
        {
            tb_name1.BackColor = Color.White;
        }

        /// <summary>
        /// if textbox text is changed so change the backcolor
        /// </summary>
        private void tb_Name2_TextChanged(object sender, EventArgs e)
        {
            tb_name2.BackColor = Color.White;
        }
    }
}
