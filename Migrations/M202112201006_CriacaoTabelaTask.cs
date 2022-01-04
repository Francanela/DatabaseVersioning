using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseVersioning.Migrations
{
    [Migration(202112201006, "Criação da tabela TASK")]
    public class M202112201006_CriacaoTabelaTask : Migration
    {
        public override void Down()
        {
            Delete.Table("Task");
        }

        public override void Up()
        {
            Create.Table("TaskTeste")
                .WithColumn("Id").AsGuid().PrimaryKey()
                .WithColumn("Descrição").AsString(250);
                            
        }
    }
}
