using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Player : MonoBehaviour {

    public StonePlace spToGive;
    public StonePlace spToGet;

    public bool IsAI = true;
    public bool IsMyTurn;
    public List<Stone> stones = new List<Stone>();
    
    public delegate void VoidDelegate();
    public event VoidDelegate TurnFinishedEvent;
    public event VoidDelegate TurnStartedEvent;

    public void GiveStones(List<Stone> Stones)
    {
        stones.AddRange(Stones);
    }

    public void PlayTurn()
    {
        StartCoroutine(PlayTurnRoutine());
    }

    private IEnumerator PlayTurnRoutine()
    {
        
        //Play Turn Things
        //TODO: PLAY!
        yield return new WaitForSeconds(4f);


        TurnFinished();
        yield return null;
    }

    protected void TurnFinished()
    {
        if (TurnFinishedEvent != null) TurnFinishedEvent();
    }

}
