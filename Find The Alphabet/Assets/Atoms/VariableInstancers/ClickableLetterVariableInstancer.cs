using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms
{
    /// <summary>
    /// Variable Instancer of type `ClickableLetter`. Inherits from `AtomVariableInstancer&lt;ClickableLetterVariable, ClickableLetterPair, ClickableLetter, ClickableLetterEvent, ClickableLetterPairEvent, ClickableLetterClickableLetterFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/ClickableLetter Variable Instancer")]
    public class ClickableLetterVariableInstancer : AtomVariableInstancer<
        ClickableLetterVariable,
        ClickableLetterPair,
        ClickableLetter,
        ClickableLetterEvent,
        ClickableLetterPairEvent,
        ClickableLetterClickableLetterFunction>
    { }
}
