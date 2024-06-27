using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class offsetPipe : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float offset;

    void Start()
    {
        float x = Random.Range(0,offset);
        transform.position = new Vector3(transform.position.x,transform.position.y+x,transform.position.z);        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
