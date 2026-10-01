using System;
using System.Collections.Generic;
using System.Text;

namespace GDocuments.DDL.Tests.Helpers.InputTestData
{
    internal class CategoriaEdadDataT: TheoryData<int, string>
    {
        public CategoriaEdadDataT()
        {
            Add (-1, "Edad Invalida");
            Add (5, "Niño");
            Add (12, "Niño");
            Add (15, "Adolecente");
            Add (17, "Adolecente");
            Add (38, "Adulto");
            Add (64, "Adulto");
            Add (75, "Adulto");
            //20 cojuntos de datos mas
        }
    }
}