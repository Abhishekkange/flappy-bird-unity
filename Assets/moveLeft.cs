using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveLeft : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int moveSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        transform.position = transform.position + new Vector3(1f, 0f, 0f) * moveSpeed *Time.deltaTime;




    }
}
