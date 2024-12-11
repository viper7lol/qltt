using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlytrongtrot.Controllers
{
    internal class BaseController : System.MVC.Controller
    {
        public virtual object Index() => View();
    }
}
