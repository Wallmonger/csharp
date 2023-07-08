using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PremierScript : MonoBehaviour
{
    public Rigidbody rb;
    public Renderer rend;

    float speed = 3;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        

        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);  
        }

        if(Input.GetKey(KeyCode.DownArrow))
        {
             transform.Translate(Vector3.back * Time.deltaTime * speed);  
        }
        
        if(Input.GetKey(KeyCode.LeftArrow))
        {
             transform.Translate(Vector3.left * Time.deltaTime * speed);  
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);  
        }


        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * 150);
        }

    }

    private void OnTriggerEnter(Collider other) 
    {
        // On supprime l'objet lié au collider
        Destroy(other.gameObject);
    }


    private void OnMouseUp() 
    {
        // Ici, Random.Range génère un nombre aléatoire entre 0 et 1
        rend.material.color = new Color(Random.Range(0f, 1f),Random.Range(0f, 1f),Random.Range(0f, 1f));
        rb.useGravity = true; 
    }


}
