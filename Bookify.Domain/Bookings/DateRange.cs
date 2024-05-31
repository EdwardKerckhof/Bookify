namespace Bookify.Domain.Bookings;

public record DateRange
{
    private DateRange() { }

    public DateOnly Start { get; private init; }

    public DateOnly End { get; private init; }

    public int LengthInDays => End.DayNumber - Start.DayNumber;

    public static DateRange Create(DateOnly start, DateOnly end)
    {
        if (start > end)
        {
            throw new ArgumentException("Start date must be before end date.");
        }

        return new DateRange { Start = start, End = end };
    }
}