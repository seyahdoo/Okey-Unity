using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class PlayerStoneOutput : MonoBehaviour , IStoneDroppable {

   
    public Player toGet;
    public Player toGive;

    public Stack<Stone> stones = new Stack<Stone>();
	float lerpingtime;
	Transform StartPos;

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
		Move (stone);
        GameManager.instance.TurnFinish();
    }

	IEnumerator Move(Stone stone)
	{
		StartPos = stone.transform.position;
		while(lerpingtime < 3)
		{
			lerpingtime += Time.deltatime;
			stone.transform.position = Vector3.Lerp(StartPos, transform.position, lerpingtime/3);
		}
	}

}
