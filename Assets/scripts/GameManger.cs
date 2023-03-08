using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    [SerializeField] private GameObject[] BowPrefabs;
    [SerializeField] private Transform[] waypoints;
    [SerializeField] private GameObject[] Create_enemys = new GameObject[4];
    private float time;
    private int number;
    private int x_point;

    // Start is called before the first frame update
    void Start()
    {
        time = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if(time <= 0.0f)
        {
            time = 1.0f;
            randam_list(waypoints);
            for (int i = 0; i < Create_enemys.Length; i++)
            {
                number = UnityEngine.Random.Range (0, BowPrefabs.Length);
                Create_enemys[i] = BowPrefabs[number];
                Instantiate(Create_enemys[i], new Vector2(waypoints[i].position.x, waypoints[i].position.y), Quaternion.identity);
            }
        }
    }

    void randam_list(Transform[] num)
    {
        for(int i = 0; i < num.Length; i++)
        {
            //現在の要素をtempに預ける
            Transform temp = num[i];
            //入れ替える先をランダムに選ぶ
            int randomIndex = UnityEngine.Random.Range(0, num.Length);
            //選んだ先のデータを元の要素に入れる
            num[i] = num[randomIndex];
            //選んだ先に元のデータを入れる
            num[randomIndex] = temp;
        }
    }
}
