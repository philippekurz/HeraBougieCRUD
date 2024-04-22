using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using System.Windows;

namespace HeraBougieCRUD
{

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        // Lire la configuration (dsn)
        private static string _dsn = ConfigurationManager.ConnectionStrings["hbConnexionString"].ToString();
        public static MySqlConnection _connexion = new MySqlConnection(_dsn); // connection

    }

}
