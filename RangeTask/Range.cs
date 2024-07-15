namespace RangeTask
{
    public class Range
    {
        public double From { get; set; }

        public double To { get; set; }

        public double From2 { get; set; }

        public double To2 { get; set; }


        public Range(double from, double to)
        {
            From = from;
            To = to;
        }

        public Range(double from1, double to1, double from2, double to2)
        {
            From = from1;
            To = to1;
            From2 = from2;
            To2 = to2;
        }

        public double GetRangeLength()
        {
            return To - From;
        }

        public bool IsInside(double inputNumber)
        {
            if (inputNumber >= From && inputNumber <= To)
            {
                return true;
            }

            return false;
        }

        public Range GetRangeIntersection()
        {
            if (To > From2)
            {
                return new Range(From2, To);
            }

            return null;
        }

        public Range[] GetRangeUnion()
        {
            if (To >= From2)
            {
                return new Range[] { new Range(From, To2) };
            }

            return new Range[] { new Range(From, To), new Range(From2, To2) };
        }

        public Range[] GetRangeDifference()
        {
            if (From == From2 && To == To2)
            {
                return new Range[] { new Range(0, 0) };
            }
            else if (From2 < To)
            {
                return new Range[] { new Range(From, From2) };
            }
            else if (From2 > From && To2 < To)
            {
                return new Range[] { new Range(From, From2), new Range(To2, To) };
            }

            return null;
        }
    }
}
