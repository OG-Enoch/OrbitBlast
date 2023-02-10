using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KnobMechanics : MonoBehaviour
{
    private GameObject border;
    public GameObject knobParticle;
    public float lerpTime;
    public List<Color> TintColors;
    public SpriteRenderer spriteRenderer;
    private Image img;
    private float timer;
    public GameObject target;
    public GameObject targetParticles;
    // Start is called before the first frame update
    void Start()
    {
        ColorChanger();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private Color ColorChanger()
    {
        Color c = TintColors[Random.Range(0, TintColors.Count)];
        return spriteRenderer.color = c;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Border")
        {
            //Destroy(gameObject);
            Instantiate(knobParticle, transform.position, Quaternion.identity);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Target")
        {
            ColorChanger();
            Destroy(target.gameObject);
            Instantiate(targetParticles, target.transform.position, Quaternion.identity);
        }
    }
}
