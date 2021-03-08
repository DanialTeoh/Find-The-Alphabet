using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `ClickableLetter`. Inherits from `AtomEvent&lt;ClickableLetter&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/ClickableLetter", fileName = "ClickableLetterEvent")]
    public sealed class ClickableLetterEvent : AtomEvent<ClickableLetter>
    {
    }
}
