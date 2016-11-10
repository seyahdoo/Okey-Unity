using UnityEngine;
using UnityEditor;
using NUnit.Framework;
using System.Collections.Generic;

public class TestAiPlay {

	[Test]
	public void AiPlay()
	{


        int failCount = 0;

        //-------------------
        List<Stone> sl = new List<Stone>();   //Making an arbitrary player hand
        sl.Add(new Stone(1, Stone.StoneColor.Black, false));
        sl.Add(new Stone(2, Stone.StoneColor.Black, false));
        //..

        LogicApi.AiAction act = LogicApi.AIPlay(sl, new Stone(5, Stone.StoneColor.Red, true),new Stone(4,Stone.StoneColor.Black,false));

        if (act.Action != LogicApi.AiAction.PlayAction.GetFromPlayer)
            failCount++;        //it we are not happy with the result count the fails
        //---------------------
        //TODO: yukarıdaki gibi en az 10 tane use case yaz


        //TODO: delete this
        failCount++;

        if (failCount > 0) Debug.LogError("Fails in LogicApi.AiAction() counts " + failCount + ", FIX ME!!!");
        Assert.AreEqual(0, failCount);
    }
}
