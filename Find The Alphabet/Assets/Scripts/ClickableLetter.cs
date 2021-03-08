using System;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using Random = UnityEngine.Random;

public class ClickableLetter : MonoBehaviour {
    private char _letter;
    private bool _upperCase;

    private TMP_Text _tmpText;

    public char Letter {
        get => _letter;
        set {
            enabled = true;
            _tmpText.color = Color.white;
            _letter = value;
            if (Random.Range(0, 100) > 50) {
                _upperCase = false;
                _tmpText.text = _letter.ToString();
            }
            else {
                _upperCase = true;
                _tmpText.text = _letter.ToString().ToUpper();
            }
        }
    }

    public Color Color {
        get => _tmpText.color;
        set => _tmpText.color = value;
    }

    private void Awake() {
        _tmpText = GetComponent<TMP_Text>();
    }


    public bool IsUpperCase() {
        return _upperCase;
    }

    void Update() {
        
    }
}