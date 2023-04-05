using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class BasicFeatures : MonoBehaviour
{
    public void doExitGame(){
        Application.Quit();
        Debug.Log("Exit 0");
    }

    public Vector2 GetScreenSize() {
    return new Vector2(Screen.width, Screen.height);
    }

    public void CreateBackground(){
        for (int i = 0 ; i < GetScreenSize().y/(GetScreenSize().x/(double)7); i++)
        {
            int multiplier = 0;
            if(i < GetScreenSize().y/(GetScreenSize().x/(double)7)/2){
                multiplier = -1*i;
            }
            else if(i > GetScreenSize().y/(GetScreenSize().x/(double)7)/2){
                multiplier = 1* (int)i-(int)(GetScreenSize().y/(GetScreenSize().x/(double)7)/2);
            }
            for (int j = 0; j < 7; j++)
            {
                        Object prefab = AssetDatabase.LoadAssetAtPath("Assets/BackgroundImages.prefab", typeof(GameObject));

                        GameObject clone = Instantiate(prefab, Vector3.zero, Quaternion.identity) as GameObject;
                        // Modify the clone to your heart's content
                        clone.transform.localScale = new Vector3(((GetScreenSize().x/(float) 7)/(float) 100),((GetScreenSize().x/(float) 7)/(float) 100),((GetScreenSize().x/(float) 7)/(float) 100));
                        if(j<3){
                            clone.transform.position = new Vector2((-1*j*(GetScreenSize().x/(float) 7)),multiplier*100*(GetScreenSize().x/(float) 7) );
                        }
                        else if(j==3){
                            clone.transform.position = new Vector2(0,i*(GetScreenSize().x/(float) 7));
                        }
                        else if(j>3){
                            clone.transform.position = new Vector2((1*j*(GetScreenSize().x/(float) 7)),multiplier*100*(GetScreenSize().x/(float) 7) );
                        }
                        
            }
        }

    }

    void Start(){
        CreateBackground();

    }
}

