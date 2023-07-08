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
        
    }

    private void OnMouseUp() 
    {
        // Ici, Random.Range génère un nombre aléatoire entre 0 et 1
        float val = Random.Range(0f, 1f);
        rend.material.color = new Color(val,val,val);
        rb.useGravity = true; 
    }

    

}
