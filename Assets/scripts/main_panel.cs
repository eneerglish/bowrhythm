using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class main_panel : MonoBehaviour
{
    public RectTransform main_panel_position;
    private Image main_panel_image;
    private float main_alpha;

    private bool fadein;
    // Start is called before the first frame update
    void Start()
    {
        main_panel_image = GetComponent<Image>();
        main_panel_position = GetComponent<RectTransform>();
        fadein = true;
        main_alpha = main_panel_image.color.a;
    }   

    // Update is called once per frame
    void Update()
    {
        FadeOut(0.001f);
    }

    void FadeOut(float value)
    {
        main_alpha -= value;
        main_panel_image.color = new Color(1, 1, 1, main_alpha);
        
        if(main_alpha <= 0)
        {
            fadein = false;
            main_panel_position.anchoredPosition = new Vector2(-512, 0);
        }
    }
}
