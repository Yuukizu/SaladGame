using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeCoroutine : MonoBehaviour
{
    private Color color1 = Color.white;
    private Color color2 = Color.black;

    [SerializeField] private float _timer = 0;
    [SerializeField] private float C_Speed = 1.0f;
    [SerializeField] private SpriteRenderer spriteRenderer;

    private bool lerpDirection = true;

    void Start()
    {
        StartCoroutine(ChangeColors());
    }

    IEnumerator ChangeColors()
    {
        float timer = 0;
        float t = Mathf.Clamp01(timer);


        while (true)
        {
            if (lerpDirection)
            {
                _timer += Time.deltaTime * C_Speed;
            }
            else
            {
                _timer -= Time.deltaTime * C_Speed;
            }

            _timer = Mathf.Clamp01(_timer);

            if (t <= 0 || t >= 1)
            {
                lerpDirection = !lerpDirection;
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                lerpDirection = !lerpDirection;
            }

            spriteRenderer.color = Color.Lerp(color1, color2, _timer);
        }
    }
}
