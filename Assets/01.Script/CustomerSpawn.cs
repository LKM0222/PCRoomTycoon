using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerSpawn : MonoBehaviour
{
    public GameObject customerPrefabs;

    public Transform[] seatList = new Transform[Database.seatArr.Length];

    [SerializeField] float time = 5f;//random필요

    [SerializeField] float t = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        t += Time.deltaTime;

        if(t > time){
            var customer = Instantiate(customerPrefabs ,this.transform.position,Quaternion.identity);
            time = Random.Range(10f,15f);
            t = 0f;
        }
    }
}
