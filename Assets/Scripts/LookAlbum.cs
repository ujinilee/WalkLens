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
        print("������");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActiveInfo()
    {
        print("�Լ�������");
        info.SetActive(true);
    }
}
