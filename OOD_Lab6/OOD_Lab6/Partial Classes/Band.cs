using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Lab6
{
    /// <summary>
    /// Extends the Band class
    /// </summary>
    public partial class Band
    {

        /// <summary>
        /// Overrides the tostring method of the parent class
        /// </summary>
        /// <returns>Returns the name of of the album as a string</returns>
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
