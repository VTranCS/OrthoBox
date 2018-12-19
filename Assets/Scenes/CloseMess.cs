using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseMess : MonoBehaviour {

	// Use this for initialization
	public void deleteMessage(string s)
    {
        Destroy(transform.gameObject);
    }
}
