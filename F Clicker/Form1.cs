using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F_Clicker
{
    public partial class Form1 : Form
    {
        static string ver = "1.0.0";
        string[] master = new string[13];
        double Fs = 0;
        double Fpc = 1;
        double Fps = 0;
        double mousefneed = 5;
        static int upgradenum = 3;
        string fcename = "New";
        string saveloc;
        int mousegetted = 0;
        int fonatorgetted = 0;
        double fonatorfneed = 90;
        int manufabrigetted = 1;
        double manufabrifneed = 50;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Fs += Fpc;
        }

        private void repaet_Tick(object sender, EventArgs e)
        {
            label1.Text = "F's:" + Fs;
            if (checkBox1.Checked)
            {
                upgrades.Show();
            }
            else
            {
                upgrades.Hide();
            }
            string[] fneeds = new string[1] { "Mouse" };
            File.WriteAllLines(@".\fneeds.mem", fneeds);
        }

        private void upgrades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (upgrades.Columns[e.ColumnIndex].Name == "Mouse")
            {
                if(Fs > mousefneed)
                {
                    Fpc += 1;
                    mousefneed *= 1.5;
                    Fs -= mousefneed;
                    mousegetted++;
                }
                else
                {
                    MessageBox.Show("You Need" + " (" + (mousefneed - Fs) + ") " + "More F's");
                    if(MessageBox.Show("Do you want to Go to Shop?", "Shop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        MessageBox.Show("Going to shop...", "Shop");
                    }
                }
            }
            if (upgrades.Columns[e.ColumnIndex].Name == "Fonator")
            {
                if (Fs > fonatorfneed)
                {
                    Fps += 1;
                    fonatorfneed *= 1.5;
                    Fs -= fonatorfneed;
                    fonatorgetted++;
                }
                else
                {
                    MessageBox.Show("You Need" + " (" + (fonatorfneed - Fs) + ") " + "More F's");
                    if (MessageBox.Show("Do you want to Go to Shop?", "Shop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        MessageBox.Show("Going to shop...", "Shop");
                    }
                }
            }
            if (upgrades.Columns[e.ColumnIndex].Name == "ManualFabricator")
            {
                if (Fs > manufabrifneed)
                {
                    Fpc += 10;
                    manufabrifneed *= 1.5;
                    Fs -= manufabrifneed;
                    manufabrigetted++;
                }
                else
                {
                    MessageBox.Show("You Need" + " (" + (manufabrifneed - Fs) + ") " + "More F's");
                    if (MessageBox.Show("Do you want to Go to Shop?", "Shop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        MessageBox.Show("Going to shop...", "Shop");
                    }
                }
            }
        }

        private void needswrite_Tick(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                master[0] = fcename;
                master[1] = Convert.ToString(Fs);
                master[2] = Convert.ToString(Fpc);
                master[3] = Convert.ToString(mousefneed);
                master[4] = Convert.ToString(ver);
                master[5] = Convert.ToString(upgradenum);
                master[6] = "Time Played";
                master[7] = Convert.ToString(mousegetted);
                master[8] = Convert.ToString(Fps);
                master[9] = Convert.ToString(fonatorfneed);
                master[10] = Convert.ToString(fonatorgetted);
                master[11] = Convert.ToString(manufabrifneed);
                master[12] = Convert.ToString(manufabrigetted);
                saveFileDialog1.Filter = "F clicker save files (*.fcsave) | *.fcsave";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllLines(saveFileDialog1.FileName, master);
                    saveloc = saveFileDialog1.FileName;
                }
            }
            catch (Exception ex)
            {
                File.WriteAllText(@".\error.error",Convert.ToString(ex));
                MessageBox.Show("Error");
            }
            finally
            {

            }
        }

        private void autoSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                master[0] = fcename;
                master[1] = Convert.ToString(Fs);
                master[2] = Convert.ToString(Fpc);
                master[3] = Convert.ToString(mousefneed);
                master[4] = Convert.ToString(ver);
                master[5] = Convert.ToString(upgradenum);
                master[6] = "Time Played";
                master[7] = Convert.ToString(mousegetted);
                master[8] = Convert.ToString(Fps);
                master[9] = Convert.ToString(fonatorfneed);
                master[10] = Convert.ToString(fonatorgetted);
                master[11] = Convert.ToString(manufabrifneed);
                master[12] = Convert.ToString(manufabrigetted);
                if (string.IsNullOrEmpty(saveloc))
                {
                    MessageBox.Show("You need to save first");
                }
                else
                {
                    File.WriteAllLines(saveloc, master);
                }
            }
            catch(Exception ex)
            {
                File.WriteAllText(@".\error.error", Convert.ToString(ex));
                MessageBox.Show("Error");
            }
            finally
            {

            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "F clicker save files (*.fcsave) | *.fcsave";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    master = File.ReadAllLines(openFileDialog1.FileName);
                    Fs = Convert.ToDouble(master[1]);
                    Fpc = Convert.ToDouble(master[2]);
                    mousefneed = Convert.ToDouble(master[3]);
                    mousegetted = Convert.ToInt32(master[7]);
                    Fps = Convert.ToDouble(master[8]);
                    fonatorfneed = Convert.ToDouble(master[9]);
                    fonatorgetted = Convert.ToInt32(master[10]);
                    manufabrifneed = Convert.ToDouble(master[11]);
                    manufabrigetted = Convert.ToInt32(master[12]);
                }
            }
            catch(Exception ex)
            {
                File.WriteAllText(@".\error.error", Convert.ToString(ex));
                MessageBox.Show("Error");
            }
            finally
            {
                
            }
        }

        private void masterwriter_Tick(object sender, EventArgs e)
        {
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void psticker_Tick(object sender, EventArgs e)
        {
            Fs += Fps;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.Delete(@".\fneeds.mem");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
