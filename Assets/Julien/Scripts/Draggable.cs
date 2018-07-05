using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

    Transform parentToReturnTo = null;

	public void OnBeginDrag(PointerEventData eventData) {
        Debug.Log("OnBeginDrag");

        parentToReturnTo = this.transform.parent; //Makes card go back to the back of a players hand
        this.transform.SetParent( this.transform.parent.parent );
    }
    //Begins Dragging

    public void OnDrag(PointerEventData eventData) {
        Debug.Log("OnDrag");

        this.transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData) {
        Debug.Log("OnEndDrag");
        this.transform.SetParent( parentToReturnTo );
    }
    //Ends Dragging
}
