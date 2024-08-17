﻿global using Apiresources.Application;
global using Apiresources.Application.Exceptions;
global using Apiresources.Application.Features.Departments.Queries.GetDepartments;
global using Apiresources.Application.Features.Employees.Queries.GetEmployees;
global using Apiresources.Application.Features.Positions.Commands.CreatePosition;
global using Apiresources.Application.Features.Positions.Commands.DeletePositionById;
global using Apiresources.Application.Features.Positions.Commands.UpdatePosition;
global using Apiresources.Application.Features.Positions.Queries.GetPositionById;
global using Apiresources.Application.Features.Positions.Queries.GetPositions;
global using Apiresources.Application.Features.SalaryRanges.Queries.GetSalaryRanges;
global using Apiresources.Application.Wrappers;
global using Apiresources.Infrastructure.Persistence;
global using Apiresources.Infrastructure.Persistence.Contexts;
global using Apiresources.Infrastructure.Persistence.SeedData;
global using Apiresources.Infrastructure.Shared;
global using Apiresources.WebApi.Extensions;
global using Apiresources.WebApi.Middlewares;
global using Asp.Versioning;
global using MediatR;
global using Microsoft.AspNetCore.Authentication.JwtBearer;
global using Microsoft.AspNetCore.Builder;
global using Microsoft.AspNetCore.Hosting;
global using Microsoft.AspNetCore.Http;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Hosting;
global using Microsoft.Extensions.Logging;
global using Microsoft.OpenApi.Models;
global using Serilog;
global using System;
global using System.Collections.Generic;
global using System.Diagnostics;
global using System.Net;
global using System.Text.Json;
global using System.Threading.Tasks;
