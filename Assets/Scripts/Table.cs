using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Table : MonoBehaviour {


    public Stack<Stone> stones = new Stack<Stone>();

    
    public void Scramle()
    {
        List<Stone> sl = new List<Stone>();
        sl.AddRange(stones);
        sl.Shuffle();

        stones.Clear();

        foreach (var item in sl)
        {
            stones.Push(item);
        }


    }

    public List<Stone> GetNStone(int N)
    {
        //TODO: This
        List<Stone> sl = new List<Stone>();
        for (int i = 0; i < N; i++)
        {
            sl.Add(stones.Pop());
        }

        return sl;
    }

    public Stone Get1Stone()
    {
        return stones.Pop();
    }

    public void GiveStone(List<Stone> Stones)
    {
       
        foreach (var item in Stones)
        {
            stones.Push(item);
        }
        
    }


}
