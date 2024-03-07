using CZ.API;
using CZ.Common;
var builder = WebApplication.CreateBuilder();

builder.Configuration.BuildCrapazonConfiguration();

builder.Services.ConfigureServices(builder.Configuration);

var app_ = builder.Build();

app_.Configure();

app_.Run();