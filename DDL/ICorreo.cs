using System;
using System.Collections.Generic;
using System.Text;
    
namespace DDL
{
    public interface ICorreo
    {
        void Enviar(IDocumento documento, string destinario);    
    }
}