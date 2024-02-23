using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DachAusblenden : MonoBehaviour
{
    public GameObject dach;
    // Start is called before the first frame update
    public void einAusBlenden() {
        if(dach.activeInHierarchy) {
            dach.SetActive(false);
        } else {
            dach.SetActive(true);
        }
    }
}
