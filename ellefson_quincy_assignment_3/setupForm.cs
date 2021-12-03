using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ellefson_quincy_assignment_3
{
    public partial class setupForm : Form
    {
        public setupForm()
        {
            InitializeComponent();
        }

        private void setupForm_Load(object sender, EventArgs e)
        {

        }
       
        private void p1TileColor_Click(object sender, EventArgs e)//p1 tile color picker
        {
            ColorDialog colorDialog1 = new ColorDialog();//When the button is clicked it has a color picker dialogue popup
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                p1TileColor.BackColor = colorDialog1.Color;
            }
            Color p1tColor = p1TileColor.BackColor;
        }

        private void p1CharColor_Click(object sender, EventArgs e)//p1 character color picker
        {
            ColorDialog colorDialog1 = new ColorDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                p1CharColor.BackColor = colorDialog1.Color;
            }
            Color p1cColor = p1CharColor.BackColor;
        }

        private void p2TileColor_Click(object sender, EventArgs e)//p2 Tile color
        {
            ColorDialog colorDialog1 = new ColorDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                p2TileColor.BackColor = colorDialog1.Color;
            }
            Color p2tColor = p2TileColor.BackColor;
        }

        private void p2CharColor_Click(object sender, EventArgs e)//p2 Character color
        {
            ColorDialog colorDialog1 = new ColorDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                p2CharColor.BackColor = colorDialog1.Color;
            }
            Color p2cColor = p2CharColor.BackColor;
        }

        private void p1Name_TextChanged(object sender, EventArgs e)//Taked the name entered in text box and stores is
        {
            string p1EnteredName = p1Name.Text.ToString();
            p1Ready.Visible = true;
        }

        private void p2Name_TextChanged(object sender, EventArgs e)//P2 name storage
        {
            string p2EnteredName = p2Name.Text.ToString();
            p2Ready.Visible = true;
        }
        //Player 1 icon selection, there certainly was a better way to do this but I can't remember
        private void p1Star_Click(object sender, EventArgs e)
        {
            string p1Icon = p1Star.Text.ToString();
            p2Star.Enabled = false;
            p2Star.BackColor = Color.Red;

            p2Smile.Enabled = true;
            p2Snow.Enabled = true;
            p2Drop.Enabled = true;
            p2Sun.Enabled = true;
            p2Mouse.Enabled = true;
            p2PC.Enabled = true;
            p2Hand.Enabled = true;
        }

        private void p1Smile_Click(object sender, EventArgs e)
        {
            string p1Icon = p1Smile.Text.ToString();
            p2Smile.Enabled = false;
            p2Smile.BackColor = Color.Red;

            p2Star.Enabled = true;
            p2Snow.Enabled = true;
            p2Drop.Enabled = true;
            p2Sun.Enabled = true;
            p2Mouse.Enabled = true;
            p2PC.Enabled = true;
            p2Hand.Enabled = true;
        }

        private void p1Snow_Click(object sender, EventArgs e)
        {
            string p1Icon = p1Snow.Text.ToString();
            p2Snow.Enabled = false;
            p2Snow.BackColor = Color.Red;

            p2Star.Enabled = true;
            p2Smile.Enabled = true;
            p2Drop.Enabled = true;
            p2Sun.Enabled = true;
            p2Mouse.Enabled = true;
            p2PC.Enabled = true;
            p2Hand.Enabled = true;
        }

        private void p1Drop_Click(object sender, EventArgs e)
        {
            string p1Icon = p1Drop.Text.ToString();
            p2Drop.Enabled = false;
            p2Drop.BackColor = Color.Red;

            p2Star.Enabled = true;
            p2Smile.Enabled = true;
            p2Snow.Enabled = true;
            p2Sun.Enabled = true;
            p2Mouse.Enabled = true;
            p2PC.Enabled = true;
            p2Hand.Enabled = true;
        }

        private void p1Sun_Click(object sender, EventArgs e)
        {
            string p1Icon = p1Sun.Text.ToString();
            p2Sun.Enabled = false;
            p2Sun.BackColor = Color.Red;

            p2Star.Enabled = true;
            p2Smile.Enabled = true;
            p2Snow.Enabled = true;
            p2Drop.Enabled = true;
            p2Mouse.Enabled = true;
            p2PC.Enabled = true;
            p2Hand.Enabled = true;
        }

        private void p1Hand_Click(object sender, EventArgs e)
        {
            string p1Icon = p1Hand.Text.ToString();
            p2Hand.Enabled = false;
            p2Hand.BackColor = Color.Red;

            p2Star.Enabled = true;
            p2Smile.Enabled = true;
            p2Snow.Enabled = true;
            p2Drop.Enabled = true;
            p2Sun.Enabled = true;
            p2Mouse.Enabled = true;
            p2PC.Enabled = true;
        }

        private void p1Mouse_Click(object sender, EventArgs e)
        {
            string p1Icon = p1Mouse.Text.ToString();
            p2Mouse.Enabled = false;
            p2Mouse.BackColor = Color.Red;

            p2Star.Enabled = true;
            p2Smile.Enabled = true;
            p2Snow.Enabled = true;
            p2Drop.Enabled = true;
            p2Sun.Enabled = true;
            p2PC.Enabled = true;
            p2Hand.Enabled = true;
        }

        private void p1PC_Click(object sender, EventArgs e)
        {
            string p1Icon = p1PC.Text.ToString();
            p2PC.Enabled = false;
            p2PC.BackColor = Color.Red;

            p2Star.Enabled = true;
            p2Smile.Enabled = true;
            p2Snow.Enabled = true;
            p2Drop.Enabled = true;
            p2Sun.Enabled = true;
            p2Mouse.Enabled = true;
            p2Hand.Enabled = true;
        }
        //Then Player 2 icon selection
        private void p2Star_Click(object sender, EventArgs e)
        {
            string p2Icon = p2Star.Text.ToString();
            p1Star.Enabled = false;
            p1Star.BackColor = Color.Red;

            p1Smile.Enabled = true;
            p1Snow.Enabled = true;
            p1Drop.Enabled = true;
            p1Sun.Enabled = true;
            p1Mouse.Enabled = true;
            p1PC.Enabled = true;
            p1Hand.Enabled = true;
        }

        private void p2Smile_Click(object sender, EventArgs e)
        {
            string p2Icon = p2Smile.Text.ToString();
            p1Smile.Enabled = false;
            p1Smile.BackColor = Color.Red;

            p1Star.Enabled = true;
            p1Snow.Enabled = true;
            p1Drop.Enabled = true;
            p1Sun.Enabled = true;
            p1Mouse.Enabled = true;
            p1PC.Enabled = true;
            p1Hand.Enabled = true;
        }

        private void p2Snow_Click(object sender, EventArgs e)
        {
            string p2Icon = p2Snow.Text.ToString();
            p1Snow.Enabled = false;
            p1Snow.BackColor = Color.Red;

            p1Star.Enabled = true;
            p1Smile.Enabled = true;
            p1Drop.Enabled = true;
            p1Sun.Enabled = true;
            p1Mouse.Enabled = true;
            p1PC.Enabled = true;
            p1Hand.Enabled = true;
        }

        private void p2Drop_Click(object sender, EventArgs e)
        {
            string p2Icon = p2Drop.Text.ToString();
            p1Drop.Enabled = false;
            p1Drop.BackColor = Color.Red;

            p1Star.Enabled = true;
            p1Smile.Enabled = true;
            p1Snow.Enabled = true;
            p1Sun.Enabled = true;
            p1Mouse.Enabled = true;
            p1PC.Enabled = true;
            p1Hand.Enabled = true;
        }

        private void p2Sun_Click(object sender, EventArgs e)
        {
            string p2Icon = p2Sun.Text.ToString();
            p1Sun.Enabled = false;
            p1Sun.BackColor = Color.Red;

            p1Star.Enabled = true;
            p1Smile.Enabled = true;
            p1Snow.Enabled = true;
            p1Drop.Enabled = true;
            p1Mouse.Enabled = true;
            p1PC.Enabled = true;
            p1Hand.Enabled = true;
        }

        private void p2Hand_Click(object sender, EventArgs e)
        {
            string p2Icon = p2Hand.Text.ToString();
            p1Hand.Enabled = false;
            p1Hand.BackColor = Color.Red;

            p1Star.Enabled = true;
            p1Smile.Enabled = true;
            p1Snow.Enabled = true;
            p1Drop.Enabled = true;
            p1Sun.Enabled = true;
            p1Mouse.Enabled = true;
            p1PC.Enabled = true;
        }

        private void p2Mouse_Click(object sender, EventArgs e)
        {
            string p2Icon = p2Mouse.Text.ToString();
            p1Mouse.Enabled = false;
            p1Mouse.BackColor = Color.Red;

            p1Star.Enabled = true;
            p1Smile.Enabled = true;
            p1Snow.Enabled = true;
            p1Drop.Enabled = true;
            p1Sun.Enabled = true;
            p1PC.Enabled = true;
            p1Hand.Enabled = true;
        }

        private void p2PC_Click(object sender, EventArgs e)
        {
            string p2Icon = p2PC.Text.ToString();
            p1PC.Enabled = false;
            p1PC.BackColor = Color.Red;

            p1Star.Enabled = true;
            p1Smile.Enabled = true;
            p1Snow.Enabled = true;
            p1Drop.Enabled = true;
            p1Sun.Enabled = true;
            p1Mouse.Enabled = true;
            p1Hand.Enabled = true;
        }

        private void p2Ready_CheckedChanged(object sender, EventArgs e)//After player2 selects that they're ready this checks if p1 has readied up as well then loads the game form
        {
            if (p1Ready.Checked is true && p2Ready.Checked is true)
            {
                gameForm frm3 = new gameForm();
                frm3.Show();
                this.Hide();
            }
        }

        private void p1Ready_CheckedChanged(object sender, EventArgs e)
        {
            if (p2Ready.Checked is true && p1Ready.Checked is true) 
            { 
            gameForm frm3 = new gameForm();
            frm3.Show();
            this.Hide();
            }
        }
    }
}