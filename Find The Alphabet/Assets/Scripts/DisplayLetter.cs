using TMPro;
using UnityEngine;

public class DisplayLetter : MonoBehaviour {
    [SerializeField] bool upperCase;

    public void SetLetter(string letter) {
        GetComponent<TMP_Text>().text = upperCase ? letter.ToUpper() : letter.ToLower();
    }
}