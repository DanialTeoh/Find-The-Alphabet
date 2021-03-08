using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `ClickableLetter`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(ClickableLetterVariable))]
    public sealed class ClickableLetterVariableEditor : AtomVariableEditor<ClickableLetter, ClickableLetterPair> { }
}
