using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mod5Demo.Models
{
    public interface IFormat
    {
        string GetFormattedNumber(int number);
    }
    public class FormatNumber : IFormat
    {
        public string GetFormattedNumber(int number)
        {
            return string.Format("{0:n0}", number);
        }
    }
}
