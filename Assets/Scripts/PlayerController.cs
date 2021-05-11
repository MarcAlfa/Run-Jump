using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float Speed = 1;
    //****************************************

    private Rigidbody xPlayerBody;
    private AudioSource xAudio;

    private float xMov;
    private float zMov;

    //****************************************


    void Awake()
    {
        xPlayerBody = GetComponent<Rigidbody>();
        xAudio = GetComponent<AudioSource>();
    }


    void Update()
    {
        xMov = Input.GetAxisRaw("Horizontal") * Speed;
        zMov = Input.GetAxisRaw("Vertical") * Speed;


        xPlayerBody.velocity = new Vector3(xMov, xPlayerBody.velocity.y, zMov);

        // ** ATTACK ********************************************
        //if (Input.GetButtonDown("ATTACK"))
        //{
        //    xAudio.Play();
        //    xMovement = new Vector3(60, 0, 0);
        //    xPlayerBody.MovePosition(transform.position + xMovement * Time.deltaTime * Speed);
        //}
    }


    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("PLAYER-coll-enter: " + collision.collider.name);
        if (collision.collider.tag == "Friend")
        {
            xAudio.Play();
        }
    }




}
