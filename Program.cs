using CalculatorApp.Business.Services;
using CalculatorApp.Data.Repositories;
using CalculatorApp.UI.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp.UI
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Dependency Injection setup
            var repository = new CalculationRepository();
            var calculatorService = new CalculatorService(repository);

            Application.Run(new Mainform(calculatorService));
        }
    }
}
