using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class InvalidSongSecondsException : Exception
    {
        public InvalidSongSecondsException(string message)
            : base(message)
        {
        }
    }
}
