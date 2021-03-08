using System;
using System.Collections.Generic;
using System.Linq;
using UnityAtoms.BaseAtoms;
using UnityEngine;

public class GameBoard : MonoBehaviour {
    public StringVariable LetterToGuess;
    public IntVariable GuessAnswers;
    public IntConstant CorrectAnswers;

    private ClickableLetter[] _clickableLetters;


    void Awake() {
        _clickableLetters = FindObjectsOfType<ClickableLetter>();
    }

    public void Generate(string letterToGuess) {
        List<char> charsList = new List<char>();

        for (int i = 0; i < CorrectAnswers.Value; i++)
            charsList.Add(Convert.ToChar(letterToGuess));

        for (int i = CorrectAnswers.Value; i < _clickableLetters.Length; i++) {
            var chosenLetter = ChooseInvalidRandomLetter(Convert.ToChar(letterToGuess));
            charsList.Add(chosenLetter);
        }

        charsList = charsList
            .OrderBy(t => UnityEngine.Random.Range(0, 10000))
            .ToList();

        for (int i = 0; i < _clickableLetters.Length; i++) {
            _clickableLetters[i].Letter = charsList[i];
        }
    }

    private char ChooseInvalidRandomLetter(char correctLetter) {
        int a = UnityEngine.Random.Range(0, 26);
        var randomLetter = (char) ('a' + a);
        while (randomLetter == correctLetter) {
            a = UnityEngine.Random.Range(0, 26);
            randomLetter = (char) ('a' + a);
        }

        return randomLetter;
    }
}