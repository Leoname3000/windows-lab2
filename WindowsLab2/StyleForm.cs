using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsLab2
{
    public partial class StyleForm : Form
    {
        public StyleForm()
        {
            InitializeComponent();
        }


        MainForm owner;

        private void StyleForm_Load(object sender, EventArgs e)
        {
            owner = (MainForm)Owner;

            trackBarGradAngle.Minimum = 0;
            trackBarGradAngle.Maximum = 360;

            FormBorderStyle = FormBorderStyle.FixedDialog;
            MinimizeBox = false;
            MaximizeBox = false;
            checkBoxCircle.Checked = owner.showCircle;
            trackBarGradAngle.Enabled = owner.showGradient;
            if (trackBarGradAngle.Enabled == true)
                trackBarGradAngle.Value = (int)owner.gradAngle;            

            buttonAxisColor.BackColor = owner.axisPenColor;
            buttonGridColor.BackColor = owner.linePenColor;
        }


        // Buttons

        private void buttonStyleAxis_Click(object sender, EventArgs e)
        {
            owner.step = 1.0;
            owner.showGrid = false;
            owner.panel.Refresh();
        }

        private void buttonStyleGrid_Click(object sender, EventArgs e)
        {
            owner.step = 1.0;
            owner.showGrid = true;
            owner.panel.Refresh();
        }

        private void buttonStyleTrig_Click(object sender, EventArgs e)
        {
            owner.step = Math.PI / 2;
            owner.showGrid = true;
            owner.panel.Refresh();
        }

        private void buttonStyleColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                owner.backColor = colorDialog.Color;

                owner.showGradient = false;
                trackBarGradAngle.Enabled = false;
                owner.gradAngle = 0;
                trackBarGradAngle.Value = 0;

                owner.showColor = true;
                owner.panel.Refresh();
            }
        }

        private void buttonStyleGradient_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color colorTmp = colorDialog.Color;
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    owner.gradTopColor = colorTmp;
                    owner.gradBottomColor = colorDialog.Color;
                    owner.showColor = false;
                    owner.showGradient = true;
                    trackBarGradAngle.Enabled = true;
                    owner.panel.Refresh();
                }
            }
        }

        private void buttonStyleReset_Click(object sender, EventArgs e)
        {
            owner.axisPenColor = Color.Black;
            buttonAxisColor.BackColor = Color.Black;
            owner.linePenColor = Color.LightGray;
            buttonGridColor.BackColor = Color.LightGray;


            owner.showGrid = true;
            owner.step = 1.0;

            owner.showCircle = true;
            checkBoxCircle.Checked = true;

            owner.showUnits = false;

            owner.showColor = false;

            owner.showGradient = false;
            trackBarGradAngle.Enabled = false;
            owner.gradAngle = 0;
            trackBarGradAngle.Value = 0;

            owner.panel.Refresh();
        }

        private void buttonStyleClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBoxCircle_CheckedChanged(object sender, EventArgs e)
        {
            owner.showCircle = checkBoxCircle.Checked;
            owner.panel.Refresh();
        }

        private void trackBarGradAngle_Scroll(object sender, EventArgs e)
        {
            owner.gradAngle = trackBarGradAngle.Value;
            owner.panel.Refresh();
        }

        private void buttonAxisColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                owner.axisPenColor = colorDialog.Color;
                buttonAxisColor.BackColor = colorDialog.Color;
                owner.panel.Refresh();
            }
        }

        private void buttonGridColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                owner.linePenColor = colorDialog.Color;
                buttonGridColor.BackColor = colorDialog.Color;
                owner.panel.Refresh();
            }
        }
    }
}
