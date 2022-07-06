namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migCContactAddUserMail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "UserMail", c => c.String(maxLength: 200));
            DropColumn("dbo.Contacts", "Surname");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contacts", "Surname", c => c.String(maxLength: 50));
            DropColumn("dbo.Contacts", "UserMail");
        }
    }
}
