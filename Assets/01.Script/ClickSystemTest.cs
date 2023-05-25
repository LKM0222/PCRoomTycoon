using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ClickSystemTest : MonoBehaviour
{
    bool onSelected;
    Camera mainCamera;
    RectTransform rectTransform;
    Vector2 targetPosition;
    RaycastHit2D hit;

    [SerializeField] GameObject selectedRingPrefabs;
    [SerializeField] GameObject nameBox;
    [SerializeField] TextMeshProUGUI nameText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MouseClickDown(){
        if(Input.GetMouseButtonDown(0)){
            print("mouse click");
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            hit = Physics2D.Raycast(worldPoint,Vector2.zero);

            BoolOnonSelected();
        }
    }

    void BoolOnonSelected(){
        if(hit.collider != null){
            targetPosition = hit.transform.position;

            InstantiateSelectRing();
        }
        else{
            onSelected = false;
            Destroy(GameObject.FindGameObjectWithTag("SelectedRing"));
            nameBox.SetActive(false);
        }
    }

    void InstantiateSelectRing(){
        if(!onSelected && !GameObject.FindGameObjectWithTag("SelectedRing")){
            onSelected = true;
            nameBox.SetActive(true);
            Instantiate(selectedRingPrefabs,targetPosition,transform.rotation);
        }
        else if(onSelected && GameObject.FindGameObjectWithTag("SelectedRing"))
        {
            GameObject.FindGameObjectWithTag("SelectedRing").transform.position = targetPosition;
        }
    }

    void UIName(){
        nameText.text = hit.collider.name;
        rectTransform.position = Camera.main.WorldToScreenPoint(targetPosition) - new Vector3(0,60);
    }
}
