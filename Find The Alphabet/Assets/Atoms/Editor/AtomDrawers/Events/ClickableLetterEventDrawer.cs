#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `ClickableLetter`. Inherits from `AtomDrawer&lt;ClickableLetterEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ClickableLetterEvent))]
    public class ClickableLetterEventDrawer : AtomDrawer<ClickableLetterEvent> { }
}
#endif
