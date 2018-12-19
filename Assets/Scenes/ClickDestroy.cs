using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDestroy : MonoBehaviour {

    // Use this for initialization
    private void OnMouseDown()
    {
        Destroy(transform.gameObject);
    }
}
