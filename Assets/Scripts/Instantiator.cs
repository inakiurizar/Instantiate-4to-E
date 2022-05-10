using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    public GameObject objectToClone;
    
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TripleInstantiate()
    {
        int counter = 0;
        while (counter < 3)
        {
            Instantiate(objectToClone);
            counter++;
        }
    }
}
