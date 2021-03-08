using TMPro;
using UnityAtoms.BaseAtoms;
using UnityEngine;

public class RemainingCounterText : MonoBehaviour {
    public IntConstant CorrectAnswer;

    public void OnChangeGuessAnswers(int guessAnswers) {
        GetComponent<TMP_Text>().text = "x" + (CorrectAnswer.Value - guessAnswers);
    }
}