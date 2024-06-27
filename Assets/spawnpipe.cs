using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnpipe : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject pipe;
    [SerializeField] int delay;
    private float timer = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer<delay)
        {
            timer = timer + Time.deltaTime;

        }
        else
        {

            spawnPipe();
            timer = 0;
        }

        
    }
    void spawnPipe()
    {

        Instantiate(pipe,transform.position,transform.rotation);

    }
}
