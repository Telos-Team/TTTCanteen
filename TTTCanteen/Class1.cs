using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Dynamics.Framework.UI.Extensibility;
using Microsoft.Dynamics.Framework.UI.Extensibility.WinForms;

namespace TTTCanteen
{
    // Public key token: 3dbf0004b96e70e3

    [ControlAddInExport("TTTCanteen")]

    public class ContextBindingAddIn : StringControlAddInBase, IStringControlAddInDefinition
    {
        private Panel buttonpanel;
        private Button menubutton01;
        private Button menubutton02;
        private Button menubutton03;
        private Button menubutton04;
        private Button menubutton05;
        private Button menubutton06;
        private Button menubutton07;
        private Button menubutton08;
        private Button menubutton09;
        private Button menubutton10;
        private Button menubutton11;
        private Button menubutton12;

        [ApplicationVisible]
        public event MethodInvoker ControlAddInReady;

        [ApplicationVisible]
        public void SetMenues(
            string m01, 
            string m02, 
            string m03, 
            string m04, 
            string m05, 
            string m06, 
            string m07, 
            string m08, 
            string m09, 
            string m10, 
            string m11, 
            string m12)
        {
            menubutton01.Text = m01;
            menubutton02.Text = m02;
            menubutton03.Text = m03;
            menubutton04.Text = m04;
            menubutton05.Text = m05;
            menubutton06.Text = m06;
            menubutton07.Text = m07;
            menubutton08.Text = m08;
            menubutton09.Text = m09;
            menubutton10.Text = m10;
            menubutton11.Text = m11;
            menubutton12.Text = m12;
        }

        [ApplicationVisible]
        public Color ButtonBackColor
        {
            get { return menubutton01.BackColor; }
            set
            {
                menubutton01.BackColor = value;
                menubutton02.BackColor = value;
                menubutton03.BackColor = value;
                menubutton04.BackColor = value;
                menubutton05.BackColor = value;
                menubutton06.BackColor = value;
                menubutton07.BackColor = value;
                menubutton08.BackColor = value;
                menubutton09.BackColor = value;
                menubutton10.BackColor = value;
                menubutton11.BackColor = value;
                menubutton12.BackColor = value;
            }
        }

        [ApplicationVisible]
        public Color ClickBackColor
        {
            get; set;
        }

        [ApplicationVisible]
        public void SetSpecificButtonBackColor(int buttonNo, Color buttonColor)
        {
            switch (buttonNo)
            {
                case 1 :
                    menubutton01.BackColor = buttonColor;
                    break;
                case 2:
                    menubutton02.BackColor = buttonColor;
                    break;
                case 3:
                    menubutton03.BackColor = buttonColor;
                    break;
                case 4:
                    menubutton04.BackColor = buttonColor;
                    break;
                case 5:
                    menubutton05.BackColor = buttonColor;
                    break;
                case 6:
                    menubutton06.BackColor = buttonColor;
                    break;
                case 7:
                    menubutton07.BackColor = buttonColor;
                    break;
                case 8:
                    menubutton08.BackColor = buttonColor;
                    break;
                case 9:
                    menubutton09.BackColor = buttonColor;
                    break;
                case 10:
                    menubutton10.BackColor = buttonColor;
                    break;
                case 11:
                    menubutton11.BackColor = buttonColor;
                    break;
                case 12:
                    menubutton12.BackColor = buttonColor;
                    break;
                default:
                    break;
            }
        }

        [ApplicationVisible]
        public Color ButtonForeColor
        {
            get { return menubutton01.ForeColor; }
            set
            {
                menubutton01.ForeColor = value;
                menubutton02.ForeColor = value;
                menubutton03.ForeColor = value;
                menubutton04.ForeColor = value;
                menubutton05.ForeColor = value;
                menubutton06.ForeColor = value;
                menubutton07.ForeColor = value;
                menubutton08.ForeColor = value;
                menubutton09.ForeColor = value;
                menubutton10.ForeColor = value;
                menubutton11.ForeColor = value;
                menubutton12.ForeColor = value;
            }
        }

