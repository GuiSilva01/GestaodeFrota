using Microsoft.EntityFrameworkCore.Migrations;

namespace GestaodeFrota.Data.Migrations
{
    public partial class ForeingKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abastecimento_Automovel_AutomovelId",
                table: "Abastecimento");

            migrationBuilder.DropForeignKey(
                name: "FK_Abastecimento_Posto_PostoId",
                table: "Abastecimento");

            migrationBuilder.DropForeignKey(
                name: "FK_Apolice_Seguro_SeguroId",
                table: "Apolice");

            migrationBuilder.DropForeignKey(
                name: "FK_Automovel_Apolice_ApoliceId",
                table: "Automovel");

            migrationBuilder.DropForeignKey(
                name: "FK_Locacao_Automovel_AutomovelId",
                table: "Locacao");

            migrationBuilder.DropForeignKey(
                name: "FK_Manutencao_Automovel_AutomovelId",
                table: "Manutencao");

            migrationBuilder.DropForeignKey(
                name: "FK_Manutencao_Oficina_OficinaId",
                table: "Manutencao");

            migrationBuilder.DropForeignKey(
                name: "FK_Multa_Automovel_AutomovelId",
                table: "Multa");

            migrationBuilder.DropForeignKey(
                name: "FK_Viagem_Automovel_AutomovelId",
                table: "Viagem");

            migrationBuilder.DropForeignKey(
                name: "FK_Viagem_Motorista_MotoristaId",
                table: "Viagem");

            migrationBuilder.AlterColumn<int>(
                name: "MotoristaId",
                table: "Viagem",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AutomovelId",
                table: "Viagem",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AutomovelId",
                table: "Multa",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OficinaId",
                table: "Manutencao",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AutomovelId",
                table: "Manutencao",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AutomovelId",
                table: "Locacao",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ApoliceId",
                table: "Automovel",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SeguroId",
                table: "Apolice",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PostoId",
                table: "Abastecimento",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AutomovelId",
                table: "Abastecimento",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Abastecimento_Automovel_AutomovelId",
                table: "Abastecimento",
                column: "AutomovelId",
                principalTable: "Automovel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Abastecimento_Posto_PostoId",
                table: "Abastecimento",
                column: "PostoId",
                principalTable: "Posto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Apolice_Seguro_SeguroId",
                table: "Apolice",
                column: "SeguroId",
                principalTable: "Seguro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Automovel_Apolice_ApoliceId",
                table: "Automovel",
                column: "ApoliceId",
                principalTable: "Apolice",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Locacao_Automovel_AutomovelId",
                table: "Locacao",
                column: "AutomovelId",
                principalTable: "Automovel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Manutencao_Automovel_AutomovelId",
                table: "Manutencao",
                column: "AutomovelId",
                principalTable: "Automovel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Manutencao_Oficina_OficinaId",
                table: "Manutencao",
                column: "OficinaId",
                principalTable: "Oficina",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Multa_Automovel_AutomovelId",
                table: "Multa",
                column: "AutomovelId",
                principalTable: "Automovel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Viagem_Automovel_AutomovelId",
                table: "Viagem",
                column: "AutomovelId",
                principalTable: "Automovel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Viagem_Motorista_MotoristaId",
                table: "Viagem",
                column: "MotoristaId",
                principalTable: "Motorista",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abastecimento_Automovel_AutomovelId",
                table: "Abastecimento");

            migrationBuilder.DropForeignKey(
                name: "FK_Abastecimento_Posto_PostoId",
                table: "Abastecimento");

            migrationBuilder.DropForeignKey(
                name: "FK_Apolice_Seguro_SeguroId",
                table: "Apolice");

            migrationBuilder.DropForeignKey(
                name: "FK_Automovel_Apolice_ApoliceId",
                table: "Automovel");

            migrationBuilder.DropForeignKey(
                name: "FK_Locacao_Automovel_AutomovelId",
                table: "Locacao");

            migrationBuilder.DropForeignKey(
                name: "FK_Manutencao_Automovel_AutomovelId",
                table: "Manutencao");

            migrationBuilder.DropForeignKey(
                name: "FK_Manutencao_Oficina_OficinaId",
                table: "Manutencao");

            migrationBuilder.DropForeignKey(
                name: "FK_Multa_Automovel_AutomovelId",
                table: "Multa");

            migrationBuilder.DropForeignKey(
                name: "FK_Viagem_Automovel_AutomovelId",
                table: "Viagem");

            migrationBuilder.DropForeignKey(
                name: "FK_Viagem_Motorista_MotoristaId",
                table: "Viagem");

            migrationBuilder.AlterColumn<int>(
                name: "MotoristaId",
                table: "Viagem",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "AutomovelId",
                table: "Viagem",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "AutomovelId",
                table: "Multa",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "OficinaId",
                table: "Manutencao",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "AutomovelId",
                table: "Manutencao",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "AutomovelId",
                table: "Locacao",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ApoliceId",
                table: "Automovel",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "SeguroId",
                table: "Apolice",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "PostoId",
                table: "Abastecimento",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "AutomovelId",
                table: "Abastecimento",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Abastecimento_Automovel_AutomovelId",
                table: "Abastecimento",
                column: "AutomovelId",
                principalTable: "Automovel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Abastecimento_Posto_PostoId",
                table: "Abastecimento",
                column: "PostoId",
                principalTable: "Posto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Apolice_Seguro_SeguroId",
                table: "Apolice",
                column: "SeguroId",
                principalTable: "Seguro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Automovel_Apolice_ApoliceId",
                table: "Automovel",
                column: "ApoliceId",
                principalTable: "Apolice",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Locacao_Automovel_AutomovelId",
                table: "Locacao",
                column: "AutomovelId",
                principalTable: "Automovel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Manutencao_Automovel_AutomovelId",
                table: "Manutencao",
                column: "AutomovelId",
                principalTable: "Automovel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Manutencao_Oficina_OficinaId",
                table: "Manutencao",
                column: "OficinaId",
                principalTable: "Oficina",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Multa_Automovel_AutomovelId",
                table: "Multa",
                column: "AutomovelId",
                principalTable: "Automovel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Viagem_Automovel_AutomovelId",
                table: "Viagem",
                column: "AutomovelId",
                principalTable: "Automovel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Viagem_Motorista_MotoristaId",
                table: "Viagem",
                column: "MotoristaId",
                principalTable: "Motorista",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
