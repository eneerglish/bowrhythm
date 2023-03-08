using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_UI : MonoBehaviour
{
    public GameObject main_bow;
    // Start is called before the first frame update
    void Start()
    {
        main_bow = GameObject.Find("main_bow");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click()
    {
        GetComponent<Button>().interactable = false;
        main_bow.GetComponent<disapear_bow>().pushed = true;
    }
}
