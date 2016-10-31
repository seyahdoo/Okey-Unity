using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;

public class StoneRenderer : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler  {
    
        
    public Stone stone;
    public bool IsMovable;
    public bool IsHidden;

    public Transform parentToReturnTo = null;

    public void Render()
    {
        //TODO: change sprite or look with "stone" info inside

    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        parentToReturnTo = this.transform.parent;
        this.transform.SetParent(this.transform.parent.parent,false);
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        this.transform.SetParent(parentToReturnTo, false);
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
}
