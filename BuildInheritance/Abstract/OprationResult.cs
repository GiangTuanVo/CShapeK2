using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildInheritance.Abstract
{
    struct DataType
    {

    }
    public class OprationResult
    {
        /// <summary>
        /// Indicates whether this operation was successful.
        /// </summary>
        public bool IsSuccess { get; set; } = default;

        /// <summary>
        /// Specific error description.
        /// </summary>
        public string Message { get; set; } = default;

        /// <summary>
        /// The specific error code.
        /// </summary>
        public int ErrorCode { get; set; } = default;
        /// <summary>
        /// The specific result.
        /// </summary>
        public string Result { get; set; } = default;
    }
}
