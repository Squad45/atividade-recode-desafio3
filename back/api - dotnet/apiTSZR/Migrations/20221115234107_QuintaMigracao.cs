using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace apiTSZR.Migrations
{
    public partial class QuintaMigracao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "assistencia_tecnica",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    loja = table.Column<string>(type: "VARCHAR(80)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_assistencia_tecnica", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "VARCHAR(70)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cpf = table.Column<string>(type: "VARCHAR(11)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cnpj = table.Column<string>(type: "VARCHAR(14)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cargo = table.Column<string>(type: "VARCHAR(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    instituicao = table.Column<string>(type: "VARCHAR(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    telefone = table.Column<string>(type: "VARCHAR(11)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    escolha = table.Column<string>(type: "VARCHAR(14)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    equipamento_doado = table.Column<string>(type: "VARCHAR(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    texto_explicativo = table.Column<string>(type: "VARCHAR(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    uf = table.Column<string>(type: "VARCHAR(2)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cep = table.Column<string>(type: "VARCHAR(8)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    endereco = table.Column<string>(type: "VARCHAR(150)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ponto_referencia = table.Column<string>(type: "VARCHAR(70)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "avaliacoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    avaliacao = table.Column<string>(type: "VARCHAR(3)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_avaliacoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_avaliacoes_clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "equipamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AvaliacaoId = table.Column<int>(type: "int", nullable: false),
                    TecId = table.Column<int>(type: "int", nullable: false),
                    pecas = table.Column<string>(type: "VARCHAR(80)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    valor = table.Column<decimal>(type: "DECIMAL(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_equipamentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_equipamentos_assistencia_tecnica_TecId",
                        column: x => x.TecId,
                        principalTable: "assistencia_tecnica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_equipamentos_avaliacoes_AvaliacaoId",
                        column: x => x.AvaliacaoId,
                        principalTable: "avaliacoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "pedido",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AvaliacaoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pedido", x => x.Id);
                    table.ForeignKey(
                        name: "FK_pedido_avaliacoes_AvaliacaoId",
                        column: x => x.AvaliacaoId,
                        principalTable: "avaliacoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "equipamentos_disponiveis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EquipamentoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_equipamentos_disponiveis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_equipamentos_disponiveis_equipamentos_EquipamentoId",
                        column: x => x.EquipamentoId,
                        principalTable: "equipamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "doacoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PedidoId = table.Column<int>(type: "int", nullable: false),
                    EquipamentoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_doacoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_doacoes_equipamentos_disponiveis_EquipamentoId",
                        column: x => x.EquipamentoId,
                        principalTable: "equipamentos_disponiveis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_doacoes_pedido_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "pedido",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "assistencia_tecnica",
                columns: new[] { "Id", "loja" },
                values: new object[,]
                {
                    { 1, "Remakker" },
                    { 2, "Recuperador Tecnologia" },
                    { 3, "Cell Week" }
                });

            migrationBuilder.InsertData(
                table: "clientes",
                columns: new[] { "Id", "cargo", "cep", "cnpj", "cpf", "email", "equipamento_doado", "escolha", "texto_explicativo", "instituicao", "nome", "ponto_referencia", "endereco", "telefone", "uf" },
                values: new object[,]
                {
                    { 1, null, "23430654", null, "33344433321", "robertSil@gmail.com", null, "beneficio", "preciso porque sou estudante", null, "Roberto Silva", "mercearia do Jorge", "Rua das Flores", "11987435467", "SP" },
                    { 2, "Gerente", "41264100", "11222111222133", null, "wallacetrab@hotmail.com", "Computador", "doador", "estou aqui para doar 2 computadores que não usamos mais", "Hospital Nogueira", "Fracisco Wallace", "Terminal Alfaiate", "Av dos Alfaiates", "21987224351", "RJ" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_avaliacoes_ClienteId",
                table: "avaliacoes",
                column: "ClienteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_doacoes_EquipamentoId",
                table: "doacoes",
                column: "EquipamentoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_doacoes_PedidoId",
                table: "doacoes",
                column: "PedidoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_equipamentos_AvaliacaoId",
                table: "equipamentos",
                column: "AvaliacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_equipamentos_TecId",
                table: "equipamentos",
                column: "TecId");

            migrationBuilder.CreateIndex(
                name: "IX_equipamentos_disponiveis_EquipamentoId",
                table: "equipamentos_disponiveis",
                column: "EquipamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_pedido_AvaliacaoId",
                table: "pedido",
                column: "AvaliacaoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "doacoes");

            migrationBuilder.DropTable(
                name: "equipamentos_disponiveis");

            migrationBuilder.DropTable(
                name: "pedido");

            migrationBuilder.DropTable(
                name: "equipamentos");

            migrationBuilder.DropTable(
                name: "assistencia_tecnica");

            migrationBuilder.DropTable(
                name: "avaliacoes");

            migrationBuilder.DropTable(
                name: "clientes");
        }
    }
}
