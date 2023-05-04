using System.Collections;
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
}
