namespace RangeTask
{
    public class Range
    {
        private double _from;
        private double _to;

        public Range(double from, double to)
        {
            _from = from;
            _to = to;
        }

        public double GetFrom()
        {
            return _from;
        }

        public void SetFrom(double from)
        {
            _from = from;
        }

        public double GetTo()
        {
            return _to;
        }

        public void SetTo(double to)
        {
            _to = to;
        }

        public double GetRangeLength()
        {
            return _to - _from;
        }

        public bool IsInside(double inputNumber)
        {
            if (inputNumber >= _from && inputNumber <= _to)
            {
                return true;
            }

            return false;
        }
    }
}
