LinqQueries queries = new LinqQueries();

PrintValues(queries.TodaLaColeccion());

void PrintValues(IEnumerable<Book> listaDelibros)
{
    Console.WriteLine("{0, -60} {1,15} {2, 11}\n", "Titulo", "N. paginas", "Fecha publicacion \n");
    foreach(var item in listaDelibros){
        Console.WriteLine("{0, -60} {1,15} {2, 11}", item.Title, item.PageCount, item.PublishedDate.ToShortDateString());
    }
}