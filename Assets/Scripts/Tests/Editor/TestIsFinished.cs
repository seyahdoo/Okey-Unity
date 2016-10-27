using UnityEngine;
using UnityEditor;
using NUnit.Framework;
using System.Collections.Generic;

public class TestIsFinished {

	[Test]
	public void IsFinished()
	{

        int failCount = 0;

        //-------------------
        List<Stone> sl = new List<Stone>();   //Making an arbitrary player hand
        sl.Add(new Stone(1, Stone.StoneColor.Black, false));
        sl.Add(new Stone(2, Stone.StoneColor.Black, false));
        //..
        
        bool isF = LogicApi.IsFinished(sl);   //checking if player is finished the game
        if (isF != false) failCount++;        //it we are not happy with the result count the fails
        //---------------------
        //TODO: yukarıdaki gibi en az 10 tane use case yaz


        //TODO: delete this
        failCount++;

        if (failCount > 0) Debug.LogError("Fails in LogicApi.Isfinished() counts "+failCount+", FIX ME!!!");
        Assert.AreEqual(0, failCount);
	}
}
