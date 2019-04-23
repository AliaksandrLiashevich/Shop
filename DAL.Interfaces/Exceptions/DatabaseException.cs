﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces.Exceptions
{
    public class DatabaseException : Exception
    {
        public ErrorType Error { get; set; }

        public DatabaseException(ErrorType errorType)
        {
            Error = errorType;
        }

        public DatabaseException(ErrorType errorType, string message) : base(message)
        {
            Error = errorType;
        }

        public DatabaseException(ErrorType errorType, string message, Exception innerException) : base(message, innerException)
        {
            Error = errorType;
        }

        public enum ErrorType
        {
            WrongId,
            InvalidArgument
        }
    }
}