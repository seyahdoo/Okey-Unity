using UnityEngine;
using System.Collections;


/// <summary>
/// The data class that holds a stone info
/// </summary>
[System.Serializable]
public class Stone {

    public Stone(int Number, StoneColor Color,bool IsJoker)
    {
        this.Number = Number;
        this.Color = Color;
        this.IsJoker = IsJoker;
    }

    //TODO LATER declare this readonly
    public int Number;
    public StoneColor Color;
    public bool IsJoker;
    
    public enum StoneColor
    {
        Red,
        Blue,
        Green,
        Black
    }

    public static StoneColor IntToStoneColor(int i)
    {
        switch (i)
        {
            case 0: return StoneColor.Black;
            case 1: return StoneColor.Blue;
            case 2: return StoneColor.Green;
            case 3: return StoneColor.Red;
            default:
                Debug.LogError("Error in Stone.IntToStoneColor(int) input has to be 0-3, but was " + i);
                return StoneColor.Black;
        }

    }

}
