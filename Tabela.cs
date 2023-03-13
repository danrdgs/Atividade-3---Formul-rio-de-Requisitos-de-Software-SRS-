namespace Requisitos.Models;
public class Tabela
{
    public int Data { get; set; }
    public string Versão { get; set; }
    public string Descrição { get; set; }
    public string Autor { get; set; }

    public Tabela(int data, string versão, string descrição, string autor)
    {
        this.Data = data;
        this.Versão = versão;
        this.Descrição = descrição;
        this.Autor = autor;
    }
}
