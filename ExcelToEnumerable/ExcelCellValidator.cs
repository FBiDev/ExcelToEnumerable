using System;
using ExcelToEnumerable.Exceptions;

namespace ExcelToEnumerable
{
    public class ExcelCellValidator
    {
        public string Message { get; set; }
        
        public Func<object, bool> Validator { get; set; }
        
        public ExcelToEnumerableValidationCode? ExcelToEnumerableValidationCode { get; set; }
    }
}