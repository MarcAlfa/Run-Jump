using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendController : MonoBehaviour
{


    private AudioSource xAudio;


    // Start is called before the first frame update
    void Start()
    {
        xAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("FRIEND-coll-enter: " + collision.collider.name);
        if (collision.collider.tag == "Player")
        {
            xAudio.Play();
        }
    }

}
