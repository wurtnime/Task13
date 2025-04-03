using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace WpfApp.Tasks
{
    public class Task11
    {
        public string Execute(int[] array)
        {
            var result = array.Where(x => array.Count(y => y == x) <= 2).ToArray();
            return $"Массив после удаления: {string.Join(" ", result)}";
        }
    }
}
