using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeatScript : MonoBehaviour
{
    public GameObject seatPopup;

    Text title;
    
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        print("mouseDown");
        seatPopup.SetActive(true);
    }
}
