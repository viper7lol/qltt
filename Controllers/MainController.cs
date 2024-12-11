using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace Quanlytrongtrot.Controllers
{
    internal class MainController:BaseController
    {
        public MainController()
        {
            LoginWindow login = new LoginWindow();
            login.ShowDialog();
        }
    }
}
