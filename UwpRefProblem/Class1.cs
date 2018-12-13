using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
namespace TestBuildRefs
{

    public class DataErrorI : IDataErrorInfo
    {
        public string Error { get; }

        public string this[string columnName] => throw new NotImplementedException();
    }
}
