#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `ClickableLetter`. Inherits from `AtomEventEditor&lt;ClickableLetter, ClickableLetterEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(ClickableLetterEvent))]
    public sealed class ClickableLetterEventEditor : AtomEventEditor<ClickableLetter, ClickableLetterEvent> { }
}
#endif
