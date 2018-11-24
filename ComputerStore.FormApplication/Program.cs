using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerStore.FormApplication
{
    static class Program
    {
        private static LogInForm logInForm;
        public static LogInForm LogInForm { get; }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            logInForm = new LogInForm();
            Application.Run(logInForm);
        }
    }
}
