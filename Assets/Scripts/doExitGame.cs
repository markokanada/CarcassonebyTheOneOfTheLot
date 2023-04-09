using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using Unity;
using UnityEngine.UI;

public class doExitGame : MonoBehaviour
{
    public void DoExitGame()
    {
        Application.Quit();
        Debug.Log("Exit 0");
    }
}
