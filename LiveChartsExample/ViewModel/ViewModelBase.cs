using NLog;
using Stylet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveChartsExample.ViewModel
{
    public class ViewModelBase : Screen
    {
        /// <summary>
        /// Logger
        /// </summary>
        protected static readonly ILogger Logger = LogManager.GetCurrentClassLogger();
    }
}