using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public abstract class Player : MonoBehaviour {

    public PlayerStoneOutput spToGive;
    public PlayerStoneOutput spToGet;

    public bool IsAI = true;
    public bool IsMyTurn;
    public List<Stone> stones = new List<Stone>();
    

    public void GiveStones(List<Stone> Stones)
    {
        stones.AddRange(Stones);
    }

    public abstract void PlayTurn();


}
