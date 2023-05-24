using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Raycast를 활용해 클릭하는 물체 감지

public class ClickScript : MonoBehaviour
{
    RaycastHit2D hit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0)){
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			RaycastHit2D hit = Physics2D.Raycast(worldPoint,Vector2.zero);
            print(hit.transform.gameObject.name);
        }
    }
}
