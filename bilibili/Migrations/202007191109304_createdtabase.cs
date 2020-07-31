namespace bilibili.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createdtabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tb_FilmComment",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FilmId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        UserName = c.String(),
                        Parent = c.Int(nullable: false),
                        Content = c.String(),
                        Praise = c.Int(nullable: false),
                        AddTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.tb_FilmInfo",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FilmId = c.Int(nullable: false),
                        Company = c.String(),
                        ActionTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        CopyrightType = c.Int(nullable: false),
                        File = c.String(),
                        Money = c.Double(nullable: false),
                        EmpId = c.Int(nullable: false),
                        AddTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.tb_FilmPerson",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FilmId = c.Int(nullable: false),
                        PersonId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.tb_Film",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Describe = c.String(),
                        Duration = c.Int(nullable: false),
                        Score = c.Double(nullable: false),
                        FilmPath = c.String(),
                        FilmImage = c.String(),
                        ViewCount = c.Int(nullable: false),
                        Vip = c.Int(nullable: false),
                        AddTime = c.DateTime(nullable: false),
                        State = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.tb_FilmType",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FilmId = c.Int(nullable: false),
                        TypeId = c.Int(nullable: false),
                        TypeName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.tb_Image",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ImagePath = c.String(),
                        BelongId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.tb_Person",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Image = c.String(),
                        Describe = c.String(),
                        AddTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.tb_Type",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Parent = c.Int(nullable: false),
                        Type = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.tb_UserAddress",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        Country = c.String(),
                        Province = c.String(),
                        City = c.String(),
                        County = c.String(),
                        Detail = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.tb_UserEnshrine",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        FilmId = c.Int(nullable: false),
                        FilmName = c.String(),
                        FilmImage = c.String(),
                        EnshrineType = c.Int(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        State = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.tb_UserLike",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        LikeUserId = c.Int(nullable: false),
                        LikeType = c.Int(nullable: false),
                        State = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.tb_UserNews",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        NewsUserId = c.Int(nullable: false),
                        Content = c.String(),
                        AddTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.tb_UserPersonalFilm",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        FilmPath = c.String(),
                        FilmImage = c.String(),
                        Name = c.String(),
                        Describe = c.String(),
                        Original = c.Int(nullable: false),
                        Duration = c.String(),
                        State = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.tb_UserPersonalFilmType",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FileId = c.Int(nullable: false),
                        TypeId = c.Int(nullable: false),
                        TypeName = c.String(),
                        State = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.tb_User",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Account = c.String(),
                        Password = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        Name = c.String(),
                        Motto = c.String(),
                        Image = c.String(),
                        Birth = c.DateTime(nullable: false),
                        Sex = c.String(),
                        Member = c.Int(nullable: false),
                        Grade = c.Int(nullable: false),
                        GradeScore = c.Int(nullable: false),
                        FansNum = c.Int(nullable: false),
                        LikeNum = c.Int(nullable: false),
                        EnshrineNum = c.Int(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        State = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.tb_UserType",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Type = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        State = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.tb_UserVip",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        ActionTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        Type = c.Int(nullable: false),
                        Money = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.tb_UserWatchRecord",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        FilmId = c.Int(nullable: false),
                        FilmName = c.String(),
                        FilmImage = c.String(),
                        Duration = c.Int(nullable: false),
                        Rate = c.Double(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        State = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.tb_VipType",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        Name = c.String(),
                        Money = c.Double(nullable: false),
                        Discount = c.Double(nullable: false),
                        DiscountMoney = c.Double(nullable: false),
                        ActionTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        Remark = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tb_VipType");
            DropTable("dbo.tb_UserWatchRecord");
            DropTable("dbo.tb_UserVip");
            DropTable("dbo.tb_UserType");
            DropTable("dbo.tb_User");
            DropTable("dbo.tb_UserPersonalFilmType");
            DropTable("dbo.tb_UserPersonalFilm");
            DropTable("dbo.tb_UserNews");
            DropTable("dbo.tb_UserLike");
            DropTable("dbo.tb_UserEnshrine");
            DropTable("dbo.tb_UserAddress");
            DropTable("dbo.tb_Type");
            DropTable("dbo.tb_Person");
            DropTable("dbo.tb_Image");
            DropTable("dbo.tb_FilmType");
            DropTable("dbo.tb_Film");
            DropTable("dbo.tb_FilmPerson");
            DropTable("dbo.tb_FilmInfo");
            DropTable("dbo.tb_FilmComment");
        }
    }
}
