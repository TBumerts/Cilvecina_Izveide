using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VardsVecums : MonoBehaviour {
    public string vards;
    public string vecums;
    public GameObject ievadesVards;
    public GameObject ievadesVecums;
    public GameObject tekstaAttelosana;
    public void Teksts() {
        vards = ievadesVards.GetComponent<InputField>().text;
        vecums = ievadesVecums.GetComponent<InputField>().text;
        tekstaAttelosana.GetComponent<Text>().text = "Varonis: "+vards+" ar vecumu: "+vecums;
    }
}
