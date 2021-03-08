using System;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `ClickableLetter`. Inherits from `AtomReference&lt;ClickableLetter, ClickableLetterPair, ClickableLetterConstant, ClickableLetterVariable, ClickableLetterEvent, ClickableLetterPairEvent, ClickableLetterClickableLetterFunction, ClickableLetterVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ClickableLetterReference : AtomReference<
        ClickableLetter,
        ClickableLetterPair,
        ClickableLetterConstant,
        ClickableLetterVariable,
        ClickableLetterEvent,
        ClickableLetterPairEvent,
        ClickableLetterClickableLetterFunction,
        ClickableLetterVariableInstancer>, IEquatable<ClickableLetterReference>
    {
        public ClickableLetterReference() : base() { }
        public ClickableLetterReference(ClickableLetter value) : base(value) { }
        public bool Equals(ClickableLetterReference other) { return base.Equals(other); }
        protected override bool ValueEquals(ClickableLetter other)
        {
            throw new NotImplementedException();
        }
    }
}
