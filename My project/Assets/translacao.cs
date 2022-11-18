using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class translacao : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(Time.deltaTime*1f,0f,0f);
    }
}
