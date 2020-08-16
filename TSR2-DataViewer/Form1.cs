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
using System.Windows.Forms.VisualStyles;

namespace TSR2_DataViewer
{
   
    public partial class Form1 : Form
    {
        string filename;
        int count;
        public Form1()
        {
            InitializeComponent();
            filename ="";
            count = 0;
            Diodes.SetItemChecked(0,true);
            Diodes.SetItemChecked(1, true);
            Diodes.SetItemChecked(2, true);
            Diodes.SetItemChecked(3, true);
            
            
        }

        OpenFileDialog ofd = new OpenFileDialog();
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            int Max_1 = 5000;
            ofd.ShowDialog();
            filename = ofd.FileName;

            BinaryReader br = new BinaryReader(File.OpenRead(filename));
            
            


            float[] vals = new float[Max_1];
            int[] idx_record = new int[Max_1];
            int[] idx_phase = new int[Max_1];
            float[] targetTemp = new float[Max_1];
            float targetT = 0;
            float[] diode1 = new float[Max_1];
            float[] diode2 = new float[Max_1];
            float[] diode3 = new float[Max_1];
            float[] diode5 = new float[Max_1];
            float[] T_calc = new float[Max_1];
            float[] ctrl_out = new float[Max_1];
            float[] aom2 = new float[Max_1];

            int[] transient = new int[1500];
            int[] pulse = new int[200];

            float[] time = new float[Max_1];


            
            br.BaseStream.Position = 0;
            char[] target = new char[5];
            target[0] = br.ReadChar();
            target[1] = br.ReadChar();
            target[2] = br.ReadChar();
            target[3] = br.ReadChar();
            target[4] = br.ReadChar();
            string str = new string(target);

            txtBoxTarget.Text = str;
            targetT = br.ReadSingle();
            txtBoxTargetTemp.Text = targetT.ToString();
            txtBoxCtrl.Text = br.ReadInt32().ToString();
            txtBoxKD.Text = br.ReadDouble().ToString();
            txtBoxKP.Text = br.ReadDouble().ToString();
            txtBoxKI.Text = br.ReadDouble().ToString();
            txtBoxKwx1.Text = br.ReadDouble().ToString();
            txtBoxKwx2.Text = br.ReadDouble().ToString();
            txtBoxKwy.Text = br.ReadDouble().ToString();

            

                        while (br.BaseStream.Position != br.BaseStream.Length)
                        {
                            targetTemp[count] = targetT;

                            idx_record[count] = br.ReadInt32();
                            idx_phase[count] = br.ReadInt32();

                            diode1[count] = br.ReadSingle();

                            diode2[count] = br.ReadSingle();
                            diode3[count] = br.ReadSingle();
                            diode5[count] = br.ReadSingle();

                            T_calc[count] = br.ReadSingle();
                            ctrl_out[count] = br.ReadSingle();
                            aom2[count] = br.ReadSingle();
                            
                            
                
                            for(int i=0;i<1700;i++)
                            {
                                br.ReadInt32();
                            }

                            time[count] = (float)0.333 * count;
                            count++;
                        }
                        br.BaseStream.Position = 0;

                         Array.Resize(ref time, count);

                        Array.Resize(ref targetTemp, count);

                        Array.Resize(ref idx_record, count);
                        Array.Resize(ref idx_phase, count);

                        Array.Resize(ref diode1, count);
                        Array.Resize(ref diode2, count);
                        Array.Resize(ref diode3, count);
                        Array.Resize(ref diode5, count);

                        Array.Resize(ref T_calc, count);
                        Array.Resize(ref ctrl_out, count);
                        Array.Resize(ref ctrl_out, count);

                        Array.Resize(ref aom2, count);
                        br.Close();
            //  chart_Temperature.Series["Temp"].Points.DataBindY(T_calc);
            //  chart_Temperature.Series["Temp"].Points.DataBindY(T_calc);


            chart_Temperature.Series["Temp"].Points.Clear();
            for (int v=0;v<count;v++)
            {
                chart_Temperature.Series["Temp"].Points.AddXY(time[v], T_calc[v]);
                
            }


            foreach (var series in chart_diodes.Series)
            {
                series.Points.Clear();
            }

          
                        chart_Temperature.Series["targetTemp"].Points.DataBindY(targetTemp);
                        chart_diodes.Series["diode1"].Points.DataBindY(diode1);
                        chart_diodes.Series["diode2"].Points.DataBindY(diode2);
                        chart_diodes.Series["diode3"].Points.DataBindY(diode3);
                        chart_diodes.Series["diode5"].Points.DataBindY(diode5);

                        numTransient.Value = 0;
            
            br.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       //this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
        private void numTransient_ValueChanged(Object sender, EventArgs e)
        {
            int[] transient = new int[1500];
            int[] pulse = new int[200];

            BinaryReader br = new BinaryReader(File.OpenRead(filename));

            int head = 5 * sizeof(char) + sizeof(float) + sizeof(int) + (6 * sizeof(double))+2 * sizeof(int) + 7 * sizeof(float);
            int tail =2*sizeof(int)+ 7*sizeof(float)+ 200 * sizeof(int) + 1500 * sizeof(int);
            br.BaseStream.Position = 97+(int)numTransient.Value * tail;
            int sum = 97;// head + tail;
            for (int i = 0; i < 200; i++)
            {
                pulse[i]=br.ReadInt32();
            }

            for (int k = 0; k < 1500;k++)
            {
                transient[k] = br.ReadInt32();
            }
            chartPulse.Series["pulse"].Points.DataBindY(pulse);
            chartTransient.Series["transient"].Points.DataBindY(transient);
            br.Close();

            //MessageBox.Show("You are in the NumericUpDown.ValueChanged event.");
        }

        private void Diodes_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void chartTransient_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (var series in chart_diodes.Series)
            {
                series.Points.Clear();
            }

        }
    }
}
