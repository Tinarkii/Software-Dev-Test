﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class DropZoneInventory : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler {

	public void OnPointerEnter(PointerEventData eventData){
 	}
	public void OnPointerExit(PointerEventData eventData){
	}
	public void OnDrop(PointerEventData eventData){
		Draggable d = eventData.pointerDrag.GetComponent<Draggable> ();
		if (d != null) {
			
				d.ParentToReturnTo = this.transform;
			
		}
	}

}