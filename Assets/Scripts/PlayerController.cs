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
    int borderx = 4;
    int bordery = 2;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void playerController(int change)
    {
        GameObject selected = GameObject.Find($"selectedLine");
        Vector3 position = selected.transform.position;

        GameObject target = GameObject.Find("PlayerControll");
        float blockSize = (GetScreenSize().x / (float)7);
        int height = 10;
        UnityEngine.Object prefab2 = AssetDatabase.LoadAssetAtPath("Assets/DefaultBorder.prefab", typeof(GameObject));
        UnityEngine.Object prefab3 = AssetDatabase.LoadAssetAtPath("Assets/SelectedBorder.prefab", typeof(GameObject));
        //Debug.Log(change);
        float targetted = target.transform.position.x;

        if (change == 0)
        {
            //default
            target.transform.position = new Vector2(0, ((-1) * (3.5f) * blockSize));

        }

        if(change == 1  && bordery + 1 != 9) //&& (target.transform.position.y) + ((-1) * blockSize) < 2 * blockSize
        {
            target.transform.position = new Vector3(0, (1) * blockSize,0) + target.transform.position;
            if (change == 1 && bordery + 1 != 9)
            {
                bordery++;
                selected.transform.position += new Vector3(0, (1) * blockSize, 0);
            }

        }

        if (change == -1 && bordery - 1 != 0) // && (target.transform.position.y) + ((-1)*blockSize) > -7* blockSize
        {
            target.transform.position = new Vector3(0,  ((-1) * blockSize), 0) + target.transform.position;
            if (change == -1 && bordery - 1 != 0)
            {
                bordery--;
                selected.transform.position += new Vector3(0, (-1) * blockSize, 0);
            }

        }
        if ((change == 2 || change == -2)) {
            

            if (change == 2 && borderx+1 != 7)
            {
                borderx = borderx+1;
                selected.transform.position += new Vector3((1) * blockSize, 0, 0);
            }
            if (change == -2 && borderx - 1 != 1)
            {
                borderx = borderx - 1;
                selected.transform.position += new Vector3((-1) * blockSize,0 , 0);
            }
            //Debug.Log(borderx);

        }

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) {
            playerController(1);
            //Debug.Log(1);
        }
        else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            playerController(-1);
            //Debug.Log(-1);
        }
        else if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            playerController(-2);
            //Debug.Log(-2);
        }
        else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            playerController(2);
           // Debug.Log(2);
        }

    }




    public Vector2 GetScreenSize()
    {
        return new Vector2(Screen.width, Screen.height);
    }
}
