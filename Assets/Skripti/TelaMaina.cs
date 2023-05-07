using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TelaMaina : MonoBehaviour {
    public Sprite[] atteluMasivs;
    public GameObject mainigaisAttels;
    public GameObject slaiderisGar;
    public GameObject slaiderisPlat;
    public GameObject[] sieviesuApgerbi;
    public GameObject[] viriesuApgerbi;
    public GameObject attelotKiveri;
    public GameObject attelotbrunas;
    public GameObject attelotbikses;
    public GameObject attelotKurpes;
    public GameObject attelotKleitu;
    public GameObject attelotSievietesKurpes;
    void Start() {
        attelotKleitu.SetActive(false);
        attelotSievietesKurpes.SetActive(false);
    }
    public void DzimumuMaina(int skaitlis)
    {
        if (skaitlis == 0)
        {
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[0];
            foreach (GameObject apgerbs in viriesuApgerbi)
            {
                apgerbs.SetActive(true);
            }
            foreach (GameObject apgerbs in sieviesuApgerbi)
            {
                apgerbs.SetActive(false);
            }
        }
        else if (skaitlis == 1)
        {
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[1];
            attelotSievietesKurpes.SetActive(true);
            attelotKleitu.SetActive (true);
            attelotKiveri.SetActive(false);
            attelotbrunas.SetActive(false);
            attelotbikses.SetActive(false);
            attelotKurpes.SetActive(false);

            foreach (GameObject apgerbs in sieviesuApgerbi)
            {
                apgerbs.SetActive(true);
            }
            foreach (GameObject apgerbs in viriesuApgerbi)
            {
                apgerbs.SetActive(false);
            }
        }
        else
        {
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
