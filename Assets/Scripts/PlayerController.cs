using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using Unity;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    public void playerController(int change)
    {
        GameObject target = GameObject.Find("PlayerControll");
        float blockSize = (GetScreenSize().x / (float)7);
        int height = 10;
        Debug.Log(change);
        float targetted = target.transform.position.x;

        if (change == 0)
        {
            //default
            target.transform.position = new Vector2(0, ((-1) * (3.5f) * blockSize));

        }

        if(change == 1 && (target.transform.position.y) + ((-1) * blockSize) < -1 * blockSize)
        {
            target.transform.position = new Vector3(0, (1) * blockSize,0) + target.transform.position;
        }

        if (change == -1 && (target.transform.position.y) + ((-1)*blockSize) > -7*blockSize)
        {
            target.transform.position = new Vector3(0,  ((-1) * blockSize), 0) + target.transform.position;
        }

        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) {
            playerController(1);
            Debug.Log(1);
        }
        else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            playerController(-1);
            Debug.Log(-1);
        }
    }




    public Vector2 GetScreenSize()
    {
        return new Vector2(Screen.width, Screen.height);
    }
}
