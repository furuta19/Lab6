using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class InvalidSongNameException : Exception
    {
        public InvalidSongNameException(string message)
            : base(message)
        {
        }
    }
}
