using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Value List of type `ClickableLetter`. Inherits from `AtomValueList&lt;ClickableLetter, ClickableLetterEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/ClickableLetter", fileName = "ClickableLetterValueList")]
    public sealed class ClickableLetterValueList : AtomValueList<ClickableLetter, ClickableLetterEvent> { }
}
