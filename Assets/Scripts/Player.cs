using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class Player : MonoBehaviour {

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
        //Turn Started Event Trigger
        if (TurnStartedEvent != null) TurnStartedEvent();
        

        //Play Turn Things
        //TODO: PLAY!
        yield return new WaitForSeconds(4f);


        //Turn Finished Event Trigger
        if (TurnFinishedEvent != null) TurnFinishedEvent();
        
        yield return null;
    }


}
