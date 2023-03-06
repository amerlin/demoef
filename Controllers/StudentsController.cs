using ef_demo;
using ef_demo.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("[controller]")]
public class StudentsController : ControllerBase
{
    private DemoDbContext _context;

    public StudentsController(DemoDbContext context)
    {
        _context = context;
    }

    [HttpGet(Name = "GetStudents")]
    public IEnumerable<Students> Get()
    {
        var nome  = "NuovaStringa prova prova";
        nome.WordCount();

        int prova = 10;
        prova.IntWordCount();

        var returnValue = _context.Students.ToList();
        return returnValue;
    }

    [HttpGet("{id}")]
    public async Task<IEnumerable<Students>> GetById(int id)
    {
        var returnValue = _context.Students.Where(a => a.Id == id);
        return await returnValue.ToListAsync();
    }

    [HttpPost(Name = "PostStudents")]
    public IEnumerable<Students> Post()
    {
        var toAdd = new Students
        {
            Name = "Prova",
            Description = "prova"
        };
        _context.Add(toAdd);
        _context.SaveChanges();

        var toAddCity = new City
        {
            Name = "Tortona"
        };
        _context.Cities.Add(toAddCity);
        _context.SaveChanges();

        var returnValue = _context.Students.ToList();
        return returnValue;
    }

    [HttpPut(Name = "PutStudents")]
    public ActionResult Put(Students student)
    {
        var toEdit = _context.Students.FirstOrDefault(a => a.Id == student.Id);
        if (toEdit == null)
        {
            return this.NotFound();
        }
        toEdit.Name = "Aggiornato";
        _context.SaveChanges();
        return this.NoContent();
    }

    [HttpDelete(Name = "DeleteStudents/{id}")]
    public ActionResult Delete(int id)
    {
        var toDelete = _context.Students.FirstOrDefault(a => a.Id == id);
        if (toDelete == null)
        {
            return this.NotFound();
        }
        _context.Remove(toDelete);
        _context.SaveChanges();
        return this.NoContent();
    }


}