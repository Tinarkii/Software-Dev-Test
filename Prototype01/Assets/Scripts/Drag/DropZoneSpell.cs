﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class DropZoneSpell : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler {

	public Draggable.Slot typeOfItem = Draggable.Slot.SPELL;

	public void OnPointerEnter(PointerEventData eventData){
 	}
	public void OnPointerExit(PointerEventData eventData){
	}
	public void OnDrop(PointerEventData eventData){
		Draggable d = eventData.pointerDrag.GetComponent<Draggable> ();
		if (d != null) {
			if ( typeOfItem == d.typeOfItem)
			{
				d.ParentToReturnTo = this.transform;
			}
		}
	}

}