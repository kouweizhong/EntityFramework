// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.Data.Entity.SqlServer.FunctionalTests
{
    public class SentinelGraphUpdatesSqlServerTest : GraphUpdatesSqlServerTestBase<SentinelGraphUpdatesSqlServerTest.SentinelGraphUpdatesSqlServerFixture>
    {
        public SentinelGraphUpdatesSqlServerTest(SentinelGraphUpdatesSqlServerFixture fixture)
            : base(fixture)
        {
        }

        public class SentinelGraphUpdatesSqlServerFixture : GraphUpdatesSqlServerFixtureBase
        {
            protected override string DatabaseName => "SentinelGraphUpdatesTest";

            public override int IntSentinel => -1;

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);

                modelBuilder.ForRelational().Sequence("StartAtZeroSequence").Start(0);
                modelBuilder.Entity<Root>().Property(e => e.Id).ForSqlServer().UseSequence("StartAtZeroSequence");
                modelBuilder.Entity<Optional1>().Property(e => e.Id).ForSqlServer().UseSequence("StartAtZeroSequence");
                modelBuilder.Entity<Optional2>().Property(e => e.Id).ForSqlServer().UseSequence("StartAtZeroSequence");
                modelBuilder.Entity<OptionalAk1>().Property(e => e.Id).ForSqlServer().UseSequence("StartAtZeroSequence");
                modelBuilder.Entity<OptionalAk2>().Property(e => e.Id).ForSqlServer().UseSequence("StartAtZeroSequence");
                modelBuilder.Entity<OptionalSingle1>().Property(e => e.Id).ForSqlServer().UseSequence("StartAtZeroSequence");
                modelBuilder.Entity<OptionalSingle2>().Property(e => e.Id).ForSqlServer().UseSequence("StartAtZeroSequence");
                modelBuilder.Entity<OptionalSingleAk1>().Property(e => e.Id).ForSqlServer().UseSequence("StartAtZeroSequence");
                modelBuilder.Entity<OptionalSingleAk2>().Property(e => e.Id).ForSqlServer().UseSequence("StartAtZeroSequence");
                modelBuilder.Entity<Required1>().Property(e => e.Id).ForSqlServer().UseSequence("StartAtZeroSequence");
                modelBuilder.Entity<Required2>().Property(e => e.Id).ForSqlServer().UseSequence("StartAtZeroSequence");
                modelBuilder.Entity<RequiredAk1>().Property(e => e.Id).ForSqlServer().UseSequence("StartAtZeroSequence");
                modelBuilder.Entity<RequiredAk2>().Property(e => e.Id).ForSqlServer().UseSequence("StartAtZeroSequence");
                modelBuilder.Entity<RequiredNonPkSingle1>().Property(e => e.Id).ForSqlServer().UseSequence("StartAtZeroSequence");
                modelBuilder.Entity<RequiredNonPkSingle2>().Property(e => e.Id).ForSqlServer().UseSequence("StartAtZeroSequence");
                modelBuilder.Entity<RequiredNonPkSingleAk1>().Property(e => e.Id).ForSqlServer().UseSequence("StartAtZeroSequence");
                modelBuilder.Entity<RequiredNonPkSingleAk2>().Property(e => e.Id).ForSqlServer().UseSequence("StartAtZeroSequence");
                modelBuilder.Entity<RequiredSingleAk1>().Property(e => e.Id).ForSqlServer().UseSequence("StartAtZeroSequence");
                modelBuilder.Entity<RequiredSingleAk2>().Property(e => e.Id).ForSqlServer().UseSequence("StartAtZeroSequence");

                SetSentinelValues(modelBuilder);
            }
        }
    }
}
