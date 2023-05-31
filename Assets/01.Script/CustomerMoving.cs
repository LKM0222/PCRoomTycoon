using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyQueue{
    private Queue<Transform> _queue = new Queue<Transform>();

    public void Enqueue(Transform _pos){
        _queue.Enqueue(_pos);
    }

    public Transform Dequeue(){
        return _queue.Dequeue();
    }

    public Transform Pick(){
        return _queue.Peek();
    }

    public int Count(){
        return _queue.Count;
    }
}

public class CustomerMoving : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0.5f;
    [SerializeField] bool moveFlag = true;

    //움직임 리스트를 큐 구조로 구현하는게 좋을듯?


    public Vector3 target;
    
    
    //Customer customer = new Customer("test",true, 10001, 20001, 30001, 160, 4.5f);
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
