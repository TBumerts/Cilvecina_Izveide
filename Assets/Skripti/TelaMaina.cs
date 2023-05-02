using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TelaMaina : MonoBehaviour {
    public Sprite[] atteluMasivs;
    public GameObject mainigaisAttels;
    public void DzimumuMaina(int skaitlis) {
        if (skaitlis == 0)
        {
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[0];
        }
        else if (skaitlis == 1)
        {
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[1];
        }
        else {
            Debug.Log("Nav piesaistīts attēls!");
        }
    }
}
