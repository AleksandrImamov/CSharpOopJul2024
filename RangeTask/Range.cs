using System;

namespace RangeTask;

public class Range
{
    public double From { get; set; }

    public double To { get; set; }

    public Range(double from, double to)
    {
        From = from;
        To = to;
    }

    public double GetLength()
    {
        return To - From;
    }

    public bool IsInside(double number)
    {
        return number >= From && number <= To;
    }

    public Range? GetIntersection(Range range)
    {
        if (this.From < range.From && this.To > range.To)
        {
            return new Range(range.From, range.To);
        }

        if (this.From > range.From && this.To < range.To)
        {
            return new Range(this.From, this.To);
        }

        if (this.To > range.From)
        {
            return new Range(range.From, this.To);
        }

        if (this.From > range.From)
        {
            return new Range(this.From, range.To);
        }

        return null;
    }

    public Range[]? GetUnion(Range range)
    {
        if (this.From <= range.From && this.To >= range.To)
        {
            return new Range[] { new Range(this.From, this.To) };
        }

        if (this.From >= range.From && this.To <= range.To)
        {
            return new Range[] { new Range(range.From, range.To) };
        }

        if (this.To >= range.From)
        {
            return new Range[] { new Range(this.From, range.To) };
        }

        if (this.From >= range.From)
        {
            return new Range[] { new Range(range.From, this.To) };
        }

        return null;
    }

    public Range[]? GetDifference(Range range)
    {
        if (this.From < range.From && this.To > range.To)
        {
            return new Range[] { new Range(this.From, range.From), new Range(range.To, this.To) };
        }

        if (this.From < range.From)
        {
            return new Range[] { new Range(this.From, range.From) };
        }

        if (this.To > range.To)
        {
            return new Range[] { new Range(range.To, this.To) };
        }

        return new Range[] { };
    }

    public override string ToString()
    {
        return this.From + ", " + this.To;
    }
}

