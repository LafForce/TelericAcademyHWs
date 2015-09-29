namespace RangeExceptions
{
    using System;

    class InvalidRangeException<T> : ApplicationException
    {
        private T start;
        private T end;

        public InvalidRangeException(string msg)
            : base(msg)
        { }

        public InvalidRangeException(string msg, Exception innerEx)
            : base(msg, innerEx)
        { }

        public InvalidRangeException(string msg, T start, T end)
            : base(msg)
        {
            this.start = start;
            this.end = end;
        }
        public T Start
        {
            get { return this.start; }
            set { this.start = value; }
        }

        public T End
        {
            get { return this.end; }
            set { this.end = value; }
        }

    }
}
