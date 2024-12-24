using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _34EntityFramework.Migrations
{
    public partial class AddEmployeesStoredProcedures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                    CREATE PROCEDURE GetEmployeesById
                    @Id INT
                    AS
                    BEGIN
                    SELECT * FROM Employee
                    WHERE EId = @Id
                    END");
            migrationBuilder.Sql(@"
                    CREATE PROCEDURE GetEmployeesByAddressStartsWith
                     @StartLetter NVARCHAR(1)
                    AS
                    BEGIN
                    SELECT * FROM Employee
                    WHERE EAddress LIKE @StartLetter + '%'
                    END
                    ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP PROCEDURE GetEmployeesById");
            migrationBuilder.Sql("DROP PROCEDURE GetEmployeesByAddressStartsWith");
        }
    }
}
