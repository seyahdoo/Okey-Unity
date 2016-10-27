using UnityEngine;
using System.Collections;

public class Stone {

    public Stone(int Number, StoneColor Color,bool IsJoker)
    {
        this.Number = Number;
        this.Color = Color;
        this.IsJoker = IsJoker;
    }

    public readonly int Number;
    public readonly StoneColor Color;
    public readonly bool IsJoker;
    
    public enum StoneColor
    {
        Red,
        Blue,
        Green,
        Black
    }



}
