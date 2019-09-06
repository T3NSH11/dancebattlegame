using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///  A <see langword="static"/> class with methods (functions) for initialising or randomising the stats class.
///  
/// TODO:
///     Initialise a stats instance with generated starting stats
///     Handle the assignment of extra points or xp into an existing stats of a character
///         - this is expected to be used by NPCs leveling up to match the player.
/// </summary>
public static class StatsGenerator
{
    public static void InitialStats(Stats stats)
    {
        stats.xp = 0;
        stats.rhythm = 2;
        stats.style = 3;
        stats.luck = 0;
        stats.totalstats = 0;

    }

    public static void AssignUnusedPoints(Stats stats, int points)
    {
    }
}
