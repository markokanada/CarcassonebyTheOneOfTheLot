using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using Unity;
using UnityEngine.UI;

public class CreateGameField : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        createGameField();
    }

    public void createGameField()
    {

        int height = 10;
        UnityEngine.Object prefab3 = AssetDatabase.LoadAssetAtPath("Assets/Parent.prefab", typeof(GameObject));
        GameObject childOb = Instantiate(prefab3, Vector3.zero, Quaternion.identity) as GameObject; ;//new GameObject("name");

        for (int i = 0; i < height; i++)
        {
            int multiplier = 0;
            if (i < GetScreenSize().y / (GetScreenSize().x / (float)7) / 2)
            {
                multiplier = -1 * i;
            }
            else if (i > GetScreenSize().y / (GetScreenSize().x / (float)7) / 2)
            {
                multiplier = 1 * (int)i - (int)(GetScreenSize().y / (GetScreenSize().x / (float)7) / 2);
            }
            for (int j = 0; j < 7; j++)
            {
                UnityEngine.Object prefab = AssetDatabase.LoadAssetAtPath("Assets/BackgroundImages.prefab", typeof(GameObject));
                if (i == 0 || i == 9 || j==0 || j==6) {
                     prefab = AssetDatabase.LoadAssetAtPath("Assets/BackgroundImagesDarkWithTree.prefab", typeof(GameObject));

                }
                else
                {
                     prefab = AssetDatabase.LoadAssetAtPath("Assets/BackgroundImages.prefab", typeof(GameObject));

                }

                UnityEngine.Object prefab2 = AssetDatabase.LoadAssetAtPath("Assets/DefaultBorder.prefab", typeof(GameObject));
                
                GameObject clone = Instantiate(prefab, Vector3.zero, Quaternion.identity) as GameObject;
                GameObject cloneLine = Instantiate(prefab2, Vector3.zero, Quaternion.identity) as GameObject;
                // Modify the clone to your heart's content
                float difference_x = clone.transform.position.x;
                float difference_y = clone.transform.position.y;
                clone = clone.transform.GetChild(0).gameObject;
                cloneLine = cloneLine.transform.GetChild(0).gameObject;
                clone.transform.localScale = new Vector3(((GetScreenSize().x / (float)7) / (float)100), ((GetScreenSize().x / (float)7) / (float)100), ((GetScreenSize().x / (float)7) / (float)100));
                cloneLine.transform.localScale = new Vector3(((GetScreenSize().x / (float)7) / (float)100), ((GetScreenSize().x / (float)7) / (float)100), ((GetScreenSize().x / (float)7) / (float)100));


                float x = new float();
                float y = new float();
                clone.name = $"{i}.{j}";
                cloneLine.name = $"{i}.{j}";

                if (j < 3)
                {
                    x = (3 - j) * (-1) * (GetScreenSize().x / (float)7);
                }

                else if (j == 3)
                {
                    x = 0;
                }

                else if (j > 3)
                {
                    x = (3 - j) * (-1) * (GetScreenSize().x / (float)7);
                }

                if (i == 0)
                {
                    y = (((height - 1) / 2) + 1) * (GetScreenSize().x / (float)7) * (-1);
                }

                else if (i == 4)
                {
                    y = (-1) * (GetScreenSize().x / (float)7);
                }

                else if (i == (height - 1)){
                    y = (((height - 1) / 2) ) * (GetScreenSize().x / (float)7);
                }

                else if (i < (((height - 1) / 2) + 1))
                {
                    y = (-1) * (i + 1) * (GetScreenSize().x / (float)7);
                }

                else if (i == (((height - 1) / 2) + 1))
                {
                    y = 0;
                }

                else if (i > (((height - 1) / 2) + 1))
                {
                    y = (1) * (i - (((height - 1) / 2) + 1)) * (GetScreenSize().x / (float)7);
                }

                clone.transform.position = new Vector2((x + difference_x), (y + difference_y));
                clone = clone.transform.parent.gameObject;
                clone.gameObject.transform.SetParent(childOb.transform);
                cloneLine.transform.position = new Vector2((x + difference_x), (y + difference_y));
                cloneLine = cloneLine.transform.parent.gameObject;
                cloneLine.gameObject.transform.SetParent(childOb.transform);

            }
        }

    }

    public Vector2 GetScreenSize()
    {
        return new Vector2(Screen.width, Screen.height);
    }
}
