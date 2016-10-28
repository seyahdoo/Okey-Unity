using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Table : MonoBehaviour {


    public List<Stone> stones = new List<Stone>();


    public void Scramle()
    {
        //TODO: This
    }

    public List<Stone> GetNStone(int N)
    {
        //TODO: This
        return null;
    }

    public Stone Get1Stone()
    {
        //TODO: This
        return null;
    }

    public void GiveStone(List<Stone> Stones)
    {
        stones.AddRange(Stones);

    }


}
