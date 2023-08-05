using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAlbum : MonoBehaviour
{
    GameObject info;

    // Start is called before the first frame update
    void Start()
    {
        info = transform.GetChild(2).gameObject;
        print("실행중");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActiveInfo()
    {
        print("함수실행중");
        info.SetActive(true);
    }
}
