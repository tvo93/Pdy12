namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inheritance1 : DbMigration
    {
        public override void Up()
        {
           // DropColumn("dbo.Person", "Gpa");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Person", "Gpa", c => c.Double());
        }
    }
}
