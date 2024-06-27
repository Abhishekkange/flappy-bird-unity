using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyPipe : MonoBehaviour
{
    // Start is called before the first frame update
        private float destroyPos = -50;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(transform.position.x <destroyPos)
        {

            Destroy(this.gameObject);  
        }
        
    }
}
