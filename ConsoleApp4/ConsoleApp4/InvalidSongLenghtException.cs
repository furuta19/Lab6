using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class InvalidSongLenghtException : Exception
    {
        public InvalidSongLenghtException(string message)
            : base(message)
        {
        }
    }
}
