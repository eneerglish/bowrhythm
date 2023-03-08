using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class disapear_bow : MonoBehaviour
{
    public bool pushed = false;
    private SpriteRenderer main_sp;
    private Animator smoke;
    
    // Start is called before the first frame update
    void Start()
    {
        main_sp = GetComponent<SpriteRenderer>();
        smoke = GameObject.Find("smoke_animation").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(pushed)
        {
            Debug.Log("シーン移動");
            main_sp.enabled = false;
            smoke.SetTrigger("Exit");
            Invoke("ChangeScene", 3.0f);
        }
    }

     void ChangeScene()
    {
        SceneManager.LoadScene("main");
    }
}
