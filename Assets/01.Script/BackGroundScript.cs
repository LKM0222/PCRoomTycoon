using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//백그라운드를 배열로 나누어 칸마다 정보를 매긴다.
//크기는 n*n 정사각형의 크기로 나눈다.(n=10)
public class BackGroundScript : MonoBehaviour
{
    public int[,] map = new int[10,10];
    public BoxCollider2D mapGrid;
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
