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
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;

namespace TSR2_DataViewer
{
   
    public partial class Form1 : Form
    {
        string filename;
        string filename_exp;
        int count;
        public Form1()
        {
            InitializeComponent();
            filename ="";
            filename_exp = "";
            count = 0;
            Diodes.SetItemChecked(0,true);
            Diodes.SetItemChecked(1, true);
            Diodes.SetItemChecked(2, true);
            Diodes.SetItemChecked(3, true);
            
            
        }

        OpenFileDialog ofd = new OpenFileDialog();
        OpenFileDialog ofd_exp = new OpenFileDialog();

        //init target arrays

        int[] idx_record = new int[1000];
        int[] idx_phase = new int[1000];
        double[] targetTemp = new double[1000];

        double T_max = 0;
        double T_zero = 0;
        double T_ref = 0;


        int pulsesTotal = 0;
        string strTarget;
        float[] diode1 = new float[1000];
        float[] diode2 = new float[1000];
        float[] diode3 = new float[1000];
        float[] diode5 = new float[1000];
        float[] T_calc = new float[1000];
        float[] ctrl_out = new float[1000];
        float[] aom2 = new float[1000];

        int[,] transient = new int[1000,5000];
        int[,] pulse = new int[1000,5000];

        float[] timestamp = new float[1000];

        //arrays for displaying transients and pulses
        int[] transient_disp = new int[4000];
        int[] pulse_disp = new int[400];




