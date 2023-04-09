using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using Unity;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    public void sceneLoader(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
