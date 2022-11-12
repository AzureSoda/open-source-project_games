using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class firststart : MonoBehaviour
{
    // Start is called before the first frame update
    public void Firstgame()
    {

        SceneManager.LoadScene("PlayScene");
        GetComponent<AudioSource>().Play();
    }
}
