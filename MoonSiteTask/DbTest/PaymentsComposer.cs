using System.Diagnostics;
using Microsoft.Extensions.Logging;
using NPoco;
using Umbraco.Cms.Core;
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.Migrations;
using Umbraco.Cms.Core.Notifications;
using Umbraco.Cms.Core.Scoping;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Infrastructure.Migrations;
using Umbraco.Cms.Infrastructure.Migrations.Upgrade;
using Umbraco.Cms.Infrastructure.Persistence.DatabaseAnnotations;

namespace MoonSiteTask.DbTest
{
    public class PaymentsComposer : ComponentComposer<PaymentsComponent>
    {
    }

    public class PaymentsComponent : IComponent
    {
        private readonly ICoreScopeProvider _coreScopeProvider;
        private readonly IMigrationPlanExecutor _migrationPlanExecutor;
        private readonly IKeyValueService _keyValueService;
        private readonly IRuntimeState _runtimeState;

        public PaymentsComponent(
            ICoreScopeProvider coreScopeProvider,
            IMigrationPlanExecutor migrationPlanExecutor,
            IKeyValueService keyValueService,
            IRuntimeState runtimeState)
        {
            _coreScopeProvider = coreScopeProvider;
            _migrationPlanExecutor = migrationPlanExecutor;
            _keyValueService = keyValueService;
            _runtimeState = runtimeState;
        }

        public void Initialize()
        {
            if (_runtimeState.Level < RuntimeLevel.Run)
            {
                return;
            }

            // Create a migration plan for a specific project/feature
            // We can then track that latest migration state/step for this project/feature
            var migrationPlan = new MigrationPlan("Payments");

            // This is the steps we need to take
            // Each step in the migration adds a unique value
            migrationPlan.From(string.Empty)
                .To<AddCommentsTable>("payments-db");

            // Go and upgrade our site (Will check if it needs to do the work or not)
            // Based on the current/latest step
            var upgrader = new Upgrader(migrationPlan);
            upgrader.Execute(_migrationPlanExecutor, _coreScopeProvider, _keyValueService);
        }

        public void Terminate()
        {
        }
    }

    public class AddCommentsTable : MigrationBase
    {
        public AddCommentsTable(IMigrationContext context) : base(context)
        {
        }
        protected override void Migrate()
        {
            Logger.LogDebug("Running migration {MigrationStep}", "AddCommentsTable");

            // Lots of methods available in the MigrationBase class - discover with this.
            if (TableExists("Payments") == false)
            {
                Create.Table<PaymentSchema>().Do();
            }
            else
            {
                Logger.LogDebug("The database table {DbTable} already exists, skipping", "Payments");
            }
        }

        [TableName("Payments")]
        [PrimaryKey("Id", AutoIncrement = true)]
        [ExplicitColumns]
        public class PaymentSchema
        {
            public PaymentSchema(int AptNum, string ResName, int Amount, int Month, string PayedWith)
            {  
                this.AptNum = AptNum;
                this.ResName = ResName;
                this.Amount = Amount;
                this.Month = Month;
                this.PayedWith = PayedWith;
            }

            [PrimaryKeyColumn(AutoIncrement = true, IdentitySeed = 1)]
            [Column("Id")]
            public int Id { get; set; }

            [Column("AptNum")]
            public int AptNum { get; set; }

            [Column("ResName")]
            public string? ResName { get; set; }

            [Column("Amount")]
            public int Amount { get; set; }

            [Column("Month")]
            public int Month { get; set; }

            [Column("PayedWith")]
            public string? PayedWith { get; set; }
        }
    }
}