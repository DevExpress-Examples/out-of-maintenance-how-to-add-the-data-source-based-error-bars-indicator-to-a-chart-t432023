<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128568437/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T432023)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/DataSourceBasedErrorBars/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/DataSourceBasedErrorBars/MainWindow.xaml))
<!-- default file list end -->
# How to: Add the Data Source Based Error Bars indicator to a chart


<p>This example demonstrates how to plot Data Source Based Error Bars on the chart.</p>


<h3>Description</h3>

To do this, add a&nbsp;<a href="https://documentation.devexpress.com/#WPF/clsDevExpressXpfChartsDataSourceBasedErrorBarstopic">DataSourceBasedErrorBars</a>&nbsp;object to the series&nbsp;<a href="https://documentation.devexpress.com/#WPF/DevExpressXpfChartsXYSeries2D_Indicatorstopic">XYSeries2D.Indicators</a>&nbsp;collection.&nbsp;Then,&nbsp;specify&nbsp;which data members&nbsp;store negative and positive error values using the&nbsp;<a href="https://documentation.devexpress.com/#WPF/DevExpressXpfChartsDataSourceBasedErrorBars_NegativeErrorDataMembertopic">DataSourceBasedErrorBars.NegativeErrorDataMember</a>&nbsp;and&nbsp;<a href="https://documentation.devexpress.com/#WPF/DevExpressXpfChartsDataSourceBasedErrorBars_PositiveErrorDataMembertopic">DataSourceBasedErrorBars.PositiveErrorDataMember</a>&nbsp;properties.

<br/>


