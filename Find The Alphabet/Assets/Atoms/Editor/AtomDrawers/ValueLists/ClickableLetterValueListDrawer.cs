#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `ClickableLetter`. Inherits from `AtomDrawer&lt;ClickableLetterValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ClickableLetterValueList))]
    public class ClickableLetterValueListDrawer : AtomDrawer<ClickableLetterValueList> { }
}
#endif
