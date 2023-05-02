using Microsoft.EntityFrameworkCore;
using MinimalAPI;
using MinimalAPI.Controller;
using MinimalAPI.Models;
using System.ComponentModel.DataAnnotations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddControllers();
//builder.Services.AddDbContext<North>();
builder.Services.AddDbContext<Context>(options => options.UseInMemoryDatabase("SchoolDB"));

builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapControllers();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "MinimalAPI");
        options.DocumentTitle = "Minimal API Example";
    });
}

app.UseHttpsRedirection();

#region Northwind
//app.MapGet("api/Shipper", (North DB) => DB.Shippers);
//app.MapGet("api/Shipper{id}", (North DB, int id) => DB.Shippers.Find(id));
//app.MapPost("api/Shipper", (North DB, Shipper shipper) =>
//{
//    DB.Shippers.Add(shipper);
//    DB.SaveChanges();
//});
//app.MapPut("api/Shipper/{id}", (North DB, Shipper shipper, int id) =>
//{
//    if (id == null || shipper == null) return Results.NotFound();

//    DB.Shippers.Update(shipper);
//    DB.SaveChanges();
//    return Results.Ok();
//});

//app.MapDelete("api/Shipper/{id}", (North DB, int id) =>
//{
//    var ship = DB.Shippers.Find(id);
//    if (ship == null) return Results.NotFound();
//    DB.Shippers.Remove(ship);
//    DB.SaveChanges();
//    return Results.Ok();
//}); 
#endregion

//app.MapGet("/", () => "Merhaba");
//app.MapGet("/", () => Console.WriteLine("Merhaba Dünya :)"));

app.MapGet("/api/Student", (Context DB) => DB.Students);

app.MapGet("/api/Student/{id}", async (Context DB, int id) => await DB.Students.FindAsync(id));

app.MapPost("/api/Student/", (Context DB, Student student) =>
{
    DB.Students.Add(student);
    DB.SaveChanges();
});

app.MapPut("/api/Student/{id}", (Context DB, int id, Student student) =>
{
    if (id != student.Number || student == null) return Results.NotFound();
    DB.Students.Update(student);
    DB.SaveChanges();
    return Results.Ok();
});

app.MapDelete("/api/Student/{id}", (Context DB, int id) =>
{
    var student = DB.Students.Find(id);
    if (student == null) return Results.NotFound();
    DB.Students.Remove(student);
    DB.SaveChanges();
    return Results.Ok();
});

app.MapGet("/api/Teacher", (Context DB) => DB.Teachers);

app.MapGet("/api/Teacher/{id}", async (Context DB, int id) => await DB.Teachers.FindAsync(id));

app.MapPost("/api/Teacher/", (Context DB, Teacher teacher) =>
{
    DB.Teachers.Add(teacher);
    DB.SaveChanges();
});

app.MapPut("/api/Teacher/{id}", (Context DB, int id, Teacher teacher) =>
{
    if (id != teacher.ID || teacher == null) return Results.NotFound();
    DB.Teachers.Update(teacher);
    DB.SaveChanges();
    return Results.Ok();
});

app.MapDelete("/api/Teacher/{id}", (Context DB, int id) =>
{
    var teacher = DB.Teachers.Find(id);
    if (teacher == null) return Results.NotFound();
    DB.Teachers.Remove(teacher);
    DB.SaveChanges();
    return Results.Ok();
});

app.Run();


class Student
{
    [Key]
    public int Number { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Mail { get; set; }
}
class Teacher
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }

}
class Context : DbContext
{
    public Context(DbContextOptions options) : base(options) { }
    public DbSet<Student> Students { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder.UseInMemoryDatabase("SchoolDB"));
    }
}