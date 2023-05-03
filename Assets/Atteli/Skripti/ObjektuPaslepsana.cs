using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjektuPaslepsana : MonoBehaviour {
    public GameObject brunasimg;
    public GameObject cepures;
    public void brunuAttelosana(bool vertiva) {
        brunasimg.SetActive(vertiva);
    }
}
