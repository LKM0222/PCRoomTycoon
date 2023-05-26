using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeatScript : MonoBehaviour
{

    Database theDB;
    public GameObject seatPopup;

    public int seatNum;
    [SerializeField] Text title;

    private void Start()
    {
        theDB = FindObjectOfType<Database>();
    }
    
    private void Update() {
        
        title.text = seatNum.ToString() + "번 좌석";
    }
    
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        print("mouseDown");
        seatPopup.SetActive(true);
    }
}