        [ApplicationVisible]
        public void EnableAllButtons()
        {
            menubutton01.Enabled = true;
            menubutton02.Enabled = true;
            menubutton03.Enabled = true;
            menubutton04.Enabled = true;
            menubutton05.Enabled = true;
            menubutton06.Enabled = true;
            menubutton07.Enabled = true;
            menubutton08.Enabled = true;
            menubutton09.Enabled = true;
            menubutton10.Enabled = true;
            menubutton11.Enabled = true;
            menubutton12.Enabled = true;
        }

        [ApplicationVisible]
        public void DisableAllButtons()
        {
            menubutton01.Enabled = false;
            menubutton02.Enabled = false;
            menubutton03.Enabled = false;
            menubutton04.Enabled = false;
            menubutton05.Enabled = false;
            menubutton06.Enabled = false;
            menubutton07.Enabled = false;
            menubutton08.Enabled = false;
            menubutton09.Enabled = false;
            menubutton10.Enabled = false;
            menubutton11.Enabled = false;
            menubutton12.Enabled = false;
        }

        [ApplicationVisible]
        public void SetSpecificButtonEnabled(int buttonNo, bool enabled)
        {
            switch (buttonNo)
            {
                case 1:
                    menubutton01.Enabled = enabled;
                    break;
                case 2:
                    menubutton02.Enabled = enabled;
                    break;
                case 3:
                    menubutton03.Enabled = enabled;
                    break;
                case 4:
                    menubutton04.Enabled = enabled;
                    break;
                case 5:
                    menubutton05.Enabled = enabled;
                    break;
                case 6:
                    menubutton06.Enabled = enabled;
                    break;
                case 7:
                    menubutton07.Enabled = enabled;
                    break;
                case 8:
                    menubutton08.Enabled = enabled;
                    break;
                case 9:
                    menubutton09.Enabled = enabled;
                    break;
                case 10:
                    menubutton10.Enabled = enabled;
                    break;
                case 11:
                    menubutton11.Enabled = enabled;
                    break;
                case 12:
                    menubutton12.Enabled = enabled;
                    break;
                default:
                    break;
            }
        }

        [ApplicationVisible]
        public void SetSpecificButtonVisible(int buttonNo, bool visible)
        {
            switch (buttonNo)
            {
                case 1:
                    menubutton01.Visible = visible;
                    break;
                case 2:
                    menubutton02.Visible = visible;
                    break;
                case 3:
                    menubutton03.Visible = visible;
                    break;
                case 4:
                    menubutton04.Visible = visible;
                    break;
                case 5:
                    menubutton05.Visible = visible;
                    break;
                case 6:
                    menubutton06.Visible = visible;
                    break;
                case 7:
                    menubutton07.Visible = visible;
                    break;
                case 8:
                    menubutton08.Visible = visible;
                    break;
                case 9:
                    menubutton09.Visible = visible;
                    break;
                case 10:
                    menubutton10.Visible = visible;
                    break;
                case 11:
                    menubutton11.Visible = visible;
                    break;
                case 12:
                    menubutton12.Visible = visible;
                    break;
                default:
                    break;
            }
        }

        [ApplicationVisible]
        public void SetSpecificButtonForeColor(int buttonNo, Color buttonColor)
        {
            switch (buttonNo)
            {
                case 1:
                    menubutton01.ForeColor = buttonColor;
                    break;
                case 2:
                    menubutton02.ForeColor = buttonColor;
                    break;
                case 3:
                    menubutton03.ForeColor = buttonColor;
                    break;
                case 4:
                    menubutton04.ForeColor = buttonColor;
                    break;
                case 5:
                    menubutton05.ForeColor = buttonColor;
                    break;
                case 6:
                    menubutton06.ForeColor = buttonColor;
                    break;
                case 7:
                    menubutton07.ForeColor = buttonColor;
                    break;
                case 8:
                    menubutton08.ForeColor = buttonColor;
                    break;
                case 9:
                    menubutton09.ForeColor = buttonColor;
                    break;
                case 10:
                    menubutton10.ForeColor = buttonColor;
                    break;
                case 11:
                    menubutton11.ForeColor = buttonColor;
                    break;
                case 12:
                    menubutton12.ForeColor = buttonColor;
                    break;
                default:
                    break;
            }
        }

        [ApplicationVisible]
        public bool VisibleControl
        {
            get { return buttonpanel.Visible; }
            set { buttonpanel.Visible = value; }
        }

