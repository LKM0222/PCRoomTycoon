using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    Vector2 bounds;
    // Start is called before the first frame update
    void Start()
    {
        bounds = this.gameObject.GetComponent<BoxCollider2D>().bounds.size;
        print("cameraWindow is " + bounds.x + ","+ bounds.y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
