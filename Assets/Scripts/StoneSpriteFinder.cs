using UnityEngine;
using System.Collections;
using System.Linq;

public class StoneSpriteFinder : MonoBehaviour {

	public static Sprite[] _sprites;

    public static Sprite findSprite(Stone stone)
    {
        if(_sprites == null)
        {
            _sprites = Resources.LoadAll<Sprite>("Sprites/Taslar");
        }

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

        //Debug.Log(str);

        return _sprites.Where(a => a.name == str).FirstOrDefault();
    }


}
