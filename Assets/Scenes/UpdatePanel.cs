using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdatePanel : MonoBehaviour {
    public Text infobox;
    public string info;
	// Use this for initialization
	void OnMouseDown()
    {
        infobox.text = info;
    }
}
