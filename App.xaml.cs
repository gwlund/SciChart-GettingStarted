using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using SciChart.Charting.Visuals;

namespace SciChart_GettingStarted
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            SetSciChartLicense();

        }

        public static void SetSciChartLicense()
        {
            SciChart.Charting.Visuals.SciChartSurface.SetRuntimeLicenseKey("OxZCHORjkAR9Yqe7fdwYVSW+4X3AGMqW/WqlD4G5hzhtA5U1IBi9h2k0oCsplAVZ/iYr19RCHsDlLsEmNP+Kv49q4uPWsyBa525+WcOJE+l4zF233xsuy5Pn9zAkEVzN6H9mKExK93Ao1b9xJcrfK6mMA7d/WFOPGX/dL/rmzw0+LSh3vAPtw1+U5p2Yo7W0SxPLmDkH0I40nTHim0AoEfopr/wD8mHluLqQcrjCQGG8G1dWuJ2Pbpkw18xHzWtJ0QkxUrer3Xe+yIgTC1nQxxObLyZfgzJwls+1XivHORmW7efcxFyS9d70q6/6s6EQctUOx2vAL/FX2624z0wT9qQTCIoI1i6wkKgmzSXaMIkAyqEdESKqeFYT98PMz+RQtOIU4DzJ+YNsgVNBLV4/ZhvZGpuhH1/BJQgAO0HHJFiWG3PaSLIit83uGK1FVEJoMqPIMauWVTNequEr7qPC3uw3oHHLV3gFUUCtTdQ3RZO1d9OqWPWoFAWR74Rsn22LbRRJK074bZv6u+Uycf3vLDi1");
        }
    }

}
