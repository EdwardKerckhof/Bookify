﻿using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Bookings;

public static class BookingErrors
{
    public static readonly Error NotFound = new(
        "Booking.NotFound",
        "The booking with the specified identifier was not found");

    public static readonly Error Overlapping = new(
        "Booking.Overlap",
        "The booking overlaps with an existing booking");

    public static readonly Error NotReserved = new(
        "Booking.NotReserved",
        "The booking is not pending");

    public static readonly Error NotConfirmed = new(
        "Booking.NotReserved",
        "The booking is not confirmed");

    public static readonly Error AlreadyStarted = new(
        "Booking.AlreadyStarted",
        "The booking has already started");
}