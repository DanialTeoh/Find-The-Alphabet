#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `ClickableLetter`. Inherits from `AtomDrawer&lt;ClickableLetterVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ClickableLetterVariable))]
    public class ClickableLetterVariableDrawer : VariableDrawer<ClickableLetterVariable> { }
}
#endif
