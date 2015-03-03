// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.Data.Entity.SqlServer.FunctionalTests
{
    public class GraphUpdatesSqlServerTest : GraphUpdatesSqlServerTestBase<GraphUpdatesSqlServerTest.GraphUpdatesSqlServerFixture>
    {
        public GraphUpdatesSqlServerTest(GraphUpdatesSqlServerFixture fixture)
            : base(fixture)
        {
        }

        public class GraphUpdatesSqlServerFixture : GraphUpdatesSqlServerFixtureBase
        {
            protected override string DatabaseName => "GraphUpdatesTest";

            public override int IntSentinel => 0;

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);

                modelBuilder.Entity<Root>().Property(e => e.Id).ForSqlServer().UseSequence();
                modelBuilder.Entity<Optional1>().Property(e => e.Id).ForSqlServer().UseSequence();
                modelBuilder.Entity<Optional2>().Property(e => e.Id).ForSqlServer().UseSequence();
                modelBuilder.Entity<OptionalAk1>().Property(e => e.Id).ForSqlServer().UseSequence();
                modelBuilder.Entity<OptionalAk2>().Property(e => e.Id).ForSqlServer().UseSequence();
                modelBuilder.Entity<OptionalSingle1>().Property(e => e.Id).ForSqlServer().UseSequence();
                modelBuilder.Entity<OptionalSingle2>().Property(e => e.Id).ForSqlServer().UseSequence();
                modelBuilder.Entity<OptionalSingleAk1>().Property(e => e.Id).ForSqlServer().UseSequence();
                modelBuilder.Entity<OptionalSingleAk2>().Property(e => e.Id).ForSqlServer().UseSequence();
                modelBuilder.Entity<Required1>().Property(e => e.Id).ForSqlServer().UseSequence();
                modelBuilder.Entity<Required2>().Property(e => e.Id).ForSqlServer().UseSequence();
                modelBuilder.Entity<RequiredAk1>().Property(e => e.Id).ForSqlServer().UseSequence();
                modelBuilder.Entity<RequiredAk2>().Property(e => e.Id).ForSqlServer().UseSequence();
                modelBuilder.Entity<RequiredNonPkSingle1>().Property(e => e.Id).ForSqlServer().UseSequence();
                modelBuilder.Entity<RequiredNonPkSingle2>().Property(e => e.Id).ForSqlServer().UseSequence();
                modelBuilder.Entity<RequiredNonPkSingleAk1>().Property(e => e.Id).ForSqlServer().UseSequence();
                modelBuilder.Entity<RequiredNonPkSingleAk2>().Property(e => e.Id).ForSqlServer().UseSequence();
                modelBuilder.Entity<RequiredSingleAk1>().Property(e => e.Id).ForSqlServer().UseSequence();
                modelBuilder.Entity<RequiredSingleAk2>().Property(e => e.Id).ForSqlServer().UseSequence();
            }
        }
    }
}
