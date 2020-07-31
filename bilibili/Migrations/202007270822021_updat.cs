namespace bilibili.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updat : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_UserPersonalFilm", "UserName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_UserPersonalFilm", "UserName");
        }
    }
}