        protected override Control CreateControl()
        {
            Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea;
            int screenWidth = workingRectangle.Width;
            int screenHeight = workingRectangle.Height;
            int buttonWidth = ((screenWidth - 200) / 4);
            int buttonHeight = ((screenHeight - 400) / 3);
            float fontSize = 14.0F * (screenHeight / 480);

            menubutton01 = new Button();
            menubutton01.Location = new Point(0, 0);
            menubutton01.Name = "MenuButton01";
            menubutton01.Size = new Size(buttonWidth, buttonHeight);
            menubutton01.TabIndex = 0;
            menubutton01.Text = "Menu nr. 01";
            menubutton01.TextAlign = ContentAlignment.MiddleCenter;
            menubutton01.UseVisualStyleBackColor = false;
            menubutton01.Font = new Font(FontFamily.GenericSansSerif, fontSize, FontStyle.Bold);
            menubutton01.Click += new System.EventHandler(menubutton01_Click);

            menubutton02 = new Button();
            menubutton02.Location = new Point(buttonWidth + 10, 0);
            menubutton02.Name = "MenuButton02";
            menubutton02.Size = new Size(buttonWidth, buttonHeight);
            menubutton02.TabIndex = 0;
            menubutton02.Text = "Menu nr. 02";
            menubutton02.TextAlign = ContentAlignment.MiddleCenter;
            menubutton02.UseVisualStyleBackColor = false;
            menubutton02.Font = new Font(FontFamily.GenericSansSerif, fontSize, FontStyle.Bold);
            menubutton02.Click += new System.EventHandler(menubutton02_Click);

            menubutton03 = new Button();
            menubutton03.Location = new Point(2 * (buttonWidth + 10), 0);
            menubutton03.Name = "MenuButton03";
            menubutton03.Size = new Size(buttonWidth, buttonHeight);
            menubutton03.TabIndex = 0;
            menubutton03.Text = "Menu nr. 03";
            menubutton03.TextAlign = ContentAlignment.MiddleCenter;
            menubutton03.UseVisualStyleBackColor = false;
            menubutton03.Font = new Font(FontFamily.GenericSansSerif, fontSize, FontStyle.Bold);
            menubutton03.Click += new System.EventHandler(menubutton03_Click);

            menubutton04 = new Button();
            menubutton04.Location = new Point(3 * (buttonWidth + 10), 0);
            menubutton04.Name = "MenuButton04";
            menubutton04.Size = new Size(buttonWidth, buttonHeight);
            menubutton04.TabIndex = 0;
            menubutton04.Text = "Menu nr. 04";
            menubutton04.TextAlign = ContentAlignment.MiddleCenter;
            menubutton04.UseVisualStyleBackColor = false;
            menubutton04.Font = new Font(FontFamily.GenericSansSerif, fontSize, FontStyle.Bold);
            menubutton04.Click += new System.EventHandler(menubutton04_Click);

            menubutton05 = new Button();
            menubutton05.Location = new Point(0, buttonHeight + 10);
            menubutton05.Name = "MenuButton05";
            menubutton05.Size = new Size(buttonWidth, buttonHeight);
            menubutton05.TabIndex = 0;
            menubutton05.Text = "Menu nr. 05";
            menubutton05.TextAlign = ContentAlignment.MiddleCenter;
            menubutton05.UseVisualStyleBackColor = false;
            menubutton05.Font = new Font(FontFamily.GenericSansSerif, fontSize, FontStyle.Bold);
            menubutton05.Click += new System.EventHandler(menubutton05_Click);

            menubutton06 = new Button();
            menubutton06.Location = new Point(buttonWidth + 10, buttonHeight + 10);
            menubutton06.Name = "MenuButton06";
            menubutton06.Size = new Size(buttonWidth, buttonHeight);
            menubutton06.TabIndex = 0;
            menubutton06.Text = "Menu nr. 06";
            menubutton06.TextAlign = ContentAlignment.MiddleCenter;
            menubutton06.UseVisualStyleBackColor = false;
            menubutton06.Font = new Font(FontFamily.GenericSansSerif, fontSize, FontStyle.Bold);
            menubutton06.Click += new System.EventHandler(menubutton06_Click);

            menubutton07 = new Button();
            menubutton07.Location = new Point(2 * (buttonWidth + 10), buttonHeight + 10);
            menubutton07.Name = "MenuButton07";
            menubutton07.Size = new Size(buttonWidth, buttonHeight);
            menubutton07.TabIndex = 0;
            menubutton07.Text = "Menu nr. 07";
            menubutton07.TextAlign = ContentAlignment.MiddleCenter;
            menubutton07.UseVisualStyleBackColor = false;
            menubutton07.Font = new Font(FontFamily.GenericSansSerif, fontSize, FontStyle.Bold);
            menubutton07.Click += new System.EventHandler(menubutton07_Click);

            menubutton08 = new Button();
            menubutton08.Location = new Point(3 * (buttonWidth + 10), buttonHeight + 10);
            menubutton08.Name = "MenuButton08";
            menubutton08.Size = new Size(buttonWidth, buttonHeight);
            menubutton08.TabIndex = 0;
            menubutton08.Text = "Menu nr. 08";
            menubutton08.TextAlign = ContentAlignment.MiddleCenter;
            menubutton08.UseVisualStyleBackColor = false;
            menubutton08.Font = new Font(FontFamily.GenericSansSerif, fontSize, FontStyle.Bold);
            menubutton08.Click += new System.EventHandler(menubutton08_Click);

            menubutton09 = new Button();
            menubutton09.Location = new Point(0, 2 * (buttonHeight + 10));
            menubutton09.Name = "MenuButton09";
            menubutton09.Size = new Size(buttonWidth, buttonHeight);
            menubutton09.TabIndex = 0;
            menubutton09.Text = "Menu nr. 09";
            menubutton09.TextAlign = ContentAlignment.MiddleCenter;
            menubutton09.UseVisualStyleBackColor = false;
            menubutton09.Font = new Font(FontFamily.GenericSansSerif, fontSize, FontStyle.Bold);
            menubutton09.Click += new System.EventHandler(menubutton09_Click);

            menubutton10 = new Button();
            menubutton10.Location = new Point(buttonWidth + 10, 2 * (buttonHeight + 10));
            menubutton10.Name = "MenuButton10";
            menubutton10.Size = new Size(buttonWidth, buttonHeight);
            menubutton10.TabIndex = 0;
            menubutton10.Text = "Menu nr. 10";
            menubutton10.TextAlign = ContentAlignment.MiddleCenter;
            menubutton10.UseVisualStyleBackColor = false;
            menubutton10.Font = new Font(FontFamily.GenericSansSerif, fontSize, FontStyle.Bold);
            menubutton10.Click += new System.EventHandler(menubutton10_Click);

            menubutton11 = new Button();
            menubutton11.Location = new Point(2 * (buttonWidth + 10), 2 * (buttonHeight + 10));
            menubutton11.Name = "MenuButton11";
            menubutton11.Size = new Size(buttonWidth, buttonHeight);
            menubutton11.TabIndex = 0;
            menubutton11.Text = "Menu nr. 11";
            menubutton11.TextAlign = ContentAlignment.MiddleCenter;
            menubutton11.UseVisualStyleBackColor = false;
            menubutton11.Font = new Font(FontFamily.GenericSansSerif, fontSize, FontStyle.Bold);
            menubutton11.Click += new System.EventHandler(menubutton11_Click);

            menubutton12 = new Button();
            menubutton12.Location = new Point(3 * (buttonWidth + 10), 2 * (buttonHeight + 10));
            menubutton12.Name = "MenuButton12";
            menubutton12.Size = new Size(buttonWidth, buttonHeight);
            menubutton12.TabIndex = 0;
            menubutton12.Text = "Menu nr. 12";
            menubutton12.TextAlign = ContentAlignment.MiddleCenter;
            menubutton12.UseVisualStyleBackColor = false;
            menubutton12.Font = new Font(FontFamily.GenericSansSerif, fontSize, FontStyle.Bold);
            menubutton12.Click += new System.EventHandler(menubutton12_Click);

            ClickBackColor = menubutton01.BackColor;

            buttonpanel = new Panel();
            buttonpanel.Controls.Add(menubutton01);
            buttonpanel.Controls.Add(menubutton02);
            buttonpanel.Controls.Add(menubutton03);
            buttonpanel.Controls.Add(menubutton04);
            buttonpanel.Controls.Add(menubutton05);
            buttonpanel.Controls.Add(menubutton06);
            buttonpanel.Controls.Add(menubutton07);
            buttonpanel.Controls.Add(menubutton08);
            buttonpanel.Controls.Add(menubutton09);
            buttonpanel.Controls.Add(menubutton10);
            buttonpanel.Controls.Add(menubutton11);
            buttonpanel.Controls.Add(menubutton12);
            buttonpanel.Location = new Point(0, 0);
            buttonpanel.Name = "GroupBox1";
            buttonpanel.Padding = new Padding(4, 4, 4, 4);
            buttonpanel.Size = new Size(4 * (buttonWidth + 10), 3 * (buttonHeight + 10));
            buttonpanel.TabIndex = 0;
            buttonpanel.Text = "Buttons";

            buttonpanel.HandleCreated += (sender, args) =>
            {
                if (ControlAddInReady != null)
                {
                    ControlAddInReady();
                }
            };

            return buttonpanel;
        }

