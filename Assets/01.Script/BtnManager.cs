using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnManager : MonoBehaviour
{
    public GameObject publicGameObj;
    //public 
    public void OnPopupOpenClose(){
        if(publicGameObj.activeSelf == true){
            publicGameObj.SetActive(false);
        }
        else{
            publicGameObj.SetActive(true);
        }
    }

}
