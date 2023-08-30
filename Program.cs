using Bangazonn.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http.Json;
using Bangazonn;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// allows passing datetimes without time zone data 
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

// allows our api endpoints to access the database through Entity Framework Core
builder.Services.AddNpgsql<BangazonnDbContext>(builder.Configuration["BangazonnDbConnectionString"]);

// Set the JSON serializer options
builder.Services.Configure<JsonOptions>(options =>
{
    options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// get all users
app.MapGet("/api/Users", (BangazonnDbContext db) =>
{
    return db.Users.ToList();
});

app.MapGet("api/users/{id}", (BangazonnDbContext db, int id) =>
{
    Users user = db.Users.SingleOrDefault(pr => pr.Id == id);
    return user;
});

// delete user by id 
app.MapDelete("api/users/{id}", (BangazonnDbContext db, int id) =>
{
    Users user = db.Users.SingleOrDefault(pr => pr.Id == id);
    if (user == null)
    {
        return Results.NotFound();
    }
    db.Users.Remove(user);
    db.SaveChanges();
    return Results.NoContent();
});

//create users 
app.MapPost("api/Users", (BangazonnDbContext db, Users user) =>
{
    db.Users.Add(user);
    db.SaveChanges();
    return Results.Created($"/api/Users/{user.Id}", user);
});

// get products
app.MapGet("/api/Products", (BangazonnDbContext db) =>
{
    return db.Products.ToList();
});

// get products by id 
app.MapGet("api/products/{id}", (BangazonnDbContext db, int id) =>
{
    Products product = db.Products.SingleOrDefault(pr => pr.Id == id);
    return product;
});

// delete products 
app.MapDelete("api/products/{id}", (BangazonnDbContext db, int id) =>
{
    Products product = db.Products.SingleOrDefault(pr => pr.Id == id);
    if (product == null)
    {
        return Results.NotFound();
    }
    db.Products.Remove(product);
    db.SaveChanges();
    return Results.NoContent();
});

//create products 
app.MapPost("api/Products", (BangazonnDbContext db, Products product) =>
{
    db.Products.Add(product);
    db.SaveChanges();
    return Results.Created($"/api/Products/{product.Id}", product);
});


// get orders
app.MapGet("/api/orders", (BangazonnDbContext db) =>
{
    return db.Orders.ToList();
});

// get orders by id 
app.MapGet("api/orders/{id}", (BangazonnDbContext db, int id) =>
{
    Orders order = db.Orders.SingleOrDefault(pr => pr.Id == id);
    return order;
});

// delete single order 
app.MapDelete("api/orders/{id}", (BangazonnDbContext db, int id) =>
{
    Orders order = db.Orders.SingleOrDefault(pr => pr.Id == id);
    if (order == null)
    {
        return Results.NotFound();
    }
    db.Orders.Remove(order);
    db.SaveChanges();
    return Results.NoContent();
});

//create orders 
app.MapPost("api/Orders", (BangazonnDbContext db, Orders order) =>
{
    db.Orders.Add(order);
    db.SaveChanges();
    return Results.Created($"/api/Orders/{order.Id}", order);
});


// get paymentTypes
app.MapGet("/api/paymenttypes", (BangazonnDbContext db) =>
{
    return db.PaymentTypes.ToList();
});

// get paymentTypes by id 
app.MapGet("api/paymenttypes/{id}", (BangazonnDbContext db, int id) =>
{
    PaymentType payment = db.PaymentTypes.SingleOrDefault(pr => pr.Id == id);
    return payment;
});

app.MapGet("/api/ProductCategories", (BangazonnDbContext db) =>
{
    return db.ProductCategories.ToList();
});

// get ProductCategories by id 
app.MapGet("api/ProductCategories/{id}", (BangazonnDbContext db, int id) =>
{
    ProductCategories category = db.ProductCategories.SingleOrDefault(pr => pr.Id == id);
    return category;
});

// delete single ProductCategory
app.MapDelete("api/ProductCategories/{id}", (BangazonnDbContext db, int id) =>
{
    ProductCategories category = db.ProductCategories.SingleOrDefault(pr => pr.Id == id);
    if (category == null)
    {
        return Results.NotFound();
    }
    db.ProductCategories.Remove(category);
    db.SaveChanges();
    return Results.NoContent();
});

//create ProductCategory
app.MapPost("api/ProductCategories", (BangazonnDbContext db, ProductCategories category) =>
{
    db.ProductCategories.Add(category);
    db.SaveChanges();
    return Results.Created($"/api/ProductCategories/{category.Id}", category);
});


app.UseHttpsRedirection();

app.Run();


