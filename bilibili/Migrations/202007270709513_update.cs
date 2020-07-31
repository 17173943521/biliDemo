﻿namespace bilibili.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Type", "TypeUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_Type", "TypeUrl");
        }
    }
}
