using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Serie
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataTable tablaVentas = GetVentasActual();
            DataTable tblventasanterior = GetVentasAnterior();
            var query = from table1 in tablaVentas.AsEnumerable()
                        join table2 in tblventasanterior.AsEnumerable()
                        on table1.Field<int>("Numerosucursal") equals
                        table2.Field<int>("Numerosucursal")
                        select new
                        {
                            Numerosucursal = table1.Field<int>("Numerosucursal"),
                            TotalActual = table1.Field<decimal>("TotalActual"),
                            Codigo_De_Sucursal = table1.Field<string>("Codigo_De_Sucursal"),
                            Nombre = table1.Field<string>("Nombre"),
                            TotalAnterior = table2.Field<decimal>("TotalAnterior"),
                        };
            DataTable nueva = new DataTable();
            nueva.Columns.Add("Numerosucursal", typeof(int));
            nueva.Columns.Add("TotalActual", typeof(decimal));
            nueva.Columns.Add("Codigo_De_Sucursal", typeof(string));
            nueva.Columns.Add("Nombre", typeof(string));
            nueva.Columns.Add("TotalAnterior", typeof(decimal));


            foreach (var item in query)
            {
                nueva.Rows.Add(item.Numerosucursal, item.TotalActual, item.Codigo_De_Sucursal, item.Nombre, item.TotalAnterior);

            }
            Report1 fac = new Report1(nueva);




        }


        static DataTable GetVentasActual()
        {



            string conect = "SERVER = 192.168.200.1; DATABASE = Punto_De_Venta; USER ID = sa; PASSWORD = dgo2007 ";

            SqlConnection sqlconn = new SqlConnection(conect);
            try
            {
                sqlconn.Open();
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR DE CONEXION" + ex.Message);
            }




            SqlDataAdapter adapter = new SqlDataAdapter(" SELECT    CASE WHEN Numero_Corto_De_Sucursal = 55 THEN 05 ELSE Numero_Corto_De_Sucursal END AS Numerosucursal, SUM(Total) AS TotalActual, CASE WHEN Codigo_De_Sucursal = 'B1' THEN 'B01' WHEN Codigo_De_Sucursal = 'B2' THEN 'B02' WHEN Codigo_De_Sucursal = 'B3' THEN 'B03' WHEN Codigo_De_Sucursal = 'B4' THEN 'B04' WHEN Codigo_De_Sucursal = 'B8' THEN 'B08' WHEN Codigo_De_Sucursal = 'B9' THEN 'B09' ELSE Codigo_De_Sucursal END AS Codigo_De_Sucursal , Sucursal as Nombre  FROM dbo.fncReporteadorDeVentas() fncReporteadorDeVentas WHERE(Fecha_Del_Documento BETWEEN CONVERT(DATETIME, '05/02/2019 00:00:00', 102)  AND CONVERT(DATETIME, '05/02/2019 00:00:00', 102)) and (Numero_Corto_De_Sucursal not in(7,11,17)) GROUP BY Numero_Corto_De_Sucursal, Codigo_De_Sucursal, Sucursal order by Numerosucursal asc ", sqlconn);
            DataSet dsPubs = new DataSet("Pubs");
            adapter.Fill(dsPubs, "Vista");
            DataTable dtbl = new DataTable();

            dtbl = dsPubs.Tables["Vista"];
            sqlconn.Close();

            return dtbl;

        }
        static DataTable GetVentasAnterior()
        {



            string conect = "SERVER = 192.168.200.1; DATABASE = Punto_De_Venta; USER ID = sa; PASSWORD = dgo2007 ";

            SqlConnection sqlconn = new SqlConnection(conect);
            try
            {
                sqlconn.Open();
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR DE CONEXION" + ex.Message);
            }




            SqlDataAdapter adapter = new SqlDataAdapter("SELECT    CASE WHEN Numero_Corto_De_Sucursal = 55 THEN 05 ELSE Numero_Corto_De_Sucursal END AS Numerosucursal, SUM(Total) AS TotalAnterior  FROM dbo.fncReporteadorDeVentas() fncReporteadorDeVentas WHERE(Fecha_Del_Documento BETWEEN CONVERT(DATETIME, '05/02/2018 00:00:00', 102)  AND CONVERT(DATETIME, '05/02/2018 00:00:00', 102)) and (Numero_Corto_De_Sucursal not in(7,10,11,17)) GROUP BY Numero_Corto_De_Sucursal, Codigo_De_Sucursal, Sucursal order by Numerosucursal asc ", sqlconn);
            DataSet dsPubs = new DataSet("Pubs");
            adapter.Fill(dsPubs, "Vista");
            DataTable dtbl = new DataTable();

            dtbl = dsPubs.Tables["Vista"];
            sqlconn.Close();

            return dtbl;

        }


    }
}
