#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `ClickableLetterPair`. Inherits from `AtomDrawer&lt;ClickableLetterPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ClickableLetterPairEvent))]
    public class ClickableLetterPairEventDrawer : AtomDrawer<ClickableLetterPairEvent> { }
}
#endif
