using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference Listener of type `ClickableLetter`. Inherits from `AtomEventReferenceListener&lt;ClickableLetter, ClickableLetterEvent, ClickableLetterEventReference, ClickableLetterUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/ClickableLetter Event Reference Listener")]
    public sealed class ClickableLetterEventReferenceListener : AtomEventReferenceListener<
        ClickableLetter,
        ClickableLetterEvent,
        ClickableLetterEventReference,
        ClickableLetterUnityEvent>
    { }
}
