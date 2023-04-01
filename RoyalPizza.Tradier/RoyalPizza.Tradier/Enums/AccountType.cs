using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalPizza.Tradier.Enums
{
    /// <summary>
    /// 
    /// </summary>
    public enum AccountType
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("Margin")]
        Margin = 1,

        /// <summary>
        /// 
        /// </summary>
        [Description("Cash")]
        Cash,
        
        /// <summary>
        /// 
        /// </summary>
        [Description("Pattern Day Trader")]
        PDT
    }
}
