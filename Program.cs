Livro livro1 = new Livro();

livro1.titulo = "A bela e a fera";
livro1.ano = 1932;
livro1.autor = "John da Silva Pereira de Souza Almeida Benedict de não sei o que lá";
livro1.paginas = 127;

livro1.exibirInformacoes();

Livro livro2 = new Livro();
livro2.titulo = "Livro interessante e importante";
livro2.ano = 1243;
livro2.autor = "Charlie brown Jr.";
livro2.paginas = 8946;

if(livro2.TemMais300paginas() == true)
{
    Console.WriteLine($"{livro2.titulo} tem mais de 300 páginas!");
}else
{
    Console.WriteLine($"{livro2.titulo} tem menos de 300 páginas!");
}
