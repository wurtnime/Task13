using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Tasks
{
    public class Task29
    {
        public string Execute(string positiveBinary, string negativeBinary)
        {
            int positiveDecimal = Convert.ToInt32(positiveBinary, 2);
            int negativeDecimal = Convert.ToInt32(negativeBinary, 2);

            int sum = positiveDecimal + negativeDecimal;
            string sumBinary = Convert.ToString(sum, 2);

            return $"Сумма: {sumBinary} (десятичное: {sum})";
        }
    }
}