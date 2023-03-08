using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_RentalMovie.Migrations
{
    /// <inheritdoc />
    public partial class InitialCommit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_rzh_m_actors",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    first_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    last_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    last_update = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_rzh_m_actors", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_rzh_m_categories",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    last_update = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_rzh_m_categories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_rzh_m_countries",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    last_update = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_rzh_m_countries", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_rzh_m_languages",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    last_update = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_rzh_m_languages", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_rzh_m_roles",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_rzh_m_roles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_rzh_m_cities",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    last_update = table.Column<DateTime>(type: "datetime2", nullable: false),
                    country_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_rzh_m_cities", x => x.id);
                    table.ForeignKey(
                        name: "FK_tb_rzh_m_cities_tb_rzh_m_countries_country_id",
                        column: x => x.country_id,
                        principalTable: "tb_rzh_m_countries",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_rzh_m_films",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tittle = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    release_year = table.Column<int>(type: "int", nullable: false),
                    rental_duration = table.Column<int>(type: "int", nullable: false),
                    rental_rate = table.Column<decimal>(type: "numeric(19,0)", nullable: false),
                    length = table.Column<int>(type: "int", nullable: false),
                    replacement_cost = table.Column<decimal>(type: "numeric(19,0)", nullable: false),
                    rating = table.Column<int>(type: "int", nullable: false),
                    last_update = table.Column<DateTime>(type: "datetime2", nullable: false),
                    special_features = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    full_text = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    language_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_rzh_m_films", x => x.id);
                    table.ForeignKey(
                        name: "FK_tb_rzh_m_films_tb_rzh_m_languages_language_id",
                        column: x => x.language_id,
                        principalTable: "tb_rzh_m_languages",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_rzh_m_addresses",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    address1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    address2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    district = table.Column<int>(type: "int", nullable: false),
                    postal_code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    last_update = table.Column<DateTime>(type: "datetime2", nullable: false),
                    city_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_rzh_m_addresses", x => x.id);
                    table.ForeignKey(
                        name: "FK_tb_rzh_m_addresses_tb_rzh_m_cities_city_id",
                        column: x => x.city_id,
                        principalTable: "tb_rzh_m_cities",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_rzh_m_inventories",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    last_update = table.Column<DateTime>(type: "datetime2", nullable: false),
                    film_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_rzh_m_inventories", x => x.id);
                    table.ForeignKey(
                        name: "FK_tb_rzh_m_inventories_tb_rzh_m_films_film_id",
                        column: x => x.film_id,
                        principalTable: "tb_rzh_m_films",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_rzh_tr_filmactors",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    last_update = table.Column<DateTime>(type: "datetime2", nullable: false),
                    film_id = table.Column<int>(type: "int", nullable: false),
                    actor_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_rzh_tr_filmactors", x => x.id);
                    table.ForeignKey(
                        name: "FK_tb_rzh_tr_filmactors_tb_rzh_m_actors_actor_id",
                        column: x => x.actor_id,
                        principalTable: "tb_rzh_m_actors",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_rzh_tr_filmactors_tb_rzh_m_films_film_id",
                        column: x => x.film_id,
                        principalTable: "tb_rzh_m_films",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_rzh_tr_filmcategories",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    last_update = table.Column<DateTime>(type: "datetime2", nullable: false),
                    film_id = table.Column<int>(type: "int", nullable: false),
                    category_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_rzh_tr_filmcategories", x => x.id);
                    table.ForeignKey(
                        name: "FK_tb_rzh_tr_filmcategories_tb_rzh_m_categories_category_id",
                        column: x => x.category_id,
                        principalTable: "tb_rzh_m_categories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_rzh_tr_filmcategories_tb_rzh_m_films_film_id",
                        column: x => x.film_id,
                        principalTable: "tb_rzh_m_films",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_rzh_m_customers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    first_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    last_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    active = table.Column<string>(type: "nchar(1)", nullable: false),
                    create_update = table.Column<DateTime>(type: "datetime2", nullable: false),
                    last_update = table.Column<DateTime>(type: "datetime2", nullable: false),
                    addres_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_rzh_m_customers", x => x.id);
                    table.ForeignKey(
                        name: "FK_tb_rzh_m_customers_tb_rzh_m_addresses_addres_id",
                        column: x => x.addres_id,
                        principalTable: "tb_rzh_m_addresses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_rzh_m_stores",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    last_update = table.Column<DateTime>(type: "datetime2", nullable: false),
                    address_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_rzh_m_stores", x => x.id);
                    table.ForeignKey(
                        name: "FK_tb_rzh_m_stores_tb_rzh_m_addresses_address_id",
                        column: x => x.address_id,
                        principalTable: "tb_rzh_m_addresses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_rzh_m_staffs",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    payment_id = table.Column<int>(type: "int", nullable: true),
                    first_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    last_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    active = table.Column<string>(type: "nchar(1)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    last_update = table.Column<DateTime>(type: "datetime2", nullable: false),
                    picture_url = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    address_id = table.Column<int>(type: "int", nullable: false),
                    store_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_rzh_m_staffs", x => x.id);
                    table.ForeignKey(
                        name: "FK_tb_rzh_m_staffs_tb_rzh_m_addresses_address_id",
                        column: x => x.address_id,
                        principalTable: "tb_rzh_m_addresses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_rzh_m_staffs_tb_rzh_m_stores_store_id",
                        column: x => x.store_id,
                        principalTable: "tb_rzh_m_stores",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "tb_rzh_m_accounts",
                columns: table => new
                {
                    staff_id = table.Column<int>(type: "int", nullable: false),
                    password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_rzh_m_accounts", x => x.staff_id);
                    table.ForeignKey(
                        name: "FK_tb_rzh_m_accounts_tb_rzh_m_staffs_staff_id",
                        column: x => x.staff_id,
                        principalTable: "tb_rzh_m_staffs",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "tb_rzh_tr_rentals",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rental_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    return_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    last_update = table.Column<DateTime>(type: "datetime2", nullable: false),
                    staff_id = table.Column<int>(type: "int", nullable: false),
                    customer_id = table.Column<int>(type: "int", nullable: false),
                    inventory_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_rzh_tr_rentals", x => x.id);
                    table.ForeignKey(
                        name: "FK_tb_rzh_tr_rentals_tb_rzh_m_customers_customer_id",
                        column: x => x.customer_id,
                        principalTable: "tb_rzh_m_customers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_rzh_tr_rentals_tb_rzh_m_inventories_inventory_id",
                        column: x => x.inventory_id,
                        principalTable: "tb_rzh_m_inventories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_rzh_tr_rentals_tb_rzh_m_staffs_staff_id",
                        column: x => x.staff_id,
                        principalTable: "tb_rzh_m_staffs",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "tb_rzh_tr_accountroles",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    account_id = table.Column<int>(type: "int", nullable: false),
                    role_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_rzh_tr_accountroles", x => x.id);
                    table.ForeignKey(
                        name: "FK_tb_rzh_tr_accountroles_tb_rzh_m_accounts_account_id",
                        column: x => x.account_id,
                        principalTable: "tb_rzh_m_accounts",
                        principalColumn: "staff_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_rzh_tr_accountroles_tb_rzh_m_roles_role_id",
                        column: x => x.role_id,
                        principalTable: "tb_rzh_m_roles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_rzh_tr_payments",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    amount = table.Column<decimal>(type: "numeric(19,0)", nullable: false),
                    payment_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    rental_id = table.Column<int>(type: "int", nullable: false),
                    customer_id = table.Column<int>(type: "int", nullable: false),
                    staff_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_rzh_tr_payments", x => x.id);
                    table.ForeignKey(
                        name: "FK_tb_rzh_tr_payments_tb_rzh_m_customers_customer_id",
                        column: x => x.customer_id,
                        principalTable: "tb_rzh_m_customers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_rzh_tr_payments_tb_rzh_m_staffs_staff_id",
                        column: x => x.staff_id,
                        principalTable: "tb_rzh_m_staffs",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_tb_rzh_tr_payments_tb_rzh_tr_rentals_rental_id",
                        column: x => x.rental_id,
                        principalTable: "tb_rzh_tr_rentals",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_rzh_m_addresses_city_id",
                table: "tb_rzh_m_addresses",
                column: "city_id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_rzh_m_cities_country_id",
                table: "tb_rzh_m_cities",
                column: "country_id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_rzh_m_customers_addres_id",
                table: "tb_rzh_m_customers",
                column: "addres_id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_rzh_m_customers_email",
                table: "tb_rzh_m_customers",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_rzh_m_films_language_id",
                table: "tb_rzh_m_films",
                column: "language_id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_rzh_m_inventories_film_id",
                table: "tb_rzh_m_inventories",
                column: "film_id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_rzh_m_staffs_address_id",
                table: "tb_rzh_m_staffs",
                column: "address_id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_rzh_m_staffs_email",
                table: "tb_rzh_m_staffs",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_rzh_m_staffs_store_id",
                table: "tb_rzh_m_staffs",
                column: "store_id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_rzh_m_stores_address_id",
                table: "tb_rzh_m_stores",
                column: "address_id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_rzh_tr_accountroles_account_id",
                table: "tb_rzh_tr_accountroles",
                column: "account_id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_rzh_tr_accountroles_role_id",
                table: "tb_rzh_tr_accountroles",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_rzh_tr_filmactors_actor_id",
                table: "tb_rzh_tr_filmactors",
                column: "actor_id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_rzh_tr_filmactors_film_id",
                table: "tb_rzh_tr_filmactors",
                column: "film_id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_rzh_tr_filmcategories_category_id",
                table: "tb_rzh_tr_filmcategories",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_rzh_tr_filmcategories_film_id",
                table: "tb_rzh_tr_filmcategories",
                column: "film_id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_rzh_tr_payments_customer_id",
                table: "tb_rzh_tr_payments",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_rzh_tr_payments_rental_id",
                table: "tb_rzh_tr_payments",
                column: "rental_id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_rzh_tr_payments_staff_id",
                table: "tb_rzh_tr_payments",
                column: "staff_id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_rzh_tr_rentals_customer_id",
                table: "tb_rzh_tr_rentals",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_rzh_tr_rentals_inventory_id",
                table: "tb_rzh_tr_rentals",
                column: "inventory_id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_rzh_tr_rentals_staff_id",
                table: "tb_rzh_tr_rentals",
                column: "staff_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_rzh_tr_accountroles");

            migrationBuilder.DropTable(
                name: "tb_rzh_tr_filmactors");

            migrationBuilder.DropTable(
                name: "tb_rzh_tr_filmcategories");

            migrationBuilder.DropTable(
                name: "tb_rzh_tr_payments");

            migrationBuilder.DropTable(
                name: "tb_rzh_m_accounts");

            migrationBuilder.DropTable(
                name: "tb_rzh_m_roles");

            migrationBuilder.DropTable(
                name: "tb_rzh_m_actors");

            migrationBuilder.DropTable(
                name: "tb_rzh_m_categories");

            migrationBuilder.DropTable(
                name: "tb_rzh_tr_rentals");

            migrationBuilder.DropTable(
                name: "tb_rzh_m_customers");

            migrationBuilder.DropTable(
                name: "tb_rzh_m_inventories");

            migrationBuilder.DropTable(
                name: "tb_rzh_m_staffs");

            migrationBuilder.DropTable(
                name: "tb_rzh_m_films");

            migrationBuilder.DropTable(
                name: "tb_rzh_m_stores");

            migrationBuilder.DropTable(
                name: "tb_rzh_m_languages");

            migrationBuilder.DropTable(
                name: "tb_rzh_m_addresses");

            migrationBuilder.DropTable(
                name: "tb_rzh_m_cities");

            migrationBuilder.DropTable(
                name: "tb_rzh_m_countries");
        }
    }
}
