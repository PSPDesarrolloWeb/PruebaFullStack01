using BackEndPrueba.Models;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;

using BackEndPrueba.Services.Contrato;
using BackEndPrueba.Services.Implement;

using AutoMapper;
using BackEndPrueba.DTOs;
using BackEndPrueba.Utilities;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<PruebaContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("cadenaSQL"));
});

builder.Services.AddScoped<IDepartamentoService, DepartamentoService>();
builder.Services.AddScoped<ICargoService, CargoService>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddAutoMapper(typeof(AutoMapperProfile));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


#region PETICIONES API
app.MapGet("/departamento/list", async(
    IDepartamentoService _departamentoServicio,
    IMapper _mapper
    ) =>
{
    var listaDepartamento = await _departamentoServicio.GetList();
    var listaDepartamentoDTO = _mapper.Map<List<DepartamentoDTO>>(listaDepartamento);

    if(listaDepartamentoDTO.Count > 0)
        return Results.Ok(listaDepartamentoDTO);
    else
        return Results.NotFound();
});


app.MapPost("user/save", async (
    UserDTO modelo,
    IUserService _userServicio,
    IMapper _mapper 
    ) => 
{

    var _user = _mapper.Map<User>(modelo);
    var _userCreado = await _userServicio.Add(_user);

    if (!string.IsNullOrEmpty(_userCreado.UsuarioUs))
        return Results.Ok(_mapper.Map<UserDTO>(_userCreado));

    else
        return Results.StatusCode(StatusCodes.Status500InternalServerError);


});

app.MapPut("user/update/{UsuarioUs}", async (
    string UsuarioUs,
    UserDTO modelo,
    IUserService _userServicio,
    IMapper _mapper
    ) => 
{
    var _found = await _userServicio.Get(UsuarioUs);
    if (_found is null)
        return Results.NotFound();
    var _user = _mapper.Map<User>(modelo);

    _found.PrimerNombreUs = _user.PrimerNombreUs;
    _found.SegundoNombreUs = _user.SegundoNombreUs;
    _found.PrimerApellidoUs = _user.PrimerApellidoUs;
    _found.SegundoApellidoUs = _user.SegundoApellidoUs;

    var respuesta = await _userServicio.Update(_found);

    if (respuesta)
        return Results.Ok(_mapper.Map<UserDTO>(_found));
    else
        return Results.StatusCode(StatusCodes.Status500InternalServerError);


});
app.MapDelete("user/delete/{UsuarioUs}", async (
    string UsuarioUs,
    IUserService _userServicio
    ) => 
{
    var _found = await _userServicio.Get(UsuarioUs);

    if(_found is null) return Results.NotFound();

    var respuesta = await _userServicio.Delete(_found);

    if (respuesta)
        return Results.Ok();
    else
        return Results.StatusCode(StatusCodes.Status500InternalServerError);
});

app.Run();
#endregion
