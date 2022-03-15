using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Task6_7_
{
    public partial class OrdUpdate : Window
    {
        public OrdUpdate()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string sql = $"UPDATE Orders SET Commodity = '{TextBoxStuff.Text}', Number = '{Convert.ToInt32(TextBoxCount.Text)}', Limit = '{Convert.ToInt32(TextBoxLimit.Text)}'  WHERE IdCs = '{Convert.ToInt32(TextBoxId.Text)}'";
            SqlConnection sqlConn = new SqlConnection(@"Data Source=DESKTOP-AB9A3BT\SQLEXPRESS;Initial Catalog=HomeWork;Integrated Security=True");
            sqlConn.Open();
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConn);
            sqlCommand.ExecuteNonQuery();
            sqlConn.Close();
            MainWindow mainWindow = new MainWindow();

            mainWindow.Show();
            this.Close();
        }
    }
}
