namespace bilibili.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.tb_UserPersonalFilm", "UserName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_UserPersonalFilm", "UserName", c => c.String());
        }
    }
}
