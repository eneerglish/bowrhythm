using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemys : MonoBehaviour
{
    private float speed = 20;
    private float move;
    private GameManger gamemanger;
    private fadein main_fadein;

    private float spawn_time;
    private float perfect_time;
    // Start is called before the first frame update
    void Start()
    {
        main_fadein = GameObject.Find("Panel").GetComponent<fadein>();
        gamemanger = GameObject.Find("gamemanager").GetComponent<GameManger>();
    }

    // Update is called once per frame
    void Update()
    {
        move = transform.position.y + Time.deltaTime * speed;
        if(move < 0)
        {
            transform.position = new Vector2(transform.position.x, move);
            spawn_time = Time.time;
        }
        else
        {
            transform.position = new Vector2(transform.position.x, 0);
            
            if(Time.time > spawn_time + 0.5f)
            {
                Debug.Log("ゲームオーバー");
                main_fadein.gameover = true;
            }
        }

        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit2d = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);
            Destroy(hit2d.transform.gameObject);
        }
    }
}
