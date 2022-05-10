using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiator : MonoBehaviour
{
    public GameObject objectToClone;
    int cloneAmount;
    public Text txtUserCloneAmount;
    GameObject clon;

    public void MultiInstantiate()
    {
        if (txtUserCloneAmount.text != " ")
        {
            cloneAmount = int.Parse(txtUserCloneAmount.text);
        }
        
        for(int i = 0; i<cloneAmount; i++)
        {
            clon = Instantiate(objectToClone);
            Destroy(clon, 2);
        }
    }
}
