using UnityEngine;
using System;
using System.Collections;

public class AiPlayer : Player {

	int random;
	int WhichStone;

    public override void PlayTurn()
    {
        StartCoroutine(PlayTurnRoutine());
    }

    private IEnumerator PlayTurnRoutine()
    {

        //Play Turn Things
        //TODO: PLAY!
        //yield return new WaitForSeconds(4f);
		System.Random rnd = new System.Random();
        //random=rnd(0,2);

        //if(random == 0)
        //	//ortadan tas al 
        //else if(random == 1)
        //	//Oyuncudan tas al
        //
        //	stone

        WhichStone = rnd.Next(0, stones.Count);

		spToGive.DropStone(stones[WhichStone]);

        //print("AI THROW");
        GameRenderer.RenderGhostStone(stones[WhichStone], this.transform, spToGive.transform, false,spToGive.isPickable);



        //DİĞER PLAYER DAN AL
        //ORTADAN ÇEK


        //STONE DAN BİRİNİ SEÇ AT.


        TurnFinished();
        yield return null;
    }

}
