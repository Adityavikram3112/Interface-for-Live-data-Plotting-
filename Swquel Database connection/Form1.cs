using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Media;


namespace Swquel_Database_connection
{
    public partial class Form1 : Form
    { 

        dynamic Data1;
        List<float> Data3 = new List<float>();
        string Data2;
        dynamic wdata;
        static Wheatherdata.root plotlist = new Wheatherdata.root();
        static List<double> weatherdatamax = new List<double>();
        static List<double> weatherdatamin = new List<double>();

        public Form1()
        {
            InitializeComponent();
            UpdateBinding();
            CreateDropDown();
        }



        public void populate()
        {

            
            //DataChart.Refresh();
            //DataChart.ChartAreas[0].Dispose();
            DataChart.Series["DataPlot"].Points.Clear();
            DataChart.Annotations.Clear();
           
            HorizontalLineAnnotation hl = new HorizontalLineAnnotation();
            hl.AllowMoving = false;
            hl.IsInfinitive = true;
            hl.ClipToChartArea ="ChartArea1";
            hl.LineColor = System.Drawing.Color.Red;
            hl.AnchorY = Convert.ToDouble(USLText.Text);
            hl.AxisX = DataChart.ChartAreas[0].AxisX;
            hl.AxisY = DataChart.ChartAreas[0].AxisY;
            DataChart.Annotations.Add(hl);

            HorizontalLineAnnotation hllsl = new HorizontalLineAnnotation();
            hllsl.AllowMoving = false;
            hllsl.IsInfinitive = true;
            hllsl.ClipToChartArea = "ChartArea1";
            hllsl.LineColor = System.Drawing.Color.BlueViolet;
            hllsl.AnchorY = Convert.ToDouble(LSLText.Text);
            hllsl.AxisX = DataChart.ChartAreas[0].AxisX;
            hllsl.AxisY = DataChart.ChartAreas[0].AxisY;
            DataChart.Annotations.Add(hllsl);
              

            int x = DataAccess.l1.Count;
            DataChart.DataSource = DataAccess.l1;
            int y = 0;
            for (int i = 0; i< x; i++)
            {
                DataChart.Series["DataPlot"].Points.AddXY(y, DataAccess.l1[i]);
                y++;
            }
            DataAccess obj6 = new DataAccess();
            var data1 = obj6.CheckLowerLimits(LSLText.Text);
            var data2 = obj6.CheckUpperLimits(USLText.Text);
            UpperError.DataSource = data2;
            UpperError.DisplayMember = Convert.ToString(data2);

            LowerError.DataSource = data1;
            LowerError.DisplayMember = Convert.ToString(data1);
            string uec = Convert.ToString(data2.Count);
            UpperErrorCountText.Text = uec;
            string lec = Convert.ToString(data1.Count);
            LowerErrorCountText.Text = lec;
        }



        public void UpdateBinding()
        {
            dataListBox.DataSource = DataAccess.l1;
            dataListBox.DisplayMember = this.ColumnBox.GetItemText(this.ColumnBox.SelectedItem);
        }



        //button events

        private void getDataButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess(); 
            string selected = this.ColumnBox.GetItemText(this.ColumnBox.SelectedItem);
            string date1 = DatePicker1.Value.ToShortDateString();
            string time1 = TimePicker1.Value.ToString("HH:mm:ss");
            string datetime1 = $"{date1} {time1}.000";
            string date2 = DatePicker2.Value.ToShortDateString();
            string time2 = TimePicker2.Value.ToString("HH:mm:ss");
            string datetime2 = $"{date2} {time2}.000";
            Data1 = db.GetInfo(datetime1,datetime2,selected);
            populate();
            UpdateBinding();
            

        }



        private void AvgButton_Click(object sender, EventArgs e)
        {
            DataAccess obj = new DataAccess();
            Data2 = obj.GetAvgAlt();
            AvgText.Text = Data2;
        }



        private void SdButton_Click(object sender, EventArgs e)
        {
            DataAccess obj1 = new DataAccess();
            var data2 = obj1.GetSd();
            SdText.Text = data2;
            
        }



        private void CpButton_Click(object sender, EventArgs e)
        {
            DataAccess obj2 = new DataAccess();
            double USl = Convert.ToDouble(USLText.Text);
            double Lsl = Convert.ToDouble(LSLText.Text);
            var datacp = obj2.GetCp(USl,Lsl);
            CpText.Text = datacp;
        }



        private void CpuButton_Click(object sender, EventArgs e)
        {
            DataAccess obj3 = new DataAccess();
            double usl = Convert.ToDouble(USLText.Text);
            string op= obj3.GetCpu(usl);
            CpuText.Text = op;
        }



        private void CplButton_Click(object sender, EventArgs e)
        {
            DataAccess obj4 = new DataAccess();
            double lsl = Convert.ToDouble(LSLText.Text);
            string op =obj4.GetCpl(lsl);
            CplText.Text = op;

        }



        private void CpkButton_Click(object sender, EventArgs e)
        {
            DataAccess obj5 = new DataAccess();
            string op = obj5.GetCpk();
            CpkText.Text = op;
        }



        private void ColumnBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string col1 = ColumnBox.SelectedItem.ToString();
        }



         
        public void  CreateDropDown()
        {
            
            ColumnBox.Items.Add("Val_1");
            ColumnBox.Items.Add("LogTime");
            ColumnBox.Items.Add("EtrSgt");
            ColumnBox.Items.Add("DtrSgt");
            ColumnBox.Items.Add("MillSpeed");
            ColumnBox.Items.Add("DriveSideLoad");
            ColumnBox.Items.Add("OpSideLoad");
            ColumnBox.Items.Add("EtrTension");
            ColumnBox.Items.Add("DtrTension");
            ColumnBox.Items.Add("Dspt");
            ColumnBox.Items.Add("Ospt");
            ColumnBox.Items.Add("BreakCount");
            ColumnBox.Items.Add("CoilWeight");
            ColumnBox.Items.Add("CoilLength");
            ColumnBox.Items.Add(" MILL_SPD_GRT_15");

        }
    }
}
