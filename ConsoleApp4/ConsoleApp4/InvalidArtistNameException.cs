using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class InvalidArtistNameException : Exception
    {
        public InvalidArtistNameException(string message)
            : base(message)
        {
        }
    }
}
