using UnityEngine;
using System.Collections;

public class HumanPlayer : Player {

    public StonePlace[] istaka;

    private IEnumerator PlayTurnRoutine()
    {

        //wait for get


        //wait for give


        //finished
        TurnFinished();

        yield return null;
    }


}
