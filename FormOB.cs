using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    public enum FormOB
    {
        /// <summary>
        /// очная
        /// </summary>
        [Description("очная")]
        fulltime,
        /// <summary>
        /// Женский
        /// </summary>
        [Description("Заочная")]
        correspondence,
    }
}
