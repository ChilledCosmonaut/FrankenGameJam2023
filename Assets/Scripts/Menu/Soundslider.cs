using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Soundslider : MonoBehaviour
{

    [SerializeField] Slider Volume; 
    [SerializeField] AudioSource Tycoon;

    [SerializeField] AudioSource ButtonSound;
    // Start is called before the first frame update
    void Start()
    {
        if(!PlayerPrefs.HasKey("musicVolume")){
            PlayerPrefs.SetFloat("musicVolume", 1);
            Load();
        }

        else {
            Load();
        }
    
       
    }

    public void ChangeVolume(){
       Tycoon.volume = Volume.value;
       ButtonSound.volume = Volume.value;
        Save();
    }

    private void Load(){
        Volume.value = PlayerPrefs.GetFloat("musicVolume");
    }

    private void Save(){
        PlayerPrefs.SetFloat("musicVolume", Volume.value);
    }
}
