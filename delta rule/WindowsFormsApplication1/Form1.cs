using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        static double learningRate = 0.2;
        List<double[]> data;
        Chart mychart;
        List<double> slope = new List<double>();
        List<double> bias = new List<double>();
        List<double> errorValues = new List<double>();
        List<double> weights = new List<double>();
        List<double[]> weightsHistory = new List<double[]>();
        int chart_index = 0;
        double theta = 0.55;
        int numItteration = 100;
        bool isChartUpdateEnabled = false;
        int chartstepSize = 10;
        int accuracy = 90;
        bool isShuffleOn = false;

        public Form1()
        {
            InitializeComponent();

            //read parameters
            readParameters();
            mychart = this.chart1;

            //read data
            data = readFile();
            instantiateChart();

            // apply delta rule
            deltaRule(data);

            Timer timer1 = new Timer();
            timer1.Interval = 120;
            timer1.Enabled = true;
            timer1.Tick += new System.EventHandler(OnTimerEvent);
        }

        private void instantiateChart()
        {
            try
            {

                mychart.Series.Add("Series2");
                mychart.Series.Add("Series3");
            }
            catch (Exception e) { }

            //mychart.ChartAreas[0].AxisY.Maximum = 6;
            //mychart.ChartAreas[0].AxisY.Minimum = -4;
            //mychart.ChartAreas[0].AxisX.Maximum = 4;
            //mychart.ChartAreas[0].AxisX.Minimum = -1;
            mychart.ChartAreas[0].AxisY.Maximum = 1.1;
            mychart.ChartAreas[0].AxisY.Minimum = -0.2;
            mychart.ChartAreas[0].AxisX.Maximum = 1.1;
            mychart.ChartAreas[0].AxisX.Minimum = -0.2;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            mychart.Series["Series1"].ChartType = SeriesChartType.Point;
            mychart.Series["Series3"].ChartType = SeriesChartType.Point;
            mychart.Series["Series2"].ChartType = SeriesChartType.Line;
            mychart.Series["Series2"].BorderWidth = 2;

            // for scater plot
            List<double> x_col_c1 = new List<double>();
            List<double> y_col_c1 = new List<double>();
            List<double> x_col_c2 = new List<double>();
            List<double> y_col_c2 = new List<double>();

            for (int i = 0; i < data.Count; i++)
            {
                if (data[i][2] == 0)
                {
                    x_col_c1.Add(data[i][0]);
                    y_col_c1.Add(data[i][1]);
                }
                else if (data[i][2] == 1)
                {
                    x_col_c2.Add(data[i][0]);
                    y_col_c2.Add(data[i][1]);
                }

            }

            mychart.Series["Series1"].Points.DataBindXY(x_col_c1, y_col_c1);
            mychart.Series["Series3"].Points.DataBindXY(x_col_c2, y_col_c2);
            this.Refresh();

        }

        private void OnTimerEvent(object sender, EventArgs e)
        {
            //drawLine(wight 1, weight2);
            if (chart_index < slope.Count & isChartUpdateEnabled)
            {
                drawLine(slope[chart_index], bias[chart_index]);

                lbl_w1.Text = weightsHistory[chart_index][0].ToString();
                lbl_w2.Text = weightsHistory[chart_index][1].ToString();
                chart_index = chart_index + chartstepSize;
            }
            if (chart_index >= slope.Count & isChartUpdateEnabled)
            {
                drawLine(slope[slope.Count - 1], bias[slope.Count - 1]);

                lbl_w1.Text = weightsHistory[slope.Count - 1][0].ToString();
                lbl_w2.Text = weightsHistory[slope.Count - 1][1].ToString();
                isChartUpdateEnabled = false;
            }

        }

        public static List<double[]> readFile(string fileLocation = "data-3.csv")
        {

            List<double[]> listA = new List<double[]>();

            using (var reader = new StreamReader(fileLocation))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    listA.Add(Array.ConvertAll(values, Double.Parse));
                }
            }

            return listA;

        }

        void deltaRule(List<double[]> data)
        {
            btn_browse.Enabled = false;
            btn_start.Enabled = false;
            slope = new List<double>();
            bias = new List<double>();
            errorValues = new List<double>();
            weights = new List<double>();
            weightsHistory = new List<double[]>();

            //get number of rows and columns
            int dataRowCount = data.Count();
            int dataColumnCount = data[0].Length;
            if (dataRowCount > 100) chartstepSize = 100;
            else chartstepSize = 10;

            //initialize random weight for all features
            Random randomNumGenerator = new Random();

            for (int c = 0; c < dataColumnCount - 1; c++)
            {
                double rand = randomNumGenerator.Next(-5, 5);
                weights.Add(rand / 10);
            }
            weights[0] = 1;
            weights[1] = -1;
            //draw the intial classification boundary
            drawLine(weights[0], weights[1]);
            lbl_w1.Text = weights[0].ToString();
            lbl_w2.Text = weights[1].ToString();
            double[] weightsdata = { weights[0], weights[1] };
            weightsHistory.Add(weightsdata);

            // loop the code for the desired itteration count
            //for (int i = 0; i < numItteration; i++)
            int i = 0, error_count = 0;
            while (i < numItteration)
            {
                error_count = 0;
                Shuffle(data);

                // for each instance (row) itterate and adjust the weight
                for (int j = 0; j < dataRowCount; j++)
                {
                    // calculate output
                    double output = 0;
                    for (int c = 0; c < dataColumnCount - 1; c++)
                    {
                        output += weights[c] * data[j][c];

                    }


                    if (output > theta) output = 1;
                    else output = 0;

                    //calculate error
                    double instancError = (data[j][dataColumnCount - 1] - output);
                    if (instancError != 0) error_count++;


                    // calculate delta and update weight
                    for (int c = 0; c < dataColumnCount - 1; c++)
                    {
                        weights[c] = weights[c] + learningRate * (instancError * data[j][c]);
                    }

                    double[] weightsdata2 = { weights[0], weights[1] };
                    weightsHistory.Add(weightsdata2);
                    slope.Add(weights[0]);
                    bias.Add(weights[1]);
                }

                // increment i
                i++;


                errorValues.Add(error_count);
                if ((100 * error_count / dataRowCount) < 10) break;
            }

            File.WriteAllText("errorList.txt", String.Empty);
            // save values to text
            using (TextWriter tw = new StreamWriter("errorList.txt"))
            {
                foreach (double s in errorValues)
                    tw.WriteLine(s);
            }


            btn_browse.Enabled = true;
            btn_start.Enabled = true;
        }

        public void drawLine(double m, double b)
        {

            List<double> x = new List<double>();
            List<double> y = new List<double>();

            //for (double i = -1; i < 4;)
            for (double i = -.1; i < 1.2;)
            {
                x.Add(i);
                //x1*w1 + x2*w2 > etta
                y.Add(theta / b - m / b * i);
                i += 0.1;
            }

            try
            {
                mychart.Series["Series2"].Points.DataBindXY(x, y);
            }
            catch (Exception e) { }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            isChartUpdateEnabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtfilelocation.Text = openFileDialog1.FileName;
                data = readFile(openFileDialog1.FileName);
                instantiateChart();
                deltaRule(data);
                isChartUpdateEnabled = false;
                chart_index = 0;
            }
        }

        public void readParameters()
        {

            using (var reader = new StreamReader("parameters.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    switch (values[0])
                    {
                        case "theta": theta = double.Parse(values[1]); break;
                        case "numItteration": numItteration = int.Parse(values[1]); break;
                        case "learningRate": learningRate = double.Parse(values[1]); break;
                    }
                }
            }
            displayParameters();
        }

        public void displayParameters()
        {
            lbl_iteration.Text = numItteration + "";
            lbl_theta.Text = theta + "";
            lbl_lr.Text = learningRate + "";

        }


        public static void Shuffle<T>(IList<T> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

    }
}
