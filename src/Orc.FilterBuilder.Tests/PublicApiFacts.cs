﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PublicApiFacts.cs" company="WildGums">
//   Copyright (c) 2008 - 2017 WildGums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Orc.FilterBuilder.Tests
{
    using System.Runtime.CompilerServices;
    using ApiApprover;
    using FilterBuilder.Models;
    using NUnit.Framework;
    using Views;

    [TestFixture]
    public class PublicApiFacts
    {
        [Test, MethodImpl(MethodImplOptions.NoInlining)]
        public void Orc_FilterBuilder_HasNoBreakingChanges()
        {
            var assembly = typeof(FilterScheme).Assembly;

            PublicApiApprover.ApprovePublicApi(assembly);
        }

        [Test, MethodImpl(MethodImplOptions.NoInlining)]
        public void Orc_FilterBuilder_Xaml_HasNoBreakingChanges()
        {
            var assembly = typeof(EditFilterView).Assembly;

            PublicApiApprover.ApprovePublicApi(assembly);
        }
    }
}