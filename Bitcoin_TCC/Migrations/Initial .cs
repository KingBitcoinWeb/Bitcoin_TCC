using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Data.Entity.Migrations;

namespace Bitcoin_TCC.Migrations
{

    using System;
    using System.Data.Entity.Migrations;

    public partial class Initial : DbMigration
    {

        public override void Up()
        {
            CreateTable(
                "dbo.ContatoKB",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Nome = c.String(),
                    Email = c.String(),
                    Mensagem = c.String(),
                })
                .PrimaryKey(t => t.ID);

        }


        public override void Down()
        {
            DropTable("dbo.ContatoKB");
        }
    }


}
}
