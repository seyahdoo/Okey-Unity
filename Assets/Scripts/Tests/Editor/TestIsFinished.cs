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
		sl.Add(new Stone(3, Stone.StoneColor.Black, false));
		sl.Add(new Stone(4, Stone.StoneColor.Black, false));
		sl.Add(new Stone(4, Stone.StoneColor.Blue, false));
		sl.Add(new Stone(4, Stone.StoneColor.Green, false));
		sl.Add(new Stone(4, Stone.StoneColor.Red, false));
		sl.Add(new Stone(7, Stone.StoneColor.Red, false));
		sl.Add(new Stone(8, Stone.StoneColor.Red, false));
		sl.Add(new Stone(9, Stone.StoneColor.Red, false));
		sl.Add(new Stone(8, Stone.StoneColor.Green, false));
		sl.Add(new Stone(9, Stone.StoneColor.Green, false));
		sl.Add(new Stone(10, Stone.StoneColor.Green, false));

        //..
        
        bool isF = LogicApi.IsFinished(sl);   //checking if player is finished the game
        if (isF != false) failCount++;        //it we are not happy with the result count the fails
        //---------------------
        //TODO: yukarıdaki gibi en az 10 tane use case yaz

		//-------------------
		List<Stone> s2 = new List<Stone>();   //Making an arbitrary player hand
		s2.Add(new Stone(4, Stone.StoneColor.Blue, false));
		s2.Add(new Stone(5, Stone.StoneColor.Blue, false));
		s2.Add(new Stone(6, Stone.StoneColor.Blue, false));
		s2.Add(new Stone(7, Stone.StoneColor.Blue, false));
		s2.Add(new Stone(8, Stone.StoneColor.Blue, false));
		s2.Add(new Stone(5, Stone.StoneColor.Black, false));
		s2.Add(new Stone(6, Stone.StoneColor.Black, false));
		s2.Add(new Stone(7, Stone.StoneColor.Black, false));
		s2.Add(new Stone(8, Stone.StoneColor.Black, false));
		s2.Add(new Stone(10, Stone.StoneColor.Red, false));
		s2.Add(new Stone(10, Stone.StoneColor.Green, false));
		s2.Add(new Stone(10, Stone.StoneColor.Black, false));
		s2.Add(new Stone(10, Stone.StoneColor.Blue, false));
		s2.Add(new Stone(13, Stone.StoneColor.Blue, false));
		//..

		isF = LogicApi.IsFinished(s2);   //checking if player is finished the game
		if (isF != false) failCount++;        //it we are not happy with the result count the fails


		//-------------------
		List<Stone> s3 = new List<Stone>();   //Making an arbitrary player hand
		s3.Add(new Stone(11, Stone.StoneColor.Green, false));
		s3.Add(new Stone(12, Stone.StoneColor.Green, false));
		s3.Add(new Stone(13, Stone.StoneColor.Green, false));
		s3.Add(new Stone(1, Stone.StoneColor.Green, false));
		s3.Add(new Stone(3, Stone.StoneColor.Black, false));
		s3.Add(new Stone(3, Stone.StoneColor.Blue, false));
		s3.Add(new Stone(3, Stone.StoneColor.Red, false));
		s3.Add(new Stone(3, Stone.StoneColor.Green, false));
		s3.Add(new Stone(2, Stone.StoneColor.Blue, false));
		s3.Add(new Stone(3, Stone.StoneColor.Blue, false));
		s3.Add(new Stone(4, Stone.StoneColor.Blue, false));
		s3.Add(new Stone(5, Stone.StoneColor.Blue, false));
		s3.Add(new Stone(6, Stone.StoneColor.Blue, false));
		s3.Add(new Stone(7, Stone.StoneColor.Blue, false));
		//..

		isF = LogicApi.IsFinished(s3);   //checking if player is finished the game
		if (isF != false) failCount++;        //it we are not happy with the result count the fails

		//-------------------
		List<Stone> s4 = new List<Stone>();   //Making an arbitrary player hand
		s4.Add(new Stone(5, Stone.StoneColor.Green, false));
		s4.Add(new Stone(5, Stone.StoneColor.Green, false));
		s4.Add(new Stone(5, Stone.StoneColor.Green, false));
		s4.Add(new Stone(5, Stone.StoneColor.Green, false));
		s4.Add(new Stone(13, Stone.StoneColor.Blue, false));
		s4.Add(new Stone(1, Stone.StoneColor.Blue, false));
		s4.Add(new Stone(2, Stone.StoneColor.Blue, false));
		s4.Add(new Stone(3, Stone.StoneColor.Blue, false));
		s4.Add(new Stone(4, Stone.StoneColor.Red, false));
		s4.Add(new Stone(5, Stone.StoneColor.Red, false));
		s4.Add(new Stone(6, Stone.StoneColor.Red, false));
		s4.Add(new Stone(7, Stone.StoneColor.Red, false));
		s4.Add(new Stone(8, Stone.StoneColor.Red, false));
		s4.Add(new Stone(9, Stone.StoneColor.Red, false));
		//..

		isF = LogicApi.IsFinished(s4);   //checking if player is finished the game
		if (isF != false) failCount++;        //it we are not happy with the result count the fails

		//-------------------
		List<Stone> s5 = new List<Stone>();   //Making an arbitrary player hand
		s5.Add(new Stone(1, Stone.StoneColor.Red, false));
		s5.Add(new Stone(1, Stone.StoneColor.Red, false));
		s5.Add(new Stone(1, Stone.StoneColor.Red, false));
		s5.Add(new Stone(1, Stone.StoneColor.Red, false));
		s5.Add(new Stone(8, Stone.StoneColor.Black, false));
		s5.Add(new Stone(9, Stone.StoneColor.Black, false));
		s5.Add(new Stone(10, Stone.StoneColor.Black, false));
		s5.Add(new Stone(11, Stone.StoneColor.Black, false));
		s5.Add(new Stone(4, Stone.StoneColor.Red, false));
		s5.Add(new Stone(4, Stone.StoneColor.Green, false));
		s5.Add(new Stone(4, Stone.StoneColor.Blue, false));
		s5.Add(new Stone(13, Stone.StoneColor.Black, false));
		s5.Add(new Stone(13, Stone.StoneColor.Blue, false));
		s5.Add(new Stone(13, Stone.StoneColor.Green, false));
		//..

		isF = LogicApi.IsFinished(s5);   //checking if player is finished the game
		if (isF != false) failCount++;        //it we are not happy with the result count the fails

		//-------------------
		List<Stone> s6 = new List<Stone>();   //Making an arbitrary player hand
		s6.Add(new Stone(9, Stone.StoneColor.Green, false));
		s6.Add(new Stone(10, Stone.StoneColor.Green, false));
		s6.Add(new Stone(11, Stone.StoneColor.Green, false));
		s6.Add(new Stone(12, Stone.StoneColor.Green, false));
		s6.Add(new Stone(13, Stone.StoneColor.Green, false));
		s6.Add(new Stone(1, Stone.StoneColor.Green, false));
		s6.Add(new Stone(2, Stone.StoneColor.Green, false));
		s6.Add(new Stone(7, Stone.StoneColor.Black, false));
		s6.Add(new Stone(7, Stone.StoneColor.Red, false));
		s6.Add(new Stone(7, Stone.StoneColor.Green, false));
		s6.Add(new Stone(7, Stone.StoneColor.Blue, false));
		s6.Add(new Stone(11, Stone.StoneColor.Black, false));
		s6.Add(new Stone(11, Stone.StoneColor.Blue, false));
		s6.Add(new Stone(11, Stone.StoneColor.Green, false));
		//..

		isF = LogicApi.IsFinished(s6);   //checking if player is finished the game
		if (isF != false) failCount++;        //it we are not happy with the result count the fails




        //TODO: delete this
        failCount++;

        if (failCount > 0) Debug.LogError("Fails in LogicApi.Isfinished() counts "+failCount+", FIX ME!!!");
        Assert.AreEqual(0, failCount);
	}
}
