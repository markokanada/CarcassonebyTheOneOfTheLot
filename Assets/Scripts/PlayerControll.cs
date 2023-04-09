using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    public Transform target;
    public int counter = 0;
    public Vector3 offset;
    public Vector3 targetPosition;
    public float damping;
    private Vector3 velocity = Vector3.zero;

    void Start()
    {
        target = GameObject.Find("PlayerControll").transform;
        targetPosition = target.position;
        //GameObject.Find("PlayerControll").GetComponent<PlayerController>().playerController(0);

    }

    void Update()
    {
        
        if (counter < 150)
        {
            GameObject.Find("PlayerControll").GetComponent<PlayerController>().playerController(0);
            counter++;
        }
        
        if (target.position != targetPosition && target.position != transform.position) {
            
            Vector3 movePosition = (transform.position + (targetPosition-target.position));
            transform.position = Vector3.SmoothDamp(transform.position,movePosition, ref velocity, damping);
            targetPosition = target.position;
        }

    }
    
    public Vector2 GetScreenSize()
    {
        return new Vector2(Screen.width, Screen.height);
    }
}
