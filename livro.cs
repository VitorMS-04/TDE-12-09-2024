class Livro
{
    public string titulo;
    public string autor;
    public int ano;
    public int paginas;


    public void exibirInformacoes()
    {
        Console.WriteLine($"Informações\nTítulo: {titulo}\nAutor: {autor}\nAno de publicação: {ano}\nNúmeo de paginas: {paginas}");
    }

    public bool TemMais300paginas()
    {
        return paginas >= 300;
    }
}