using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OresDatabase.Model.Attributes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
    internal class FieldNameAttribute : Attribute
    {
        public string FieldName { get; }
        public FieldNameAttribute(string fieldName) => FieldName = fieldName;
    }
}
