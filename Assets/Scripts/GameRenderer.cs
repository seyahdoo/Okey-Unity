﻿using UnityEngine;
using System.Collections;

public class GameRenderer : MonoBehaviour {
    
	float lerpingtime;

    //TODO: Design how to render the game???
    

    /// <summary>
    /// will be going to render ai movements
    /// </summary>
    /// <param name="stone"></param>
    /// <param name="from"></param>
    /// <param name="to"></param>
    public static void RenderGhostStone(Stone stone, Vector3 from, Vector3 to, bool isHidden)
    {
        //TODO: render a stone that is not draggable or changable who will stay on "to"
        //      pulled from pool, spawned at from and will be going to "to" with a speed

		GameObject go = Pool.Get("Stone");
		if (!isHidden) {
			go.GetComponent<StoneRenderer> ().Render ();
		}
        //todo
        go.transform.position = to;
		//StartCoroutine(Move(go));
    }

	//IEnumerator Move(GameObject go)
    //
	//{	
	//	while(lerpingtime < 3)
	//	{	
	//		go.transform.position = Vector3.Lerp(from, to, lerpingtime/3);
	//		lerpingtime += Time.deltaTime;
	//		yield return new WaitForEndOfFrame ();
	//	}
	//}






}
