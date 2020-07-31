namespace bilibili.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updat1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_UserPersonalFilm", "AddTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_UserPersonalFilm", "AddTime");
        }
    }
}
