#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `ClickableLetter`. Inherits from `AtomDrawer&lt;ClickableLetterConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ClickableLetterConstant))]
    public class ClickableLetterConstantDrawer : VariableDrawer<ClickableLetterConstant> { }
}
#endif
