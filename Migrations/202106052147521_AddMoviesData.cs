namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddMoviesData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT into Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) values ('Godzilla vs.Kong', '2016-07-10', '2015-07-12', 10, 5 )");
            Sql("INSERT into Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) values ('A Quiet Place Part II', '2017-07-11', '2015-07-10', 9, 4 )");
            Sql("INSERT into Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) values ('Raya and the Last Dragon', '2018-07-10', '2015-07-12', 8, 5 )");
            Sql("INSERT into Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) values ('Mortal Kombat', '2012-07-10', '2015-07-12', 7, 5 )");
            Sql("INSERT into Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) values ('Cruella', '2010-07-10', '2015-07-12', 6, 5 )");
            Sql("INSERT into Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) values ('Nobody', '2018-07-10', '2015-07-12', 5, 5 )");
            Sql("INSERT into Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) values ('Wrath of Man', '2014-07-10', '2015-07-12', 4, 5 )");
            Sql("INSERT into Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) values ('Spiral', '2013-07-10', '2015-07-12', 3, 5 )");
            Sql("INSERT into Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) values ('The Marksman', '2012-07-10', '2015-07-12', 2, 5 )");
        }

        public override void Down()
        {
        }
    }
}
