using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameras : MonoBehaviour {

    private Transform player;

    [SerializeField]
    float smoothX;
    [SerializeField]
    float smoothY;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }


    void LateUpdate()
    {

        float posX = Mathf.MoveTowards(transform.position.x, player.position.x, smoothX);
        float posY = Mathf.MoveTowards(transform.position.y, player.position.y, smoothY);

        transform.position = new Vector3(posX, posY, transform.position.z);


    }


}


