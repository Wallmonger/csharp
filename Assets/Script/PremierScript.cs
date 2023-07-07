using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PremierScript : MonoBehaviour
{

    public string couleur = "rouge";
    public int nbVie = 3;
    public float or = 3.5f;
    public float subOr = 1.1f; 
    public bool estActif = false;
    public Vector3 speed;

    // Special var for colors in unity
    public Color col;
    // We also can include components directly.
    public Rigidbody rb;
    public Renderer rend;





    // Start is called before the first frame update
    void Start()
    {
        rend.material.color = col;
        rb.useGravity = true;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime);
        rend.material.color = col;
    }
}
