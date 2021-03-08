using System;
using UnityEngine;
namespace UnityAtoms
{
    /// <summary>
    /// IPair of type `&lt;ClickableLetter&gt;`. Inherits from `IPair&lt;ClickableLetter&gt;`.
    /// </summary>
    [Serializable]
    public struct ClickableLetterPair : IPair<ClickableLetter>
    {
        public ClickableLetter Item1 { get => _item1; set => _item1 = value; }
        public ClickableLetter Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private ClickableLetter _item1;
        [SerializeField]
        private ClickableLetter _item2;

        public void Deconstruct(out ClickableLetter item1, out ClickableLetter item2) { item1 = Item1; item2 = Item2; }
    }
}