using UnityEngine;
using System.Collections;
using System;
using UnityEngine.EventSystems;

public class StonePlace : MonoBehaviour ,IStoneDroppable, IDropHandler , IPointerEnterHandler, IPointerExitHandler
{

    public Stone stone;
    int countChild;
    public void DropStone(Stone stone)
    {
        this.stone = stone;
    }

    public void OnDrop(PointerEventData eventData)
    {
        StoneRenderer stoneRenderer = eventData.pointerDrag.GetComponent<StoneRenderer>();
        if (stoneRenderer != null)
        {
            if (countChild ==0)
            {
                stoneRenderer.parentToReturnTo = this.transform;
                DropStone(stoneRenderer.stone);
            }
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        countChild = transform.childCount;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
     
    }
}
