using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apear : MonoBehaviour
{
    private SpriteRenderer sp;
    private int count;
    private bool isOn = true;

    // Start is called before the first frame update
    void Start()
    {
        sp = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        count += 1;
        
        if(count % 150 == 0)
        {
            if(isOn)
            {
                sp.enabled = false;
                isOn = false;
            }
            else if(!isOn)
            {
                sp.enabled = true;
                isOn = true;
            }
        }
    }
}
