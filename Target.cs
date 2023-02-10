using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Target : MonoBehaviour
{
    public List<Color> TintColors;
    public SpriteRenderer spriteRenderer;
    private Image img;
    private float timer;
    void Start()
    {
        ColorChanger();
    }
    
    void Update()
    {
        //StartCoroutine(ColorChange());
        timer += Time.deltaTime;
        if(timer > 4)
        {
            ColorChanger();
            timer = 0;
        }

    }

    private Color ColorChanger()
    {
        Color c = TintColors[Random.Range(0, TintColors.Count)];
        return spriteRenderer.color = c;
    }
}
