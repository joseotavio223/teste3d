using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleobjeto : MonoBehaviour
{
    public GameObject objeto;   
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
        gameObject.GetComponent<MeshRenderer>().enabled=false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other){
       Debug.Log("Start");
       objeto.GetComponent<MeshRenderer>().enabled= false;
       
    }

    void OnTriggerStay(Collider other){
       //Debug.Log("Stay");
    }
    void OnTriggerExit(Collider other){
       objeto.GetComponent<MeshRenderer>().enabled = true;
    }
}