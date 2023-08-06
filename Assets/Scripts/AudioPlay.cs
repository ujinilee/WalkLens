using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlay : MonoBehaviour
{
    public bool activeHand = false;
    public int func = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay(Collision collider)
    {
        print(collider.gameObject.tag);
        if (collider.gameObject.tag == "Hole" && activeHand==false && func == 1)
        {
            PlayMusic();
            func = 2;
        }
        
    }

    public void PlayMusic()
    {
        GetComponent<AudioSource>().Play();
    }

    public void SwitchTrue()
    {
        activeHand = true;

    }

    public void SwitchFalse()
    {
        activeHand = false;
    }
}
