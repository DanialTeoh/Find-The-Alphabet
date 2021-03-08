using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Instancer of type `ClickableLetter`. Inherits from `AtomEventInstancer&lt;ClickableLetter, ClickableLetterEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/ClickableLetter Event Instancer")]
    public class ClickableLetterEventInstancer : AtomEventInstancer<ClickableLetter, ClickableLetterEvent> { }
}
