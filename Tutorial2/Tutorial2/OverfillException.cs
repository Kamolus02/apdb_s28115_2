﻿using System;

namespace Tutorial2
{
    public class OverfillException : Exception
    {
        public OverfillException(string message) : base(message)
        {
        }
    }
}