namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SettingMoviesName : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded,ReleaseDate,NumberInStock) VALUES ('A Love So Beautiful',4,1995-02-03, 2017-10-29,3)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded,ReleaseDate,NumberInStock) VALUES ('Hang Over',2,2017-10-29, 2020-07-09,0)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded,ReleaseDate,NumberInStock) VALUES ('Deadpool',1,2010-01-20, 1995-02-03,0)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded,ReleaseDate,NumberInStock) VALUES ('Avengers',3,2015-03-10, 2015-03-10,0)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded,ReleaseDate,NumberInStock) VALUES ('Cinderella',1,2020-07-09, 2017-12-12,3)");
        }

        public override void Down()
        {
        }
    }
}
