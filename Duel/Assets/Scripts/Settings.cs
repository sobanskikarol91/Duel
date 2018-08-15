using UnityEngine;
using System.Collections;

public static class Settings
{
    public static int FirstConflictToken { get; } = 2;
    public static int SecondConflictToken { get; } = 5;
    public static int CardCost { get; } = 2;
    public static int ResourcesCost { get; } = 2;
    public static int StartGold { get; } = 7;
    public static Color32 toExpensiveCard { get; } = new Color32(166, 76, 76,255) ;
}
