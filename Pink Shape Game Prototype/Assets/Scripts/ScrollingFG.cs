using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingFG : MonoBehaviour
{
    public float beatTempo;
    public float endx;
    public float startx;

    private void Start()
    {
        beatTempo = beatTempo / 60f;
    }


    void Update()
    {
        transform.Translate(Vector2.left * beatTempo * Time.deltaTime);

        if (transform.position.x <= endx)
        {

            Vector2 pos = new Vector2(startx, transform.position.y);
            transform.position = pos;
        }
    }
}
