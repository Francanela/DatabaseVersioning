using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseVersioning.Migrations
{
    [Migration(202112210918, "Alter table da tabela TASK com script")]
    public class M202112210918_UpdateScript : Migration
    {
        public override void Down()
        {
            Execute.EmbeddedScript("DatabaseVersioning.Scripts.M202112210918_UpdateScript.Down.UpdateTaskRollback.sql");
        }

        public override void Up()
        {
            Execute.EmbeddedScript("DatabaseVersioning.Scripts.M202112210918_UpdateScript.Up.UpdateTask.sql");
        }
    }
}
