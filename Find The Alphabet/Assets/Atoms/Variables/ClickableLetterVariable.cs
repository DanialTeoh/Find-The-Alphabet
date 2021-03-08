using UnityEngine;
using System;

namespace UnityAtoms
{
    /// <summary>
    /// Variable of type `ClickableLetter`. Inherits from `AtomVariable&lt;ClickableLetter, ClickableLetterPair, ClickableLetterEvent, ClickableLetterPairEvent, ClickableLetterClickableLetterFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/ClickableLetter", fileName = "ClickableLetterVariable")]
    public sealed class ClickableLetterVariable : AtomVariable<ClickableLetter, ClickableLetterPair, ClickableLetterEvent, ClickableLetterPairEvent, ClickableLetterClickableLetterFunction>
    {
        protected override bool ValueEquals(ClickableLetter other)
        {
            throw new NotImplementedException();
        }
    }
}
