namespace TSR2_DataViewer
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.chart_Temperature = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnExit = new System.Windows.Forms.Button();
            this.chart_diodes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Diodes = new System.Windows.Forms.CheckedListBox();
            this.txtBoxTarget = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxCtrl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Kwx1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxKD = new System.Windows.Forms.TextBox();
            this.txtBoxKP = new System.Windows.Forms.TextBox();
            this.txtBoxKI = new System.Windows.Forms.TextBox();
            this.txtBoxKwx1 = new System.Windows.Forms.TextBox();
            this.txtBoxKwx2 = new System.Windows.Forms.TextBox();
            this.txtBoxKwy = new System.Windows.Forms.TextBox();
            this.chartTransient = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPulse = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.numTransient = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxTargetTemp = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Temperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_diodes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTransient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPulse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTransient)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(75, 12);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "open data file";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // chart_Temperature
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_Temperature.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Far;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.chart_Temperature.Legends.Add(legend1);
            this.chart_Temperature.Location = new System.Drawing.Point(213, 12);
            this.chart_Temperature.Name = "chart_Temperature";
            this.chart_Temperature.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Temp";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "targetTemp";
            this.chart_Temperature.Series.Add(series1);
            this.chart_Temperature.Series.Add(series2);
            this.chart_Temperature.Size = new System.Drawing.Size(874, 224);
            this.chart_Temperature.TabIndex = 2;
            this.chart_Temperature.Text = "chart1";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(75, 418);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // chart_diodes
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_diodes.ChartAreas.Add(chartArea2);
            legend2.Alignment = System.Drawing.StringAlignment.Far;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.Name = "Legend1";
            this.chart_diodes.Legends.Add(legend2);
            this.chart_diodes.Location = new System.Drawing.Point(213, 246);
            this.chart_diodes.Name = "chart_diodes";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "diode1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "diode2";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "diode3";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "diode5";
            this.chart_diodes.Series.Add(series3);
            this.chart_diodes.Series.Add(series4);
            this.chart_diodes.Series.Add(series5);
            this.chart_diodes.Series.Add(series6);
            this.chart_diodes.Size = new System.Drawing.Size(874, 224);
            this.chart_diodes.TabIndex = 5;
            this.chart_diodes.Text = "chart1";
            // 
            // Diodes
            // 
            this.Diodes.FormattingEnabled = true;
            this.Diodes.Items.AddRange(new object[] {
            "Diode1",
            "Diode2",
            "Diode3",
            "Diode5"});
            this.Diodes.Location = new System.Drawing.Point(44, 566);
            this.Diodes.Name = "Diodes";
            this.Diodes.Size = new System.Drawing.Size(120, 64);
            this.Diodes.TabIndex = 6;
            this.Diodes.SelectedIndexChanged += new System.EventHandler(this.Diodes_SelectedIndexChanged);
            // 
            // txtBoxTarget
            // 
            this.txtBoxTarget.Location = new System.Drawing.Point(74, 41);
            this.txtBoxTarget.Name = "txtBoxTarget";
            this.txtBoxTarget.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTarget.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Target";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Controller";
            // 
            // txtBoxCtrl
            // 
            this.txtBoxCtrl.Location = new System.Drawing.Point(74, 220);
            this.txtBoxCtrl.Name = "txtBoxCtrl";
            this.txtBoxCtrl.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCtrl.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "KD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "KP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "KI";
            // 
            // Kwx1
            // 
            this.Kwx1.AutoSize = true;
            this.Kwx1.Location = new System.Drawing.Point(18, 324);
            this.Kwx1.Name = "Kwx1";
            this.Kwx1.Size = new System.Drawing.Size(33, 13);
            this.Kwx1.TabIndex = 14;
            this.Kwx1.Text = "Kwx1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Kwx2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Kwy";
            // 
            // txtBoxKD
            // 
            this.txtBoxKD.Location = new System.Drawing.Point(74, 246);
            this.txtBoxKD.Name = "txtBoxKD";
            this.txtBoxKD.Size = new System.Drawing.Size(100, 20);
            this.txtBoxKD.TabIndex = 17;
            // 
            // txtBoxKP
            // 
            this.txtBoxKP.Location = new System.Drawing.Point(74, 272);
            this.txtBoxKP.Name = "txtBoxKP";
            this.txtBoxKP.Size = new System.Drawing.Size(100, 20);
            this.txtBoxKP.TabIndex = 18;
            // 
            // txtBoxKI
            // 
            this.txtBoxKI.Location = new System.Drawing.Point(74, 298);
            this.txtBoxKI.Name = "txtBoxKI";
            this.txtBoxKI.Size = new System.Drawing.Size(100, 20);
            this.txtBoxKI.TabIndex = 19;
            // 
            // txtBoxKwx1
            // 
            this.txtBoxKwx1.Location = new System.Drawing.Point(74, 324);
            this.txtBoxKwx1.Name = "txtBoxKwx1";
            this.txtBoxKwx1.Size = new System.Drawing.Size(100, 20);
            this.txtBoxKwx1.TabIndex = 20;
            // 
            // txtBoxKwx2
            // 
            this.txtBoxKwx2.Location = new System.Drawing.Point(74, 350);
            this.txtBoxKwx2.Name = "txtBoxKwx2";
            this.txtBoxKwx2.Size = new System.Drawing.Size(100, 20);
            this.txtBoxKwx2.TabIndex = 21;
            // 
            // txtBoxKwy
            // 
            this.txtBoxKwy.Location = new System.Drawing.Point(74, 376);
            this.txtBoxKwy.Name = "txtBoxKwy";
            this.txtBoxKwy.Size = new System.Drawing.Size(100, 20);
            this.txtBoxKwy.TabIndex = 22;
            // 
            // chartTransient
            // 
            chartArea3.Name = "ChartArea1";
            this.chartTransient.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartTransient.Legends.Add(legend3);
            this.chartTransient.Location = new System.Drawing.Point(213, 476);
            this.chartTransient.Name = "chartTransient";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "transient";
            this.chartTransient.Series.Add(series7);
            this.chartTransient.Size = new System.Drawing.Size(504, 201);
            this.chartTransient.TabIndex = 23;
            this.chartTransient.Text = "chart1";
            this.chartTransient.Click += new System.EventHandler(this.chartTransient_Click);
            // 
            // chartPulse
            // 
            chartArea4.Name = "ChartArea1";
            this.chartPulse.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartPulse.Legends.Add(legend4);
            this.chartPulse.Location = new System.Drawing.Point(723, 476);
            this.chartPulse.Name = "chartPulse";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "pulse";
            this.chartPulse.Series.Add(series8);
            this.chartPulse.Size = new System.Drawing.Size(364, 199);
            this.chartPulse.TabIndex = 24;
            this.chartPulse.Text = "chart1";
            // 
            // numTransient
            // 
            this.numTransient.Location = new System.Drawing.Point(64, 504);
            this.numTransient.Name = "numTransient";
            this.numTransient.Size = new System.Drawing.Size(75, 20);
            this.numTransient.TabIndex = 25;
            this.numTransient.ValueChanged += new System.EventHandler(this.numTransient_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "target Temp";
            // 
            // txtBoxTargetTemp
            // 
            this.txtBoxTargetTemp.Location = new System.Drawing.Point(74, 67);
            this.txtBoxTargetTemp.Name = "txtBoxTargetTemp";
            this.txtBoxTargetTemp.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTargetTemp.TabIndex = 27;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(74, 132);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 28;
            this.btnReset.Text = "reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 687);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtBoxTargetTemp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numTransient);
            this.Controls.Add(this.chartPulse);
            this.Controls.Add(this.chartTransient);
            this.Controls.Add(this.txtBoxKwy);
            this.Controls.Add(this.txtBoxKwx2);
            this.Controls.Add(this.txtBoxKwx1);
            this.Controls.Add(this.txtBoxKI);
            this.Controls.Add(this.txtBoxKP);
            this.Controls.Add(this.txtBoxKD);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Kwx1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxCtrl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxTarget);
            this.Controls.Add(this.Diodes);
            this.Controls.Add(this.chart_diodes);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.chart_Temperature);
            this.Controls.Add(this.btnOpenFile);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart_Temperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_diodes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTransient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPulse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTransient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Temperature;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_diodes;
        private System.Windows.Forms.CheckedListBox Diodes;
        private System.Windows.Forms.TextBox txtBoxTarget;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxCtrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Kwx1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxKD;
        private System.Windows.Forms.TextBox txtBoxKP;
        private System.Windows.Forms.TextBox txtBoxKI;
        private System.Windows.Forms.TextBox txtBoxKwx1;
        private System.Windows.Forms.TextBox txtBoxKwx2;
        private System.Windows.Forms.TextBox txtBoxKwy;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTransient;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPulse;
        private System.Windows.Forms.NumericUpDown numTransient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxTargetTemp;
        private System.Windows.Forms.Button btnReset;
    }
}

