using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;
public class Menu : MonoBehaviour
{

    public TextMeshProUGUI Play;
    public TextMeshProUGUI Quit;
    public TextMeshProUGUI Credit;

    private void MoveText(){
        
    }
public void OnPlay(){
    SceneManager.LoadScene("LevelDesign");
  
}

public void Awake(){
    GameObject instance = GameObject.FindWithTag("Music");

        if (instance != null)
        {
            Destroy(instance);
    
        }
}
public void OnQuit(){
    Application.Quit();
    
}

public void OnCredit(){
    SceneManager.LoadScene("Credit");
}


   
}
