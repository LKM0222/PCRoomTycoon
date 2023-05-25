using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Raycast를 활용해 클릭하는 물체 감지

public class ClickScript : MonoBehaviour
{
    RaycastHit2D hit;

    public GameObject seatPopup;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown() {
        Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		RaycastHit2D hit = Physics2D.Raycast(worldPoint,Vector2.zero);

        print(hit.transform.tag);
    }
}

/*
코드저장소~~
기존update문에 있던 코드 그대로 복사해서 쓰면 됨
if(Input.GetMouseButton(0)){
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			RaycastHit2D hit = Physics2D.Raycast(worldPoint,Vector2.zero);
            //print(hit.transform.gameObject.layer);

            try{
                switch(hit.transform.gameObject.layer){
                    case 6://seat
                        seatPopup.SetActive(true);
                        break;

                    default:
                        print("등록되지 않음");
                        break;
                }
            }
            catch(System.NullReferenceException){
                print("x");
            }
           
            
            
            
        }

*/
