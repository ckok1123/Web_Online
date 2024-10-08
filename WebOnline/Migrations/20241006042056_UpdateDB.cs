﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebOnline.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_CaiDatHeThong",
                columns: table => new
                {
                    SettingKey = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SettingValue = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    CreatBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_CaiDatHeThong", x => x.SettingKey);
                });

            migrationBuilder.CreateTable(
                name: "tb_DanhMuc",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Positon = table.Column<int>(type: "int", nullable: false),
                    SeoTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeoDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeoKeyWord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_DanhMuc", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_DanhMucSanPham",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeoTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeoDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeoKeyWord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_DanhMucSanPham", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_HinhAnhSanPham",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_HinhAnhSanPham", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_LienHe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsReal = table.Column<bool>(type: "bit", nullable: false),
                    CreatBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_LienHe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_QuangCao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreatBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_QuangCao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_TaiKhoan",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_TaiKhoan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_VaiTro",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_VaiTro", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb.ThuongHieu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameBranch = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb.ThuongHieu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_BaiViet",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    SeoTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeoDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeoKeyWords = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryssId = table.Column<int>(type: "int", nullable: false),
                    CreatBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_BaiViet", x => x.ID);
                    table.ForeignKey(
                        name: "FK_tb_BaiViet_tb_DanhMuc_CategoryssId",
                        column: x => x.CategoryssId,
                        principalTable: "tb_DanhMuc",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_TinTuc",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    SeoTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeoDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeoKeyWords = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategorysId = table.Column<int>(type: "int", nullable: false),
                    CreatBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_TinTuc", x => x.ID);
                    table.ForeignKey(
                        name: "FK_tb_TinTuc_tb_DanhMuc_CategorysId",
                        column: x => x.CategorysId,
                        principalTable: "tb_DanhMuc",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_UserClaims_tb_TaiKhoan_UserId",
                        column: x => x.UserId,
                        principalTable: "tb_TaiKhoan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_tb_UserLogins_tb_TaiKhoan_UserId",
                        column: x => x.UserId,
                        principalTable: "tb_TaiKhoan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_tb_UserTokens_tb_TaiKhoan_UserId",
                        column: x => x.UserId,
                        principalTable: "tb_TaiKhoan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb.GioHang",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb.GioHang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb.GioHang_tb_TaiKhoan_UserID",
                        column: x => x.UserID,
                        principalTable: "tb_TaiKhoan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_tb_TaiKhoan_UserId",
                        column: x => x.UserId,
                        principalTable: "tb_TaiKhoan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_tb_VaiTro_RoleId",
                        column: x => x.RoleId,
                        principalTable: "tb_VaiTro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_RoleClaims_tb_VaiTro_RoleId",
                        column: x => x.RoleId,
                        principalTable: "tb_VaiTro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_SanPham",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PriceSale = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    IsHome = table.Column<bool>(type: "bit", nullable: false),
                    IsSale = table.Column<bool>(type: "bit", nullable: false),
                    IsFeature = table.Column<bool>(type: "bit", nullable: false),
                    IsHot = table.Column<bool>(type: "bit", nullable: false),
                    ProductCategory = table.Column<int>(type: "int", nullable: false),
                    SeoTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeoDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeoKeyWords = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductCategorysId = table.Column<int>(type: "int", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    CreatBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_SanPham", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_SanPham_tb.ThuongHieu_BranchId",
                        column: x => x.BranchId,
                        principalTable: "tb.ThuongHieu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_SanPham_tb_DanhMucSanPham_ProductCategorysId",
                        column: x => x.ProductCategorysId,
                        principalTable: "tb_DanhMucSanPham",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_DonHang",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalArmout = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_DonHang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_DonHang_tb.GioHang_CartId",
                        column: x => x.CartId,
                        principalTable: "tb.GioHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_DonHang_tb_TaiKhoan_UserId",
                        column: x => x.UserId,
                        principalTable: "tb_TaiKhoan",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tb.CartItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb.CartItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb.CartItem_tb.GioHang_CartId",
                        column: x => x.CartId,
                        principalTable: "tb.GioHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb.CartItem_tb_SanPham_ProductId",
                        column: x => x.ProductId,
                        principalTable: "tb_SanPham",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb.OderItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OdersId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb.OderItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb.OderItem_tb_DonHang_OdersId",
                        column: x => x.OdersId,
                        principalTable: "tb_DonHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb.OderItem_tb_SanPham_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "tb_SanPham",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_BaiViet_CategoryssId",
                table: "tb_BaiViet",
                column: "CategoryssId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_DonHang_CartId",
                table: "tb_DonHang",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_DonHang_UserId",
                table: "tb_DonHang",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_RoleClaims_RoleId",
                table: "tb_RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_SanPham_BranchId",
                table: "tb_SanPham",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_SanPham_ProductCategorysId",
                table: "tb_SanPham",
                column: "ProductCategorysId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "tb_TaiKhoan",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "tb_TaiKhoan",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_tb_TinTuc_CategorysId",
                table: "tb_TinTuc",
                column: "CategorysId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_UserClaims_UserId",
                table: "tb_UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_UserLogins_UserId",
                table: "tb_UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "tb_VaiTro",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_tb.CartItem_CartId",
                table: "tb.CartItem",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_tb.CartItem_ProductId",
                table: "tb.CartItem",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_tb.GioHang_UserID",
                table: "tb.GioHang",
                column: "UserID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb.OderItem_OdersId",
                table: "tb.OderItem",
                column: "OdersId");

            migrationBuilder.CreateIndex(
                name: "IX_tb.OderItem_ProductsId",
                table: "tb.OderItem",
                column: "ProductsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "tb_BaiViet");

            migrationBuilder.DropTable(
                name: "tb_CaiDatHeThong");

            migrationBuilder.DropTable(
                name: "tb_HinhAnhSanPham");

            migrationBuilder.DropTable(
                name: "tb_LienHe");

            migrationBuilder.DropTable(
                name: "tb_QuangCao");

            migrationBuilder.DropTable(
                name: "tb_RoleClaims");

            migrationBuilder.DropTable(
                name: "tb_TinTuc");

            migrationBuilder.DropTable(
                name: "tb_UserClaims");

            migrationBuilder.DropTable(
                name: "tb_UserLogins");

            migrationBuilder.DropTable(
                name: "tb_UserTokens");

            migrationBuilder.DropTable(
                name: "tb.CartItem");

            migrationBuilder.DropTable(
                name: "tb.OderItem");

            migrationBuilder.DropTable(
                name: "tb_VaiTro");

            migrationBuilder.DropTable(
                name: "tb_DanhMuc");

            migrationBuilder.DropTable(
                name: "tb_DonHang");

            migrationBuilder.DropTable(
                name: "tb_SanPham");

            migrationBuilder.DropTable(
                name: "tb.GioHang");

            migrationBuilder.DropTable(
                name: "tb.ThuongHieu");

            migrationBuilder.DropTable(
                name: "tb_DanhMucSanPham");

            migrationBuilder.DropTable(
                name: "tb_TaiKhoan");
        }
    }
}
