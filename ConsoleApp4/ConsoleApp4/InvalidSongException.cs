using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class InvalidSongException : Exception
    {
        public InvalidSongException(string message)
            : base(message)
        {
        }
    }
}
