using UnityEngine;
using System.Collections;

public class AiPlayer : Player {

	int random;
	 
    private IEnumerator PlayTurnRoutine()
    {

        //Play Turn Things
        //TODO: PLAY!
        yield return new WaitForSeconds(4f);
		System.Random rnd = new System.Random();
        //random=rnd(0,2);

        //if(random == 0)
        //	//ortadan tas al 
        //else if(random == 1)
        //	//Oyuncudan tas al
        //
        //	stone




        //DİĞER PLAYER DAN AL
        //ORTADAN ÇEK


        //STONE DAN BİRİNİ SEÇ AT.


        TurnFinished();
        yield return null;
    }

}
