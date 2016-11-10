using UnityEngine;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

public partial class LogicApi
{
    public static bool IsFinished(List<Stone> Stones)
    {
        //Shouldn't say new Stone() !?
        //TODO: Write this stuff

        List<Color> colorRed = new List<Color>();
        List<Color> colorBlue = new List<Color>();
        List<Color> colorGreen = new List<Color>();
        List<Color> colorBlack = new List<Color>();
        List<int> stoneNumbersCheckList = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 });
        List<int> stoneNumbers = new List<int>();
        bool seriBitme = false;

        foreach (var item in Stones)
        {
            if (item.IsJoker)
            {
                seriBitme = true;
            }
            switch (item.Color)
            {
                case Stone.StoneColor.Red:
                    colorRed.Add(Color.red);
                    stoneNumbers.Add(item.Number);
                    break;
                case Stone.StoneColor.Blue:
                    colorBlue.Add(Color.blue);
                    stoneNumbers.Add(item.Number);
                    break;
                case Stone.StoneColor.Green:
                    colorGreen.Add(Color.green);
                    stoneNumbers.Add(item.Number);
                    break;
                case Stone.StoneColor.Black:
                    colorBlack.Add(Color.black);
                    stoneNumbers.Add(item.Number);
                    break;
                default:
                    break;
            }
            if (colorRed.Count == 13 || colorBlue.Count == 13 || colorGreen.Count == 13 || colorBlack.Count == 13)
            {
                var result = stoneNumbers.Except(stoneNumbersCheckList).ToList();
                if (result.Count == 0)
                {
                    if (seriBitme)
                    {
                        return true;
                    }
                }
            }
        }
        return false;
    }
    bool SeriBitme()
    {
        return true;
    }
}