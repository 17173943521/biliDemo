namespace bilibili.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class uuuu : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tb_UserInsertCoins",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        FilmId = c.Int(nullable: false),
                        CoinNum = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.tb_UserPraise",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        FilmId = c.Int(nullable: false),
                        State = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.tb_UserTransmit",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        FilmId = c.Int(nullable: false),
                        ToWhere = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.tb_UserPersonalFilm", "ShowNum", c => c.Int(nullable: false));
            AddColumn("dbo.tb_UserPersonalFilm", "PraiseNum", c => c.Int(nullable: false));
            AddColumn("dbo.tb_UserPersonalFilm", "InsertCoinsNum", c => c.Int(nullable: false));
            AddColumn("dbo.tb_UserPersonalFilm", "EnshrineNum", c => c.Int(nullable: false));
            AddColumn("dbo.tb_UserPersonalFilm", "TransmitNum", c => c.Int(nullable: false));
            AddColumn("dbo.tb_User", "CoinNum", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_User", "CoinNum");
            DropColumn("dbo.tb_UserPersonalFilm", "TransmitNum");
            DropColumn("dbo.tb_UserPersonalFilm", "EnshrineNum");
            DropColumn("dbo.tb_UserPersonalFilm", "InsertCoinsNum");
            DropColumn("dbo.tb_UserPersonalFilm", "PraiseNum");
            DropColumn("dbo.tb_UserPersonalFilm", "ShowNum");
            DropTable("dbo.tb_UserTransmit");
            DropTable("dbo.tb_UserPraise");
            DropTable("dbo.tb_UserInsertCoins");
        }
    }
}
