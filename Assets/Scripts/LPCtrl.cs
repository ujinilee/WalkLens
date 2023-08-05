using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LPCtrl : MonoBehaviour
{
    public Transform Target;
    public float Speed = 1f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Target.position, Speed * Time.deltaTime);
    }

}
