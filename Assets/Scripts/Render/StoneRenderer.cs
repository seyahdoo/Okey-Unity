﻿using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;
using UnityEngine.UI;

public class StoneRenderer : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler  {
    
        
    public Stone stone;
    public bool IsMovable;
    public bool IsHidden;

    public Image image;

    public Transform parentToReturnTo = null;

    public void Render()
    {
        //TODO: change sprite or look with "stone" info inside
        //print("Rendered");

        if (stone.Number == 0)
        {
            print("wtf");
        }
		 image.sprite = StoneSpriteFinder.findSprite (stone);
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (!IsMovable) return;
        parentToReturnTo = this.transform.parent;
        this.transform.SetParent(this.transform.parent.parent,false);
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (!IsMovable) return;
        this.transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (!IsMovable) return;

        this.transform.SetParent(parentToReturnTo, false);
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
}
