using UnityEngine;
using System.Collections;
using System.Linq;
using System;

public class HumanPlayer : Player {

    public StonePlace[] istaka;

    public void GetDeals()
    {
        var result = Enumerable.Range(0, 30).OrderBy(g => Guid.NewGuid()).Take(15).ToArray();
        //Pool.Get("Stone");
        int i = 0;
        foreach (var stone in stones)
        {
            istaka[i].DropStone(stone);
            GameObject go = Pool.Get("Stone");
            go.transform.position = istaka[i].transform.position;
            go.transform.SetParent(istaka[result[i]].transform,false);
            i++;
        }

    }

    private IEnumerator PlayTurnRoutine()
    {

        //wait for get


        //wait for give


        //finished
        TurnFinished();

        yield return null;
    }


}
