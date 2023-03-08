using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fadeout : MonoBehaviour
{
    public RectTransform panel_transform;
    private Image image_alpha;
    public disapear_bow disapear_bow;


    private float alpha;
    public float set_alpha;
    // Start is called before the first frame update
    void Start()
    {
        disapear_bow = GameObject.Find("main_bow").GetComponent<disapear_bow>();
        image_alpha = GetComponent<Image>();
        panel_transform = GetComponent<RectTransform>();
        alpha = image_alpha.color.a;
    }

    // Update is called once per frame
    void Update()
    {
        if (disapear_bow.pushed == true)
        {
            panel_transform.anchoredPosition = new Vector2(0, 0);
            FadeIn(set_alpha);
        }
    }

    void FadeIn(float value)
    {
        alpha += value;
        image_alpha.color = new Color(1, 1, 1, alpha);
    }
}