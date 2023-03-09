using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disapear_bow : MonoBehaviour
{
    public bool pushed = false;
    private SpriteRenderer main_sp;
    private Animator smoke;
    private fadein title_fadein;
    
    // Start is called before the first frame update
    void Start()
    {
        main_sp = GetComponent<SpriteRenderer>();
        smoke = GameObject.Find("smoke_animation").GetComponent<Animator>();
        title_fadein = GameObject.Find("Panel").GetComponent<fadein>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit2d = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);
            if(hit2d.transform.gameObject.CompareTag("main_bow"))
            {
                title_fadein.pushed = true;
                Debug.Log("シーン移動");
                main_sp.enabled = false;
                smoke.SetTrigger("Exit");
            }
        }
    }
}

