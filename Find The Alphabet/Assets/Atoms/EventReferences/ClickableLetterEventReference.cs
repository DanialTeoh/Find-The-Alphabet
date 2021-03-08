using System;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `ClickableLetter`. Inherits from `AtomEventReference&lt;ClickableLetter, ClickableLetterVariable, ClickableLetterEvent, ClickableLetterVariableInstancer, ClickableLetterEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ClickableLetterEventReference : AtomEventReference<
        ClickableLetter,
        ClickableLetterVariable,
        ClickableLetterEvent,
        ClickableLetterVariableInstancer,
        ClickableLetterEventInstancer>, IGetEvent 
    { }
}
