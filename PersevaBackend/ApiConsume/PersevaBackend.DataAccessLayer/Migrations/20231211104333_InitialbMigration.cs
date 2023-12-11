using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PersevaBackend.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class InitialbMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BillingInfos",
                columns: table => new
                {
                    BillingId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BillingFirstName = table.Column<string>(type: "text", nullable: false),
                    BillingLastName = table.Column<string>(type: "text", nullable: false),
                    BillingNationalId = table.Column<string>(type: "text", nullable: false),
                    BillingEmail = table.Column<string>(type: "text", nullable: false),
                    BillingPhone = table.Column<string>(type: "text", nullable: false),
                    BillingCompany = table.Column<string>(type: "text", nullable: false),
                    BillingTaxOffice = table.Column<string>(type: "text", nullable: true),
                    BillingTaxNumber = table.Column<string>(type: "text", nullable: true),
                    BillingAddress = table.Column<string>(type: "text", nullable: true),
                    BillingDistrict = table.Column<string>(type: "text", nullable: true),
                    BillingCity = table.Column<string>(type: "text", nullable: true),
                    BillingPostcode = table.Column<int>(type: "integer", nullable: false),
                    BillingCountry = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillingInfos", x => x.BillingId);
                });

            migrationBuilder.CreateTable(
                name: "Cargos",
                columns: table => new
                {
                    CargoId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CargoStatus = table.Column<string>(type: "text", nullable: false),
                    CargoMethod = table.Column<string>(type: "text", nullable: false),
                    CargoType = table.Column<string>(type: "text", nullable: false),
                    CargoDateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CargoDateDispatched = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CargoCompany = table.Column<string>(type: "text", nullable: false),
                    CargoCode = table.Column<string>(type: "text", nullable: false),
                    CargoTrackingNumber = table.Column<string>(type: "text", nullable: false),
                    CargoTrackingUrl = table.Column<string>(type: "text", nullable: false),
                    CargoSize = table.Column<string>(type: "text", nullable: false),
                    CargoSizeUnit = table.Column<string>(type: "text", nullable: false),
                    CargoWeight = table.Column<decimal>(type: "numeric", nullable: false),
                    CargoWeightUnit = table.Column<string>(type: "text", nullable: false),
                    CargoCost = table.Column<double>(type: "double precision", nullable: false),
                    CargoCurrency = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargos", x => x.CargoId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CategoryName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    DiscountId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DiscountCode = table.Column<string>(type: "text", nullable: false),
                    DiscountDateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DiscountType = table.Column<string>(type: "text", nullable: false),
                    DiscountCurrency = table.Column<string>(type: "text", nullable: false),
                    DiscountNumAvailable = table.Column<string>(type: "text", nullable: false),
                    DiscountNumUsed = table.Column<string>(type: "text", nullable: false),
                    DiscountExpiresAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.DiscountId);
                });

            migrationBuilder.CreateTable(
                name: "ShopOwners",
                columns: table => new
                {
                    ShopOwnerId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Type = table.Column<string>(type: "text", nullable: true),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Phone = table.Column<string>(type: "text", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    District = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true),
                    Country = table.Column<string>(type: "text", nullable: true),
                    CompanyName = table.Column<string>(type: "text", nullable: true),
                    TaxOffice = table.Column<string>(type: "text", nullable: true),
                    TaxNumber = table.Column<string>(type: "text", nullable: true),
                    BankAccountHolder = table.Column<string>(type: "text", nullable: true),
                    BankAccountIban = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopOwners", x => x.ShopOwnerId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Username = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Fulfillments",
                columns: table => new
                {
                    FulfillmentId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CargoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fulfillments", x => x.FulfillmentId);
                    table.ForeignKey(
                        name: "FK_Fulfillments_Cargos_CargoId",
                        column: x => x.CargoId,
                        principalTable: "Cargos",
                        principalColumn: "CargoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Type = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<decimal>(type: "numeric", nullable: true),
                    CoverImage = table.Column<string>(type: "text", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Stock = table.Column<string>(type: "text", nullable: true),
                    CategoryId = table.Column<int>(type: "integer", nullable: false),
                    DiscountId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Discounts_DiscountId",
                        column: x => x.DiscountId,
                        principalTable: "Discounts",
                        principalColumn: "DiscountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAddresses",
                columns: table => new
                {
                    UserAddressId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AddressLine1 = table.Column<string>(type: "text", nullable: false),
                    AddressLine2 = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: false),
                    PostalCode = table.Column<string>(type: "text", nullable: false),
                    Country = table.Column<string>(type: "text", nullable: false),
                    Phone = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAddresses", x => x.UserAddressId);
                    table.ForeignKey(
                        name: "FK_UserAddresses_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Baskets",
                columns: table => new
                {
                    BasketId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    OrderId = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baskets", x => x.BasketId);
                    table.ForeignKey(
                        name: "FK_Baskets_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Status = table.Column<string>(type: "text", nullable: false),
                    PaymentStatus = table.Column<string>(type: "text", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Currency = table.Column<string>(type: "text", nullable: false),
                    PaymentMethod = table.Column<string>(type: "text", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    Note = table.Column<string>(type: "text", nullable: true),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Phone = table.Column<string>(type: "text", nullable: false),
                    Company = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    District = table.Column<string>(type: "text", nullable: false),
                    City = table.Column<string>(type: "text", nullable: false),
                    Postcode = table.Column<string>(type: "text", nullable: false),
                    Country = table.Column<string>(type: "text", nullable: false),
                    DiscountId = table.Column<int>(type: "integer", nullable: false),
                    BillingId = table.Column<int>(type: "integer", nullable: false),
                    BillingInfoBillingId = table.Column<int>(type: "integer", nullable: true),
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    FulfillmentsId = table.Column<int>(type: "integer", nullable: false),
                    RefundsId = table.Column<int>(type: "integer", nullable: false),
                    RefundId = table.Column<int>(type: "integer", nullable: true),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    CargoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_BillingInfos_BillingInfoBillingId",
                        column: x => x.BillingInfoBillingId,
                        principalTable: "BillingInfos",
                        principalColumn: "BillingId");
                    table.ForeignKey(
                        name: "FK_Orders_Cargos_CargoId",
                        column: x => x.CargoId,
                        principalTable: "Cargos",
                        principalColumn: "CargoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Discounts_DiscountId",
                        column: x => x.DiscountId,
                        principalTable: "Discounts",
                        principalColumn: "DiscountId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Fulfillments_FulfillmentsId",
                        column: x => x.FulfillmentsId,
                        principalTable: "Fulfillments",
                        principalColumn: "FulfillmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Returns",
                columns: table => new
                {
                    ReturnId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ReturnType = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: false),
                    ReturnDateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ReturnDateRefunded = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Currency = table.Column<string>(type: "text", nullable: false),
                    ReturnTotal = table.Column<double>(type: "double precision", nullable: false),
                    Note = table.Column<string>(type: "text", nullable: true),
                    OrderId = table.Column<int>(type: "integer", nullable: false),
                    CargoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Returns", x => x.ReturnId);
                    table.ForeignKey(
                        name: "FK_Returns_Cargos_CargoId",
                        column: x => x.CargoId,
                        principalTable: "Cargos",
                        principalColumn: "CargoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Returns_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Refunds",
                columns: table => new
                {
                    RefundId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RefundType = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: false),
                    RefundStatus = table.Column<string>(type: "text", nullable: false),
                    PaymentStatus = table.Column<string>(type: "text", nullable: false),
                    RefundDateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RefundDateRefunded = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Currency = table.Column<string>(type: "text", nullable: false),
                    RefundTotal = table.Column<double>(type: "double precision", nullable: false),
                    PaymentMethod = table.Column<string>(type: "text", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    Note = table.Column<string>(type: "text", nullable: true),
                    ReturnId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Refunds", x => x.RefundId);
                    table.ForeignKey(
                        name: "FK_Refunds_Returns_ReturnId",
                        column: x => x.ReturnId,
                        principalTable: "Returns",
                        principalColumn: "ReturnId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_OrderId",
                table: "Baskets",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_ProductId",
                table: "Baskets",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Fulfillments_CargoId",
                table: "Fulfillments",
                column: "CargoId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_BillingInfoBillingId",
                table: "Orders",
                column: "BillingInfoBillingId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CargoId",
                table: "Orders",
                column: "CargoId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_DiscountId",
                table: "Orders",
                column: "DiscountId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_FulfillmentsId",
                table: "Orders",
                column: "FulfillmentsId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ProductId",
                table: "Orders",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_RefundId",
                table: "Orders",
                column: "RefundId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_DiscountId",
                table: "Products",
                column: "DiscountId");

            migrationBuilder.CreateIndex(
                name: "IX_Refunds_ReturnId",
                table: "Refunds",
                column: "ReturnId");

            migrationBuilder.CreateIndex(
                name: "IX_Returns_CargoId",
                table: "Returns",
                column: "CargoId");

            migrationBuilder.CreateIndex(
                name: "IX_Returns_OrderId",
                table: "Returns",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAddresses_UserId",
                table: "UserAddresses",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Baskets_Orders_OrderId",
                table: "Baskets",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Refunds_RefundId",
                table: "Orders",
                column: "RefundId",
                principalTable: "Refunds",
                principalColumn: "RefundId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Returns_Orders_OrderId",
                table: "Returns");

            migrationBuilder.DropTable(
                name: "Baskets");

            migrationBuilder.DropTable(
                name: "ShopOwners");

            migrationBuilder.DropTable(
                name: "UserAddresses");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "BillingInfos");

            migrationBuilder.DropTable(
                name: "Fulfillments");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Refunds");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Discounts");

            migrationBuilder.DropTable(
                name: "Returns");

            migrationBuilder.DropTable(
                name: "Cargos");
        }
    }
}
