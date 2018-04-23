Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...

Namespace Series_StepLineChart
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' Create a new chart.
			Dim stepLineChart As New ChartControl()

			' Create a step line series.
			Dim series1 As New Series("Series 1", ViewType.StepLine)

			' Add points to it.
			series1.Points.Add(New SeriesPoint("A", 12))
			series1.Points.Add(New SeriesPoint("B", 4))
			series1.Points.Add(New SeriesPoint("C", 17))
			series1.Points.Add(New SeriesPoint("D", 7))
			series1.Points.Add(New SeriesPoint("E", 12))
			series1.Points.Add(New SeriesPoint("F", 4))
			series1.Points.Add(New SeriesPoint("G", 17))
			series1.Points.Add(New SeriesPoint("H", 7))

			' Add the series to the chart.
			stepLineChart.Series.Add(series1)

			' Customize the view-type-specific properties of the series.
			Dim myView As StepLineSeriesView = CType(series1.View, StepLineSeriesView)
			myView.LineMarkerOptions.Kind = MarkerKind.Star
			myView.LineMarkerOptions.StarPointCount = 5
			myView.LineStyle.DashStyle = DashStyle.Dash

			' Access the diagram's options.
			CType(stepLineChart.Diagram, XYDiagram).Rotated = True

			' Hide the legend (if necessary).
			stepLineChart.Legend.Visible = False

			' Add a title to the chart (if necessary).
			stepLineChart.Titles.Add(New ChartTitle())
			stepLineChart.Titles(0).Text = "A Step Line Chart"

			' Add the chart to the form.
			stepLineChart.Dock = DockStyle.Fill
			Me.Controls.Add(stepLineChart)
		End Sub
	End Class
End Namespace