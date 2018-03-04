namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeformats : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Person", "GPA", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Person", "GPA", c => c.Double());
        }
    }
}
