using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generatepipe : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pipe;
    float timer = 0;
    public float timediff;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //설정값마다 파이프 생성
        timer += Time.deltaTime;
         
        if(timer > timediff)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = new Vector3(5, Random.Range(-1.7f, 4.5f),0);
            timer = 0;
            Destroy(newpipe, 10.0f);
        }
    }
}
