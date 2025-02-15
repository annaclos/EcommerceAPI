﻿using ecommerceApi.src.Base.Util;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace ecommerceApi.Model;

public class Usuario : BaseEntity
{
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public string? Cpf { get; set; }
    public string? Birthday { get; set; }
    public string? PhoneNumber { get; set; }

    [MaxLength(1)]
    public string? Gender { get; set; }

    [DefaultValue(true)]
    public bool Active { get; set; } = true;

    #region relacionamento
    [XmlIgnore, JsonIgnore]
    public IEnumerable<Endereco>? Endereco { get; set; }

    #endregion

    #region Gerar Hash
    public void SetHashPassword()
    {
        Password = Password!.HashPassword();
    }
    #endregion
}
