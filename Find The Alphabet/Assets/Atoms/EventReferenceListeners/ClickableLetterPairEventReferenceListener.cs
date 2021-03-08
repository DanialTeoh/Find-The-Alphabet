using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference Listener of type `ClickableLetterPair`. Inherits from `AtomEventReferenceListener&lt;ClickableLetterPair, ClickableLetterPairEvent, ClickableLetterPairEventReference, ClickableLetterPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/ClickableLetterPair Event Reference Listener")]
    public sealed class ClickableLetterPairEventReferenceListener : AtomEventReferenceListener<
        ClickableLetterPair,
        ClickableLetterPairEvent,
        ClickableLetterPairEventReference,
        ClickableLetterPairUnityEvent>
    { }
}
