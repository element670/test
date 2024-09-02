using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler, IPointerDownHandler
{

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Starting to drag");
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("Ending drag");
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(mousePos.x, mousePos.y, 0);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("YES");
    }
}
