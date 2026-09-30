using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace DDL {
    public class Documento : IDocumento
    {
        private string? _titulo;
        private string? _cuerpo;
        private readonly IGeneradorFirma _generadorFirma; // Campo de la clase

        public Documento(IGeneradorFirma generadorFirma) // Parametro constructor
        {
            this._generadorFirma = generadorFirma;
        }

        public void EscribirTitulo (string titulo)
        {
            this._titulo = titulo;
        }

        public void EscribirCuerpo(string cuerpo)
        {
            this._cuerpo = cuerpo;
        }

        public string GenerarDocumento()
        {
            return _titulo + _cuerpo + _generadorFirma.Firma();
        }
    }
}