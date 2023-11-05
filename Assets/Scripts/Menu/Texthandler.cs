using System.Collections;
using System.Collections.Generic;
using TMPro;
//using TMPro.Examples;
using UnityEngine;
using UnityEngine.EventSystems;

public class Texthandler : MonoBehaviour,IPointerDownHandler, IPointerUpHandler
{
    public TextMeshProUGUI text;
    public void OnPointerDown(PointerEventData eventData)
    {
      text.transform.position = new Vector2(text.transform.position.x, text.transform.position.y-10);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
      text.transform.position = new Vector2(text.transform.position.x, text.transform.position.y+10);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
