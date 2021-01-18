namespace WisestJobMasters.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotationToFirstName : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Applicants", "FirstName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Applicants", "FirstName", c => c.String());
        }
    }
}
