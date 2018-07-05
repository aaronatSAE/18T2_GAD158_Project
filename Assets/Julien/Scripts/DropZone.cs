using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler ,IPointerEnterHandler, {

	public void OnDrop(PointerEventData eventData) {
        Debug.Log("OnDrop to " + gameobject.name);
    }

}
