using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class collisionTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject scorehandler;

    void Start()
    {
        scorehandler = GameObject.FindGameObjectWithTag("scorehandler");
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("colluision trigger is running");
        if (collision.gameObject.tag == "bird")
        {

            Debug.Log("bird colllision triggee is runnig");
            scorehandler.GetComponent<updateScore>().increaseScore();
        }

    }
}
