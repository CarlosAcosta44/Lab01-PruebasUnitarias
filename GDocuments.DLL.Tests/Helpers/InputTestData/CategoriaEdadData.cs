using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GDocuments.DDL.Tests.Helpers.InputTestData
{
    internal class CategoriaEdadData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { -1, "Edad Invalida"};
            yield return new object[] { 5, "Niño"};
            yield return new object[] { 12, "Niño"};
            yield return new object[] { 15, "Adolecente"};
            yield return new object[] { 17, "Adolecente"};
            yield return new object[] { 38, "Adulto"};
            yield return new object[] { 64, "Adulto"};
            yield return new object[] { 75, "Adulto Mayor"};
            //20 conjuntos de datos mas
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}