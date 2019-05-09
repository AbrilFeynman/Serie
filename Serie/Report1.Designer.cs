namespace Serie
{
    partial class Report1
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.Reporting.GraphGroup graphGroup5 = new Telerik.Reporting.GraphGroup();
            Telerik.Reporting.Drawing.ColorPalette colorPalette2 = new Telerik.Reporting.Drawing.ColorPalette();
            Telerik.Reporting.GraphTitle graphTitle3 = new Telerik.Reporting.GraphTitle();
            Telerik.Reporting.DateTimeScale dateTimeScale2 = new Telerik.Reporting.DateTimeScale();
            Telerik.Reporting.NumericalScale numericalScale5 = new Telerik.Reporting.NumericalScale();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report1));
            Telerik.Reporting.GraphGroup graphGroup6 = new Telerik.Reporting.GraphGroup();
            Telerik.Reporting.NumericalScale numericalScale6 = new Telerik.Reporting.NumericalScale();
            Telerik.Reporting.NumericalScale numericalScale7 = new Telerik.Reporting.NumericalScale();
            Telerik.Reporting.CategoryScale categoryScale3 = new Telerik.Reporting.CategoryScale();
            Telerik.Reporting.GraphGroup graphGroup2 = new Telerik.Reporting.GraphGroup();
            Telerik.Reporting.GraphTitle graphTitle4 = new Telerik.Reporting.GraphTitle();
            Telerik.Reporting.CategoryScale categoryScale4 = new Telerik.Reporting.CategoryScale();
            Telerik.Reporting.CategoryScaleCrossAxisPosition categoryScaleCrossAxisPosition3 = new Telerik.Reporting.CategoryScaleCrossAxisPosition();
            Telerik.Reporting.CategoryScaleCrossAxisPosition categoryScaleCrossAxisPosition4 = new Telerik.Reporting.CategoryScaleCrossAxisPosition();
            Telerik.Reporting.NumericalScale numericalScale8 = new Telerik.Reporting.NumericalScale();
            Telerik.Reporting.DataColumn dataColumn6 = new Telerik.Reporting.DataColumn();
            Telerik.Reporting.DataColumn dataColumn7 = new Telerik.Reporting.DataColumn();
            Telerik.Reporting.DataColumn dataColumn8 = new Telerik.Reporting.DataColumn();
            Telerik.Reporting.DataColumn dataColumn9 = new Telerik.Reporting.DataColumn();
            Telerik.Reporting.DataColumn dataColumn10 = new Telerik.Reporting.DataColumn();
            Telerik.Reporting.GraphGroup graphGroup7 = new Telerik.Reporting.GraphGroup();
            Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule();
            this.pageHeaderSection1 = new Telerik.Reporting.PageHeaderSection();
            this.detail = new Telerik.Reporting.DetailSection();
            this.pageFooterSection1 = new Telerik.Reporting.PageFooterSection();
            this.objectDataSource1 = new Telerik.Reporting.ObjectDataSource();
            this.graph1 = new Telerik.Reporting.Graph();
            this.cartesianCoordinateSystem1 = new Telerik.Reporting.CartesianCoordinateSystem();
            this.graphAxis2 = new Telerik.Reporting.GraphAxis();
            this.graphAxis1 = new Telerik.Reporting.GraphAxis();
            this.salesData = new Telerik.Reporting.SqlDataSource();
            this.lineSeries1 = new Telerik.Reporting.LineSeries();
            this.graphAxis3 = new Telerik.Reporting.GraphAxis();
            this.graphAxis4 = new Telerik.Reporting.GraphAxis();
            this.graphAxis5 = new Telerik.Reporting.GraphAxis();
            this.objectDataSource2 = new Telerik.Reporting.ObjectDataSource();
            this.objectDataSource3 = new Telerik.Reporting.ObjectDataSource();
            this.graph2 = new Telerik.Reporting.Graph();
            this.cartesianCoordinateSystem2 = new Telerik.Reporting.CartesianCoordinateSystem();
            this.graphAxis6 = new Telerik.Reporting.GraphAxis();
            this.graphAxis7 = new Telerik.Reporting.GraphAxis();
            this.csvDataSource1 = new Telerik.Reporting.CsvDataSource();
            this.lineSeries2 = new Telerik.Reporting.LineSeries();
            this.lineSeries3 = new Telerik.Reporting.LineSeries();
            this.barSeries1 = new Telerik.Reporting.BarSeries();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // pageHeaderSection1
            // 
            this.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.4D);
            this.pageHeaderSection1.Name = "pageHeaderSection1";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(9.5D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.graph1,
            this.graph2});
            this.detail.Name = "detail";
            // 
            // pageFooterSection1
            // 
            this.pageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.3D);
            this.pageFooterSection1.Name = "pageFooterSection1";
            // 
            // objectDataSource1
            // 
            this.objectDataSource1.CalculatedFields.AddRange(new Telerik.Reporting.CalculatedField[] {
            new Telerik.Reporting.CalculatedField("Field1", typeof(string), "Fields.Numerosucursal"),
            new Telerik.Reporting.CalculatedField("Field2", typeof(decimal), "Fields.TotalActual"),
            new Telerik.Reporting.CalculatedField("Field3", typeof(string), "Fields.Codigo_De_Sucursal"),
            new Telerik.Reporting.CalculatedField("Field4", typeof(string), "Fields.Nombre"),
            new Telerik.Reporting.CalculatedField("Field5", typeof(decimal), "Fields.TotalAnterior")});
            this.objectDataSource1.Name = "objectDataSource1";
            // 
            // graph1
            // 
            graphGroup5.Groupings.Add(new Telerik.Reporting.Grouping("=Fields.Field3"));
            graphGroup5.Name = "orderDateMonthGroup";
            graphGroup5.Sortings.Add(new Telerik.Reporting.Sorting("=Fields.Field3", Telerik.Reporting.SortDirection.Asc));
            this.graph1.CategoryGroups.Add(graphGroup5);
            colorPalette2.Colors.Add(System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(192)))), ((int)(((byte)(80)))), ((int)(((byte)(77))))));
            colorPalette2.Colors.Add(System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(128)))), ((int)(((byte)(100)))), ((int)(((byte)(162))))));
            colorPalette2.Colors.Add(System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(247)))), ((int)(((byte)(150)))), ((int)(((byte)(70))))));
            colorPalette2.Colors.Add(System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(119)))), ((int)(((byte)(44)))), ((int)(((byte)(42))))));
            colorPalette2.Colors.Add(System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))), ((int)(((byte)(98))))));
            colorPalette2.Colors.Add(System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(182)))), ((int)(((byte)(87)))), ((int)(((byte)(8))))));
            this.graph1.ColorPalette = colorPalette2;
            this.graph1.CoordinateSystems.Add(this.cartesianCoordinateSystem1);
            this.graph1.DataSource = null;
            this.graph1.Legend.Position = Telerik.Reporting.GraphItemPosition.BottomCenter;
            this.graph1.Legend.Style.LineColor = System.Drawing.Color.LightGray;
            this.graph1.Legend.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Cm(0D);
            this.graph1.Legend.Style.Visible = false;
            this.graph1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.508D), Telerik.Reporting.Drawing.Unit.Cm(0.254D));
            this.graph1.Name = "graph1";
            this.graph1.PlotAreaStyle.LineColor = System.Drawing.Color.LightGray;
            this.graph1.PlotAreaStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Cm(0D);
            this.graph1.Series.Add(this.lineSeries1);
            this.graph1.SeriesGroups.Add(graphGroup6);
            this.graph1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(14.5D), Telerik.Reporting.Drawing.Unit.Cm(5.5D));
            this.graph1.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(10D);
            this.graph1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(10D);
            this.graph1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(10D);
            this.graph1.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(10D);
            graphTitle3.Position = Telerik.Reporting.GraphItemPosition.TopLeft;
            graphTitle3.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            graphTitle3.Style.Font.Bold = false;
            graphTitle3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
            graphTitle3.Style.LineColor = System.Drawing.Color.LightGray;
            graphTitle3.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Cm(0D);
            graphTitle3.Text = "SALES VOLUME, MOUNTLY (in millions USD)";
            this.graph1.Titles.Add(graphTitle3);
            // 
            // cartesianCoordinateSystem1
            // 
            this.cartesianCoordinateSystem1.Name = "cartesianCoordinateSystem1";
            this.cartesianCoordinateSystem1.XAxis = this.graphAxis5;
            this.cartesianCoordinateSystem1.YAxis = this.graphAxis1;
            // 
            // graphAxis2
            // 
            this.graphAxis2.LabelFormat = "{0}";
            this.graphAxis2.MajorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis2.MajorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis2.MinorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis2.MinorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis2.MinorGridLineStyle.Visible = false;
            this.graphAxis2.Name = "graphAxis2";
            dateTimeScale2.BaseUnit = Telerik.Reporting.DateTimeScaleUnits.Months;
            this.graphAxis2.Scale = dateTimeScale2;
            this.graphAxis2.Title = "";
            this.graphAxis2.TitlePlacement = Telerik.Reporting.GraphAxisTitlePlacement.AtMaximum;
            // 
            // graphAxis1
            // 
            this.graphAxis1.LabelFormat = "{0:C2}";
            this.graphAxis1.MajorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis1.MajorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis1.MajorGridLineStyle.Visible = true;
            this.graphAxis1.MinorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis1.MinorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis1.MinorGridLineStyle.Visible = false;
            this.graphAxis1.Name = "graphAxis1";
            this.graphAxis1.Scale = numericalScale5;
            this.graphAxis1.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Cm(0D);
            this.graphAxis1.Style.Visible = true;
            this.graphAxis1.Title = "";
            this.graphAxis1.TitlePlacement = Telerik.Reporting.GraphAxisTitlePlacement.AtMaximum;
            // 
            // salesData
            // 
            this.salesData.ConnectionString = "My.MySettings.TelerikConnectionString";
            this.salesData.Name = "salesData";
            this.salesData.Parameters.AddRange(new Telerik.Reporting.SqlDataSourceParameter[] {
            new Telerik.Reporting.SqlDataSourceParameter("@country", System.Data.DbType.String, "=Parameters.country.Value"),
            new Telerik.Reporting.SqlDataSourceParameter("@year", System.Data.DbType.Int32, "=Parameters.year.Value"),
            new Telerik.Reporting.SqlDataSourceParameter("@category", System.Data.DbType.Int32, "=Parameters.category.Value")});
            this.salesData.SelectCommand = resources.GetString("salesData.SelectCommand");
            // 
            // lineSeries1
            // 
            this.lineSeries1.CategoryGroup = graphGroup5;
            this.lineSeries1.CoordinateSystem = this.cartesianCoordinateSystem1;
            this.lineSeries1.DataPointLabel = "=Sum(Fields.Field2)";
            this.lineSeries1.DataPointLabelStyle.Visible = false;
            this.lineSeries1.DataPointStyle.Visible = false;
            this.lineSeries1.LegendItem.Style.BackgroundColor = System.Drawing.Color.Transparent;
            this.lineSeries1.LegendItem.Style.LineColor = System.Drawing.Color.Transparent;
            this.lineSeries1.LegendItem.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Cm(0D);
            this.lineSeries1.LegendItem.Value = "=Fields.OrderDate.Year";
            this.lineSeries1.LineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.lineSeries1.MarkerMaxSize = Telerik.Reporting.Drawing.Unit.Pixel(50D);
            this.lineSeries1.MarkerMinSize = Telerik.Reporting.Drawing.Unit.Pixel(5D);
            this.lineSeries1.MarkerSize = Telerik.Reporting.Drawing.Unit.Pixel(5D);
            this.lineSeries1.MarkerType = Telerik.Reporting.DataPointMarkerType.Diamond;
            this.lineSeries1.Name = "lineSeries1";
            graphGroup6.Groupings.Add(new Telerik.Reporting.Grouping("=Fields.Field1"));
            graphGroup6.Name = "orderDateYearGroup";
            graphGroup6.Sortings.Add(new Telerik.Reporting.Sorting("=Fields.Field1", Telerik.Reporting.SortDirection.Asc));
            this.lineSeries1.SeriesGroup = graphGroup6;
            this.lineSeries1.Size = null;
            this.lineSeries1.Y = "=Sum(Fields.Field2)";
            // 
            // graphAxis3
            // 
            this.graphAxis3.MajorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis3.MajorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis3.MinorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis3.MinorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis3.MinorGridLineStyle.Visible = false;
            this.graphAxis3.Name = "GraphAxis1";
            this.graphAxis3.Scale = numericalScale6;
            // 
            // graphAxis4
            // 
            this.graphAxis4.MajorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis4.MajorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis4.MinorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis4.MinorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis4.MinorGridLineStyle.Visible = false;
            this.graphAxis4.Name = "GraphAxis2";
            this.graphAxis4.Scale = numericalScale7;
            // 
            // graphAxis5
            // 
            this.graphAxis5.MajorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis5.MajorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis5.MinorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis5.MinorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis5.MinorGridLineStyle.Visible = false;
            this.graphAxis5.Name = "GraphAxis1";
            this.graphAxis5.Scale = categoryScale3;
            // 
            // objectDataSource2
            // 
            this.objectDataSource2.CalculatedFields.AddRange(new Telerik.Reporting.CalculatedField[] {
            new Telerik.Reporting.CalculatedField("Field1", typeof(int), "Fields.Numerosucursal"),
            new Telerik.Reporting.CalculatedField("Field2", typeof(decimal), "Fields.TotalActual"),
            new Telerik.Reporting.CalculatedField("Field3", typeof(string), "Fields.Codigo_De_Sucursal"),
            new Telerik.Reporting.CalculatedField("Field4", typeof(string), "Fields.Nombre")});
            this.objectDataSource2.Name = "objectDataSource2";
            // 
            // objectDataSource3
            // 
            this.objectDataSource3.Name = "objectDataSource3";
            // 
            // graph2
            // 
            graphGroup2.Groupings.Add(new Telerik.Reporting.Grouping("= Fields.Codigo_De_Sucursal"));
            graphGroup2.Name = "itemGroup";
            graphGroup2.Sortings.Add(new Telerik.Reporting.Sorting("= Fields.Numerosucursal", Telerik.Reporting.SortDirection.Asc));
            this.graph2.CategoryGroups.Add(graphGroup2);
            this.graph2.CoordinateSystems.Add(this.cartesianCoordinateSystem2);
            this.graph2.DataSource = null;
            this.graph2.Legend.Style.LineColor = System.Drawing.Color.LightGray;
            this.graph2.Legend.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0D);
            this.graph2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.3D), Telerik.Reporting.Drawing.Unit.Inch(3D));
            this.graph2.Name = "graph2";
            this.graph2.PlotAreaStyle.LineColor = System.Drawing.Color.LightGray;
            this.graph2.PlotAreaStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0D);
            this.graph2.Series.Add(this.lineSeries2);
            this.graph2.Series.Add(this.lineSeries3);
            this.graph2.Series.Add(this.barSeries1);
            this.graph2.SeriesGroups.Add(graphGroup7);
            this.graph2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.5D), Telerik.Reporting.Drawing.Unit.Inch(3.3D));
            this.graph2.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(10D);
            this.graph2.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(10D);
            this.graph2.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(10D);
            this.graph2.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(10D);
            graphTitle4.Position = Telerik.Reporting.GraphItemPosition.TopCenter;
            graphTitle4.Style.LineColor = System.Drawing.Color.LightGray;
            graphTitle4.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0D);
            graphTitle4.Text = "graph1";
            this.graph2.Titles.Add(graphTitle4);
            // 
            // cartesianCoordinateSystem2
            // 
            this.cartesianCoordinateSystem2.Name = "cartesianCoordinateSystem1";
            this.cartesianCoordinateSystem2.XAxis = this.graphAxis6;
            this.cartesianCoordinateSystem2.YAxis = this.graphAxis7;
            // 
            // graphAxis6
            // 
            this.graphAxis6.MajorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis6.MajorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis6.MinorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis6.MinorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis6.MinorGridLineStyle.Visible = false;
            this.graphAxis6.Name = "graphAxis2";
            categoryScaleCrossAxisPosition3.Position = Telerik.Reporting.GraphScaleCrossAxisPosition.AtMaximum;
            categoryScaleCrossAxisPosition4.Position = Telerik.Reporting.GraphScaleCrossAxisPosition.AtMinimum;
            categoryScale4.CrossAxisPositions.Add(categoryScaleCrossAxisPosition3);
            categoryScale4.CrossAxisPositions.Add(categoryScaleCrossAxisPosition4);
            this.graphAxis6.Scale = categoryScale4;
            // 
            // graphAxis7
            // 
            this.graphAxis7.MajorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis7.MajorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis7.MinorGridLineStyle.LineColor = System.Drawing.Color.LightGray;
            this.graphAxis7.MinorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.graphAxis7.MinorGridLineStyle.Visible = false;
            this.graphAxis7.Name = "GraphAxis2";
            this.graphAxis7.Scale = numericalScale8;
            // 
            // csvDataSource1
            // 
            dataColumn6.Name = "Numerosucursal";
            dataColumn7.Name = "TotalActual";
            dataColumn7.Type = Telerik.Reporting.SimpleType.Integer;
            dataColumn8.Name = "Codigo_De_Sucursal";
            dataColumn9.Name = "Nombre";
            dataColumn10.Name = "TotalAnterior";
            dataColumn10.Type = Telerik.Reporting.SimpleType.Integer;
            this.csvDataSource1.Columns.Add(dataColumn6);
            this.csvDataSource1.Columns.Add(dataColumn7);
            this.csvDataSource1.Columns.Add(dataColumn8);
            this.csvDataSource1.Columns.Add(dataColumn9);
            this.csvDataSource1.Columns.Add(dataColumn10);
            this.csvDataSource1.FieldSeparators = new char[] {
        ','};
            this.csvDataSource1.HasHeaders = true;
            this.csvDataSource1.Name = "csvDataSource1";
            this.csvDataSource1.RecordSeparators = new char[] {
        '\r',
        '\n'};
            this.csvDataSource1.Source = resources.GetString("csvDataSource1.Source");
            // 
            // lineSeries2
            // 
            this.lineSeries2.CategoryGroup = graphGroup2;
            this.lineSeries2.CoordinateSystem = this.cartesianCoordinateSystem2;
            this.lineSeries2.DataPointLabel = "= Sum(Fields.TotalActual)";
            this.lineSeries2.DataPointLabelStyle.Visible = false;
            this.lineSeries2.DataPointStyle.Visible = true;
            this.lineSeries2.LegendItem.Value = "\'Sum(TotalAnterior)\'";
            this.lineSeries2.LineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.lineSeries2.MarkerMaxSize = Telerik.Reporting.Drawing.Unit.Pixel(50D);
            this.lineSeries2.MarkerMinSize = Telerik.Reporting.Drawing.Unit.Pixel(5D);
            this.lineSeries2.MarkerSize = Telerik.Reporting.Drawing.Unit.Pixel(5D);
            this.lineSeries2.MissingValuesLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.lineSeries2.MissingValuesLineStyle.Visible = false;
            this.lineSeries2.Name = "lineSeries1";
            graphGroup7.Name = "seriesGroup";
            this.lineSeries2.SeriesGroup = graphGroup7;
            this.lineSeries2.Size = null;
            this.lineSeries2.Y = "= Sum(Fields.TotalActual)";
            // 
            // lineSeries3
            // 
            this.lineSeries3.CategoryGroup = graphGroup2;
            this.lineSeries3.CoordinateSystem = this.cartesianCoordinateSystem2;
            this.lineSeries3.DataPointLabel = "= Sum(Fields.TotalAnterior)";
            this.lineSeries3.DataPointLabelStyle.Visible = false;
            this.lineSeries3.DataPointStyle.Visible = false;
            this.lineSeries3.LegendItem.Value = "\'Sum(TotalActual)\'";
            this.lineSeries3.LineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.lineSeries3.MarkerMaxSize = Telerik.Reporting.Drawing.Unit.Pixel(50D);
            this.lineSeries3.MarkerMinSize = Telerik.Reporting.Drawing.Unit.Pixel(5D);
            this.lineSeries3.MarkerSize = Telerik.Reporting.Drawing.Unit.Pixel(5D);
            this.lineSeries3.MissingValuesLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.lineSeries3.MissingValuesLineStyle.Visible = false;
            this.lineSeries3.Name = "lineSeries2";
            this.lineSeries3.SeriesGroup = graphGroup7;
            this.lineSeries3.Size = null;
            this.lineSeries3.Y = "= Sum(Fields.TotalAnterior)";
            // 
            // barSeries1
            // 
            this.barSeries1.CategoryGroup = graphGroup2;
            this.barSeries1.CoordinateSystem = this.cartesianCoordinateSystem2;
            this.barSeries1.DataPointLabelConnectorStyle.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Point(2D);
            this.barSeries1.DataPointLabelConnectorStyle.Padding.Top = Telerik.Reporting.Drawing.Unit.Point(2D);
            this.barSeries1.DataPointLabelConnectorStyle.Visible = false;
            this.barSeries1.SeriesGroup = graphGroup7;
            this.barSeries1.Y = "= Fields.TotalActual";
            // 
            // Report1
            // 
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.pageHeaderSection1,
            this.detail,
            this.pageFooterSection1});
            this.Name = "Report1";
            this.PageSettings.ContinuousPaper = false;
            this.PageSettings.Landscape = false;
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Cm(0.5D), Telerik.Reporting.Drawing.Unit.Cm(0.5D), Telerik.Reporting.Drawing.Unit.Cm(0.5D), Telerik.Reporting.Drawing.Unit.Cm(0.5D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            styleRule2.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.TextItemBase)),
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.HtmlTextBox))});
            styleRule2.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule2.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2D);
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule2});
            this.UnitOfMeasure = Telerik.Reporting.Drawing.UnitType.Inch;
            this.Width = Telerik.Reporting.Drawing.Unit.Cm(20.5D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.PageHeaderSection pageHeaderSection1;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.PageFooterSection pageFooterSection1;
        private Telerik.Reporting.ObjectDataSource objectDataSource1;
        internal Telerik.Reporting.CartesianCoordinateSystem cartesianCoordinateSystem1;
        internal Telerik.Reporting.GraphAxis graphAxis2;
        internal Telerik.Reporting.GraphAxis graphAxis1;
        internal Telerik.Reporting.LineSeries lineSeries1;
        internal Telerik.Reporting.SqlDataSource salesData;
        public Telerik.Reporting.Graph graph1;
        private Telerik.Reporting.GraphAxis graphAxis4;
        private Telerik.Reporting.GraphAxis graphAxis3;
        private Telerik.Reporting.GraphAxis graphAxis5;
        private Telerik.Reporting.ObjectDataSource objectDataSource2;
        private Telerik.Reporting.ObjectDataSource objectDataSource3;
        private Telerik.Reporting.Graph graph2;
        private Telerik.Reporting.CartesianCoordinateSystem cartesianCoordinateSystem2;
        private Telerik.Reporting.GraphAxis graphAxis6;
        private Telerik.Reporting.GraphAxis graphAxis7;
        private Telerik.Reporting.LineSeries lineSeries2;
        private Telerik.Reporting.LineSeries lineSeries3;
        private Telerik.Reporting.BarSeries barSeries1;
        private Telerik.Reporting.CsvDataSource csvDataSource1;
    }
}