﻿using Microsoft.AspNetCore.Identity;
using MinimalAPI.Dominio.Enuns;

namespace MinimalAPI.Dominio.ModelViews;

public record AdministradorModelView
{
    public int Id { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string Perfil { get; set; }
}