﻿using TheNoobs.ValueObjects.UnidadesFederativas.Abstractions;
using TheNoobs.ValueObjects.UnidadesFederativas.Constants;
using TheNoobs.ValueObjects.UnidadesFederativas.Regioes;

namespace TheNoobs.ValueObjects.UnidadesFederativas;

public sealed record MatoGrosso() : UnidadeFederativa(Siglas.MATO_GROSSO, "Mato Grosso", new CentroOeste());
