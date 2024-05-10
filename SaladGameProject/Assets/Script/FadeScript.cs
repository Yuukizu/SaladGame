using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeScript : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _renderer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            Fade();
        }
    }

    private void Fade()
    {
        Color c = _renderer.color;
        for(float alpha =1f; alpha>= 0f; alpha -= 0.01f)
        {
            c.a = alpha;
            _renderer.color = c;
        }
    }
}
