using UnityEngine;
using System.Collections;

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



}
