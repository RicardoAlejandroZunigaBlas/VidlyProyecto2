namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'cbbe417a-1ff2-4ea9-8457-7534223721fa', N'guest@vidly.com', 0, N'AMm3ZYjqFHvtOWCIxPj25y4nHfsg3i6sdpRvTwcfOMzShCxgiTQ/txFDdQp8AbZ3bg==', N'8e9036f6-7f3b-4c34-b527-d97ab3975271', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f7cd07c6-b5b6-4c56-934f-ef75596ac7a6', N'admin@vidly.com', 0, N'AHImXlxzhvyAs2SYRgA0fOfQnuKjqYj3TtwMdA75W+f2z2hbsscQyRQL/Dkl14o1Tw==', N'52e2837e-817a-4368-9af9-c1378e37f106', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'aac7402c-8e55-48b2-a7e7-5a08d80d1bee', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'f7cd07c6-b5b6-4c56-934f-ef75596ac7a6', N'aac7402c-8e55-48b2-a7e7-5a08d80d1bee')

");
        }

        public override void Down()
        {
        }
    }
}
