using UnityEngine;
using System.Collections;

public class GameRenderer : MonoBehaviour {
    
	//float lerpingtime;


    /// <summary>
    /// will be going to render ai movements
    /// </summary>
    public static void RenderGhostStone(Stone stone, Transform from, Transform to, bool isHidden,bool isMovable)
    {
        //TODO: render a stone that is not draggable or changable who will stay on "to"
        //      pulled from pool, spawned at from and will be going to "to" with a speed
        //print("Rendering ghost!");

		GameObject go = Pool.Get("Stone");
        StoneRenderer sr = go.GetComponent<StoneRenderer>();
        if (!isHidden) {
            sr.stone = stone;
            sr.Render();
		}
        sr.IsMovable = isMovable;
        //todo
        //go.transform.position = to.position;
        go.transform.SetParent(to, false);
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
