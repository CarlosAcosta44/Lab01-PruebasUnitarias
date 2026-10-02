using DDL;

IGeneradorFirma generadorFirma = new GeneradorFirma();
IDocumento documento = new Documento(generadorFirma);

documento.EscribirTitulo("Test Unitarios");
documento.EscribirCuerpo("Una prueba unitaria es un bloque de codigo que prueba otro bloque de codigo, es decir la unidad mas pequeña. Funcion, metodo o clase ");
ICorreo correo = new Correo();
correo.Enviar(documento, "carloscosta12007@gmail.com");