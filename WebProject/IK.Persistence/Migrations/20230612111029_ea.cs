using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace IK.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ea : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gnl_EduType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    LangKey = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gnl_EduType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gnl_InvCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ParentID = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    LangKey = table.Column<string>(type: "text", nullable: false),
                    SyncID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gnl_InvCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gnl_LobbyDashboard",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    LangKey = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gnl_LobbyDashboard", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gnl_WorkGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ParentID = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gnl_WorkGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gnl_WorkTemp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    LangKey = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gnl_WorkTemp", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeaveTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsPaid = table.Column<short>(type: "smallint", nullable: false),
                    IsDamaged = table.Column<short>(type: "smallint", nullable: false),
                    Status = table.Column<short>(type: "smallint", nullable: false),
                    Title = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    LangKey = table.Column<string>(type: "text", nullable: false),
                    SyncID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Status = table.Column<bool>(type: "boolean", nullable: false),
                    RegNumber = table.Column<string>(type: "text", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_DemandType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    LangKey = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_DemandType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_DocumentType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    LangKey = table.Column<string>(type: "text", nullable: false),
                    MyProperty = table.Column<int>(type: "integer", nullable: false),
                    TypeID = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_DocumentType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_FeedbackCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    LangKey = table.Column<string>(type: "text", nullable: false),
                    Typeid = table.Column<int>(type: "integer", nullable: false),
                    sysid = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_FeedbackCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_Module",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ParentID = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<short>(type: "smallint", nullable: false),
                    IsMain = table.Column<short>(type: "smallint", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    OrderNo = table.Column<int>(type: "integer", nullable: false),
                    Vers = table.Column<string>(type: "text", nullable: false),
                    LangKey = table.Column<string>(type: "text", nullable: false),
                    Icon = table.Column<string>(type: "text", nullable: false),
                    Url = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Module", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_PersonTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    LangKey = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_PersonTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_Position",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    LangKey = table.Column<string>(type: "text", nullable: false),
                    SyncID = table.Column<int>(type: "integer", nullable: true),
                    ParentID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Position", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_VisaType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    LangKey = table.Column<string>(type: "text", nullable: false),
                    SyncID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_VisaType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "totaltahmin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Yil = table.Column<int>(type: "integer", nullable: false),
                    TotalTahmin = table.Column<double>(type: "double precision", nullable: false),
                    CalisilmayanGunler = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_totaltahmin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gnl_WorkTempItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SysWorkTempID = table.Column<int>(type: "integer", nullable: false),
                    dayid = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<short>(type: "smallint", nullable: false),
                    StartAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gnl_WorkTempItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gnl_WorkTempItem_Gnl_WorkTemp_SysWorkTempID",
                        column: x => x.SysWorkTempID,
                        principalTable: "Gnl_WorkTemp",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sys_Department",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SysCompanyID = table.Column<int>(type: "integer", nullable: false),
                    SysWorkTempID = table.Column<int>(type: "integer", nullable: false),
                    ParentID = table.Column<int>(type: "integer", nullable: false),
                    SuperVisorID = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    LangKey = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<short>(type: "smallint", nullable: false),
                    SyncID = table.Column<int>(type: "integer", nullable: false),
                    GnlWorkTempId = table.Column<int>(name: "Gnl_WorkTempId", type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Department", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sys_Department_Gnl_WorkTemp_Gnl_WorkTempId",
                        column: x => x.GnlWorkTempId,
                        principalTable: "Gnl_WorkTemp",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Sys_Department_Sys_Companies_SysCompanyID",
                        column: x => x.SysCompanyID,
                        principalTable: "Sys_Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sys_ModuleMenu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SysModuleID = table.Column<int>(type: "integer", nullable: false),
                    ParentID = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<short>(type: "smallint", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    MenuGroup = table.Column<string>(type: "text", nullable: false),
                    OrderNo = table.Column<int>(type: "integer", nullable: false),
                    LangKey = table.Column<string>(type: "text", nullable: false),
                    Icon = table.Column<string>(type: "text", nullable: false),
                    Url = table.Column<string>(type: "text", nullable: false),
                    TestUrl = table.Column<string>(type: "text", nullable: false),
                    SyncID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_ModuleMenu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sys_ModuleMenu_Sys_Module_SysModuleID",
                        column: x => x.SysModuleID,
                        principalTable: "Sys_Module",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sys_Persons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonTypeID = table.Column<int>(type: "integer", nullable: false),
                    PersonFingerID = table.Column<int>(type: "integer", nullable: true),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Status = table.Column<short>(type: "smallint", nullable: false),
                    SyncID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Persons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sys_Persons_Sys_PersonTypes_PersonTypeID",
                        column: x => x.PersonTypeID,
                        principalTable: "Sys_PersonTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sys_Shift",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SysDepartmentID = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    StartAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Shift", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sys_Shift_Sys_Department_SysDepartmentID",
                        column: x => x.SysDepartmentID,
                        principalTable: "Sys_Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sys_MenuPer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SysModuleMenuID = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<short>(type: "smallint", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    LangKey = table.Column<string>(type: "text", nullable: false),
                    PerKey = table.Column<string>(type: "text", nullable: false),
                    SysModuleMenuId = table.Column<int>(name: "Sys_ModuleMenuId", type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_MenuPer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sys_MenuPer_Sys_ModuleMenu_Sys_ModuleMenuId",
                        column: x => x.SysModuleMenuId,
                        principalTable: "Sys_ModuleMenu",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Gnl_Inventory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonID = table.Column<int>(type: "integer", nullable: false),
                    SysCompanyID = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<short>(type: "smallint", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    SpecialCode = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gnl_Inventory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gnl_Inventory_Sys_Companies_SysCompanyID",
                        column: x => x.SysCompanyID,
                        principalTable: "Sys_Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Gnl_Inventory_Sys_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Sys_Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Gnl_PersonConDashboard",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonID = table.Column<int>(type: "integer", nullable: false),
                    DashID = table.Column<int>(type: "integer", nullable: false),
                    SysLobbyDashboardId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gnl_PersonConDashboard", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gnl_PersonConDashboard_Gnl_LobbyDashboard_SysLobbyDashboard~",
                        column: x => x.SysLobbyDashboardId,
                        principalTable: "Gnl_LobbyDashboard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Gnl_PersonConDashboard_Sys_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Sys_Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Gnl_PersonConDepartment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonID = table.Column<int>(type: "integer", nullable: false),
                    SysDepartmentID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gnl_PersonConDepartment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gnl_PersonConDepartment_Sys_Department_SysDepartmentID",
                        column: x => x.SysDepartmentID,
                        principalTable: "Sys_Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Gnl_PersonConDepartment_Sys_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Sys_Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Gnl_PersonConModule",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonID = table.Column<int>(type: "integer", nullable: false),
                    SysModuleID = table.Column<int>(type: "integer", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gnl_PersonConModule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gnl_PersonConModule_Sys_Module_SysModuleID",
                        column: x => x.SysModuleID,
                        principalTable: "Sys_Module",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Gnl_PersonConModule_Sys_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Sys_Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Gnl_PersonConModuleMenu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonID = table.Column<int>(type: "integer", nullable: false),
                    SysModuleMenuID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gnl_PersonConModuleMenu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gnl_PersonConModuleMenu_Sys_ModuleMenu_SysModuleMenuID",
                        column: x => x.SysModuleMenuID,
                        principalTable: "Sys_ModuleMenu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Gnl_PersonConModuleMenu_Sys_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Sys_Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Gnl_PersonConPerM",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonID = table.Column<int>(type: "integer", nullable: false),
                    PerMID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gnl_PersonConPerM", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gnl_PersonConPerM_Sys_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Sys_Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Gnl_PersonConPositions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonId = table.Column<int>(type: "integer", nullable: false),
                    SysPositionID = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gnl_PersonConPositions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gnl_PersonConPositions_Sys_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Sys_Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Gnl_PersonConPositions_Sys_Position_SysPositionID",
                        column: x => x.SysPositionID,
                        principalTable: "Sys_Position",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Gnl_PersonConRollcallDepartment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonID = table.Column<int>(type: "integer", nullable: false),
                    SysDepartmentID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gnl_PersonConRollcallDepartment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gnl_PersonConRollcallDepartment_Sys_Department_SysDepartmen~",
                        column: x => x.SysDepartmentID,
                        principalTable: "Sys_Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Gnl_PersonConRollcallDepartment_Sys_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Sys_Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Gnl_PersonConWorkGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonID = table.Column<int>(type: "integer", nullable: false),
                    WorkGroupID = table.Column<int>(type: "integer", nullable: false),
                    SysWorkGroupId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gnl_PersonConWorkGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gnl_PersonConWorkGroup_Gnl_WorkGroup_SysWorkGroupId",
                        column: x => x.SysWorkGroupId,
                        principalTable: "Gnl_WorkGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Gnl_PersonConWorkGroup_Sys_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Sys_Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Gnl_PersonConWorkTemp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonID = table.Column<int>(type: "integer", nullable: false),
                    SysWorkTempID = table.Column<int>(type: "integer", nullable: false),
                    YearSection = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gnl_PersonConWorkTemp", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gnl_PersonConWorkTemp_Gnl_WorkTemp_SysWorkTempID",
                        column: x => x.SysWorkTempID,
                        principalTable: "Gnl_WorkTemp",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Gnl_PersonConWorkTemp_Sys_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Sys_Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Gnl_PersonPassaports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonId = table.Column<int>(type: "integer", nullable: false),
                    type = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    code = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    country = table.Column<string>(type: "text", nullable: true),
                    nation = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<bool>(type: "boolean", nullable: false),
                    startAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    endAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gnl_PersonPassaports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gnl_PersonPassaports_Sys_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Sys_Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Gnl_PersonPepper",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonID = table.Column<int>(type: "integer", nullable: false),
                    PepperSys = table.Column<short>(type: "smallint", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    Lang = table.Column<string>(type: "text", nullable: false),
                    Ccheck = table.Column<short>(type: "smallint", nullable: false),
                    Scheck = table.Column<short>(type: "smallint", nullable: false),
                    Vcheck = table.Column<short>(type: "smallint", nullable: false),
                    Acheck = table.Column<short>(type: "smallint", nullable: false),
                    IMcheck = table.Column<short>(type: "smallint", nullable: false),
                    CMcheck = table.Column<short>(type: "smallint", nullable: false),
                    VMcheck = table.Column<short>(type: "smallint", nullable: false),
                    CHMcheck = table.Column<short>(type: "smallint", nullable: false),
                    SMcheck = table.Column<short>(type: "smallint", nullable: false),
                    IPcheck = table.Column<short>(type: "smallint", nullable: false),
                    WDcheck = table.Column<short>(type: "smallint", nullable: false),
                    LDProperty = table.Column<short>(type: "smallint", nullable: false),
                    IMD = table.Column<short>(type: "smallint", nullable: false),
                    CMD = table.Column<short>(type: "smallint", nullable: false),
                    VMD = table.Column<short>(type: "smallint", nullable: false),
                    CHMD = table.Column<short>(type: "smallint", nullable: false),
                    SMD = table.Column<short>(type: "smallint", nullable: false),
                    IP = table.Column<string>(type: "text", nullable: false),
                    TermID = table.Column<string>(type: "text", nullable: false),
                    WDDate = table.Column<string>(type: "text", nullable: false),
                    LDDate = table.Column<string>(type: "text", nullable: false),
                    Dashboard = table.Column<string>(type: "text", nullable: false),
                    PGManager = table.Column<string>(type: "text", nullable: false),
                    TLang = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gnl_PersonPepper", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gnl_PersonPepper_Sys_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Sys_Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "maliyetzarari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonID = table.Column<int>(type: "integer", nullable: false),
                    Yil = table.Column<int>(type: "integer", nullable: false),
                    Durum = table.Column<int>(type: "integer", nullable: false),
                    GunlukUcret = table.Column<double>(type: "double precision", nullable: false),
                    Zarar = table.Column<double>(type: "double precision", nullable: false),
                    DevamsizGun = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    SysPersonId = table.Column<int>(name: "Sys_PersonId", type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_maliyetzarari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_maliyetzarari_Sys_Persons_Sys_PersonId",
                        column: x => x.SysPersonId,
                        principalTable: "Sys_Persons",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "personleaves",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonID = table.Column<int>(type: "integer", nullable: false),
                    SysLeaveTypeID = table.Column<int>(type: "integer", nullable: false),
                    StartAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    LFile = table.Column<string>(type: "text", nullable: false),
                    Note = table.Column<string>(type: "text", nullable: false),
                    SyncID = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personleaves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_personleaves_LeaveTypes_SysLeaveTypeID",
                        column: x => x.SysLeaveTypeID,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_personleaves_Sys_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Sys_Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sys_Address",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonID = table.Column<int>(type: "integer", nullable: false),
                    CTypeID = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    CountryID = table.Column<int>(type: "integer", nullable: false),
                    City = table.Column<string>(type: "text", nullable: false),
                    Province = table.Column<string>(type: "text", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: false),
                    Latitude = table.Column<decimal>(type: "numeric", nullable: false),
                    Longitude = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Address", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sys_Address_Sys_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Sys_Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sys_Demand",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonID = table.Column<int>(type: "integer", nullable: false),
                    SysDemandTypeID = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: false),
                    Note = table.Column<string>(type: "text", nullable: false),
                    StatusNote = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Demand", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sys_Demand_Sys_DemandType_SysDemandTypeID",
                        column: x => x.SysDemandTypeID,
                        principalTable: "Sys_DemandType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sys_Demand_Sys_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Sys_Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sys_Document",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TypeID = table.Column<int>(type: "integer", nullable: false),
                    SysDocumentTypeId = table.Column<int>(type: "integer", nullable: false),
                    PersonID = table.Column<int>(type: "integer", nullable: false),
                    LFile = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Document", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sys_Document_Sys_DocumentType_SysDocumentTypeId",
                        column: x => x.SysDocumentTypeId,
                        principalTable: "Sys_DocumentType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sys_Document_Sys_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Sys_Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sys_Feedback",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonID = table.Column<int>(type: "integer", nullable: false),
                    FixerID = table.Column<int>(type: "integer", nullable: false),
                    CategoryID = table.Column<int>(type: "integer", nullable: false),
                    SysFeedbackCategoryId = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<short>(type: "smallint", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Note = table.Column<string>(type: "text", nullable: false),
                    LFile = table.Column<string>(type: "text", nullable: false),
                    Priority = table.Column<int>(type: "integer", nullable: false),
                    GnlWorkTempItemId = table.Column<int>(name: "Gnl_WorkTempItemId", type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Feedback", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sys_Feedback_Gnl_WorkTempItem_Gnl_WorkTempItemId",
                        column: x => x.GnlWorkTempItemId,
                        principalTable: "Gnl_WorkTempItem",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Sys_Feedback_Sys_FeedbackCategory_SysFeedbackCategoryId",
                        column: x => x.SysFeedbackCategoryId,
                        principalTable: "Sys_FeedbackCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sys_Feedback_Sys_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Sys_Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sys_PersonCard",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonID = table.Column<int>(type: "integer", nullable: false),
                    SysCompanyID = table.Column<int>(type: "integer", nullable: false),
                    Gender = table.Column<int>(type: "integer", nullable: true),
                    MilitaryStatus = table.Column<int>(type: "integer", nullable: true),
                    MaritalStatus = table.Column<int>(type: "integer", nullable: true),
                    Height = table.Column<int>(type: "integer", nullable: true),
                    Weight = table.Column<int>(type: "integer", nullable: true),
                    Body = table.Column<int>(type: "integer", nullable: true),
                    FootNumber = table.Column<int>(type: "integer", nullable: true),
                    DriverLicense = table.Column<string>(type: "text", nullable: true),
                    BirthPlace = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<bool>(type: "boolean", nullable: false),
                    BirthDate = table.Column<DateOnly>(type: "date", nullable: true),
                    IDNo = table.Column<int>(name: "ID_No", type: "integer", nullable: true),
                    SerialNo = table.Column<string>(name: "Serial_No", type: "text", nullable: true),
                    Nationality = table.Column<string>(type: "text", nullable: true),
                    MothersName = table.Column<string>(type: "text", nullable: true),
                    FathersName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    LFile = table.Column<string>(type: "text", nullable: true),
                    EnteredAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ExitedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_PersonCard", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sys_PersonCard_Sys_Companies_SysCompanyID",
                        column: x => x.SysCompanyID,
                        principalTable: "Sys_Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sys_PersonCard_Sys_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Sys_Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sys_PersonEdu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonID = table.Column<int>(type: "integer", nullable: false),
                    SysEduTypeID = table.Column<int>(type: "integer", nullable: false),
                    InstitutionName = table.Column<string>(type: "text", nullable: false),
                    SectionName = table.Column<string>(type: "text", nullable: false),
                    LFile = table.Column<string>(type: "text", nullable: false),
                    EndYear = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_PersonEdu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sys_PersonEdu_Gnl_EduType_SysEduTypeID",
                        column: x => x.SysEduTypeID,
                        principalTable: "Gnl_EduType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sys_PersonEdu_Sys_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Sys_Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sys_PersonFinger",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonID = table.Column<int>(type: "integer", nullable: false),
                    DeviceID = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    OrginalDate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_PersonFinger", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sys_PersonFinger_Sys_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Sys_Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sys_PersonVisa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonID = table.Column<int>(type: "integer", nullable: false),
                    SysVisaTypeID = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<short>(type: "smallint", nullable: false),
                    StartedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    SyncID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_PersonVisa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sys_PersonVisa_Sys_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Sys_Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sys_PersonVisa_Sys_VisaType_SysVisaTypeID",
                        column: x => x.SysVisaTypeID,
                        principalTable: "Sys_VisaType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sys_Rollcall",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonID = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    CheckedAt = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Rollcall", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sys_Rollcall_Sys_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Sys_Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sys_Socials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonID = table.Column<int>(type: "integer", nullable: false),
                    CTypeID = table.Column<int>(type: "integer", nullable: false),
                    STypeID = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<short>(type: "smallint", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sys_Socials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_sys_Socials_Sys_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Sys_Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sys_Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonID = table.Column<int>(type: "integer", nullable: false),
                    Utype = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<short>(type: "smallint", nullable: false),
                    Username = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sys_Users_Sys_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Sys_Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "zarartahmini",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonID = table.Column<int>(type: "integer", nullable: false),
                    Yil = table.Column<int>(type: "integer", nullable: false),
                    TahminiZarar = table.Column<double>(type: "double precision", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_zarartahmini", x => x.Id);
                    table.ForeignKey(
                        name: "FK_zarartahmini_Sys_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Sys_Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Gnl_PersonConShift",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonID = table.Column<int>(type: "integer", nullable: false),
                    SysShiftID = table.Column<int>(type: "integer", nullable: false),
                    TargetedAt = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gnl_PersonConShift", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gnl_PersonConShift_Sys_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Sys_Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Gnl_PersonConShift_Sys_Shift_SysShiftID",
                        column: x => x.SysShiftID,
                        principalTable: "Sys_Shift",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sys_PersonConShift",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonID = table.Column<int>(type: "integer", nullable: false),
                    SysShiftID = table.Column<int>(type: "integer", nullable: false),
                    TypeID = table.Column<short>(type: "smallint", nullable: false),
                    TargetedAt = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_PersonConShift", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sys_PersonConShift_Sys_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Sys_Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sys_PersonConShift_Sys_Shift_SysShiftID",
                        column: x => x.SysShiftID,
                        principalTable: "Sys_Shift",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Gnl_InventoryConCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    InventoryID = table.Column<int>(type: "integer", nullable: false),
                    InvCategoryID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gnl_InventoryConCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gnl_InventoryConCategory_Gnl_InvCategory_InvCategoryID",
                        column: x => x.InvCategoryID,
                        principalTable: "Gnl_InvCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Gnl_InventoryConCategory_Gnl_Inventory_InventoryID",
                        column: x => x.InventoryID,
                        principalTable: "Gnl_Inventory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Gnl_InvTrans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    InventoryID = table.Column<int>(type: "integer", nullable: false),
                    FromID = table.Column<int>(type: "integer", nullable: false),
                    ToID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gnl_InvTrans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gnl_InvTrans_Gnl_Inventory_InventoryID",
                        column: x => x.InventoryID,
                        principalTable: "Gnl_Inventory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sys_FeedbackTrans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SysFeedbackID = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<short>(type: "smallint", nullable: false),
                    Note = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_FeedbackTrans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sys_FeedbackTrans_Sys_Feedback_SysFeedbackID",
                        column: x => x.SysFeedbackID,
                        principalTable: "Sys_Feedback",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sys_UserToken",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SysUserID = table.Column<int>(type: "integer", nullable: false),
                    UserSign = table.Column<string>(type: "text", nullable: false),
                    UserToken = table.Column<string>(type: "text", nullable: false),
                    EndAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_UserToken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sys_UserToken_Sys_Users_SysUserID",
                        column: x => x.SysUserID,
                        principalTable: "Sys_Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Gnl_Inventory_PersonID",
                table: "Gnl_Inventory",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Gnl_Inventory_SysCompanyID",
                table: "Gnl_Inventory",
                column: "SysCompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_Gnl_InventoryConCategory_InvCategoryID",
                table: "Gnl_InventoryConCategory",
                column: "InvCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Gnl_InventoryConCategory_InventoryID",
                table: "Gnl_InventoryConCategory",
                column: "InventoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Gnl_InvTrans_InventoryID",
                table: "Gnl_InvTrans",
                column: "InventoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Gnl_PersonConDashboard_PersonID",
                table: "Gnl_PersonConDashboard",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Gnl_PersonConDashboard_SysLobbyDashboardId",
                table: "Gnl_PersonConDashboard",
                column: "SysLobbyDashboardId");

            migrationBuilder.CreateIndex(
                name: "IX_Gnl_PersonConDepartment_PersonID",
                table: "Gnl_PersonConDepartment",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Gnl_PersonConDepartment_SysDepartmentID",
                table: "Gnl_PersonConDepartment",
                column: "SysDepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Gnl_PersonConModule_PersonID",
                table: "Gnl_PersonConModule",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Gnl_PersonConModule_SysModuleID",
                table: "Gnl_PersonConModule",
                column: "SysModuleID");

            migrationBuilder.CreateIndex(
                name: "IX_Gnl_PersonConModuleMenu_PersonID",
                table: "Gnl_PersonConModuleMenu",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Gnl_PersonConModuleMenu_SysModuleMenuID",
                table: "Gnl_PersonConModuleMenu",
                column: "SysModuleMenuID");

            migrationBuilder.CreateIndex(
                name: "IX_Gnl_PersonConPerM_PersonID",
                table: "Gnl_PersonConPerM",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Gnl_PersonConPositions_PersonId",
                table: "Gnl_PersonConPositions",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Gnl_PersonConPositions_SysPositionID",
                table: "Gnl_PersonConPositions",
                column: "SysPositionID");

            migrationBuilder.CreateIndex(
                name: "IX_Gnl_PersonConRollcallDepartment_PersonID",
                table: "Gnl_PersonConRollcallDepartment",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Gnl_PersonConRollcallDepartment_SysDepartmentID",
                table: "Gnl_PersonConRollcallDepartment",
                column: "SysDepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Gnl_PersonConShift_PersonID",
                table: "Gnl_PersonConShift",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Gnl_PersonConShift_SysShiftID",
                table: "Gnl_PersonConShift",
                column: "SysShiftID");

            migrationBuilder.CreateIndex(
                name: "IX_Gnl_PersonConWorkGroup_PersonID",
                table: "Gnl_PersonConWorkGroup",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Gnl_PersonConWorkGroup_SysWorkGroupId",
                table: "Gnl_PersonConWorkGroup",
                column: "SysWorkGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Gnl_PersonConWorkTemp_PersonID",
                table: "Gnl_PersonConWorkTemp",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Gnl_PersonConWorkTemp_SysWorkTempID",
                table: "Gnl_PersonConWorkTemp",
                column: "SysWorkTempID");

            migrationBuilder.CreateIndex(
                name: "IX_Gnl_PersonPassaports_PersonId",
                table: "Gnl_PersonPassaports",
                column: "PersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Gnl_PersonPepper_PersonID",
                table: "Gnl_PersonPepper",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Gnl_WorkTempItem_SysWorkTempID",
                table: "Gnl_WorkTempItem",
                column: "SysWorkTempID");

            migrationBuilder.CreateIndex(
                name: "IX_maliyetzarari_Sys_PersonId",
                table: "maliyetzarari",
                column: "Sys_PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_personleaves_PersonID",
                table: "personleaves",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_personleaves_SysLeaveTypeID",
                table: "personleaves",
                column: "SysLeaveTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Sys_Address_PersonID",
                table: "Sys_Address",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Sys_Demand_PersonID",
                table: "Sys_Demand",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Sys_Demand_SysDemandTypeID",
                table: "Sys_Demand",
                column: "SysDemandTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Sys_Department_Gnl_WorkTempId",
                table: "Sys_Department",
                column: "Gnl_WorkTempId");

            migrationBuilder.CreateIndex(
                name: "IX_Sys_Department_SysCompanyID",
                table: "Sys_Department",
                column: "SysCompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_Sys_Document_PersonID",
                table: "Sys_Document",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Sys_Document_SysDocumentTypeId",
                table: "Sys_Document",
                column: "SysDocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Sys_Feedback_Gnl_WorkTempItemId",
                table: "Sys_Feedback",
                column: "Gnl_WorkTempItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Sys_Feedback_PersonID",
                table: "Sys_Feedback",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Sys_Feedback_SysFeedbackCategoryId",
                table: "Sys_Feedback",
                column: "SysFeedbackCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Sys_FeedbackTrans_SysFeedbackID",
                table: "Sys_FeedbackTrans",
                column: "SysFeedbackID");

            migrationBuilder.CreateIndex(
                name: "IX_Sys_MenuPer_Sys_ModuleMenuId",
                table: "Sys_MenuPer",
                column: "Sys_ModuleMenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Sys_ModuleMenu_SysModuleID",
                table: "Sys_ModuleMenu",
                column: "SysModuleID");

            migrationBuilder.CreateIndex(
                name: "IX_Sys_PersonCard_PersonID",
                table: "Sys_PersonCard",
                column: "PersonID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sys_PersonCard_SysCompanyID",
                table: "Sys_PersonCard",
                column: "SysCompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_Sys_PersonConShift_PersonID",
                table: "Sys_PersonConShift",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Sys_PersonConShift_SysShiftID",
                table: "Sys_PersonConShift",
                column: "SysShiftID");

            migrationBuilder.CreateIndex(
                name: "IX_Sys_PersonEdu_PersonID",
                table: "Sys_PersonEdu",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Sys_PersonEdu_SysEduTypeID",
                table: "Sys_PersonEdu",
                column: "SysEduTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Sys_PersonFinger_PersonID",
                table: "Sys_PersonFinger",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Sys_Persons_PersonTypeID",
                table: "Sys_Persons",
                column: "PersonTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Sys_PersonVisa_PersonID",
                table: "Sys_PersonVisa",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Sys_PersonVisa_SysVisaTypeID",
                table: "Sys_PersonVisa",
                column: "SysVisaTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Sys_Rollcall_PersonID",
                table: "Sys_Rollcall",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Sys_Shift_SysDepartmentID",
                table: "Sys_Shift",
                column: "SysDepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_sys_Socials_PersonID",
                table: "sys_Socials",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Sys_Users_PersonID",
                table: "Sys_Users",
                column: "PersonID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sys_UserToken_SysUserID",
                table: "Sys_UserToken",
                column: "SysUserID");

            migrationBuilder.CreateIndex(
                name: "IX_zarartahmini_PersonID",
                table: "zarartahmini",
                column: "PersonID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gnl_InventoryConCategory");

            migrationBuilder.DropTable(
                name: "Gnl_InvTrans");

            migrationBuilder.DropTable(
                name: "Gnl_PersonConDashboard");

            migrationBuilder.DropTable(
                name: "Gnl_PersonConDepartment");

            migrationBuilder.DropTable(
                name: "Gnl_PersonConModule");

            migrationBuilder.DropTable(
                name: "Gnl_PersonConModuleMenu");

            migrationBuilder.DropTable(
                name: "Gnl_PersonConPerM");

            migrationBuilder.DropTable(
                name: "Gnl_PersonConPositions");

            migrationBuilder.DropTable(
                name: "Gnl_PersonConRollcallDepartment");

            migrationBuilder.DropTable(
                name: "Gnl_PersonConShift");

            migrationBuilder.DropTable(
                name: "Gnl_PersonConWorkGroup");

            migrationBuilder.DropTable(
                name: "Gnl_PersonConWorkTemp");

            migrationBuilder.DropTable(
                name: "Gnl_PersonPassaports");

            migrationBuilder.DropTable(
                name: "Gnl_PersonPepper");

            migrationBuilder.DropTable(
                name: "maliyetzarari");

            migrationBuilder.DropTable(
                name: "personleaves");

            migrationBuilder.DropTable(
                name: "Sys_Address");

            migrationBuilder.DropTable(
                name: "Sys_Demand");

            migrationBuilder.DropTable(
                name: "Sys_Document");

            migrationBuilder.DropTable(
                name: "Sys_FeedbackTrans");

            migrationBuilder.DropTable(
                name: "Sys_MenuPer");

            migrationBuilder.DropTable(
                name: "Sys_PersonCard");

            migrationBuilder.DropTable(
                name: "Sys_PersonConShift");

            migrationBuilder.DropTable(
                name: "Sys_PersonEdu");

            migrationBuilder.DropTable(
                name: "Sys_PersonFinger");

            migrationBuilder.DropTable(
                name: "Sys_PersonVisa");

            migrationBuilder.DropTable(
                name: "Sys_Rollcall");

            migrationBuilder.DropTable(
                name: "sys_Socials");

            migrationBuilder.DropTable(
                name: "Sys_UserToken");

            migrationBuilder.DropTable(
                name: "totaltahmin");

            migrationBuilder.DropTable(
                name: "zarartahmini");

            migrationBuilder.DropTable(
                name: "Gnl_InvCategory");

            migrationBuilder.DropTable(
                name: "Gnl_Inventory");

            migrationBuilder.DropTable(
                name: "Gnl_LobbyDashboard");

            migrationBuilder.DropTable(
                name: "Sys_Position");

            migrationBuilder.DropTable(
                name: "Gnl_WorkGroup");

            migrationBuilder.DropTable(
                name: "LeaveTypes");

            migrationBuilder.DropTable(
                name: "Sys_DemandType");

            migrationBuilder.DropTable(
                name: "Sys_DocumentType");

            migrationBuilder.DropTable(
                name: "Sys_Feedback");

            migrationBuilder.DropTable(
                name: "Sys_ModuleMenu");

            migrationBuilder.DropTable(
                name: "Sys_Shift");

            migrationBuilder.DropTable(
                name: "Gnl_EduType");

            migrationBuilder.DropTable(
                name: "Sys_VisaType");

            migrationBuilder.DropTable(
                name: "Sys_Users");

            migrationBuilder.DropTable(
                name: "Gnl_WorkTempItem");

            migrationBuilder.DropTable(
                name: "Sys_FeedbackCategory");

            migrationBuilder.DropTable(
                name: "Sys_Module");

            migrationBuilder.DropTable(
                name: "Sys_Department");

            migrationBuilder.DropTable(
                name: "Sys_Persons");

            migrationBuilder.DropTable(
                name: "Gnl_WorkTemp");

            migrationBuilder.DropTable(
                name: "Sys_Companies");

            migrationBuilder.DropTable(
                name: "Sys_PersonTypes");
        }
    }
}
