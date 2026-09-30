namespace DDL
{
    public interface IDocumento
    {
    void EscribirTitulo(string titulo);
    void EscribirCuerpo(string cuerpo);
    string GenerarDocumento();
    }
}