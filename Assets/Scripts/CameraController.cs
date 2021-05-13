using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.Mathematics;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    private PlayerController xPlayer;


    // Start is called before the first frame update
    void Awake()
    {
        xPlayer = FindObjectOfType<PlayerController>();
    }

    void Update()
    {        
        // movimento
        transform.position = new Vector3(xPlayer.transform.position.x, transform.position.y, transform.position.z);
    }

}
