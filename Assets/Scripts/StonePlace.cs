using UnityEngine;
using System.Collections;
using System;
using UnityEngine.EventSystems;

public class StonePlace : MonoBehaviour ,IStoneDroppable, IDropHandler , IPointerEnterHandler, IPointerExitHandler
{

    public void DropStone(Stone stone)
    {
       
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

    }

    public void OnPointerExit(PointerEventData eventData)
    {
     
    }
}
