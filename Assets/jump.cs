using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float speed = 4f;
    [SerializeField] AudioSource audioSource;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0f, 1f, 0f) * speed;
            audioSource.Play();

        }
        if(Input.touchCount ==1)
        {
            this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0f, 1f, 0f) * speed;
            audioSource.Play();


        }
    }
}
