using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnpipe : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject pipe;
    [SerializeField] int delay;
    public float heightoffset = 2f;

    public float lowerLimit, upperLimit;
    private float timer = 2f;
    void Start()
    {
        
        lowerLimit = transform.position.y - heightoffset;
        upperLimit = transform.position.y + heightoffset;


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

        
        float abc = Random.Range(lowerLimit, upperLimit);
        Instantiate(pipe,new Vector3(0f,abc,0f),transform.rotation);

    }
}
