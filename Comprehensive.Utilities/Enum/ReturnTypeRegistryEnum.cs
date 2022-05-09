using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comprehensive.Utilities.Enum
{
    public enum ReturnTypeRegistryEnum
    {
        [Description("None")]
        None = 0,

        [Description("Included succesfully")]
        IncludedSuccessfully = 1,

        [Description("Not Included")]
        NotIncluded = 2,

        [Description("Error while trying to access the internet")]
        ExceptionInclude = 3,

        [Description("Error while trying to access the internet")]
        ExceptionIncludeChange = 4,

        [Description("Altered succesfully")]
        AlteredSuccessfully = 5,

        [Description("Not Altered")]
        NotAltered = 6,

        [Description("Error while trying to access the internet")]
        ExceptionAlter = 7,

        [Description("Error while trying to access the internet")]
        ExceptionAlterChange = 8,
    }
}
