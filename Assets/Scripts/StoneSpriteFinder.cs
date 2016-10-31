using UnityEngine;
using System.Collections;

public class StoneSpriteFinder : MonoBehaviour {

	
    public static Sprite findSprite(Stone stone)
    {
        string str = "Tas-";
        
        switch (stone.Color)
        {
            case Stone.StoneColor.Red:
                str += "Kirmizi-";
                break;
            case Stone.StoneColor.Blue:
                str += "Mavi-";
                break;
            case Stone.StoneColor.Green:
                str += "Yesil-";
                break;
            case Stone.StoneColor.Black:
                str += "Siyah-";
                break;
        }

        str += stone.Number;

        return Resources.Load("Sprites/" + str) as Sprite;
    }


}
