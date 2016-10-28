using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using System;

public class PlayerStoneOutput : MonoBehaviour , IStoneDroppable , IDropHandler, IPointerEnterHandler, IPointerExitHandler
{

   
    public Player toGet;
    public Player toGive;

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
        GameManager.instance.TurnFinish();
    }

    public void OnDrop(PointerEventData eventData)
    {
        StoneRenderer stoneRenderer = eventData.pointerDrag.GetComponent<StoneRenderer>();
        if (stoneRenderer != null)
        {
            stoneRenderer.parentToReturnTo = this.transform;
            DropStone(stoneRenderer.stone);
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            Debug.Log(eventData.pointerDrag.transform.name);
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("OnPointerExit");
    }
}
