using System;
using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;

public class NextLetterToGuess : MonoBehaviour {
    public StringVariable LetterToGuess;
    public IntVariable GuessAnswers;
    public IntConstant CorrectAnswers;

    void Start() {
        LetterToGuess.Value = "a";
    }


    public void HandleCorrectLetterClick(ClickableLetter clickableLetter) {
        clickableLetter.Color = Color.green;
        clickableLetter.enabled = false;

        if (GuessAnswers.Value >= CorrectAnswers.Value) {
            MoveToNextLetter();
        }
    }

    private void MoveToNextLetter() {
        LetterToGuess.Value = Convert.ToChar(LetterToGuess.Value[0] + 1).ToString();
        if (LetterToGuess.Value[0] > 122)
            LetterToGuess.Value = "a";
    }
}