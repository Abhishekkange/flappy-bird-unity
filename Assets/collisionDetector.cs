using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class collisionDetector : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameOverScreen;
    public AudioSource audioSource;
    public AudioSource bgmSource;

    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.collider.tag);
        
        if(collision.collider.tag == "collider")
        {
            audioSource.Play();
            bgmSource.Stop();

            gameOverScreen.SetActive(true);
            Destroy(this.gameObject);
            
        }


    }
}
