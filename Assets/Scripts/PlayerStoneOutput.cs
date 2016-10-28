using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class PlayerStoneOutput : MonoBehaviour , IStoneDroppable {
    
    public List<Stone> stones;

    public Stone GetLastStone()
    {
        //TODO: This
        return null;
    }

    public List<Stone> GetAllStones()
    {
        //TODO: This
        return null;
    }

    public void Give1Stone(Stone stone)
    {
        //TODO: This
    }

    public void DropStone(Stone stone)
    {
        throw new NotImplementedException();
    }
}
