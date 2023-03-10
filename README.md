# Demo Ef

ID	Name	Description
------------------------
1 | Name1 | Description1
2 | Name2 | Description2
3 | Name3 | Description3
4 | Name4 | Description4
5 | Name5 | Description5

## Creazione del modello riga

```
public Riga 
{
    public int Id {get;set;}
    public string Name {get;set;}
    public string Description {get;set;}
}
```

## Creazione modello della tabella

```
var tabella = new List<Riga>();
tabella.Add(new Riga(){Id =1, Name="Name1", Description="Description1"});
tabella.Add(new Riga(){Id =2, Name="Name2", Description="Description2"});
tabella.Add(new Riga(){Id =3, Name="Name3", Description="Description3"});
tabella.Add(new Riga(){Id =4, Name="Name4", Description="Description4"});
```

## Utilizzo di IEnumerable
IEnumerable<Riga>

1) collegarci con il database
2) creare un sistema che mappa la nostra classe Riga con una riga di una tabella nel database
3) creare un metodo per scrivere la tabella nel database
4) creare un metodo per leggere i dati dal database

## Linguaggio per interrogazione: Linq

```
public class Student
{
    public int Id { get; set; }
    public string StudentName { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public decimal Height { get; set; }
    public float Weight { get; set; }
}
```

## Defizione di entity framework

```
using System.Data.Entity;

public class EsempioContext : DbContext
{
    //Costruttore della classe
    public EsempioContext()
    { 
    }
    public DbSet<Tabella> Tabella001 { get; set; }
	public DbSet<Student> Students { get; set; }
} 

```

## Migration Command

```
dotnet ef migrations add NomeMigrazione
dotnet ef database update
```

## Link

Entity Framework tools
https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Tools

Entity Framework sql server
https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer/

