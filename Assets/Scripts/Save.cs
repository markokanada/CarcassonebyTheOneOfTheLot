using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using Unity;
using UnityEngine.UI;

public class Save : MonoBehaviour
{
    public void save(Text inputfield)
    {
        string filename = "test";
        string data = inputfield.text;
        StreamWriter sw = new StreamWriter($"{filename}.txt", false);
        sw.WriteLine(data);
        sw.Close();
        Debug.Log(data);
    }
}
