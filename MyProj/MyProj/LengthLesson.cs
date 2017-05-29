using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace MyProj
{
    public class LengthLesson : IDataErrorInfo
    { 
        public int Time { get; set; }
        public string this[string columnName]
        {
            get
            {
                string error = String.Empty;
                switch (columnName)
                {
                    case "Time":
                        if ((Time < 0) || (Time > 100))
                        {
                            error = "Длительность пары должна быть положительна и меньше ста";
                        }
                        break;
                }
                return error;
            }
        }
        public string Error
        {
            get { throw new NotImplementedException(); }
        }
    }
}
