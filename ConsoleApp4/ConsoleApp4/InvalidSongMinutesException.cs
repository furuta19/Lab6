using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class InvalidSongMinutesException : Exception
    {
        public InvalidSongMinutesException(string message)
            : base(message)
        {
        }
    }
}
