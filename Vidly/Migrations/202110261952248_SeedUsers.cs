namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'acc821ea-0ac6-4e14-acdf-cba0a0958c8d', N'guest@vidly.com', 0, N'ALwqb0+GX+KRNA/35gIBklnm6n0N6otRfD23Vt9pMIp4TRVfinM8XvUm7zGkclJrig==', N'afd68345-129e-43e3-8866-b3e062492eef', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                  INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c758dd03-af3b-4359-b1f6-102594df0aba', N'admin@vidly.com', 0, N'AAeybBpHo1vLybX7MK06Z9vgN+Z1k2/HwL0jF5yqk+qlceU7P0P0JHEc8KR1rH4NVA==', N'f74320f7-165b-444b-b0bf-e84794865049', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                  INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e6390a57-7acc-4ede-991c-0aa6b1fd8afb', N'effigub@gmail.com', 0, N'AGbw8MKd0+qlMuofdmqONWASiQXLxpCPqIuQBMJq73HrN8ID+iSGff0tO1dAPMvLNg==', N'25ca93c8-75b2-4eee-872f-7939754407bd', NULL, 0, 0, NULL, 1, 0, N'effigub@gmail.com')

                  INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'9341144d-9d1f-4ff2-8cac-c5a788d996d3', N'CanManageMovies')

                  INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c758dd03-af3b-4359-b1f6-102594df0aba', N'9341144d-9d1f-4ff2-8cac-c5a788d996d3')
");

        }

        public override void Down()
        {
        }
    }
}