        void menubutton01_Click(object sender, System.EventArgs e)
        {
            menubutton01.BackColor = ClickBackColor;
            menubutton01.Enabled = false;

            this.RaiseControlAddInEvent(1, "01");
        }

        void menubutton02_Click(object sender, System.EventArgs e)
        {
            menubutton02.BackColor = ClickBackColor;
            menubutton02.Enabled = false;

            this.RaiseControlAddInEvent(1, "02");
        }

        void menubutton03_Click(object sender, System.EventArgs e)
        {
            menubutton03.BackColor = ClickBackColor;
            menubutton03.Enabled = false;

            this.RaiseControlAddInEvent(1, "03");
        }

        void menubutton04_Click(object sender, System.EventArgs e)
        {
            menubutton04.BackColor = ClickBackColor;
            menubutton04.Enabled = false;

            this.RaiseControlAddInEvent(1, "04");
        }

        void menubutton05_Click(object sender, System.EventArgs e)
        {
            menubutton05.BackColor = ClickBackColor;
            menubutton05.Enabled = false;

            this.RaiseControlAddInEvent(1, "05");
        }

        void menubutton06_Click(object sender, System.EventArgs e)
        {
            menubutton06.BackColor = ClickBackColor;
            menubutton06.Enabled = false;

            this.RaiseControlAddInEvent(1, "06");
        }

