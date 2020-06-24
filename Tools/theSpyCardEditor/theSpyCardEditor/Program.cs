using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace theSpyCardEditor
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            TestSimulation.TestBooleenCondition();
            TestSimulation.TestLabel();
            TestSimulation.TestReturnTextFromLabels();

            FileMethods.GeneralCheck();
            FileMethods.CheckAndLoadPreferences();
            EditorProperties.CurrentIdLanguage = (ELanguage)UserPreferences.LANGUAGE_USED;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
