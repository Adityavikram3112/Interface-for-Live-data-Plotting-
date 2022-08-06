
namespace Swquel_Database_connection
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.AvgButton = new System.Windows.Forms.Button();
            this.SdButton = new System.Windows.Forms.Button();
            this.CpButton = new System.Windows.Forms.Button();
            this.CpuButton = new System.Windows.Forms.Button();
            this.CplButton = new System.Windows.Forms.Button();
            this.CpkButton = new System.Windows.Forms.Button();
            this.AvgText = new System.Windows.Forms.TextBox();
            this.SdText = new System.Windows.Forms.TextBox();
            this.CpText = new System.Windows.Forms.TextBox();
            this.CpuText = new System.Windows.Forms.TextBox();
            this.CplText = new System.Windows.Forms.TextBox();
            this.CpkText = new System.Windows.Forms.TextBox();
            this.getDataButton = new System.Windows.Forms.Button();
            this.dataListBox = new System.Windows.Forms.ListBox();
            this.IndexLab = new System.Windows.Forms.Label();
            this.IndexText1 = new System.Windows.Forms.Label();
            this.LSLText = new System.Windows.Forms.TextBox();
            this.USLText = new System.Windows.Forms.TextBox();
            this.usllabel = new System.Windows.Forms.Label();
            this.lsllabel = new System.Windows.Forms.Label();
            this.ColumnLabel = new System.Windows.Forms.Label();
            this.ColumnBox = new System.Windows.Forms.ComboBox();
            this.DataChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LowerError = new System.Windows.Forms.ListBox();
            this.LowerErrorLabel = new System.Windows.Forms.Label();
            this.UpperErrorLable = new System.Windows.Forms.Label();
            this.UpperError = new System.Windows.Forms.ListBox();
            this.LowerErrorCountText = new System.Windows.Forms.TextBox();
            this.LowerErrorCountLable = new System.Windows.Forms.Label();
            this.UpperLayerErrorCountLable = new System.Windows.Forms.Label();
            this.UpperErrorCountText = new System.Windows.Forms.TextBox();
            this.DatePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DatePicker2 = new System.Windows.Forms.DateTimePicker();
            this.TimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DataChart)).BeginInit();
            this.SuspendLayout();
            // 
            // AvgButton
            // 
            this.AvgButton.Location = new System.Drawing.Point(1120, 165);
            this.AvgButton.Name = "AvgButton";
            this.AvgButton.Size = new System.Drawing.Size(69, 23);
            this.AvgButton.TabIndex = 0;
            this.AvgButton.Text = "Average";
            this.AvgButton.UseVisualStyleBackColor = true;
            this.AvgButton.Click += new System.EventHandler(this.AvgButton_Click);
            // 
            // SdButton
            // 
            this.SdButton.Location = new System.Drawing.Point(1120, 209);
            this.SdButton.Name = "SdButton";
            this.SdButton.Size = new System.Drawing.Size(69, 23);
            this.SdButton.TabIndex = 1;
            this.SdButton.Text = "SD";
            this.SdButton.UseVisualStyleBackColor = true;
            this.SdButton.Click += new System.EventHandler(this.SdButton_Click);
            // 
            // CpButton
            // 
            this.CpButton.Location = new System.Drawing.Point(1120, 254);
            this.CpButton.Name = "CpButton";
            this.CpButton.Size = new System.Drawing.Size(69, 23);
            this.CpButton.TabIndex = 2;
            this.CpButton.Text = "Cp";
            this.CpButton.UseVisualStyleBackColor = true;
            this.CpButton.Click += new System.EventHandler(this.CpButton_Click);
            // 
            // CpuButton
            // 
            this.CpuButton.Location = new System.Drawing.Point(1120, 297);
            this.CpuButton.Name = "CpuButton";
            this.CpuButton.Size = new System.Drawing.Size(69, 23);
            this.CpuButton.TabIndex = 3;
            this.CpuButton.Text = "Cpu";
            this.CpuButton.UseVisualStyleBackColor = true;
            this.CpuButton.Click += new System.EventHandler(this.CpuButton_Click);
            // 
            // CplButton
            // 
            this.CplButton.Location = new System.Drawing.Point(1120, 343);
            this.CplButton.Name = "CplButton";
            this.CplButton.Size = new System.Drawing.Size(69, 23);
            this.CplButton.TabIndex = 4;
            this.CplButton.Text = "Cpl";
            this.CplButton.UseVisualStyleBackColor = true;
            this.CplButton.Click += new System.EventHandler(this.CplButton_Click);
            // 
            // CpkButton
            // 
            this.CpkButton.Location = new System.Drawing.Point(1120, 389);
            this.CpkButton.Name = "CpkButton";
            this.CpkButton.Size = new System.Drawing.Size(69, 23);
            this.CpkButton.TabIndex = 5;
            this.CpkButton.Text = "Cpk";
            this.CpkButton.UseVisualStyleBackColor = true;
            this.CpkButton.Click += new System.EventHandler(this.CpkButton_Click);
            // 
            // AvgText
            // 
            this.AvgText.Location = new System.Drawing.Point(1220, 168);
            this.AvgText.Name = "AvgText";
            this.AvgText.Size = new System.Drawing.Size(118, 20);
            this.AvgText.TabIndex = 6;
            // 
            // SdText
            // 
            this.SdText.Location = new System.Drawing.Point(1220, 210);
            this.SdText.Name = "SdText";
            this.SdText.Size = new System.Drawing.Size(117, 20);
            this.SdText.TabIndex = 7;
            // 
            // CpText
            // 
            this.CpText.Location = new System.Drawing.Point(1221, 257);
            this.CpText.Name = "CpText";
            this.CpText.Size = new System.Drawing.Size(117, 20);
            this.CpText.TabIndex = 8;
            // 
            // CpuText
            // 
            this.CpuText.Location = new System.Drawing.Point(1221, 300);
            this.CpuText.Name = "CpuText";
            this.CpuText.Size = new System.Drawing.Size(117, 20);
            this.CpuText.TabIndex = 9;
            // 
            // CplText
            // 
            this.CplText.Location = new System.Drawing.Point(1220, 346);
            this.CplText.Name = "CplText";
            this.CplText.Size = new System.Drawing.Size(117, 20);
            this.CplText.TabIndex = 10;
            // 
            // CpkText
            // 
            this.CpkText.Location = new System.Drawing.Point(1221, 392);
            this.CpkText.Name = "CpkText";
            this.CpkText.Size = new System.Drawing.Size(117, 20);
            this.CpkText.TabIndex = 11;
            // 
            // getDataButton
            // 
            this.getDataButton.Location = new System.Drawing.Point(96, 261);
            this.getDataButton.Name = "getDataButton";
            this.getDataButton.Size = new System.Drawing.Size(75, 23);
            this.getDataButton.TabIndex = 12;
            this.getDataButton.Text = "Get Data";
            this.getDataButton.UseVisualStyleBackColor = true;
            this.getDataButton.Click += new System.EventHandler(this.getDataButton_Click);
            // 
            // dataListBox
            // 
            this.dataListBox.FormattingEnabled = true;
            this.dataListBox.Location = new System.Drawing.Point(31, 290);
            this.dataListBox.Name = "dataListBox";
            this.dataListBox.Size = new System.Drawing.Size(215, 303);
            this.dataListBox.TabIndex = 13;
            // 
            // IndexLab
            // 
            this.IndexLab.AutoSize = true;
            this.IndexLab.Location = new System.Drawing.Point(28, 189);
            this.IndexLab.Name = "IndexLab";
            this.IndexLab.Size = new System.Drawing.Size(85, 13);
            this.IndexLab.TabIndex = 15;
            this.IndexLab.Text = "END Date Time ";
            // 
            // IndexText1
            // 
            this.IndexText1.AutoSize = true;
            this.IndexText1.Location = new System.Drawing.Point(12, 143);
            this.IndexText1.Name = "IndexText1";
            this.IndexText1.Size = new System.Drawing.Size(101, 13);
            this.IndexText1.TabIndex = 16;
            this.IndexText1.Text = "  START Date Time";
            // 
            // LSLText
            // 
            this.LSLText.Location = new System.Drawing.Point(1220, 135);
            this.LSLText.Name = "LSLText";
            this.LSLText.Size = new System.Drawing.Size(117, 20);
            this.LSLText.TabIndex = 18;
            // 
            // USLText
            // 
            this.USLText.Location = new System.Drawing.Point(1220, 108);
            this.USLText.Name = "USLText";
            this.USLText.Size = new System.Drawing.Size(118, 20);
            this.USLText.TabIndex = 19;
            // 
            // usllabel
            // 
            this.usllabel.AutoSize = true;
            this.usllabel.Location = new System.Drawing.Point(1142, 108);
            this.usllabel.Name = "usllabel";
            this.usllabel.Size = new System.Drawing.Size(28, 13);
            this.usllabel.TabIndex = 20;
            this.usllabel.Text = "USL";
            // 
            // lsllabel
            // 
            this.lsllabel.AutoSize = true;
            this.lsllabel.Location = new System.Drawing.Point(1142, 142);
            this.lsllabel.Name = "lsllabel";
            this.lsllabel.Size = new System.Drawing.Size(26, 13);
            this.lsllabel.TabIndex = 21;
            this.lsllabel.Text = "LSL";
            // 
            // ColumnLabel
            // 
            this.ColumnLabel.AutoSize = true;
            this.ColumnLabel.Location = new System.Drawing.Point(74, 105);
            this.ColumnLabel.Name = "ColumnLabel";
            this.ColumnLabel.Size = new System.Drawing.Size(45, 13);
            this.ColumnLabel.TabIndex = 22;
            this.ColumnLabel.Text = "Column ";
            // 
            // ColumnBox
            // 
            this.ColumnBox.FormattingEnabled = true;
            this.ColumnBox.Location = new System.Drawing.Point(125, 103);
            this.ColumnBox.Name = "ColumnBox";
            this.ColumnBox.Size = new System.Drawing.Size(121, 21);
            this.ColumnBox.TabIndex = 24;
            this.ColumnBox.SelectedIndexChanged += new System.EventHandler(this.ColumnBox_SelectedIndexChanged);
            // 
            // DataChart
            // 
            chartArea3.Name = "ChartArea1";
            this.DataChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.DataChart.Legends.Add(legend3);
            this.DataChart.Location = new System.Drawing.Point(312, 31);
            this.DataChart.Name = "DataChart";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.Name = "DataPlot";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.Legend = "Legend1";
            series10.Name = "TempMax";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series11.Legend = "Legend1";
            series11.Name = "TempMin";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series12.Legend = "Legend1";
            series12.Name = "WindSpeed";
            this.DataChart.Series.Add(series9);
            this.DataChart.Series.Add(series10);
            this.DataChart.Series.Add(series11);
            this.DataChart.Series.Add(series12);
            this.DataChart.Size = new System.Drawing.Size(786, 649);
            this.DataChart.TabIndex = 25;
            this.DataChart.Text = "chart1";
            title3.Name = "Title1";
            this.DataChart.Titles.Add(title3);
            // 
            // LowerError
            // 
            this.LowerError.FormattingEnabled = true;
            this.LowerError.Location = new System.Drawing.Point(1221, 433);
            this.LowerError.Name = "LowerError";
            this.LowerError.Size = new System.Drawing.Size(120, 95);
            this.LowerError.TabIndex = 26;
            // 
            // LowerErrorLabel
            // 
            this.LowerErrorLabel.AutoSize = true;
            this.LowerErrorLabel.Location = new System.Drawing.Point(1122, 464);
            this.LowerErrorLabel.Name = "LowerErrorLabel";
            this.LowerErrorLabel.Size = new System.Drawing.Size(93, 13);
            this.LowerErrorLabel.TabIndex = 27;
            this.LowerErrorLabel.Text = "Values Below LSL";
            // 
            // UpperErrorLable
            // 
            this.UpperErrorLable.AutoSize = true;
            this.UpperErrorLable.Location = new System.Drawing.Point(1122, 603);
            this.UpperErrorLable.Name = "UpperErrorLable";
            this.UpperErrorLable.Size = new System.Drawing.Size(97, 13);
            this.UpperErrorLable.TabIndex = 28;
            this.UpperErrorLable.Text = "Values Above USL";
            // 
            // UpperError
            // 
            this.UpperError.FormattingEnabled = true;
            this.UpperError.Location = new System.Drawing.Point(1225, 560);
            this.UpperError.Name = "UpperError";
            this.UpperError.Size = new System.Drawing.Size(120, 95);
            this.UpperError.TabIndex = 29;
            // 
            // LowerErrorCountText
            // 
            this.LowerErrorCountText.Location = new System.Drawing.Point(1245, 533);
            this.LowerErrorCountText.Name = "LowerErrorCountText";
            this.LowerErrorCountText.Size = new System.Drawing.Size(100, 20);
            this.LowerErrorCountText.TabIndex = 30;
            // 
            // LowerErrorCountLable
            // 
            this.LowerErrorCountLable.AutoSize = true;
            this.LowerErrorCountLable.Location = new System.Drawing.Point(1117, 536);
            this.LowerErrorCountLable.Name = "LowerErrorCountLable";
            this.LowerErrorCountLable.Size = new System.Drawing.Size(122, 13);
            this.LowerErrorCountLable.TabIndex = 31;
            this.LowerErrorCountLable.Text = "No of Values Below LSL";
            // 
            // UpperLayerErrorCountLable
            // 
            this.UpperLayerErrorCountLable.AutoSize = true;
            this.UpperLayerErrorCountLable.Location = new System.Drawing.Point(1113, 663);
            this.UpperLayerErrorCountLable.Name = "UpperLayerErrorCountLable";
            this.UpperLayerErrorCountLable.Size = new System.Drawing.Size(126, 13);
            this.UpperLayerErrorCountLable.TabIndex = 32;
            this.UpperLayerErrorCountLable.Text = "No of Values Above USL";
            // 
            // UpperErrorCountText
            // 
            this.UpperErrorCountText.Location = new System.Drawing.Point(1245, 660);
            this.UpperErrorCountText.Name = "UpperErrorCountText";
            this.UpperErrorCountText.Size = new System.Drawing.Size(100, 20);
            this.UpperErrorCountText.TabIndex = 33;
            // 
            // DatePicker1
            // 
            this.DatePicker1.CustomFormat = "yyyy/MM/dd";
            this.DatePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePicker1.Location = new System.Drawing.Point(125, 137);
            this.DatePicker1.Name = "DatePicker1";
            this.DatePicker1.Size = new System.Drawing.Size(79, 20);
            this.DatePicker1.TabIndex = 34;
            // 
            // TimePicker1
            // 
            this.TimePicker1.CustomFormat = "HH:mm:ss";
            this.TimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimePicker1.Location = new System.Drawing.Point(210, 137);
            this.TimePicker1.MinDate = new System.DateTime(2012, 1, 1, 0, 0, 0, 0);
            this.TimePicker1.Name = "TimePicker1";
            this.TimePicker1.Size = new System.Drawing.Size(81, 20);
            this.TimePicker1.TabIndex = 35;
            // 
            // DatePicker2
            // 
            this.DatePicker2.CustomFormat = "yyyy/MM/dd";
            this.DatePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePicker2.Location = new System.Drawing.Point(125, 183);
            this.DatePicker2.Name = "DatePicker2";
            this.DatePicker2.Size = new System.Drawing.Size(79, 20);
            this.DatePicker2.TabIndex = 36;
            // 
            // TimePicker2
            // 
            this.TimePicker2.CustomFormat = "HH:mm:ss";
            this.TimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimePicker2.Location = new System.Drawing.Point(210, 182);
            this.TimePicker2.Name = "TimePicker2";
            this.TimePicker2.Size = new System.Drawing.Size(84, 20);
            this.TimePicker2.TabIndex = 37;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 721);
            this.Controls.Add(this.TimePicker2);
            this.Controls.Add(this.DatePicker2);
            this.Controls.Add(this.TimePicker1);
            this.Controls.Add(this.DatePicker1);
            this.Controls.Add(this.UpperErrorCountText);
            this.Controls.Add(this.UpperLayerErrorCountLable);
            this.Controls.Add(this.LowerErrorCountLable);
            this.Controls.Add(this.LowerErrorCountText);
            this.Controls.Add(this.UpperError);
            this.Controls.Add(this.UpperErrorLable);
            this.Controls.Add(this.LowerErrorLabel);
            this.Controls.Add(this.LowerError);
            this.Controls.Add(this.DataChart);
            this.Controls.Add(this.ColumnBox);
            this.Controls.Add(this.ColumnLabel);
            this.Controls.Add(this.lsllabel);
            this.Controls.Add(this.usllabel);
            this.Controls.Add(this.USLText);
            this.Controls.Add(this.LSLText);
            this.Controls.Add(this.IndexText1);
            this.Controls.Add(this.IndexLab);
            this.Controls.Add(this.dataListBox);
            this.Controls.Add(this.getDataButton);
            this.Controls.Add(this.CpkText);
            this.Controls.Add(this.CplText);
            this.Controls.Add(this.CpuText);
            this.Controls.Add(this.CpText);
            this.Controls.Add(this.SdText);
            this.Controls.Add(this.AvgText);
            this.Controls.Add(this.CpkButton);
            this.Controls.Add(this.CplButton);
            this.Controls.Add(this.CpuButton);
            this.Controls.Add(this.CpButton);
            this.Controls.Add(this.SdButton);
            this.Controls.Add(this.AvgButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DataChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AvgButton;
        private System.Windows.Forms.Button SdButton;
        private System.Windows.Forms.Button CpButton;
        private System.Windows.Forms.Button CpuButton;
        private System.Windows.Forms.Button CplButton;
        private System.Windows.Forms.Button CpkButton;
        private System.Windows.Forms.TextBox AvgText;
        private System.Windows.Forms.TextBox SdText;
        private System.Windows.Forms.TextBox CpText;
        private System.Windows.Forms.TextBox CpuText;
        private System.Windows.Forms.TextBox CplText;
        private System.Windows.Forms.TextBox CpkText;
        private System.Windows.Forms.Button getDataButton;
        private System.Windows.Forms.ListBox dataListBox;
        private System.Windows.Forms.Label IndexLab;
        private System.Windows.Forms.Label IndexText1;
        private System.Windows.Forms.TextBox LSLText;
        private System.Windows.Forms.TextBox USLText;
        private System.Windows.Forms.Label usllabel;
        private System.Windows.Forms.Label lsllabel;
        private System.Windows.Forms.Label ColumnLabel;
        private System.Windows.Forms.ComboBox ColumnBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart DataChart;
        private System.Windows.Forms.ListBox LowerError;
        private System.Windows.Forms.Label LowerErrorLabel;
        private System.Windows.Forms.Label UpperErrorLable;
        private System.Windows.Forms.ListBox UpperError;
        private System.Windows.Forms.TextBox LowerErrorCountText;
        private System.Windows.Forms.Label LowerErrorCountLable;
        private System.Windows.Forms.Label UpperLayerErrorCountLable;
        private System.Windows.Forms.TextBox UpperErrorCountText;
        private System.Windows.Forms.DateTimePicker DatePicker1;
        private System.Windows.Forms.DateTimePicker TimePicker1;
        private System.Windows.Forms.DateTimePicker DatePicker2;
        private System.Windows.Forms.DateTimePicker TimePicker2;
    }
}

