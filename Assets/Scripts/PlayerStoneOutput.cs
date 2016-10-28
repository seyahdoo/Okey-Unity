using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class PlayerStoneOutput : MonoBehaviour , IStoneDroppable {

   
    public Player toGet;
    public Player toGive;

    public Stack<Stone> stones = new Stack<Stone>();

    public Stone GetLastStone()
    {
        return stones.Pop();
    }

    public List<Stone> GetAllStones()
    {
        List<Stone> sl = new List<Stone>();
        sl.AddRange(stones);
        stones.Clear();

        return sl;
    }

    public void Give1Stone(Stone stone)
    {
        stones.Push(stone);
    }

    public void DropStone(Stone stone)
    {
        stones.Push(stone);
        GameManager.instance.TurnFinish();
    }
}
