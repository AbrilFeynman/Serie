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


            DataTable crud = new DataTable();
            crud = GetDates();
            DataTable detalle = new DataTable();
            detalle = GetDetalle();

          

            //FUSIONAR LAS DOS TABLAS ANTERIOR Y ACTUAL
            // DataTable tablaMen = Gw




            var query = from table1 in crud.AsEnumerable()
                        join table2 in detalle.AsEnumerable()
                        on table1.Field<int>("Date") equals
                        table2.Field<int>("Dia")
                        select new
                        {
                            Dia = table1.Field<int>("Date"),
                            Codigo_De_Sucursal = table2.Field<string>("Codigo_De_Sucursal"),
                            Total = table2.Field<decimal>("Total"),
                            Fecha = table2.Field<DateTime>("Fecha"),
                           
                        };

                       var lstLeftJoin =
                           from fact in crud.AsEnumerable()
                           join desc in detalle.AsEnumerable() on fact.Field<int>("Date") equals desc.Field<int>("Dia") into FactDesc
                            from fd in FactDesc.DefaultIfEmpty()
                            select new
                            {
                                Dia = fact.Field<int>("Date"),
                                Total = (fd == null) ?  0 : fd.Field<decimal>("Total")
                                


                            }
                           ;







            DataTable nueva = new DataTable();
            nueva.Columns.Add("Date", typeof(int));
            nueva.Columns.Add("Total", typeof(decimal));







            foreach (var item in lstLeftJoin)
            {
                //un if de que si no hay registro se guarde cero :v
                nueva.Rows.Add(item.Dia, item.Total);

            }


            int osoKrasny = 1;
            //aqui manda al rpt 

        }

        public DataTable GetDates()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Date", typeof(Int32));

            int year = 2019;
            int month = 2;

            int daysInMonth = DateTime.DaysInMonth(year, month);
            for (int i = 0; i < daysInMonth; i++)
            {
                DataRow dr = dt.NewRow();
                dr["Date"] = i + 1;
                dt.Rows.Add(dr);
            }

            return dt;
        }


        static DataTable GetDetalle()
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




            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Codigo_De_Sucursal,SUM(Total)as Total, Fecha_Del_Documento as Fecha, Day(Fecha_Del_Documento) as Dia " +
                "FROM dbo.fncReporteadorDeVentas() fncReporteadorDeVentas WHERE month(Fecha_Del_Documento) = 02 and year(Fecha_Del_Documento) = 2019 " +
                "and(Numero_Corto_De_Sucursal in (7)) group by Fecha_Del_Documento, Codigo_De_Sucursal ", sqlconn);
            DataSet dsPubs = new DataSet("Pubs");
            adapter.Fill(dsPubs, "Vista");
            DataTable dtbl = new DataTable();

            dtbl = dsPubs.Tables["Vista"];
            sqlconn.Close();

            return dtbl;

        }
        static DataTable GetVentasActual2()
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




            SqlDataAdapter adapter = new SqlDataAdapter(" SELECT    CASE WHEN Numero_Corto_De_Sucursal = 55 THEN 05 ELSE Numero_Corto_De_Sucursal END AS Numerosucursal, SUM(Total) AS TotalActual, CASE WHEN Codigo_De_Sucursal = 'B1' THEN 'B01' WHEN Codigo_De_Sucursal = 'B2' THEN 'B02' WHEN Codigo_De_Sucursal = 'B3' THEN 'B03' WHEN Codigo_De_Sucursal = 'B4' THEN 'B04' WHEN Codigo_De_Sucursal = 'B8' THEN 'B08' WHEN Codigo_De_Sucursal = 'B9' THEN 'B09' ELSE Codigo_De_Sucursal END AS Codigo_De_Sucursal , Sucursal as Nombre  FROM dbo.fncReporteadorDeVentas() fncReporteadorDeVentas WHERE(Fecha_Del_Documento BETWEEN CONVERT(DATETIME, '05/02/2018 00:00:00', 102)  AND CONVERT(DATETIME, '05/02/2018 00:00:00', 102)) and (Numero_Corto_De_Sucursal not in(7,11,17)) GROUP BY Numero_Corto_De_Sucursal, Codigo_De_Sucursal, Sucursal order by Numerosucursal asc ", sqlconn);
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
