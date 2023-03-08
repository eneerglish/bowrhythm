using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemys : MonoBehaviour
{
    [SerializeField] private float speed = 5;
    private float move;
    private GameManger gamemanger;
    // Start is called before the first frame update
    void Start()
    {
        gamemanger = GameObject.Find("gamemanager").GetComponent<GameManger>();
    }

    // Update is called once per frame
    void Update()
    {
        move = transform.position.y + Time.deltaTime * speed;
        if(move < 0)
        {
            transform.position = new Vector2(transform.position.x, move);
        }
        else
        {
            transform.position = new Vector2(transform.position.x, 0);
        }

        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit2d = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);
            Destroy(hit2d.transform.gameObject);
        }
    }
}
