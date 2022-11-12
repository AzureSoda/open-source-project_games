using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Replay : MonoBehaviour
{
   public void Replaygame()
    {
        
        SceneManager.LoadScene("PlayScene");
        GameObject.Find("¿ÁΩ√¿€.mp3").GetComponent<AudioSource>().Play();

    }
    public void replaysound()
    {
        
    }
}
