namespace Portfolio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Inquiries",
                c => new
                    {
                        InquiryID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.InquiryID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Inquiries");
        }
    }
}
