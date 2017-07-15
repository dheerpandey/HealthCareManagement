namespace Queries.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialScript : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AppointmentTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        ContactNumber = c.String(),
                        Email = c.String(),
                        Address = c.String(),
                        Education = c.String(),
                        Specialization = c.String(),
                        Appointment_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Appointments", t => t.Appointment_Id)
                .Index(t => t.Appointment_Id);
            
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Doctors", "Appointment_Id", "dbo.Appointments");
            DropIndex("dbo.Doctors", new[] { "Appointment_Id" });
            DropTable("dbo.Authors");
            DropTable("dbo.Doctors");
            DropTable("dbo.Appointments");
        }
    }
}
