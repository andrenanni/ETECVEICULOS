using EtecVeiculos.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace EtecVeiculos.Api.Data;
public class AppDbSeed
{
    public AppDbSeed(ModelBuilder modelBuilder)
    {
        #region TipoVeiculo
        List<TipoVeiculo> tipoVeiculos = [
            new(){
                Id = 1,
                Name = "Moto"
            },
            new(){
                Id = 2,
                Name = "Carro"
            },
            new(){
                Id = 3,
                Name = "Caminhão"
            }
        ];
        modelBuilder.Entity<TipoVeiculo>().HasData(tipoVeiculos);
        #endregion

        #region Marcas
        List<Marca> Marcas = [
            new(){
                MarcaId = 1,
                Name = "Volkswagen"
            },
            new(){
                MarcaId = 2,
                Name = "Ford"
            },
            new(){
                MarcaId = 3,
                Name = "Jarguar"
            },
        ];
        modelBuilder.Entity<Marca>().HasData(Marcas);
        #endregion
    }
}