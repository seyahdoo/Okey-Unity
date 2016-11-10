using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using System;

public class PlayerStoneOutput : MonoBehaviour , IStoneDroppable , IDropHandler, IPointerEnterHandler, IPointerExitHandler
{

   
    public Player toGet;
    public Player toGive;
    public bool isPickable;
    

    public Stack<Stone> stones = new Stack<Stone>();

    public Stone GetLastStone()
    {
        return stones.Pop();
    }

    public List<Stone> GetAllStones()
    {
        List<Stone> sl = new List<Stone>();
        sl.AddRange(stones);
        stones.Clear();

        return sl;
    }

    public void Give1Stone(Stone stone)
    {
        stones.Push(stone);
    }

    public void DropStone(Stone stone)
    {
        stones.Push(stone);
        //Render();

        GameManager.instance.TurnFinish();
    }
    
    public virtual void OnDrop(PointerEventData eventData)
    {
        print("dropped");
        StoneRenderer stoneRenderer = eventData.pointerDrag.GetComponent<StoneRenderer>();
        if (stoneRenderer != null)
        {
            if (!stoneRenderer.IsMovable) return;
            stoneRenderer.IsMovable = false;
            stoneRenderer.transform.SetParent(this.transform);

            stoneRenderer.parentToReturnTo = this.transform;
            DropStone(stoneRenderer.stone);
        }

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            //Debug.Log(eventData.pointerDrag.transform.name);
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //Debug.Log("OnPointerExit");
    }

    //TODO: Delete this mess
    /// <summary>
    /// çöp aslında bu. wont be used!
    /// </summary>
    public void Render()
    {
        //get last stone,
        Stone s = stones.Peek();

        if (isPickable)
        {
            GameObject sg = Pool.Get("Stone");
            //sg.transform.position = this.transform.position;
            sg.transform.SetParent(this.transform);
            StoneRenderer sr = sg.GetComponent<StoneRenderer>();
            sr.stone = s;
            sr.Render();
        }
        else
        {
            GameRenderer.RenderGhostStone(s, transform, transform, false,false);
        }
        

    }





}
