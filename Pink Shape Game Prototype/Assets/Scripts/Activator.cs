using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    public KeyCode key;
    bool active = false;
    GameObject note;
    public GameObject effect;

    private Shake shake;

    private void Start()
    {
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<Shake>();
    }

    void Update()
    {
        if (Input.GetKeyDown(key) && active)
        {
            shake.CamShake();
            Destroy(note);
            Instantiate(effect, transform.position, Quaternion.identity);
        }

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        active = true;
        if (col.gameObject.tag == "Note")
            note = col.gameObject;

    }

    void OnTriggerExit2D(Collider2D col)    
    {
        active = false;

    }
}