using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour {

    public void QuitApp(string s)
    {
        Debug.Log(s);
        Application.Quit();
    }
}
