using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitLabSniffer
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;
            Application.Run(new mainWindow());
        }

        private static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            switch (args.Name.Split(',')[0])
            {
                case "Newtonsoft.Json":
                    using (var jsonDLL = Assembly.GetExecutingAssembly().GetManifestResourceStream("GitLabSniffer.Newtonsoft.Json.dll"))
                    {
                        byte[] assemblyData = new byte[jsonDLL.Length];
                        jsonDLL.Read(assemblyData, 0, assemblyData.Length);
                        return Assembly.Load(assemblyData);
                    }

                case "ClosedXML":
                    using (var jsonDLL = Assembly.GetExecutingAssembly().GetManifestResourceStream("GitLabSniffer.ClosedXML.dll"))
                    {
                        byte[] assemblyData = new byte[jsonDLL.Length];
                        jsonDLL.Read(assemblyData, 0, assemblyData.Length);
                        return Assembly.Load(assemblyData);
                    }

                case "DocumentFormat.OpenXml":
                    using (var jsonDLL = Assembly.GetExecutingAssembly().GetManifestResourceStream("GitLabSniffer.DocumentFormat.OpenXml.dll"))
                    {
                        byte[] assemblyData = new byte[jsonDLL.Length];
                        jsonDLL.Read(assemblyData, 0, assemblyData.Length);
                        return Assembly.Load(assemblyData);
                    }

                case "ExcelNumberFormat":
                    using (var jsonDLL = Assembly.GetExecutingAssembly().GetManifestResourceStream("GitLabSniffer.ExcelNumberFormat.dll"))
                    {
                        byte[] assemblyData = new byte[jsonDLL.Length];
                        jsonDLL.Read(assemblyData, 0, assemblyData.Length);
                        return Assembly.Load(assemblyData);
                    }
            }

            return null;
        }
    }
}
