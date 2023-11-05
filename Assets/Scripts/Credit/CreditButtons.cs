using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CreditButtons : MonoBehaviour
{
    public void OnClick(){
        SceneManager.LoadScene("Menu");
    }
}
