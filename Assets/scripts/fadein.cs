using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class fadein : MonoBehaviour
{
    public RectTransform panel_transform;
    private Image image_alpha;
    public disapear_bow disapear_bow;


    private float alpha;
    public float set_alpha;
    public bool gameover = false;
    public bool pushed = false;
    // Start is called before the first frame update
    void Start()
    {
        image_alpha = GetComponent<Image>();
        panel_transform = GetComponent<RectTransform>();
        alpha = image_alpha.color.a;
    }

    // Update is called once per frame
    void Update()
    {
        if (pushed)
        {
            Debug.Log("パネルフェードイン");
            panel_transform.anchoredPosition = new Vector2(0, 0);
            FadeIn(set_alpha);
            Invoke("ChangeScene1", 3.0f);
        }

        if(gameover)
        {
            Debug.Log("パネルフェードイン");
            panel_transform.anchoredPosition = new Vector2(0, 0);
            FadeIn(set_alpha);
            Invoke("ChangeScene2", 3.0f);
        }

    }

    void FadeIn(float value)
    {
        alpha += value;
        image_alpha.color = new Color(1, 1, 1, alpha);
    }

    void ChangeScene1()
    {
        SceneManager.LoadScene("main");
    }

    void ChangeScene2()
    {
        SceneManager.LoadScene("title");
    }
}