using UnityEngine;
using System.Linq;

public class StoneSpriteFinder : MonoBehaviour {

	public static Sprite[] _sprites;

    /// <summary>
    /// give the stone as data and get its sprite!
    /// </summary>
    /// <param name="stone">Stone data</param>
    /// <returns>Sprite as it should be seen</returns>
    public static Sprite findSprite(Stone stone)
    {
        if (stone.Number == 0) return null;

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

        Debug.Log(str);

        return _sprites.Where(a => a.name == str).First();
    }


}
