using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerMoving : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0.5f;
    [SerializeField] bool moveFlag = true;

    [SerializeField] Vector3 target;
    
    Customer customer = new Customer("test",true, 10001, 20001, 30001, 160, 4.5f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(moveFlag){
            this.transform.position = Vector3.MoveTowards(this.transform.position, target, Time.deltaTime * moveSpeed);
        }
        
    }
}
