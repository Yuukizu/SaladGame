using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class FadeSS : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _renderer;
    private float _timer,interval = 2f;
    private float _alpha;
    private bool fading = false;

    private Coroutine _fadingCo;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {   ///******************\\\
        if (Input.GetKeyDown(KeyCode.F))
        {
            if(_fadingCo != null)
            {
                StopCoroutine(_fadingCo);
            }
            _fadingCo = StartCoroutine(Fading());

            
        }
        ///******************\\\


    }

    private void Fade()
    {
        
        Color c = _renderer.color;

        _timer += Time.deltaTime;
        if (_timer > interval)
        {
            for (float alpha = 1f; alpha >= 0f; alpha -= 0.01f)
            {
                c.a -= alpha;
                _renderer.color = c;

                _timer = 0;
            }

            
        }
        
    }
    
    
    private IEnumerator Fading()
    {
        
        float alpha= 1f;
        if(alpha > 0f)
        {
            
            alpha -= Time.deltaTime;
            Color c = _renderer.color;
            c.a -= alpha;
            _renderer.color = c;

            
        }
        

        yield return null;

    }

    
}
