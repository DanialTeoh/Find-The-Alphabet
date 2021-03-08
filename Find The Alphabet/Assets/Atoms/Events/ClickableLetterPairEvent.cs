using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `ClickableLetterPair`. Inherits from `AtomEvent&lt;ClickableLetterPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/ClickableLetterPair", fileName = "ClickableLetterPairEvent")]
    public sealed class ClickableLetterPairEvent : AtomEvent<ClickableLetterPair>
    {
    }
}
