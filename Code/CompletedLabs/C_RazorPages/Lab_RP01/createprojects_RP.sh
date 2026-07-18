#!/usr/bin/env bash

echo "create the ASP.NET Core Web App (Razor Pages) project and add it to the solution"
dotnet new razor -lang c# -n AutoLot.Web -au none -o AutoLot.Web -f net10.0
dotnet sln AutoLot.slnx add AutoLot.Web
dotnet add AutoLot.Web reference AutoLot.Models
dotnet add AutoLot.Web reference AutoLot.Dal
dotnet add AutoLot.Web reference AutoLot.Services

echo "add packages"
dotnet add AutoLot.Web package LigerShark.WebOptimizer.Core -v '[3.*,4)'
dotnet add AutoLot.Web package Microsoft.Web.LibraryManager.Build -v '[3.*,4.0)'
dotnet add AutoLot.Web package Microsoft.EntityFrameworkCore.SqlServer -v '[10.*,11.0)'
dotnet add AutoLot.Web package Microsoft.EntityFrameworkCore.Design -v '[10.*,11.0)'
dotnet add AutoLot.Web package Microsoft.VisualStudio.Threading.Analyzers -v '[18.*,19.0)'

read -p "Press Enter to continue" </dev/ttyc
