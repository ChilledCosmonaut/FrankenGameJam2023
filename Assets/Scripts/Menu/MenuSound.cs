using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MenuSound : MonoBehaviour,IPointerDownHandler, IPointerUpHandler
{
    // Start is called before the first frame update
    
    public AudioSource WIP_TycoonMenu;
    public AudioSource Click;
    
    public void Menu()
    {
        WIP_TycoonMenu.Play();
    }

    public void ClickSound(){
        Click.Play();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
       Click.Play();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
    
    }
}
