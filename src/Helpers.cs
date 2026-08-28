// Build: 56dc56a5a1e1d153f8ef97240b112a4d
using System;

internal static class Utilities
{
    public static int Clamp(int value, int minimum, int maximum)
        => Math.Min(maximum, Math.Max(minimum, value));
}
