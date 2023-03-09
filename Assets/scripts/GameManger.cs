using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    [SerializeField] private GameObject[] BowPrefabs;
    [SerializeField] private Transform[] waypoints;
    //[SerializeField] private GameObject[] Create_enemys = new GameObject[4];

    private float time;
    private int number;
    private int x_point;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Generate_Rhythm());
    }

    // Update is called once per frame
    void Update()
    {

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

    IEnumerator Generate_Rhythm()
    {
        randam_list(waypoints);
        number = UnityEngine.Random.Range(0, BowPrefabs.Length);
        Instantiate(BowPrefabs[number], new Vector2(waypoints[0].position.x, waypoints[0].position.y), Quaternion.identity);
        yield return new WaitForSeconds(0.5f);
        number = UnityEngine.Random.Range(0, BowPrefabs.Length);
        Instantiate(BowPrefabs[number], new Vector2(waypoints[1].position.x, waypoints[1].position.y), Quaternion.identity);
        yield return new WaitForSeconds(0.5f);
        number = UnityEngine.Random.Range(0, BowPrefabs.Length);
        Instantiate(BowPrefabs[number], new Vector2(waypoints[2].position.x, waypoints[2].position.y), Quaternion.identity);
        yield return new WaitForSeconds(0.5f);
        number = UnityEngine.Random.Range(0, BowPrefabs.Length);
        Instantiate(BowPrefabs[number], new Vector2(waypoints[3].position.x, waypoints[3].position.y), Quaternion.identity);
        yield return new WaitForSeconds(2f);
        StartCoroutine(Generate_Rhythm());
    }
}
