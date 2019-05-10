﻿namespace AssertAll.Exceptions
{
    internal class AssertAllInconclusiveException : AssertAllException
    {
        internal AssertAllInconclusiveException(string message, string stackTrace) : base(message, stackTrace)
        {
        }
        
        //public override string StackTrace => OldStackTrace;
    }
}