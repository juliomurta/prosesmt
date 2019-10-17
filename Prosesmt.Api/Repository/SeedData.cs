using Microsoft.AspNetCore.Builder;
using Prosesmt.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;

namespace Prosesmt.Api.Repository
{    
    public static class SeedData
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            ProsesmtContext context = applicationBuilder.ApplicationServices.GetRequiredService<ProsesmtContext>();

            if (!context.Clientes.Any())
            {
                context.Add(new Cliente
                {
                    CnpjCpf = "11111111111", 
                    RazaoSocial = "TESTE 1",
                    Telefone = "(11)1111-1111",
                    CEP = "11111-111",
                    Bairro = "Morumbi",
                    Cidade = "São Paulo",
                    UF = "SP",
                    Complemento = "ao lado dos correios",
                    Logradouro = "Av. Morumbi",
                    Numero = "567",
                    SLARespostaTempo = 3
                });

                context.Add(new Cliente
                {
                    CnpjCpf = "22222222222",
                    RazaoSocial = "TESTE 2",
                    Telefone = "(22)2222-2222",
                    CEP = "22222-222",
                    Bairro = "Morumbi",
                    Cidade = "São Paulo",
                    UF = "SP",
                    Complemento = "ao lado dos correios",
                    Logradouro = "Av. Morumbi",
                    Numero = "567",
                    SLARespostaTempo = 3
                });

                context.Add(new Cliente
                {
                    CnpjCpf = "33333333333",
                    RazaoSocial = "TESTE 3",
                    Telefone = "(33)3333-3333",
                    CEP = "33333-333",
                    Bairro = "Morumbi",
                    Cidade = "São Paulo",
                    UF = "SP",
                    Complemento = "ao lado dos correios",
                    Logradouro = "Av. Morumbi",
                    Numero = "567",
                    SLARespostaTempo = 3
                });

                context.Add(new Cliente
                {
                    CnpjCpf = "4444444444444",
                    RazaoSocial = "TESTE 4",
                    Telefone = "(44)4444-4444",
                    CEP = "44444-444",
                    Bairro = "Morumbi",
                    Cidade = "São Paulo",
                    UF = "SP",
                    Complemento = "ao lado dos correios",
                    Logradouro = "Av. Morumbi",
                    Numero = "567",
                    SLARespostaTempo = 3
                });

                context.Add(new Cliente
                {
                    CnpjCpf = "55555555555",
                    RazaoSocial = "TESTE 5",
                    Telefone = "(55)5555-5555",
                    CEP = "55555-555",
                    Bairro = "Morumbi",
                    Cidade = "São Paulo",
                    UF = "SP",
                    Complemento = "ao lado dos correios",
                    Logradouro = "Av. Morumbi",
                    Numero = "567",
                    SLARespostaTempo = 3
                });

                context.Add(new Cliente
                {
                    CnpjCpf = "666666666666",
                    RazaoSocial = "TESTE 6",
                    Telefone = "(66)6666-66666",
                    CEP = "66666-666",
                    Bairro = "Morumbi",
                    Cidade = "São Paulo",
                    UF = "SP",
                    Complemento = "ao lado dos correios",
                    Logradouro = "Av. Morumbi",
                    Numero = "567",
                    SLARespostaTempo = 3
                });

                context.Add(new Cliente
                {
                    CnpjCpf = "77777777777",
                    RazaoSocial = "TESTE 7",
                    Telefone = "(77)7777-7777",
                    CEP = "77777-777",
                    Bairro = "Morumbi",
                    Cidade = "São Paulo",
                    UF = "SP",
                    Complemento = "ao lado dos correios",
                    Logradouro = "Av. Morumbi",
                    Numero = "567",
                    SLARespostaTempo = 3
                });

                context.Add(new Cliente
                {
                    CnpjCpf = "88888888888",
                    RazaoSocial = "TESTE 8",
                    Telefone = "(88)8888-8888",
                    CEP = "88888-888",
                    Bairro = "Morumbi",
                    Cidade = "São Paulo",
                    UF = "SP",
                    Complemento = "ao lado dos correios",
                    Logradouro = "Av. Morumbi",
                    Numero = "567",
                    SLARespostaTempo = 3
                });

                context.Add(new Cliente
                {
                    CnpjCpf = "99999999999",
                    RazaoSocial = "TESTE 9",
                    Telefone = "(99)9999-9999",
                    CEP = "99999-999",
                    Bairro = "Morumbi",
                    Cidade = "São Paulo",
                    UF = "SP",
                    Complemento = "ao lado dos correios",
                    Logradouro = "Av. Morumbi",
                    Numero = "567",
                    SLARespostaTempo = 3
                });

                context.Add(new Cliente
                {
                    CnpjCpf = "1010101010",
                    RazaoSocial = "TESTE 10",
                    Telefone = "(10)1010-1010",
                    CEP = "10101-101",
                    Bairro = "Morumbi",
                    Cidade = "São Paulo",
                    UF = "SP",
                    Complemento = "ao lado dos correios",
                    Logradouro = "Av. Morumbi",
                    Numero = "567",
                    SLARespostaTempo = 3
                });

                context.Add(new Cliente
                {
                    CnpjCpf = "2020202020",
                    RazaoSocial = "TESTE 20",
                    Telefone = "(20)2020-2020",
                    CEP = "20202-202",
                    Bairro = "Morumbi",
                    Cidade = "São Paulo",
                    UF = "SP",
                    Complemento = "ao lado dos correios",
                    Logradouro = "Av. Morumbi",
                    Numero = "567",
                    SLARespostaTempo = 3
                });

                context.Add(new Cliente
                {
                    CnpjCpf = "3030303030",
                    RazaoSocial = "TESTE 30",
                    Telefone = "(0)3030-3030",
                    CEP = "30303-303",
                    Bairro = "Morumbi",
                    Cidade = "São Paulo",
                    UF = "SP",
                    Complemento = "ao lado dos correios",
                    Logradouro = "Av. Morumbi",
                    Numero = "567",
                    SLARespostaTempo = 3
                });
            }

            context.SaveChanges();
        }        
    }
}
