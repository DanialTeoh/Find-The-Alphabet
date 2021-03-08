using System;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `ClickableLetterPair`. Inherits from `AtomEventReference&lt;ClickableLetterPair, ClickableLetterVariable, ClickableLetterPairEvent, ClickableLetterVariableInstancer, ClickableLetterPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ClickableLetterPairEventReference : AtomEventReference<
        ClickableLetterPair,
        ClickableLetterVariable,
        ClickableLetterPairEvent,
        ClickableLetterVariableInstancer,
        ClickableLetterPairEventInstancer>, IGetEvent 
    { }
}
