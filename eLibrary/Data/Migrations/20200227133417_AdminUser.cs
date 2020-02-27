using Microsoft.EntityFrameworkCore.Migrations;

namespace eLibrary.Data.Migrations
{
    public partial class AdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'8378b1fc-1a09-4278-aa98-455ae7af7f12', N'admin@aubg.edu', N'ADMIN@AUBG.EDU', N'admin@aubg.edu', N'ADMIN@AUBG.EDU', 0, N'AQAAAAEAACcQAAAAEN7OD/RnUoxptjlHbSh6Hzy5j8rhPhrWqHkd8DXNxMtCcDxUU348cfJmp4Z1GiTEHg==', N'ZL2QQTVRNVJETFJSP2MNFHV6KE56YDIT', N'6c653f7a-a9cd-45b8-b016-e6589454565e', NULL, 0, 0, NULL, 1, 0)
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'1', N'Admin', N'ADMIN', N')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8378b1fc-1a09-4278-aa98-455ae7af7f12', N'1')
");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
