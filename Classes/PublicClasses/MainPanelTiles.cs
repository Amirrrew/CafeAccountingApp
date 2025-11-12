using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace CafeApplication.Classes.PublicClasses
{
    internal class MainPanelTiles
    {

        public void ExpandMainPanel(Panel MainPanel,RadButton btn)
        {
            MainForm mf = new MainForm();
            string openPath = Application.StartupPath + @"/Assets/Icons/chevron-left (2).png";
            string closePath = Application.StartupPath + @"/Assets/Icons/Public/chevron-right (2).png";

            if (MainPanel.Width < 700)
            {
                MainPanel.Size = new Size(742, 729);
                btn.Image = Image.FromFile(closePath);
            }
            else
            {
                MainPanel.Size = new Size(368, 729);
                btn.Image = Image.FromFile(openPath);
            }
        }




        public void PrepareLabel(Panel MainPanel , RadButton btn,int lblCount, Action LblFunc)
        {
            MainForm mf = new MainForm();
            ExpandMainPanel(MainPanel ,btn);
            LblCount(lblCount);
        }

        public void LblCount(int lblCount)
        {
            MainForm mf = new MainForm();
            if (lblCount == 1)
            {
                mf.lbl_Option1.Visible = false;
            }
                //case 1:
                    //mf.lbl_Option1.Visible = false;
                    //    mf.lbl_Option2.Visible = false;
                    //    mf.lbl_Option3.Visible = false;
                    //    mf.lbl_Option4.Visible = false;
                    //    mf.lbl_Option5.Visible = false;
                    //    mf.lbl_Option6.Visible = false;
                    //    mf.lbl_Option7.Visible = false;
                    //    mf.lbl_Option8.Visible = false;
                    //    mf.lbl_Option9.Visible = false;
                    //    mf.lbl_Option10.Visible = false;
                    //    mf.lbl_Option11.Visible = false;
                    //    mf.lbl_Option12.Visible = false;
                    //    mf.lbl_Option13.Visible = false;
                    //    mf.lbl_Option14.Visible = false;
                    //break;

                    //case 2:
                    //    mf.lbl_Option1.Visible = true;
                    //    mf.lbl_Option1.Visible = true;
                    //    mf.lbl_Option2.Visible = false;
                    //    mf.lbl_Option3.Visible = false;
                    //    mf.lbl_Option4.Visible = false;
                    //    mf.lbl_Option5.Visible = false;
                    //    mf.lbl_Option6.Visible = false;
                    //    mf.lbl_Option7.Visible = false;
                    //    mf.lbl_Option8.Visible = false;
                    //    mf.lbl_Option9.Visible = false;
                    //    mf.lbl_Option10.Visible = false;
                    //    mf.lbl_Option11.Visible = false;
                    //    mf.lbl_Option12.Visible = false;
                    //    mf.lbl_Option13.Visible = false;
                    //    mf.lbl_Option14.Visible = false;
                    //    break;

                    //case 3:
                    //    mf.lbl_Option1.Visible = true;
                    //    mf.lbl_Option2.Visible = true;
                    //    mf.lbl_Option3.Visible = true;
                    //    mf.lbl_Option4.Visible = false;
                    //    mf.lbl_Option5.Visible = false;
                    //    mf.lbl_Option6.Visible = false;
                    //    mf.lbl_Option7.Visible = false;
                    //    mf.lbl_Option8.Visible = false;
                    //    mf.lbl_Option9.Visible = false;
                    //    mf.lbl_Option10.Visible = false;
                    //    mf.lbl_Option11.Visible = false;
                    //    mf.lbl_Option12.Visible = false;
                    //    mf.lbl_Option13.Visible = false;
                    //    mf.lbl_Option14.Visible = false;
                    //    break;

                    //case 4:
                    //    mf.lbl_Option1.Visible = true;
                    //    mf.lbl_Option2.Visible = true;
                    //    mf.lbl_Option3.Visible = true;
                    //    mf.lbl_Option4.Visible = true;
                    //    mf.lbl_Option5.Visible = false;
                    //    mf.lbl_Option6.Visible = false;
                    //    mf.lbl_Option7.Visible = false;
                    //    mf.lbl_Option8.Visible = false;
                    //    mf.lbl_Option9.Visible = false;
                    //    mf.lbl_Option10.Visible = false;
                    //    mf.lbl_Option11.Visible = false;
                    //    mf.lbl_Option12.Visible = false;
                    //    mf.lbl_Option13.Visible = false;
                    //    mf.lbl_Option14.Visible = false;
                    //    break;

                    //case 5:
                    //    mf.lbl_Option1.Visible = true;
                    //    mf.lbl_Option2.Visible = true;
                    //    mf.lbl_Option3.Visible = true;
                    //    mf.lbl_Option4.Visible = true;
                    //    mf.lbl_Option5.Visible = true;
                    //    mf.lbl_Option6.Visible = false;
                    //    mf.lbl_Option7.Visible = false;
                    //    mf.lbl_Option8.Visible = false;
                    //    mf.lbl_Option9.Visible = false;
                    //    mf.lbl_Option10.Visible = false;
                    //    mf.lbl_Option11.Visible = false;
                    //    mf.lbl_Option12.Visible = false;
                    //    mf.lbl_Option13.Visible = false;
                    //    mf.lbl_Option14.Visible = false;
                    //    break;

                    //case 6:
                    //    mf.lbl_Option1.Visible = true;
                    //    mf.lbl_Option2.Visible = true;
                    //    mf.lbl_Option3.Visible = true;
                    //    mf.lbl_Option4.Visible = true;
                    //    mf.lbl_Option5.Visible = true;
                    //    mf.lbl_Option6.Visible = true;
                    //    mf.lbl_Option7.Visible = false;
                    //    mf.lbl_Option8.Visible = false;
                    //    mf.lbl_Option9.Visible = false;
                    //    mf.lbl_Option10.Visible = false;
                    //    mf.lbl_Option11.Visible = false;
                    //    mf.lbl_Option12.Visible = false;
                    //    mf.lbl_Option13.Visible = false;
                    //    mf.lbl_Option14.Visible = false;
                    //    break;

                    //case 7:
                    //    mf.lbl_Option1.Visible = true;
                    //    mf.lbl_Option2.Visible = true;
                    //    mf.lbl_Option3.Visible = true;
                    //    mf.lbl_Option4.Visible = true;
                    //    mf.lbl_Option5.Visible = true;
                    //    mf.lbl_Option6.Visible = true;
                    //    mf.lbl_Option7.Visible = true;
                    //    mf.lbl_Option8.Visible = false;
                    //    mf.lbl_Option9.Visible = false;
                    //    mf.lbl_Option10.Visible = false;
                    //    mf.lbl_Option11.Visible = false;
                    //    mf.lbl_Option12.Visible = false;
                    //    mf.lbl_Option13.Visible = false;
                    //    mf.lbl_Option14.Visible = false;
                    //    break;

                    //case 8:
                    //    mf.lbl_Option1.Visible = true;
                    //    mf.lbl_Option2.Visible = true;
                    //    mf.lbl_Option3.Visible = true;
                    //    mf.lbl_Option4.Visible = true;
                    //    mf.lbl_Option5.Visible = true;
                    //    mf.lbl_Option6.Visible = true;
                    //    mf.lbl_Option7.Visible = true;
                    //    mf.lbl_Option8.Visible = true;
                    //    mf.lbl_Option9.Visible = false;
                    //    mf.lbl_Option10.Visible = false;
                    //    mf.lbl_Option11.Visible = false;
                    //    mf.lbl_Option12.Visible = false;
                    //    mf.lbl_Option13.Visible = false;
                    //    mf.lbl_Option14.Visible = false;
                    //    break;

                    //case 9:
                    //    mf.lbl_Option1.Visible = true;
                    //    mf.lbl_Option2.Visible = true;
                    //    mf.lbl_Option3.Visible = true;
                    //    mf.lbl_Option4.Visible = true;
                    //    mf.lbl_Option5.Visible = true;
                    //    mf.lbl_Option6.Visible = true;
                    //    mf.lbl_Option7.Visible = true;
                    //    mf.lbl_Option8.Visible = true;
                    //    mf.lbl_Option9.Visible = true;
                    //    mf.lbl_Option10.Visible = false;
                    //    mf.lbl_Option11.Visible = false;
                    //    mf.lbl_Option12.Visible = false;
                    //    mf.lbl_Option13.Visible = false;
                    //    mf.lbl_Option14.Visible = false;
                    //    break;

                    //case 10:
                    //    mf.lbl_Option1.Visible = true;
                    //    mf.lbl_Option2.Visible = true;
                    //    mf.lbl_Option3.Visible = true;
                    //    mf.lbl_Option4.Visible = true;
                    //    mf.lbl_Option5.Visible = true;
                    //    mf.lbl_Option6.Visible = true;
                    //    mf.lbl_Option7.Visible = true;
                    //    mf.lbl_Option8.Visible = true;
                    //    mf.lbl_Option9.Visible = true;
                    //    mf.lbl_Option10.Visible = true;
                    //    mf.lbl_Option11.Visible = false;
                    //    mf.lbl_Option12.Visible = false;
                    //    mf.lbl_Option13.Visible = false;
                    //    mf.lbl_Option14.Visible = false;
                    //    break;

                    //case 11:
                    //    mf.lbl_Option1.Visible = true;
                    //    mf.lbl_Option2.Visible = true;
                    //    mf.lbl_Option3.Visible = true;
                    //    mf.lbl_Option4.Visible = true;
                    //    mf.lbl_Option5.Visible = true;
                    //    mf.lbl_Option6.Visible = true;
                    //    mf.lbl_Option7.Visible = true;
                    //    mf.lbl_Option8.Visible = true;
                    //    mf.lbl_Option9.Visible = true;
                    //    mf.lbl_Option10.Visible = true;
                    //    mf.lbl_Option11.Visible = true;
                    //    mf.lbl_Option12.Visible = false;
                    //    mf.lbl_Option13.Visible = false;
                    //    mf.lbl_Option14.Visible = false;
                    //    break;

                    //case 12:
                    //    mf.lbl_Option1.Visible = true;
                    //    mf.lbl_Option2.Visible = true;
                    //    mf.lbl_Option3.Visible = true;
                    //    mf.lbl_Option4.Visible = true;
                    //    mf.lbl_Option5.Visible = true;
                    //    mf.lbl_Option6.Visible = true;
                    //    mf.lbl_Option7.Visible = true;
                    //    mf.lbl_Option8.Visible = true;
                    //    mf.lbl_Option9.Visible = true;
                    //    mf.lbl_Option10.Visible = true;
                    //    mf.lbl_Option11.Visible = true;
                    //    mf.lbl_Option12.Visible = true;
                    //    mf.lbl_Option13.Visible = false;
                    //    mf.lbl_Option14.Visible = false;
                    //    break;

                    //case 13:
                    //    mf.lbl_Option1.Visible = true;
                    //    mf.lbl_Option2.Visible = true;
                    //    mf.lbl_Option3.Visible = true;
                    //    mf.lbl_Option4.Visible = true;
                    //    mf.lbl_Option5.Visible = true;
                    //    mf.lbl_Option6.Visible = true;
                    //    mf.lbl_Option7.Visible = true;
                    //    mf.lbl_Option8.Visible = true;
                    //    mf.lbl_Option9.Visible = true;
                    //    mf.lbl_Option10.Visible = true;
                    //    mf.lbl_Option11.Visible = true;
                    //    mf.lbl_Option12.Visible = true;
                    //    mf.lbl_Option13.Visible = true;
                    //    mf.lbl_Option14.Visible = false;
                    //    break;

                    //case 14:
                    //    mf.lbl_Option1.Visible = true;
                    //    mf.lbl_Option2.Visible = true;
                    //    mf.lbl_Option3.Visible = true;
                    //    mf.lbl_Option4.Visible = true;
                    //    mf.lbl_Option5.Visible = true;
                    //    mf.lbl_Option6.Visible = true;
                    //    mf.lbl_Option7.Visible = true;
                    //    mf.lbl_Option8.Visible = true;
                    //    mf.lbl_Option9.Visible = true;
                    //    mf.lbl_Option10.Visible = true;
                    //    mf.lbl_Option11.Visible = true;
                    //    mf.lbl_Option12.Visible = true;
                    //    mf.lbl_Option13.Visible = true;
                    //    mf.lbl_Option14.Visible = true;
                    //    break;
            
        }
    }
}
