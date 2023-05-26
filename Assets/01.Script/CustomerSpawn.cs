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
            customer.GetComponent<CustomerMoving>().target = 
                new Vector3(Random.RandomRange(0f,5f), Random.RandomRange(0f,5f), customer.transform.position.z);
            time = Random.RandomRange(10f,15f);
            t = 0f;
        }
    }
}
