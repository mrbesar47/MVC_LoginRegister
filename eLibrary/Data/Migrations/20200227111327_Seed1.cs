using Microsoft.EntityFrameworkCore.Migrations;

namespace eLibrary.Data.Migrations
{
    public partial class Seed1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'e3bd4d44-fa22-40eb-838f-65e57c4eb5be', N'test@aubg.edu', N'TEST@AUBG.EDU', N'test@aubg.edu', N'TEST@AUBG.EDU', 0, N'AQAAAAEAACcQAAAAEGNrrFEr88IlzrtW6p6h1hooFq2il0WFt/8bk8TO3ihi1It5LPw3/+SP+P/tPsXJUQ==', N'NB5H4C2ZUTVE2OLWWYPTNJZNNUZUZGIS', N'dd5d9fcf-ed40-4b6f-a66a-f67c02a35383', NULL, 0, 0, NULL, 1, 0)

SET IDENTITY_INSERT [dbo].[Book] ON
INSERT INTO [dbo].[Book] ([Id], [Name], [DateAdded], [PublishDate], [NumberInStock], [NumberAvailable]) VALUES (1, N'Hamlet', N'2020-02-27 13:02:00', N'1984-10-26 12:59:00', 4, 4)
SET IDENTITY_INSERT [dbo].[Book] OFF

SET IDENTITY_INSERT [dbo].[Book] ON
INSERT INTO [dbo].[Book] ([Id], [Name], [DateAdded], [PublishDate], [NumberInStock], [NumberAvailable]) VALUES (2, N'Harry Potter', N'2020-02-27 13:02:00', N'1984-10-26 12:59:00', 4, 4)
SET IDENTITY_INSERT [dbo].[Book] OFF

SET IDENTITY_INSERT [dbo].[Book] ON
INSERT INTO [dbo].[Book] ([Id], [Name], [DateAdded], [PublishDate], [NumberInStock], [NumberAvailable]) VALUES (3, N'Killers', N'2020-02-27 13:02:00', N'1984-10-26 12:59:00', 4, 4)
SET IDENTITY_INSERT [dbo].[Book] OFF

SET IDENTITY_INSERT [dbo].[Book] ON
INSERT INTO [dbo].[Book] ([Id], [Name], [DateAdded], [PublishDate], [NumberInStock], [NumberAvailable]) VALUES (4, N'Knight', N'2020-02-27 13:02:00', N'1984-10-26 12:59:00', 4, 4)
SET IDENTITY_INSERT [dbo].[Book] OFF
");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
