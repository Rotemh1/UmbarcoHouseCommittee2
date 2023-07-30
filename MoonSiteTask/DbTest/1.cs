using Microsoft.Extensions.Logging;
using NPoco;
using Umbraco.Cms.Core;
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.Migrations;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Scoping;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Infrastructure.Migrations;
using Umbraco.Cms.Infrastructure.Migrations.Upgrade;
using Umbraco.Cms.Infrastructure.Persistence.DatabaseAnnotations;

namespace MoonSiteTask.DbTest
{

[TableName("MyCustomTable")]
[PrimaryKey("Id", AutoIncrement = true)]
public class MyCustomObject
{
    [PrimaryKeyColumn(AutoIncrement = true)]
    [Column("Id")]
    public int Id { get; set; }
    [Column("Name")]
    public required string Name { get; set; }
}
}