using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms
{
    /// <summary>
    /// Adds Variable Instancer's Variable of type ClickableLetter to a Collection or List on OnEnable and removes it on OnDestroy. 
    /// </summary>
    [AddComponentMenu("Unity Atoms/Sync Variable Instancer to Collection/Sync ClickableLetter Variable Instancer to Collection")]
    [EditorIcon("atom-icon-delicate")]
    public class SyncClickableLetterVariableInstancerToCollection : SyncVariableInstancerToCollection<ClickableLetter, ClickableLetterVariable, ClickableLetterVariableInstancer> { }
}
