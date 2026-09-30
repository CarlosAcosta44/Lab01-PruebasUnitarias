using DDL;

IGeneradorFirma generadorFirma = new GeneradorFirma();
IDocumento documento = new IDocumento(generadorFirma);

documento.EcribiTitulo("Test Unitarios");
documento.EscribirCuerpo("Una prueba unitaria es un bloque de codigo que prueba otro bloque de codigo, es decir la unidad mas pequeña. Funcion, metodo o clase ");
ICorreo correo = new Correo();
correo.Enviar(documento, "melendez181205@gmail.com")