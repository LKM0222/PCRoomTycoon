using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    Vector2 prePos,nowPos,movePos;
    public float speed;

    [SerializeField] bool isAlt;
    [SerializeField] Vector2 clickPoint;
    [SerializeField] float dragSpeed = 30.0f;

    public GameObject backGround;
    Vector2 leftTop, rightBottom;

    // Start is called before the first frame update
    void Start()
    {
        float xSize = backGround.GetComponent<BoxCollider2D>().bounds.size.x;
        float ySize = backGround.GetComponent<BoxCollider2D>().bounds.size.y;
        Vector2 boxPos = backGround.transform.position;
        leftTop = new Vector2(boxPos.x - (xSize/2), boxPos.y + (ySize/2));
        rightBottom = new Vector2(boxPos.x + (xSize/2) , boxPos.y - (ySize / 2));

        print(leftTop + " " + rightBottom);
    }

    // // Update is called once per frame(touch)
    // void Update()
    // {
    //     int touchCount = Input.touchCount;

    //     if(touchCount == 1){
    //         Touch touch = Input.GetTouch (0);

    //         if( touch.phase == TouchPhase.Began )
    //         {
    //             prePos = touch.position - touch.deltaPosition;
    //         }
    //         else if(touch.phase == TouchPhase.Moved)
    //         {			
    //             nowPos = touch.position - touch.deltaPosition;
    //             movePos = (Vector2)(prePos - nowPos) * speed;
                
    //             // this.gameObject.GetComponent().transform.Translate(movePos);
    //             this.transform.Translate(movePos);
                
    //             MoveLimit();	
                
    //             prePos = touch.position - touch.deltaPosition;
    //         }
    //     }
        
    // }


    // Update is called once per frame(drag)
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.LeftAlt)) isAlt = true;
        if (Input.GetKeyUp(KeyCode.LeftAlt)) isAlt = false;

        if(Input.GetMouseButtonDown(0))clickPoint = Input.mousePosition;

        if (Input.GetMouseButton(0))
        {
            if (isAlt)
            {
				Vector3 pos = Camera.main.ScreenToViewportPoint((Vector2) Input.mousePosition - clickPoint);
                
                Vector3 move = pos * (Time.deltaTime * dragSpeed);

                MoveLimit();

                transform.Translate(move);

                
            }
        }
        
    }

    void MoveLimit()
    {
        Vector2 temp;
        //temp.x = Mathf.Clamp( transform.position.x , SideXY[ LeftX ] , SideXY[ RightX ] );
        temp.x = Mathf.Clamp( transform.position.x , leftTop.x, rightBottom.x);
        //temp.y = Mathf.Clamp( transform.position.y , SideXY[ BottomY ] , SideXY[ TopY ] );
        temp.y = Mathf.Clamp( transform.position.y, leftTop.y, rightBottom.y);
        
        transform.position = new Vector3(temp.x, temp.y ,this.transform.position.z);	
    }
}
