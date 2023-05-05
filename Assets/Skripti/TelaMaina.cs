using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TelaMaina : MonoBehaviour {
    public Sprite[] atteluMasivs;
    public GameObject mainigaisAttels;
    public GameObject slaiderisGar;
    public GameObject slaiderisPlat;
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
    public void mainitGarumu()
    {
        Debug.Log("mainitGarumu called");
        float pasreizejaVertiba = slaiderisGar.GetComponent<Slider>().value;
        Vector2 currentScale = mainigaisAttels.transform.localScale;
        currentScale.x = pasreizejaVertiba;
        mainigaisAttels.transform.localScale = currentScale;
    }
    public void mainitPlatumu()
        {
            float pasreizejaVertiba = slaiderisPlat.GetComponent<Slider>().value;
            Vector2 currentScale = mainigaisAttels.transform.localScale;
            currentScale.y = pasreizejaVertiba;
            mainigaisAttels.transform.localScale = currentScale;
        }


    }