        private void btnOpenFile_Click(object sender, EventArgs e)
        {
           
            
            ofd.ShowDialog();
            filename = ofd.FileName;

            BinaryReader br = new BinaryReader(File.OpenRead(filename));

            txtBxFilename.Text = filename;

            // Target 
           
            int n = 0;
            char[] target = new char[20];
            target[n] = br.ReadChar();
            
            while (target[n]!='E') 
            {
                n++;
                target[n] = br.ReadChar();   
            } 

            strTarget = new string(target);
            txtBoxTarget.Text = strTarget;

            // number of pulses total
            pulsesTotal = br.ReadInt32();
            txtBxnumber_records.Text = pulsesTotal.ToString();
            numTransient.Maximum = pulsesTotal-1;

            //build arrays based on number of pulses
            int[] Akku_idx_record = new int[pulsesTotal];
            int[] Akku_idx_phase = new int[pulsesTotal];
            double[] Akku_targetTemp = new double[pulsesTotal];

            float[] Akku_diode1 = new float[pulsesTotal];
            float[] Akku_diode2 = new float[pulsesTotal];
            float[] Akku_diode3 = new float[pulsesTotal];
            float[] Akku_diode5 = new float[pulsesTotal];
            float[] Akku_T_calc = new float[pulsesTotal];
            float[] Akku_ctrl_out = new float[pulsesTotal];
            float[] Akku_aom2 = new float[pulsesTotal];

            int[,] Akku_transient = new int[450,4000];
            int[,] Akku_pulse = new int[450,400];

            float[] Akku_timestamp = new float[pulsesTotal];
            idx_record = Akku_idx_record;
            idx_phase = Akku_idx_phase;
            targetTemp = Akku_targetTemp;
            diode1 = Akku_diode1;
            diode2 = Akku_diode2;
            diode3 = Akku_diode3;
            diode5 = Akku_diode5;

            T_calc = Akku_T_calc;
            ctrl_out = Akku_ctrl_out;
            aom2 = Akku_aom2;
            transient = Akku_transient;
            pulse = Akku_pulse;
            timestamp = Akku_timestamp;

            //sinlge values
            T_max = br.ReadSingle();
            txtBx_Tmax.Text = T_max.ToString();
            T_zero = br.ReadSingle();
            txtBx_Tzero.Text = T_zero.ToString();
            T_ref = br.ReadSingle();
            txtBx_Tref.Text = T_ref.ToString();

            float T_aim = br.ReadSingle();
            txtBoxTargetTemp.Text = T_aim.ToString();
            txtBoxTargetTemp.Text = T_aim.ToString();

            //populate temperature graph
            float[] t= new float[pulsesTotal];
            float[] Taim = new float[pulsesTotal];

            foreach (var series in chart_Temperature.Series)
            {
                series.Points.Clear();
            }

            for (int k = 0; k < pulsesTotal; k++)
            {
                T_calc[k] = br.ReadSingle();
                t[k] =(float) 0.33 * k;
                Taim[k] = T_aim;
            }

            chart_Temperature.Series["Temp"].Points.Clear();
            chart_Temperature.Series["targetTemp"].Points.Clear();

            chart_Temperature.Series["Temp"].Points.DataBindXY(t, T_calc);
            chart_Temperature.Series["targetTemp"].Points.DataBindXY(t, Taim);

            // read tranients and pulses

            for (int k = 0; k < pulsesTotal; k++)
            {
                for (int f = 0; f < 4000; f++)
                {
                    transient[k,f] = br.ReadInt32();
                }


                for (int g = 0; g < 400; g++)
                {
                    pulse[k,g] = br.ReadInt32();
                }

            }

            // Epulse

            txtBxEpuls.Text = br.ReadSingle().ToString() ;
            txtBoxCtrl.Text= br.ReadInt32().ToString();
            txtBoxKD.Text= br.ReadDouble().ToString();
            txtBoxKP.Text= br.ReadDouble().ToString();
            txtBoxKI.Text= br.ReadDouble().ToString();
            txtBoxKwx1.Text= br.ReadDouble().ToString();
            txtBoxKwx2.Text= br.ReadDouble().ToString();
            txtBoxKwy.Text= br.ReadDouble().ToString();

            for(int z = 0; z < pulsesTotal; z++)
            {
                idx_record[z] = br.ReadInt32();
                idx_phase[z] = br.ReadInt32();
                timestamp[z] = br.ReadInt32();
                ctrl_out[z] = br.ReadSingle();
                diode1[z] = br.ReadSingle();
                diode2[z] = br.ReadSingle();
                diode3[z] = br.ReadSingle();
                diode5[z] = br.ReadSingle();
                aom2[z] = br.ReadSingle();

            }
            
           
            chart_Temperature.Series["ctrl out"].Points.DataBindXY(t, ctrl_out);
            chart_diodes.Series["diode1"].Points.DataBindY(diode1);
            chart_diodes.Series["diode2"].Points.DataBindY(diode2);
            chart_diodes.Series["diode3"].Points.DataBindY(diode3);
            chart_diodes.Series["diode5"].Points.DataBindY(diode5);

            br.Close();
            numTransient.Value = 3;



            // Create the stripline for 'gold status'
            float border_calib = 0;
            float border_cool = 0;
            for (int z = 0; z < pulsesTotal; z++)
            {
                if(idx_phase[z]==1)
                {
                    border_calib = (float)(z*0.33);
                }
                if (idx_phase[z] == 2)
                {
                    border_cool = (float)(z*0.33);
                }

            }



            //calibration phase color marking
            StripLine calib = new StripLine();
            calib.IntervalOffset = 0;
            calib.StripWidth = border_calib;
            calib.Text = "calibration";
            calib.Interval = 0.0; // this ensures it will not repeat like normal strip lines
            calib.BackColor = Color.LightGray;
            chart_Temperature.ChartAreas[0].AxisX.StripLines.Add(calib);

            //cooling phase color marking
            StripLine cool = new StripLine();
            cool.IntervalOffset = border_cool;
            cool.StripWidth = pulsesTotal - border_calib;
            cool.Text = "cooling";
            cool.Interval = 0.0; // this ensures it will not repeat like normal strip lines
            cool.BackColor = Color.LightGray;
            chart_Temperature.ChartAreas[0].AxisX.StripLines.Add(cool);


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




       //this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
        private void numTransient_ValueChanged(Object sender, EventArgs e)
        {
            for (int a = 0; a < 400; a++)
            {
                pulse_disp[a] = pulse[(int)numTransient.Value, a];
            }


            for (int b = 0; b < 4000; b++)
            {
                transient_disp[b] = transient[(int)numTransient.Value, b];
            }


            chartPulse.Series["pulse"].Points.DataBindY(pulse_disp);
            chartTransient.Series["transient"].Points.DataBindY(transient_disp);

            chart_Temperature.ChartAreas[0].CursorX.SetCursorPosition((int)numTransient.Value*0.33);

            currentTemp.Text = T_calc[(int)numTransient.Value].ToString();
            txtBxCtrlout.Text=ctrl_out[(int)numTransient.Value].ToString();

 
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

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            
            filename_exp = filename.Substring(0,filename.Length-4) + "___exp.txt";
            txtBoxTarget.Text = filename_exp;


            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(filename_exp))
            {
                file.WriteLine("Source-File\t" + Path.GetFileName(filename));
                file.WriteLine("Target\t"+strTarget);

                file.WriteLine("T max  [degC]\t" + String.Format("{0:0.00}", T_max));
                file.WriteLine("T zero [degC]\t" + String.Format("{0:0.00}", T_zero));
                file.WriteLine("T ref  [degC]\t" + String.Format("{0:0.00}",T_ref ));
                file.WriteLine("Controller\t");
                file.WriteLine("Record \t");
                
                for (int n = 0; n < pulsesTotal; n++)
                {
                    
                    file.Write(n.ToString() );
                    //file.WriteLine("Transient(%d)\t",n);
                }
                for (int i =0;i<4000;i++) 
                {
                    //file.WriteLine(transient[10, i].ToString());
                }
                
                
                


            }



        }
    }
}
