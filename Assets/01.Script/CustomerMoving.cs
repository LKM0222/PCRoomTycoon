using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TargetQueue{
    private Queue<Transform> _queue = new Queue<Transform>();

    public void Enqueue(Transform _pos){
        _queue.Enqueue(_pos);
    }

    public Transform Dequeue(){
        return _queue.Dequeue();
    }

    public Transform Peek(){
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


    public Transform target;
    
    public TargetQueue targets;
    public Transform lobby;
    //Customer customer = new Customer("test",true, 10001, 20001, 30001, 160, 4.5f);
    // Start is called before the first frame update
    void Start()
    {   lobby = GameObject.Find("LobbyPoint").GetComponent<Transform>();
        targets.Enqueue(lobby);
    }

    // Update is called once per frame
    void Update()
    {
        if(moveFlag){
            target = targets.Peek();
            this.transform.position = Vector3.MoveTowards(this.transform.position, target.transform.position, Time.deltaTime * moveSpeed);
            if(this.transform.position == target.transform.position){
                print(targets.Dequeue());
            }
        }
        
    }
}
