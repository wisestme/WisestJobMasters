namespace WisestJobMasters.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateApplicants : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Applicants (FirstName, LastName, Phone, YearsOfExperience) VALUES('Chijioke', 'Nwagwu', '08078767873', 5)");
            Sql("INSERT INTO Applicants (FirstName, LastName, Phone, YearsOfExperience) VALUES('Onah', 'Chidiebube', '08079595873', 5)");
            Sql("INSERT INTO Applicants (FirstName, LastName, Phone, YearsOfExperience) VALUES('Alison', 'Emeka', '0807987873', 3)");
            Sql("INSERT INTO Applicants (FirstName, LastName, Phone, YearsOfExperience) VALUES('Muna', 'Marvellous', '08078347673', 4)");


        }

        public override void Down()
        {
        }
    }
}
