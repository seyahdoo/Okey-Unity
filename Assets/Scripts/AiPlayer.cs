using UnityEngine;
using System.Collections;

public class AiPlayer : Player {


    private IEnumerator PlayTurnRoutine()
    {
        //Turn Started Event Trigger
        if (TurnStartedEvent != null) TurnStartedEvent();


        //Play Turn Things
        //TODO: PLAY!
        yield return new WaitForSeconds(4f);


        //DİĞER PLAYER DAN AL
        //ORTADAN ÇEK


        //STONE DAN BİRİNİ SEÇ AT.


        //Turn Finished Event Trigger
        if (TurnFinishedEvent != null) TurnFinishedEvent();

        yield return null;
    }

}
