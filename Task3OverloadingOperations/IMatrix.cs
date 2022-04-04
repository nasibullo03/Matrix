using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3OverloadingOperations
{
    internal interface IMatrix
    {
        int Size { get; set; }
        int[,] Value { get; set; }
    }
}