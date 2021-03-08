using System;
using System.Collections;
using System.Collections.Generic;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

public class ScoreBoard : MonoBehaviour {
    public IntVariable GuessAnswers;
    public IntConstant CorrectAnswers;
    public StringVariable LetterToGuess;

    public ClickableLetterEvent TappedCorrectLetterEvent;


    public void Awake() {
        ResetScore();
    }

    public void OnTappedLetter(ClickableLetter clickableLetter) {
        if (clickableLetter.enabled && clickableLetter.Letter == LetterToGuess.Value[0]) {
            HandleCorrectLetterClick(clickableLetter);
        }
    }

    internal void HandleCorrectLetterClick(ClickableLetter clickableLetter) {
        GuessAnswers.Value += 1;
        TappedCorrectLetterEvent.Raise(clickableLetter);
    }

    public void ResetScore() {
        GuessAnswers.Value = 0;
    }
}