using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;
// ...

namespace Series_StepLineChart {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Create a new chart.
            ChartControl stepLineChart = new ChartControl();

            // Create a step line series.
            Series series1 = new Series("Series 1", ViewType.StepLine);

            // Add points to it.
            series1.Points.Add(new SeriesPoint("A", 12));
            series1.Points.Add(new SeriesPoint("B", 4));
            series1.Points.Add(new SeriesPoint("C", 17));
            series1.Points.Add(new SeriesPoint("D", 7));
            series1.Points.Add(new SeriesPoint("E", 12));
            series1.Points.Add(new SeriesPoint("F", 4));
            series1.Points.Add(new SeriesPoint("G", 17));
            series1.Points.Add(new SeriesPoint("H", 7));

            // Add the series to the chart.
            stepLineChart.Series.Add(series1);

            // Customize the view-type-specific properties of the series.
            StepLineSeriesView myView = (StepLineSeriesView)series1.View;
            myView.LineMarkerOptions.Kind = MarkerKind.Star;
            myView.LineMarkerOptions.StarPointCount = 5;
            myView.LineStyle.DashStyle = DashStyle.Dash;

            // Access the diagram's options.
            ((XYDiagram)stepLineChart.Diagram).Rotated = true;

            // Hide the legend (if necessary).
            stepLineChart.Legend.Visible = false;

            // Add a title to the chart (if necessary).
            stepLineChart.Titles.Add(new ChartTitle());
            stepLineChart.Titles[0].Text = "A Step Line Chart";

            // Add the chart to the form.
            stepLineChart.Dock = DockStyle.Fill;
            this.Controls.Add(stepLineChart);
        }
    }
}