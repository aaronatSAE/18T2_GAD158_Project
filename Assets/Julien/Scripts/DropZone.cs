using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler ,IPointerEnterHandler, IPointerExitHandler{
    private object gameobject;

    public void OnPointerEnter(PointerEventData);

    public void OmPointerExit(PointerEventData) {
    }

	public void OnDrop(PointerEventData eventData) {
        Debug.Log("OnDrop to " + gameobject.name);
    }

}
