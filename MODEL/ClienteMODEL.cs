using System;
using System.Collections.Generic;

namespace GVC.Model;

public partial class ClienteModel
{
    public int ClienteID { get; set; }

    public string Nome { get; set; } = null!;

    public string? Cpf { get; set; }

    public string? RG { get; set; }

    public string? Cnpj { get; set; }

    public string? IE { get; set; }

    public string? Telefone { get; set; }

    public string? Email { get; set; }

    public int? CidadeID { get; set; }

    public string? Logradouro { get; set; }

    public string? Numero { get; set; }

    public string? Bairro { get; set; }

    public string? Cep { get; set; }

    public DateTime? DataNascimento { get; set; }

    public string? TipoCliente { get; set; }

    public long Status { get; set; } = 1;

    public string? Observacoes { get; set; }

    public DateTime? DataUltimaCompra { get; set; }

    public decimal? LimiteCredito { get; set; }

    public DateTime DataCriacao { get; set; }

    public DateTime? DataAtualizacao { get; set; }

    public string? UsuarioCriacao { get; set; }

    public string? UsuarioAtualizacao { get; set; }

    public string? OrgaoExpedidorRG { get; set; }

    public bool? IsVendedor { get; set; }

    public virtual CidadeModel? Cidade { get; set; }

    public virtual ICollection<VendaModel> VendumClientes { get; set; } = new List<VendaModel>();

    public virtual ICollection<VendaModel> VendumVendedors { get; set; } = new List<VendaModel>();
}
