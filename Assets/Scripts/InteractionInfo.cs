using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InteractionInfo : MonoBehaviour, IPointerClickHandler
{
    public GameObject panel;
    public void OnPointerClick(PointerEventData eventData)
    {
    	
    	if(panel!=null && panel.activeSelf)
    		panel.SetActive(false);
    	else
    		panel.SetActive(true);
    }
}
