using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PremierScript : MonoBehaviour
{
    public Rigidbody rb;
    public Renderer rend;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0,0,1);
        }

        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0,0,-1);
        }

        if(Input.GetKey(KeyCode.Space))
        {
            transform.Translate(0,1,0);
        }

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-1,0,0);
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(1,0,0);
        }
    }

    private void OnMouseUp() 
    {
        // Ici, Random.Range génère un nombre aléatoire entre 0 et 1
        rend.material.color = new Color(Random.Range(0f, 1f),Random.Range(0f, 1f),Random.Range(0f, 1f));
        rb.useGravity = true; 
    }

    

}
