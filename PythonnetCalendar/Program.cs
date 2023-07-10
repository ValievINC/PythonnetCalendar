using System;
using System.Text;
using Python.Runtime;
using Aveva.Core.PMLNet;


namespace AquaLibCsharp
{
    [PMLNetCallable]
    public partial class Calendar : System.Windows.Forms.UserControl
    {
        [PMLNetCallable]
        public static void Main(string[] args)
        {
            Environment.SetEnvironmentVariable("PYTHONNET_PYDLL", "C:\\Users\\std\\AppData\\Local\\Programs\\Python\\Python311-32\\Python311");
            PythonEngine.Initialize();

            using (Py.GIL())
            {
                string filePath = "calendar.py";
                string fileContent = System.IO.File.ReadAllText(filePath, Encoding.UTF8);
                PythonEngine.Exec(fileContent);
            }
            PythonEngine.Shutdown();
        }
    }
}