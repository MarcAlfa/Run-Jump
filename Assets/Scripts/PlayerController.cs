using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float Speed = 1;
    //****************************************

    private Rigidbody xPlayerBody;
    private Transform xPlayerBall;
    private GameObject xPlayerFace;
    private Vector3 xPlayerPosition;
    private Quaternion xPlayerRotation;


    private AudioSource xAudio;

    private float xMov;
    private float zMov;
    private float yMov;

    //****************************************


    void Awake()
    {
        xAudio = GetComponent<AudioSource>();
        xPlayerBody = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {

        // posizione attuale del player
        xPlayerPosition = this.transform.position;
        // rotazione attuale del player
        xPlayerRotation = this.transform.rotation;

        if (Input.GetButtonDown("Jump"))
        {
            yMov = Speed;
        }
        else
        {
            yMov = xPlayerBody.velocity.y;
        }

        // movimento fisso, velocita'
        xPlayerBody.velocity = new Vector3(Speed, xPlayerBody.velocity.y, xPlayerBody.velocity.z);


/*

        // rotazione sx/dx
        if (xMov < 0)
        {
            if (Mathf.Abs(xPlayerRotation.y) > 0.6)
            {
                xPlayerBody.transform.Rotate(0f, xMov, 0f, Space.Self);
            }
        }
        else if (xMov > 0)
        {
            if (Mathf.Abs(xPlayerRotation.y) < 0.6)
            {
                xPlayerBody.transform.Rotate(0f, xMov * -1, 0f, Space.Self);
            }
        }

        // rotazione su/giu
        if (zMov < 0)
        {
            if (Mathf.Abs(xPlayerRotation.y) != 0 && Mathf.Abs(xPlayerRotation.w) != 1)
            {

                xPlayerBody.transform.Rotate(0f, zMov, 0f, Space.Self);
            }
        }
        else if (zMov > 0)
        {
            if (Mathf.Abs(xPlayerRotation.y) != 1 && Mathf.Abs(xPlayerRotation.w) != 0)
            {
                xPlayerBody.transform.Rotate(0f, zMov * -1, 0f, Space.Self);
            }
        }
*/


        //xPlayerBall.GetComponent<Transform>().rotation = new Vector3(1, 1, 1);
        //xPlayerBall.transform.position.y += 1f;

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
        //Debug.Log("PLAYER-coll-enter: " + collision.collider.name);

        // effetto molla
        //if (collision.collider.tag == "Ground")
        //{
        //    yMov = Molla;
        //    xPlayerBody.velocity = new Vector3(xPlayerBody.velocity.x, yMov, xPlayerBody.velocity.z);
        //}

        if (collision.collider.tag == "Friend")
        {
            if (!xAudio.isPlaying)
            {
                xAudio.Play();
            }
        }
    }


}
