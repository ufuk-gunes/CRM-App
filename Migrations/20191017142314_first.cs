using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MixCRM.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departmen",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ad = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departmen", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Firmas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirmaAdi = table.Column<string>(nullable: true),
                    Unvan = table.Column<string>(nullable: true),
                    Eposta = table.Column<string>(nullable: true),
                    Tel = table.Column<string>(nullable: true),
                    FirmaYetkilisi = table.Column<string>(nullable: true),
                    Adres = table.Column<string>(nullable: true),
                    Aciklama = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firmas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kategoris",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ad = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoris", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ad = table.Column<string>(nullable: true),
                    Soyad = table.Column<string>(nullable: true),
                    Cinsiyet = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DTarih = table.Column<DateTime>(nullable: false),
                    Foto = table.Column<string>(nullable: true),
                    Adres = table.Column<string>(nullable: true),
                    DepartmanId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personels_Departmen_DepartmanId",
                        column: x => x.DepartmanId,
                        principalTable: "Departmen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Musteris",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ad = table.Column<string>(nullable: true),
                    Soyad = table.Column<string>(nullable: true),
                    TCKimlik = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Cinsiyet = table.Column<string>(nullable: true),
                    DTarih = table.Column<DateTime>(nullable: false),
                    Adres = table.Column<string>(nullable: true),
                    FirmaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musteris", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Musteris_Firmas_FirmaId",
                        column: x => x.FirmaId,
                        principalTable: "Firmas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Uruns",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UrunKodu = table.Column<string>(nullable: true),
                    UrunAdi = table.Column<string>(nullable: true),
                    SatisFiyati = table.Column<decimal>(nullable: false),
                    AlisFiyati = table.Column<decimal>(nullable: false),
                    Aciklama = table.Column<string>(nullable: true),
                    Resim = table.Column<string>(nullable: true),
                    KategoriId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uruns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Uruns_Kategoris_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategoris",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teklifs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TeklifAdi = table.Column<string>(nullable: true),
                    BasTarih = table.Column<DateTime>(nullable: false),
                    BitTarih = table.Column<DateTime>(nullable: false),
                    PersonelId = table.Column<int>(nullable: false),
                    MusteriId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teklifs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teklifs_Musteris_MusteriId",
                        column: x => x.MusteriId,
                        principalTable: "Musteris",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Teklifs_Personels_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "Personels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Satis",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SatisAdi = table.Column<string>(nullable: true),
                    SatisTarihi = table.Column<DateTime>(nullable: false),
                    MusteriId = table.Column<int>(nullable: false),
                    PersonelId = table.Column<int>(nullable: false),
                    UrunId = table.Column<int>(nullable: false),
                    SatisAdeti = table.Column<int>(nullable: false),
                    Aciklama = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Satis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Satis_Musteris_MusteriId",
                        column: x => x.MusteriId,
                        principalTable: "Musteris",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Satis_Personels_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "Personels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Satis_Uruns_UrunId",
                        column: x => x.UrunId,
                        principalTable: "Uruns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stoks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StokAdet = table.Column<int>(nullable: false),
                    UrunId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stoks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stoks_Uruns_UrunId",
                        column: x => x.UrunId,
                        principalTable: "Uruns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Musteris_FirmaId",
                table: "Musteris",
                column: "FirmaId");

            migrationBuilder.CreateIndex(
                name: "IX_Personels_DepartmanId",
                table: "Personels",
                column: "DepartmanId");

            migrationBuilder.CreateIndex(
                name: "IX_Satis_MusteriId",
                table: "Satis",
                column: "MusteriId");

            migrationBuilder.CreateIndex(
                name: "IX_Satis_PersonelId",
                table: "Satis",
                column: "PersonelId");

            migrationBuilder.CreateIndex(
                name: "IX_Satis_UrunId",
                table: "Satis",
                column: "UrunId");

            migrationBuilder.CreateIndex(
                name: "IX_Stoks_UrunId",
                table: "Stoks",
                column: "UrunId");

            migrationBuilder.CreateIndex(
                name: "IX_Teklifs_MusteriId",
                table: "Teklifs",
                column: "MusteriId");

            migrationBuilder.CreateIndex(
                name: "IX_Teklifs_PersonelId",
                table: "Teklifs",
                column: "PersonelId");

            migrationBuilder.CreateIndex(
                name: "IX_Uruns_KategoriId",
                table: "Uruns",
                column: "KategoriId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Satis");

            migrationBuilder.DropTable(
                name: "Stoks");

            migrationBuilder.DropTable(
                name: "Teklifs");

            migrationBuilder.DropTable(
                name: "Uruns");

            migrationBuilder.DropTable(
                name: "Musteris");

            migrationBuilder.DropTable(
                name: "Personels");

            migrationBuilder.DropTable(
                name: "Kategoris");

            migrationBuilder.DropTable(
                name: "Firmas");

            migrationBuilder.DropTable(
                name: "Departmen");
        }
    }
}
