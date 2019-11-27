using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GestaodeFrota.Data.Migrations
{
    public partial class Entidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Oficina",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeOficina = table.Column<string>(nullable: true),
                    Endereco = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oficina", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomePosto = table.Column<string>(nullable: true),
                    EnderecoPosto = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Seguro",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    ValorSeguro = table.Column<double>(nullable: false),
                    Validade = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seguro", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Apolice",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Tipo = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    SeguroId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apolice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Apolice_Seguro_SeguroId",
                        column: x => x.SeguroId,
                        principalTable: "Seguro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Automovel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Placa = table.Column<string>(nullable: true),
                    Marca = table.Column<string>(nullable: true),
                    Modelo = table.Column<string>(nullable: true),
                    Ano = table.Column<DateTime>(nullable: false),
                    Quilometragem = table.Column<int>(nullable: false),
                    Alugado = table.Column<bool>(nullable: false),
                    Disponivel = table.Column<bool>(nullable: false),
                    ApoliceId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Automovel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Automovel_Apolice_ApoliceId",
                        column: x => x.ApoliceId,
                        principalTable: "Apolice",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Abastecimento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Litros = table.Column<int>(nullable: false),
                    ValorLitro = table.Column<double>(nullable: false),
                    ValorAbaste = table.Column<double>(nullable: false),
                    DataAbaste = table.Column<DateTime>(nullable: false),
                    AutomovelId = table.Column<int>(nullable: true),
                    PostoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abastecimento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Abastecimento_Automovel_AutomovelId",
                        column: x => x.AutomovelId,
                        principalTable: "Automovel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Abastecimento_Posto_PostoId",
                        column: x => x.PostoId,
                        principalTable: "Posto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Locacao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataLocacao = table.Column<DateTime>(nullable: false),
                    DataDevolucao = table.Column<DateTime>(nullable: false),
                    ValorLocacao = table.Column<double>(nullable: false),
                    Devolvido = table.Column<bool>(nullable: false),
                    AutomovelId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locacao_Automovel_AutomovelId",
                        column: x => x.AutomovelId,
                        principalTable: "Automovel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Manutencao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataManutencao = table.Column<DateTime>(nullable: false),
                    DataProxManu = table.Column<DateTime>(nullable: false),
                    Servico = table.Column<string>(nullable: true),
                    Tipo = table.Column<string>(nullable: true),
                    Valor = table.Column<double>(nullable: false),
                    AutomovelId = table.Column<int>(nullable: true),
                    OficinaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manutencao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Manutencao_Automovel_AutomovelId",
                        column: x => x.AutomovelId,
                        principalTable: "Automovel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Manutencao_Oficina_OficinaId",
                        column: x => x.OficinaId,
                        principalTable: "Oficina",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Motorista",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeMotorista = table.Column<string>(nullable: true),
                    DataNasc = table.Column<DateTime>(nullable: false),
                    CNH = table.Column<string>(nullable: true),
                    ValidadeCNH = table.Column<DateTime>(nullable: false),
                    Disponivel = table.Column<bool>(nullable: false),
                    AutomovelId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motorista", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Motorista_Automovel_AutomovelId",
                        column: x => x.AutomovelId,
                        principalTable: "Automovel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Multa",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LocalMulta = table.Column<string>(nullable: true),
                    DataMulta = table.Column<DateTime>(nullable: false),
                    Gravidade = table.Column<string>(nullable: true),
                    Pontos = table.Column<int>(nullable: false),
                    CodIfracao = table.Column<string>(nullable: true),
                    Valor = table.Column<double>(nullable: false),
                    AutomovelId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Multa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Multa_Automovel_AutomovelId",
                        column: x => x.AutomovelId,
                        principalTable: "Automovel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Viagem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataSaida = table.Column<DateTime>(nullable: false),
                    DataChegada = table.Column<DateTime>(nullable: false),
                    OdometroSaida = table.Column<int>(nullable: false),
                    OdodmetroChegada = table.Column<int>(nullable: false),
                    DestinoSaida = table.Column<string>(nullable: true),
                    DestinoChegada = table.Column<string>(nullable: true),
                    DescriçaoViagem = table.Column<string>(nullable: true),
                    AutomovelId = table.Column<int>(nullable: true),
                    MotoristaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Viagem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Viagem_Automovel_AutomovelId",
                        column: x => x.AutomovelId,
                        principalTable: "Automovel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Viagem_Motorista_MotoristaId",
                        column: x => x.MotoristaId,
                        principalTable: "Motorista",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Abastecimento_AutomovelId",
                table: "Abastecimento",
                column: "AutomovelId");

            migrationBuilder.CreateIndex(
                name: "IX_Abastecimento_PostoId",
                table: "Abastecimento",
                column: "PostoId");

            migrationBuilder.CreateIndex(
                name: "IX_Apolice_SeguroId",
                table: "Apolice",
                column: "SeguroId");

            migrationBuilder.CreateIndex(
                name: "IX_Automovel_ApoliceId",
                table: "Automovel",
                column: "ApoliceId");

            migrationBuilder.CreateIndex(
                name: "IX_Locacao_AutomovelId",
                table: "Locacao",
                column: "AutomovelId");

            migrationBuilder.CreateIndex(
                name: "IX_Manutencao_AutomovelId",
                table: "Manutencao",
                column: "AutomovelId");

            migrationBuilder.CreateIndex(
                name: "IX_Manutencao_OficinaId",
                table: "Manutencao",
                column: "OficinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Motorista_AutomovelId",
                table: "Motorista",
                column: "AutomovelId");

            migrationBuilder.CreateIndex(
                name: "IX_Multa_AutomovelId",
                table: "Multa",
                column: "AutomovelId");

            migrationBuilder.CreateIndex(
                name: "IX_Viagem_AutomovelId",
                table: "Viagem",
                column: "AutomovelId");

            migrationBuilder.CreateIndex(
                name: "IX_Viagem_MotoristaId",
                table: "Viagem",
                column: "MotoristaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abastecimento");

            migrationBuilder.DropTable(
                name: "Locacao");

            migrationBuilder.DropTable(
                name: "Manutencao");

            migrationBuilder.DropTable(
                name: "Multa");

            migrationBuilder.DropTable(
                name: "Viagem");

            migrationBuilder.DropTable(
                name: "Posto");

            migrationBuilder.DropTable(
                name: "Oficina");

            migrationBuilder.DropTable(
                name: "Motorista");

            migrationBuilder.DropTable(
                name: "Automovel");

            migrationBuilder.DropTable(
                name: "Apolice");

            migrationBuilder.DropTable(
                name: "Seguro");
        }
    }
}