        void menubutton07_Click(object sender, System.EventArgs e)
        {
            menubutton07.BackColor = ClickBackColor;
            menubutton07.Enabled = false;

            this.RaiseControlAddInEvent(1, "07");
        }

        void menubutton08_Click(object sender, System.EventArgs e)
        {
            menubutton08.BackColor = ClickBackColor;
            menubutton08.Enabled = false;

            this.RaiseControlAddInEvent(1, "08");
        }

        void menubutton09_Click(object sender, System.EventArgs e)
        {
            menubutton09.BackColor = ClickBackColor;
            menubutton09.Enabled = false;

            this.RaiseControlAddInEvent(1, "09");
        }

        void menubutton10_Click(object sender, System.EventArgs e)
        {
            menubutton10.BackColor = ClickBackColor;
            menubutton10.Enabled = false;

            this.RaiseControlAddInEvent(1, "10");
        }

        void menubutton11_Click(object sender, System.EventArgs e)
        {
            menubutton11.BackColor = ClickBackColor;
            menubutton11.Enabled = false;

            this.RaiseControlAddInEvent(1, "11");
        }

        void menubutton12_Click(object sender, System.EventArgs e)
        {
            menubutton12.BackColor = ClickBackColor;
            menubutton12.Enabled = false;

            this.RaiseControlAddInEvent(1, "12");
        }

        protected override void OnStyleChanged(Style style)
        {
            base.OnStyleChanged(style);
            switch (style)
            {
                case Style.Attention:
                    this.Control.BackColor = Color.Red;
                    this.Control.ForeColor = Color.Black;
                    break;
                case Style.Favorable:
                    this.Control.BackColor = Color.GreenYellow;
                    this.Control.ForeColor = Color.Black;
                    break;
                case Style.None:
                    this.Control.BackColor = SystemColors.Window;
                    this.Control.ForeColor = SystemColors.WindowText;
                    break;
                case Style.Strong:
                    this.Control.BackColor = Color.Blue;
                    this.Control.ForeColor = Color.White;
                    break;
            }
        }

        public override bool AllowCaptionControl
        {
            get
            {
                return false;
            }
        }
    }
}
