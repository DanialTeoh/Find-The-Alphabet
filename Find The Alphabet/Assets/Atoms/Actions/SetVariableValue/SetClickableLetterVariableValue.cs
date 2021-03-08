using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms
{
    /// <summary>
    /// Set variable value Action of type `ClickableLetter`. Inherits from `SetVariableValue&lt;ClickableLetter, ClickableLetterPair, ClickableLetterVariable, ClickableLetterConstant, ClickableLetterReference, ClickableLetterEvent, ClickableLetterPairEvent, ClickableLetterVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/ClickableLetter", fileName = "SetClickableLetterVariableValue")]
    public sealed class SetClickableLetterVariableValue : SetVariableValue<
        ClickableLetter,
        ClickableLetterPair,
        ClickableLetterVariable,
        ClickableLetterConstant,
        ClickableLetterReference,
        ClickableLetterEvent,
        ClickableLetterPairEvent,
        ClickableLetterClickableLetterFunction,
        ClickableLetterVariableInstancer>
    { }
}
