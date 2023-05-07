﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjektuPaslepsana : MonoBehaviour {
    public GameObject bronzasimg;
	public GameObject dzelzsimg;
	public GameObject melnasimg;
	public GameObject sakausejumaimg;
	public GameObject sefaimg;
	public GameObject kronisimg;
	public GameObject burvisimg;
	public GameObject santaimg;
	public GameObject gnomeimg;
	public GameObject zilaimg;
	public GameObject bronzasbimg;
	public GameObject melnasbimg;
	public GameObject dzelzsbimg;
	public GameObject sakausejumabimg;
	public GameObject bronzaskimg;
	public GameObject dzelzskimg;
	public GameObject sakausejumakimg;
	public GameObject bronzaskurpimg;
	public GameObject dzelzskurpimg;
	public GameObject sakausejumakurpimg;
	public GameObject melnaskurpimg;
	public GameObject zilaKleitaimg;
	public GameObject kurpessievietesparastasimg;
	public GameObject civilasKurpesSievimg;
	public GameObject rozaKurpesSievimg;
	public GameObject elegantaKleitaimg;
	public GameObject garaKleitaimg;
	void Start() {
		garaKleitaimg.SetActive(false);
		zilaKleitaimg.SetActive(false);
		civilasKurpesSievimg.SetActive(false);
		kurpessievietesparastasimg.SetActive(false);
		rozaKurpesSievimg.SetActive(false);
		elegantaKleitaimg.SetActive(false);
	}
    public void brunuAttelosana(bool vertiba) {
        bronzasimg.SetActive(vertiba);
		dzelzsimg.SetActive(vertiba);
		melnasimg.SetActive(vertiba);
		sakausejumaimg.SetActive(vertiba);

    }
	public void cepuruAttelosana(bool vertiba){
		sefaimg.SetActive(vertiba);
		kronisimg.SetActive(vertiba);
		burvisimg.SetActive(vertiba);
		santaimg.SetActive(vertiba);
		gnomeimg.SetActive(vertiba);
		zilaimg.SetActive (vertiba);
	}
	public void biksesAttelosana(bool vertiba) {
		bronzasbimg.SetActive(vertiba);
		melnasbimg.SetActive(vertiba);
		dzelzsbimg.SetActive(vertiba);
		sakausejumabimg.SetActive(vertiba);	
	}
	public void kiveruAttelosana(bool vertiba) {
		bronzaskimg.SetActive(vertiba);
		dzelzskimg.SetActive(vertiba);
		sakausejumakimg.SetActive(vertiba);
	}
	public void kurpesAttelosana(bool vertiba) {
		bronzaskurpimg.SetActive(vertiba);
		dzelzskurpimg.SetActive(vertiba);
		sakausejumakurpimg.SetActive(vertiba);
		melnaskurpimg.SetActive(vertiba);
	}
	public void kleitasAttelosana(bool vertiba) {
		zilaKleitaimg.SetActive(vertiba);
		elegantaKleitaimg.SetActive(vertiba);
		garaKleitaimg.SetActive(vertiba);
	}
	public void sievietesKurpesAttelosana(bool vertiba) {
		kurpessievietesparastasimg.SetActive(vertiba);
		civilasKurpesSievimg.SetActive(vertiba);
		rozaKurpesSievimg.SetActive(vertiba);
	}
}
